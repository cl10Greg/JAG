'Import items for file manipulation
Imports System.IO

Public Class bomClass
    'Private variables used for the object
    Private pBomName As String
    Private pItemNum As Integer
    Private pCompType As String
    Private pGenDes As String
    Private pDetDes As String
    Private pMfg As String
    Private pMfgNum As String
    Private pQty As Integer
    Private pBuffer As Integer
    Private pQtyTotal As Integer
    Private pSupplier As String
    Private pSupplierNum As String
    Private pPrice As Decimal
    Private pMinQty As Integer
    Private pOrderQty As Integer
    Private pOrderCost As Decimal
    Private pFilePath As String
    Private pDataTable As DataTable

    'Sets the bom name
    'Derived from the file path
    Public Property bomName() As String
        Get
            Return pBomName
        End Get
        Set(value As String)
            Dim tempVal
            tempVal = Split(value, ".")
            pBomName = tempVal(0) & ".bom"
        End Set
    End Property
    'Get/Set the item number
    Public Property itemNumber() As Integer
        Get
            Return itemNumber
        End Get
        Set(value As Integer)
            pItemNum = value
        End Set
    End Property
    'Get/Set the component type
    Public Property componentType() As String
        Get
            Return pCompType
        End Get
        Set(value As String)
            pCompType = value
        End Set
    End Property
    'Get/Set the general description of the part
    Public Property generalDescription() As String
        Get
            Return pGenDes
        End Get
        Set(value As String)
            pGenDes = value
        End Set
    End Property
    'Get/set the detailed description of the part
    Public Property detailedDescription() As String
        Get
            Return pDetDes
        End Get
        Set(value As String)
            pDetDes = value
        End Set
    End Property
    'Get/set the manufacturer information
    Public Property manufacturer() As String
        Get
            Return pMfg
        End Get
        Set(value As String)
            pMfg = value
        End Set
    End Property

    Public Property mfgNumber() As String
        Get
            Return pMfgNum
        End Get
        Set(value As String)
            pMfgNum = value
        End Set
    End Property

    Public Property quantity() As Integer
        Get
            Return pQty
        End Get
        Set(value As Integer)
            pQty = value
        End Set
    End Property

    Public Property buffer() As Integer
        Get
            Return pBuffer
        End Get
        Set(value As Integer)
            pBuffer = value
        End Set
    End Property

    Public Property qtyTotal() As Integer
        Get
            Return pQtyTotal
        End Get
        Set(value As Integer)
            pQtyTotal = value
        End Set
    End Property

    Public Property supplier() As String
        Get
            Return pSupplier
        End Get
        Set(value As String)
            pSupplier = value
        End Set
    End Property

    Public Property supplierNum() As String
        Get
            Return pSupplierNum
        End Get
        Set(value As String)
            pSupplierNum = value
        End Set
    End Property

    Public Property piecePrice() As Decimal
        Get
            Return pPrice
        End Get
        Set(value As Decimal)
            pPrice = value
        End Set
    End Property

    Public Property minQty() As Integer
        Get
            Return pMinQty
        End Get
        Set(value As Integer)
            pMinQty = value
        End Set
    End Property

    Public Property orderAmount() As Integer
        Get
            Return pOrderQty
        End Get
        Set(value As Integer)
            pOrderQty = value
        End Set
    End Property

    Public Property orderCost() As Decimal
        Get
            Return pOrderCost
        End Get
        Set(value As Decimal)
            pOrderCost = value
        End Set
    End Property

    Public Property bomFilePath() As String
        Get
            Return pFilePath
        End Get
        Set(value As String)
            Dim tempLocation As Integer
            Dim locString As String
            tempLocation = value.LastIndexOf("\")
            locString = value.Substring(0, tempLocation + 1)
            pFilePath = locString
        End Set
    End Property

    Public Property bomTable() As DataTable
        Get
            Return pDataTable
        End Get
        Set(value As DataTable)
            pDataTable = value
        End Set
    End Property
    'Read BOM from file to the datatable
    Public Function getBOM() As DataTable
        'Set the decryption key
        Dim pBomKey As String = "checkEng00"
        'Create a new datatable
        Dim bomSet As New DataTable
        'Create a datarow
        Dim bomRow As DataRow

        'If the file exist, Create the columns to the datatable
        If File.Exists(bomFilePath & bomName) Then
            bomSet.Columns.Add("Item #", GetType(Integer))
            bomSet.Columns.Add("Component Type", GetType(String))
            bomSet.Columns.Add("General Description", GetType(String))
            bomSet.Columns.Add("Detailed Description", GetType(String))
            bomSet.Columns.Add("Manufacturer", GetType(String))
            bomSet.Columns.Add("Manufacturer #", GetType(String))
            bomSet.Columns.Add("Quantity", GetType(Integer))
            bomSet.Columns.Add("Buffer", GetType(Integer))
            bomSet.Columns.Add("Total Quantity", GetType(Integer))
            bomSet.Columns.Add("Supplier", GetType(String))
            bomSet.Columns.Add("Supplier #", GetType(String))
            bomSet.Columns.Add("Piece Price", GetType(Decimal))
            bomSet.Columns.Add("Min Qty", GetType(Integer))
            bomSet.Columns.Add("Order Amount", GetType(Integer))
            bomSet.Columns.Add("Total Cost", GetType(Decimal))

            'Set the decrption key
            Dim wrapper As New Simple3Des(pBomKey)
            'Set the reader object
            Dim checkEmpty As New StreamReader(bomFilePath & bomName)
            Dim tempcontent As String
            Dim decText As String
            Dim splitString

            'Check to see if the bom is empty
            If checkEmpty.ReadToEnd.Equals(String.Empty) Then
                'Close the file
                checkEmpty.Close()
                'Set the dataTable to bomset (which is pretty much empty
                pDataTable = bomSet
                'Return the empty bomset
                Return bomSet
            Else
                'Close the file
                checkEmpty.Close()
                'Create a new reader
                Dim sr As New StreamReader(bomFilePath & bomName)
                'Do a loop until all the information is read
                Do
                    'Read the line
                    tempcontent = sr.ReadLine
                    'If the line is empty, exit the loop
                    If IsNothing(tempcontent) Then
                        Exit Do
                    Else
                        'Decrypt the data
                        decText = wrapper.decryptData(tempcontent)
                        'Create a new row
                        bomRow = bomSet.NewRow
                        'Split up the line item of the bom
                        splitString = Split(decText, ",")
                        'Store all the information to the datatable
                        bomRow("Item #") = CInt(splitString(0))
                        bomRow("Component Type") = splitString(1)
                        bomRow("General Description") = splitString(2)
                        bomRow("Detailed Description") = splitString(3)
                        bomRow("Manufacturer") = splitString(4)
                        bomRow("Manufacturer #") = splitString(5)
                        bomRow("Quantity") = CInt(splitString(6))
                        bomRow("Buffer") = CInt(splitString(7))
                        bomRow("Total Quantity") = CInt(splitString(8))
                        bomRow("Supplier") = splitString(9)
                        bomRow("Supplier #") = splitString(10)
                        bomRow("Piece Price") = CDec(splitString(11))
                        bomRow("Min Qty") = splitString(12)
                        bomRow("Order Amount") = splitString(13)
                        bomRow("Total Cost") = CDec(splitString(14))
                        'Add the row to the datatable
                        bomSet.Rows.Add(bomRow)
                    End If
                Loop
                'Close the file
                sr.Close()
            End If
            'If the file doesn't exist, return the empty dataTable
        Else
            MsgBox("File doesn't exist.")
            pDataTable = bomSet
            Return bomSet
        End If

        'Return the dataTable
        pDataTable = bomSet
        Return bomSet
    End Function
    'Add item to the datatable
    Public Sub addItemToBOM()
        'Create a new row
        Dim tempRow As DataRow
        'Set the newrow to be a newrow of the datatable
        tempRow = pDataTable.NewRow
        'Add items to the row
        tempRow("Item #") = pItemNum
        tempRow("Component Type") = pCompType
        tempRow("General Description") = pGenDes
        tempRow("Detailed Description") = pDetDes
        tempRow("Manufacturer") = pMfg
        tempRow("Manufacturer #") = pMfgNum
        tempRow("Quantity") = pQty
        tempRow("Buffer") = pBuffer
        tempRow("Total Quantity") = pQtyTotal
        tempRow("Supplier") = pSupplier
        tempRow("Supplier #") = pSupplierNum
        tempRow("Piece Price") = pPrice
        tempRow("Min Qty") = pMinQty
        tempRow("Order Amount") = pOrderQty
        tempRow("Total Cost") = pOrderCost

        'Add the row to the dataTable
        pDataTable.Rows.Add(tempRow)
    End Sub

    Public Sub writeBOMToFile()

        'User pFilePath for save location
        Dim wrapper As New Simple3Des("checkEng00")
        Dim bomItem As String = ""
        Dim cipherText As String = ""
        'Cycle through each row, make a string out of all the items
        For x = 0 To pDataTable.Rows.Count - 1
            For y = 0 To pDataTable.Columns.Count - 1
                If y = 0 Then
                    bomItem = pDataTable.Rows(x).Item(y)
                Else
                    bomItem = bomItem & "," & pDataTable.Rows(x).Item(y)
                End If

            Next
            cipherText = wrapper.encryptData(bomItem)
            If x = 0 Then
                File.WriteAllText(pFilePath & pBomName, cipherText)
            Else
                File.AppendAllText(pFilePath & pBomName, cipherText)
            End If
        Next

        'Get the newest data table from either the class or the datagridview (it should be the class)
        'Format the output string
        'Encrypt it
        'Create and write
    End Sub
End Class
