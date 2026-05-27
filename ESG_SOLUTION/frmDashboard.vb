Imports System.Runtime.CompilerServices

Public Class frmDashboard
    Private Sub btnWaste_Click(sender As Object, e As EventArgs) Handles btnWaste.Click
        Dim form As New frmWasteManagement
        Me.Close()
    End Sub

    Private Sub btnInvetory_Click(sender As Object, e As EventArgs) Handles btnInvetory.Click

    End Sub
End Class