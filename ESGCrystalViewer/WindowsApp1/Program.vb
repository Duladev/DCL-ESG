Imports System.Windows.Forms

Module Program
    <STAThread>
    Sub Main(ByVal args() As String)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Try
            Dim reportPath As String = ""
            Dim selectionFormula As String = ""
            Dim paramValue As String = ""

            ' Parse command line arguments
            If args.Length > 0 Then
                reportPath = args(0)

                ' Remove quotes if present
                If reportPath.StartsWith("""") AndAlso reportPath.EndsWith("""") Then
                    reportPath = reportPath.Trim(""""c)
                End If

                If args.Length > 1 Then
                    selectionFormula = args(1)
                    If selectionFormula.StartsWith("""") AndAlso selectionFormula.EndsWith("""") Then
                        selectionFormula = selectionFormula.Trim(""""c)
                    End If
                End If

                If args.Length > 2 Then
                    paramValue = args(2)
                    If paramValue.StartsWith("""") AndAlso paramValue.EndsWith("""") Then
                        paramValue = paramValue.Trim(""""c)
                    End If
                End If
            End If

            ' Show the viewer
            Dim viewer As frm_CrystalViewer

            If String.IsNullOrEmpty(reportPath) Then
                MessageBox.Show("Usage: ESGCrystalViewer.exe <report_path> [selection_formula] [param_value]",
                              "Usage", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewer = New frm_CrystalViewer()
            ElseIf String.IsNullOrEmpty(selectionFormula) AndAlso String.IsNullOrEmpty(paramValue) Then
                viewer = New frm_CrystalViewer(reportPath)
            ElseIf String.IsNullOrEmpty(paramValue) Then
                viewer = New frm_CrystalViewer(reportPath, selectionFormula)
            Else
                viewer = New frm_CrystalViewer(reportPath, selectionFormula, paramValue)
            End If

            Application.Run(viewer)

        Catch ex As Exception
            MessageBox.Show($"Application Error: {ex.Message}",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module