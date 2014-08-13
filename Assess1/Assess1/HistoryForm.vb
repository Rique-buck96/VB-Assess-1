Public Class HistoryForm

    Dim histClass As New ContesoLibrary.OrderHistory

    Private Sub HistFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ExitHistory()

    End Sub

    Private Sub HistFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lstDates As List(Of String) = histClass.showDates
        Dim lstIDs As List(Of Integer) = histClass.ShowOrderID()

        For i As Integer = 0 To lstDates.Count - 1
            lstOrderDates.Items.Add(":02" & lstIDs(i) & " - " & lstDates(i))

        Next

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub lstOrderDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrderDates.SelectedIndexChanged

        Dim lstIDs As List(Of Integer) = histClass.ShowOrderID()

        If lstOrderDates.SelectedIndex >= 0 Then

            lstProducts.Items.Clear()

            Dim lstInfo As List(Of String) = histClass.ShowProductInfo(lstIDs(lstOrderDates.SelectedIndex))

            For i As Integer = 0 To lstInfo.Count - 1
                lstProducts.Items.Add(lstInfo(i))

            Next

        End If



    End Sub

    Private Sub lstProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProducts.SelectedIndexChanged

    End Sub
End Class