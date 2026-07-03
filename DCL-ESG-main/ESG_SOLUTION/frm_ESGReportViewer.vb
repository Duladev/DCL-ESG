
Public Class frm_ESGReportViewer

    Private Sub frm_ESGReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error GoTo ErrorHandler

        'Check if the path string is empty
        If String.IsNullOrEmpty(strReportPath) Then
            MsgBox("Report path variable is empty!", MsgBoxStyle.Critical, "Path Error")
            Exit Sub
        End If

        'Check physical file exists
        If Not System.IO.File.Exists(strReportPath) Then
            MsgBox("File not found at: " & strReportPath, MsgBoxStyle.Critical, "Missing File")
            Exit Sub
        End If

        Dim objReportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        objReportDocument.Load(strReportPath)
        CRViewer1.ReportSource = objReportDocument

        Exit Sub
ErrorHandler:
        MsgBox(Err.Description, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Me.Text)
    End Sub
End Class