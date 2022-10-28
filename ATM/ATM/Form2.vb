Imports System.Data.OleDb
Imports System.Data
Public Class Form2
    Dim cn As New OleDbConnection
    Dim cm As OleDbCommand
    Dim ad As New OleDbDataAdapter(cm)
    Dim dt As New DataTable
    Dim DataGridView1 As Object
    Dim reder As OleDbDataReader
    Dim x As Integer

    'Dim cn As New OleDbConnection(My.Settings.Database11ConnectionString)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = TextBox1.Text & 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'x = TextBox3.Text
        Dim cn As New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
        If TextBox3.Text = Nothing Or TextBox1.Text = Nothing Then
            MessageBox.Show("please Check your informations and try again")
        Else
            Try
                cn.Open()
                Dim str As String
                str = "select AMOUNT from customer where ACOUNTID = '" + TextBox3.Text + "' "
                Dim cm As New OleDbCommand(str, cn)
                Dim reder As OleDbDataReader
                reder = cm.ExecuteReader
                reder.Read()
                Label3.Text = reder("AMOUNT")


                cn.Close()
                Label4.Text = " your balace was :"
            Catch ex As Exception
                MsgBox("please Check your information and try again", MsgBoxStyle.Information, Text)

            End Try
            Dim subs As Integer
            Try
                subs = Label3.Text - TextBox1.Text
            Catch ex As Exception
                MsgBox(" enter amont of money you want to withdrow")
            End Try

            If subs > 0 Then

                Label1.Text = subs
                'Label2.Text = ("  press  ")
            Else
                MsgBox(" out of balance")
            End If
            'If TextBox1.Text = Nothing Then
            '    MessageBox.Show("Enter your AMOuNT OF MONEY ")
            'Else

            'End If
            'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
            'Try
            If (Label1.Text = "Label1") Then

                MsgBox("invalied transaction")
            Else
                cn.Open()


                cm = cn.CreateCommand()
                cm.CommandType = CommandType.Text




                cm.CommandText = "update customer set AMOUNT = '" + Label1.Text + "' where ACOUNTID = '" + TextBox3.Text + "'"

                cm.ExecuteNonQuery()

                cn.Close()
                MsgBox("Sucessfully Compleated transaction", MsgBoxStyle.Information, Text)


                TextBox3.Text = ""
                Label6.Text = " your current is:"
                Label7.Text = subs
            End If
            'Catch ex As Exception
            'MsgBox("complet your information and try again", MsgBoxStyle.Information, Text)

            'End Try
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        'Dim cn As New OleDbConnection
        'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
        'Try
        '    cn.Open()
        '    Dim str As String
        '    str = "select AMOUNT from customer where ACOUNTID = '" + TextBox3.Text + "' "
        '    Dim cm As New OleDbCommand(str, cn)
        '    Dim reder As OleDbDataReader
        '    reder = cm.ExecuteReader
        '    reder.Read()
        '    Label3.Text = reder("AMOUNT")


        '    cn.Close()
        '    Label2.Text = " press withdrow"
        'Catch ex As Exception
        '    MsgBox("wrong", MsgBoxStyle.Information, Text)

        'End Try

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        Dim cn As New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
        Try
            cn.Open()
            Dim str As String
            str = "select AMOUNT from customer where ACOUNTID = '" + TextBox3.Text + "' "
            Dim cm As New OleDbCommand(str, cn)
            Dim reder As OleDbDataReader
            reder = cm.ExecuteReader
            reder.Read()
            Label3.Text = reder("AMOUNT")


            cn.Close()
            Label4.Text = " your current balace is :"
        Catch ex As Exception
            MsgBox("please Check your information and try again", MsgBoxStyle.Information, Text)

        End Try
        'Dim subs As Integer
        'Try
        '    subs = Label3.Text - TextBox1.Text
        'Catch ex As Exception
        '    MsgBox(" enter amont of money you want to withdrow")
        'End Try

        'If subs > 0 Then

        '    Label1.Text = subs
        '    Label2.Text = ("  press confirm ")
        'Else
        '    MsgBox(" out of balance")
        'End If

        'Label1.Text = subs



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class