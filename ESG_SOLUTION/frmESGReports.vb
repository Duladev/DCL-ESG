Public Class frmESGReports
    Private Sub frmESGReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyModernStyle(Me)
    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        objForm = New frm_ESGReportViewer
        mReportName = "crpWasteRecords.rpt"
        strReportPath = PBReportPath & "\ESG" & mReportName
        objForm.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmDashboard.Show()
        Me.Close()
    End Sub
End Class