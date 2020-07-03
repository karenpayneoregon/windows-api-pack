Imports System.Data.SqlClient

Namespace Classes

    Public Class DataOperations
        Private Shared ConnectionStringFails As String =
                           "Data Source=.\SQLEXPRESS_BAD;" &
                           "Initial Catalog=NorthWindAzureForInserts;" &
                           "Integrated Security=True"

        Public Shared Async Function ReadCustomers() As Task(Of DataTable)
            Dim dt As New DataTable
            Return Await Task.Run(
                Async Function()

                    Dim customersTable = New DataTable()

                    Using cn = New SqlConnection(ConnectionStringFails)

                        Using cmd = New SqlCommand() With {.Connection = cn}

                            cmd.CommandText = ""
                            Await cn.OpenAsync()

                            customersTable.Load(Await cmd.ExecuteReaderAsync())

                        End Using

                    End Using

                    Return customersTable

                End Function)

        End Function
    End Class
End Namespace