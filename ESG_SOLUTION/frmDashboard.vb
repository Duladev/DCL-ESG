Imports System.Runtime.CompilerServices

Public Class frmDashboard
    Private Sub btnWaste_Click(sender As Object, e As EventArgs) Handles btnWaste.Click
        Dim form As New frmWasteManagement
        Me.Close()
    End Sub

    Private Sub btnInvetory_Click(sender As Object, e As EventArgs) Handles btnInvetory.Click
        Dim form As New frmMain
        Me.Close()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class