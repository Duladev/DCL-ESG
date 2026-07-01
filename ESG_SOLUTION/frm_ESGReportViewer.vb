Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.Shared

Public Class frm_ESGReportViewer
    Private objReportDocument As ReportDocument
    Private WithEvents CRViewer1 As CrystalReportViewer

    Private Sub frm_ESGReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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

            ' Apply DB login to main report and all subreports
            ApplyLogOn(objReportDocument)

            If Not String.IsNullOrWhiteSpace(mRecordSelectionFormula) Then
                objReportDocument.RecordSelectionFormula = mRecordSelectionFormula
            End If

            CRViewer1.ReportSource = objReportDocument

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, Me.Text)
            Me.Close()
        End Try
    End Sub

    Private Sub ApplyLogOn(report As ReportDocument)
        Dim connInfo As New ConnectionInfo()
        connInfo.ServerName = "DCL-ICT-007\DEVELOPER"
        connInfo.DatabaseName = "ESG"
        connInfo.IntegratedSecurity = True

        ' Apply to main report tables
        For Each tbl As Table In report.Database.Tables
            Dim tli As TableLogOnInfo = tbl.LogOnInfo
            tli.ConnectionInfo = connInfo
            tbl.ApplyLogOnInfo(tli)
        Next

        ' Apply to subreports
        For Each section As Section In report.ReportDefinition.Sections
            For Each obj As ReportObject In section.ReportObjects
                If obj.Kind = ReportObjectKind.SubreportObject Then
                    Dim sub_report As SubreportObject = DirectCast(obj, SubreportObject)
                    Dim subDoc As ReportDocument = report.OpenSubreport(sub_report.SubreportName)
                    For Each tbl As Table In subDoc.Database.Tables
                        Dim tli As TableLogOnInfo = tbl.LogOnInfo
                        tli.ConnectionInfo = connInfo
                        tbl.ApplyLogOnInfo(tli)
                    Next
                End If
            Next
        Next
    End Sub

    Private Sub frm_ESGReportViewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If objReportDocument IsNot Nothing Then
            objReportDocument.Close()
            objReportDocument.Dispose()
        End If
    End Sub
End Class