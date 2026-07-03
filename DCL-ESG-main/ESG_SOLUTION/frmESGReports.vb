Imports System.IO

Public Class frmESGReports

    Private Sub frmESGReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyModernStyle(Me)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmDashboard.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowCrystalReport(reportPath:=Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ESG", "ESGEmployeeAge.rpt"))
        'ShowCrystalReport(reportPath:=reportPath)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowCrystalReport(reportPath:=Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ESG", "ESGEmployeeAge.rpt"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowCrystalReport(reportPath:="ESG\ESGTotalPurchases.rpt")
    End Sub

End Class