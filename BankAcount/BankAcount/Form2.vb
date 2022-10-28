Imports System.Data.OleDb
Public Class Form2
    Dim cn As New OleDbConnection
    Dim cm As OleDbCommand
    Dim ad As New OleDbDataAdapter(cm)
    Dim dt As New DataTable
    Private Sub view()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()

        cn.Open()
        cm = cn.CreateCommand()
        cm.CommandType = CommandType.Text
        ad = New OleDbDataAdapter("select * from customer", cn)
        ad.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database11DataSet5.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter3.Fill(Me.Database11DataSet5.customer)
        'TODO: This line of code loads data into the 'Database11DataSet2.customer' table. You can move, or remove it, as needed.
        'Me.CustomerTableAdapter.Fill(Me.Database11DataSet.customer)
        'TODO: This line of code loads data into the 'Database11DataSet1.customer' table. You can move, or remove it, as needed.
        'Me.CustomerTableAdapter1.Fill(Me.Database11DataSet1.customer)
        'TODO: This line of code loads data into the 'Database11DataSet.customer' table. You can move, or remove it, as needed.
        'Me.CustomerTableAdapter.Fill(Me.Database11DataSet.customer)
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
        view()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
        Try


            cn.Open()



            cm = cn.CreateCommand()
            cm.CommandType = CommandType.Text
            cm.CommandText = "insert into [customer]values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
            cm.ExecuteNonQuery()


            cn.Close()
            MsgBox("Sucessfully", MsgBoxStyle.Information, Text)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
        Catch ex As Exception
            MsgBox("compleat the acount information please", MsgBoxStyle.Information, Text)
        End Try
    End Sub


    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
        'Dim new1 As Integer = Convert.ToInt32(TextBox10.Text)
        'Dim new2 As Integer = Convert.ToInt32(TextBox8.Text)
        'Try


        '    If TextBox10.Text + TextBox8.Text < 0 Or TextBox10.Text + TextBox8.Text = "balance" Then
        '        MsgBox("compleat your information correctly")
        '    Else

        'newbalance = Val(TextBox10.Text) + Val(TextBox8.Text)

        '    End If
        'Catch ex As Exception
        '    MsgBox("compleat your information correctly")
        'End Try
        Try
            'newbalance = (Convert.ToInt32(TextBox10.Text) + Convert.ToInt32(TextBox8.Text))
            Dim a As Integer = Integer.Parse(TextBox10.Text)
            Dim b As Integer = Integer.Parse(TextBox8.Text)
            Dim c As Integer = a + b
            Label12.Text = c
            cn.Open()


            cm = cn.CreateCommand()
            cm.CommandType = CommandType.Text
            cm.CommandText = "update customer set AMOUNT = '" + Label12.Text + "' where ACOUNTID = '" + TextBox5.Text + "'"
            cm.ExecuteNonQuery()

            cn.Close()
            MsgBox("Sucessfully updated ", MsgBoxStyle.Information, Text)
            Button3_Click(New Object, New EventArgs())
            view()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
        Catch ex As Exception
            MsgBox("wrong", MsgBoxStyle.Information, Text)
        End Try

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"

        Try
            cn.Open()
            cm = cn.CreateCommand()
            cm.CommandType = CommandType.Text
            cm.CommandText = "select * from customer where ACOUNTID = '" + TextBox9.Text + "' "
            cm.ExecuteNonQuery()
            dt = New DataTable()
            ad = New OleDbDataAdapter(cm)
            ad.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
    
        Catch ex As Exception
            MsgBox("wrong", MsgBoxStyle.Information, Text)
        End Try

    End Sub

    Public Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try


            TextBox1.Text = DataGridView1.SelectedRows(0).Cells(0).Value
            TextBox2.Text = DataGridView1.SelectedRows(0).Cells(1).Value
            TextBox3.Text = DataGridView1.SelectedRows(0).Cells(2).Value
            TextBox4.Text = DataGridView1.SelectedRows(0).Cells(3).Value
            TextBox5.Text = DataGridView1.SelectedRows(0).Cells(4).Value
            TextBox6.Text = DataGridView1.SelectedRows(0).Cells(5).Value
            ComboBox1.Text = DataGridView1.SelectedRows(0).Cells(6).Value
            ComboBox2.Text = DataGridView1.SelectedRows(0).Cells(7).Value
            ComboBox3.Text = DataGridView1.SelectedRows(0).Cells(8).Value
            TextBox7.Text = DataGridView1.SelectedRows(0).Cells(9).Value
            TextBox8.Text = DataGridView1.SelectedRows(0).Cells(10).Value
        Catch ex As Exception
            MessageBox.Show("stope")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        view()
        ' Me.Hide()


        'Form4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mu\Documents\Visual Studio 2012\Projects\BankAcount\BankAcount\Database11.accdb"
        Try
            cn.Open()


            cm = cn.CreateCommand()
            cm.CommandType = CommandType.Text
            cm.CommandText = "delete * from customer where ACOUNTID = '" + TextBox9.Text + "' "

            cm.ExecuteNonQuery()

            cn.Close()
            MsgBox("Sucessfully deleted", MsgBoxStyle.Information, Text)
            Button3_Click(New Object, New EventArgs())
            view()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
        Catch ex As Exception
            MsgBox("wrong", MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class