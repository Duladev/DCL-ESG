Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Public Class frm_ESGReportViewer
    Private objReportDocument As ReportDocument
    Private WithEvents CRViewer1 As CrystalReportViewer  ' only needed if NOT added via designer

    Private Sub frm_ESGReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' If CRViewer1 was NOT added in the designer, create it here
            If CRViewer1 Is Nothing Then
                CRViewer1 = New CrystalReportViewer()
                CRViewer1.Dock = DockStyle.Fill
                Me.Controls.Add(CRViewer1)
            End If

            If Not System.IO.File.Exists(strReportPath) Then
                MsgBox("Report file not found:" & vbCrLf & strReportPath,
                       MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, Me.Text)
                Me.Close()
                Exit Sub
            End If

            objReportDocument = New ReportDocument()
            objReportDocument.Load(strReportPath)

            If Not String.IsNullOrWhiteSpace(mRecordSelectionFormula) Then
                objReportDocument.RecordSelectionFormula = mRecordSelectionFormula
            End If

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