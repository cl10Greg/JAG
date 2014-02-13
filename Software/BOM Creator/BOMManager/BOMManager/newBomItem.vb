Public Class newBomItem
    Private pBomObj As bomClass
    Public Sub setBOM(tempObj As bomClass)
        pBomObj = tempObj
    End Sub
    
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        'Create a BOM object
        'store all the data
        'Get the data table
        pBomObj.itemNumber = CInt(itemNumTxt.Text)
        pBomObj.componentType = typeCmb.Text
        pBomObj.generalDescription = generalTxt.Text
        pBomObj.detailedDescription = detailedTxt.Text
        pBomObj.manufacturer = mfgTxt.Text
        pBomObj.mfgNumber = mfgNumTxt.Text
        pBomObj.quantity = Int(qtyTxt.Text)
        pBomObj.buffer = Int(bufferTxt.Text)
        pBomObj.qtyTotal = pBomObj.quantity + pBomObj.buffer
        pBomObj.supplier = supplierTxt.Text
        pBomObj.supplierNum = supplierNumTxt.Text
        pBomObj.piecePrice = CDec(ppTxt.Text)
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
    End Sub

    Private Sub getNextBtn_Click(sender As Object, e As EventArgs) Handles getNextBtn.Click
        'Search the BOM object for new item
        If IsNothing(pBomObj.getBOM) Then
            itemNumTxt.Text = "1"
        Else

        End If
    End Sub

    Private Sub qtyTxt_TextChanged(sender As Object, e As EventArgs) Handles qtyTxt.TextChanged

    End Sub
End Class
