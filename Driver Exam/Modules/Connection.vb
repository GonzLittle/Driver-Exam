Imports System.Data.OleDb
Module Connection


    Public _driverexam As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\DriversExam.mdb;"
    Public driverexamcon As OleDbConnection
    Public _DEadapter As OleDbDataAdapter
    Public _DEds As DataSet
    Public _DEdatatable As DataTableCollection
    Public _DEBindsource As New BindingSource
    Public _DEcommand As OleDbCommand
    Public _DEdatareader As OleDbDataReader
    Public _DEresult As Integer
    Public _DEquery As String


End Module
