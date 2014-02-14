Public Class newBomItem
    'Create a new bom object when add item is called
    Private pBomObj As bomClass
    'Set the BOM object
    Public Sub setBOM(tempObj As bomClass)
        pBomObj = tempObj
    End Sub
    'Add items to bom data table
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        'If there is no item number, set it to 0
        If itemNumTxt.Text = "" Then
            getNextBtn.PerformClick()
        End If
        'Read all the information into the object
        pBomObj.itemNumber = CInt(itemNumTxt.Text)
        pBomObj.componentType = typeCmb.Text
        pBomObj.generalDescription = generalTxt.Text
        pBomObj.detailedDescription = detailedTxt.Text
        pBomObj.manufacturer = mfgTxt.Text
        pBomObj.mfgNumber = mfgNumTxt.Text
        If qtyTxt.Text = "" Then
            qtyTxt.Text = 0
        End If
        pBomObj.quantity = Int(qtyTxt.Text)
        If bufferTxt.Text = "" Then
            bufferTxt.Text = 0
        End If
        pBomObj.buffer = Int(bufferTxt.Text)
        pBomObj.qtyTotal = pBomObj.quantity + pBomObj.buffer
        pBomObj.supplier = supplierTxt.Text
        pBomObj.supplierNum = supplierNumTxt.Text
        If ppTxt.Text = "" Then
            ppTxt.Text = 0.0
        End If
        pBomObj.piecePrice = CDec(ppTxt.Text)
        If minTxt.Text = "" Then
            minTxt.Text = 1
        End If
        pBomObj.minQty = Int(minTxt.Text)
        If pBomObj.minQty > pBomObj.qtyTotal Then
            pBomObj.orderAmount = pBomObj.minQty
        Else
            pBomObj.orderAmount = pBomObj.qtyTotal
        End If
        pBomObj.orderCost = pBomObj.piecePrice * pBomObj.orderAmount

        'Add to datatable
        pBomObj.addItemToBOM()

        'Update Grid
        MainFrm.updateBomGrid(pBomObj)

        'Add to revision log

        'Save BOM to file

        'Clear the information
        clearBtn.PerformClick()
    End Sub

    Private Sub getNextBtn_Click(sender As Object, e As EventArgs) Handles getNextBtn.Click
        Dim curTable As New DataTable
        Dim nextItem As Integer = 0
        curTable = pBomObj.bomTable
        If curTable.Rows.Count = 0 Then
            itemNumTxt.Text = "1"
        Else
            For x = 0 To curTable.Rows.Count - 1
                If curTable.Rows(x).Item("Item #") > nextItem Then
                    nextItem = curTable.Rows(x).Item("Item #")
                End If
            Next
            itemNumTxt.Text = nextItem + 1
        End If


    End Sub

    Public Function getBomData() As bomClass
        Return pBomObj
    End Function

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        itemNumTxt.Clear()
        typeCmb.Text = ""
        generalTxt.Clear()
        detailedTxt.Clear()
        mfgTxt.Clear()
        mfgNumTxt.Clear()
        qtyTxt.Clear()
        bufferTxt.Clear()
        totalQtyTxt.Clear()
        supplierTxt.Clear()
        supplierNumTxt.Clear()
        ppTxt.Clear()
        minTxt.Clear()
        amountTxt.Clear()
        totalTxt.Clear()
    End Sub
End Class
