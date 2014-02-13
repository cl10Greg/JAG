Imports System.IO

Public Class bomClass
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
    Public Property itemNumber() As Integer
        Get
            Return itemNumber
        End Get
        Set(value As Integer)
            pItemNum = value
        End Set
    End Property

    Public Property componentType() As String
        Get
            Return pCompType
        End Get
        Set(value As String)
            pCompType = value
        End Set
    End Property

    Public Property generalDescription() As String
        Get
            Return pGenDes
        End Get
        Set(value As String)
            pGenDes = value
        End Set
    End Property

    Public Property detailedDescription() As String
        Get
            Return pDetDes
        End Get
        Set(value As String)
            pDetDes = value
        End Set
    End Property

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
    'Read BOM from file to the datatable
    Public Function getBOM() As DataTable
        Dim pBomKey As String = "checkEng00"
        Dim bomSet As New DataTable
        Dim bomRow As DataRow

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

            Dim wrapper As New Simple3Des(pBomKey)
            Dim checkEmpty As New StreamReader(bomFilePath & bomName)
            Dim tempcontent As String
            Dim decText As String
            Dim splitString

            If checkEmpty.ReadToEnd.Equals(String.Empty) Then
                MsgBox("BOM is empty")
                checkEmpty.Close()
                pDataTable = bomSet
                Return Nothing
            Else
                checkEmpty.Close()
                Dim sr As New StreamReader(bomFilePath & bomName)
                Do
                    tempcontent = sr.ReadLine
                    If IsNothing(tempcontent) Then
                        Exit Do
                    Else
                        decText = wrapper.decryptData(tempcontent)
                        bomRow = bomSet.NewRow
                        splitString = Split(decText, ",")
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
                        bomSet.Rows.Add(bomRow)
                    End If
                Loop
                sr.Close()
            End If
            
        Else
            MsgBox("File doesn't exist.")
            pDataTable = bomSet
            Return Nothing
        End If

        pDataTable = bomSet
        Return bomSet
    End Function
    'Add item to the datatable
    Public Sub addItemToBOM()
        Dim tempRow As DataRow
        tempRow = pDataTable.NewRow

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

        pDataTable.Rows.Add(tempRow)
        'Add item to the pDataTable object

        'Add all data to the private variables
        'create a new row
        'Add a new row
        'Update grid
    End Sub

    Public Sub writeBOMToFile(tempFile As String)
        'Write the file to the BOM location.  
        'Write new file or append?

    End Sub

    Public Function getDataTable() As DataTable
        Return pDataTable
    End Function
End Class
