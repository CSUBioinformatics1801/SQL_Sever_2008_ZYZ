Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public usertype As Integer '1为管理员 2为游客
    Public sqlcn As SqlConnection
    Public cnn As SqlConnection
    Public sqlcmd As SqlCommand
    Public da As New SqlDataAdapter
    Public Movieselected As String
    Public CurrentUsername As String
End Module
