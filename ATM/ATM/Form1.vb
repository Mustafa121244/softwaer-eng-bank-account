Imports System.Data.OleDb
Imports System.Data
Public Class Form1

    Dim cn As New OleDbConnection(My.Settings.Database11ConnectionString)
    Dim cm As OleDbCommand

    ' cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
        If TextBox3.Text = Nothing Or TextBox2.Text = Nothing Then
            MessageBox.Show("Enter your informations please")
        Else



            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim cm As New OleDbCommand("select count(*) from customer where ACOUNTID=? and ACOUNTPASSWORD=?", cn)
            cm.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox3.Text
            cm.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
            Dim con = Convert.ToInt32(cm.ExecuteScalar())
            If (con > 0) Then
                MsgBox("login Sucessfully")


                Me.Hide()
                Form2.Show()
            Else
                MsgBox("acount not found")
            End If
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        'Me.Hide()
        'Form2.Show()
    End Sub

    Private Sub pass_Click(sender As Object, e As EventArgs) Handles pass.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class

