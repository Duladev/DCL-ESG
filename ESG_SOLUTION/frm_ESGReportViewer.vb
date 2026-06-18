Public Class frm_ESGReportViewer
    Private objReportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument

    Private Sub frm_ESGReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not System.IO.File.Exists(strReportPath) Then
                MsgBox("Report file not found:" & vbCrLf & strReportPath,
                       MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, Me.Text)
                Me.Close()
                Exit Sub
            End If

            objReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            objReportDocument.Load(strReportPath)
            CRViewer1.ReportSource = objReportDocument

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, Me.Text)
            Me.Close()
        End Try
    End Sub

    Private Sub frm_ESGReportViewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If objReportDocument IsNot Nothing Then
            objReportDocument.Close()
            objReportDocument.Dispose()
        End If
    End Sub
End Class