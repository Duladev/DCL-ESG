Imports System.Data.SqlClient

Public Class DatabaseHelper

    Public Shared Function GetDataTable(ByVal query As String, ByVal parameters As SqlParameter()) As DataTable
        Using conn As SqlConnection = modShared.GetConnection()
            Using adapter As New SqlDataAdapter(query, conn)
                If parameters IsNot Nothing Then
                    adapter.SelectCommand.Parameters.AddRange(parameters)
                End If
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Public Shared Function ExecuteNonQuery(ByVal query As String, ByVal parameters As SqlParameter()) As Integer
        Using conn As SqlConnection = modShared.GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
End Class