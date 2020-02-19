Imports System.Data.OleDb
Module Connection



    'Public _driverexam As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\My Data Sources\Jerald DB\DriversExam.mdb;Jet OLEDB:Database Password=123456;"
    'Public _driverexam As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pmis_server\IDPGLUdb2013\DriversExam\DriversExam.mdb;Jet OLEDB:Database Password=123456;"
    Public _driverexam As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\jerald-pc\Jerald DB\DriversExam.mdb;Jet OLEDB:Database Password=123456;"


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
