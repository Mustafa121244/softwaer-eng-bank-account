<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database11DataSet = New BankAcount.Database11DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CustomerTableAdapter = New BankAcount.Database11DataSetTableAdapters.customerTableAdapter()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Database11DataSet1 = New BankAcount.Database11DataSet1()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter1 = New BankAcount.Database11DataSet1TableAdapters.customerTableAdapter()
        Me.Database11DataSet2 = New BankAcount.Database11DataSet2()
        Me.CustomerBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter2 = New BankAcount.Database11DataSet2TableAdapters.customerTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RISDENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WORKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACOUNTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACOUNTPASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACOUNTTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMREGENALSTATUESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSPORTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database11DataSet5 = New BankAcount.Database11DataSet5()
        Me.CustomerTableAdapter3 = New BankAcount.Database11DataSet5TableAdapters.customerTableAdapter()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database11DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database11DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database11DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"male", "female"})
        Me.ComboBox1.Location = New System.Drawing.Point(505, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 33)
        Me.ComboBox1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(123, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(123, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 31)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(123, 111)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 31)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(123, 169)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 31)
        Me.TextBox4.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Checking Account", "Savings Account", "Money Market Account", "Certificate of Deposit (CD)"})
        Me.ComboBox2.Location = New System.Drawing.Point(505, 62)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 33)
        Me.ComboBox2.TabIndex = 8
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Married ", "Divorced ", "Separated ", "Single ", "Widowed "})
        Me.ComboBox3.Location = New System.Drawing.Point(505, 111)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 33)
        Me.ComboBox3.TabIndex = 9
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.Database11DataSet
        '
        'Database11DataSet
        '
        Me.Database11DataSet.DataSetName = "Database11DataSet"
        Me.Database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "PHONE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-5, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "RESDINT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "WORK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(744, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ACOUNT ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(744, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 29)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "ACOUNT PASS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(339, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "GENDER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(303, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 29)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "ACOUNT TYPE"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(945, 15)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 31)
        Me.TextBox5.TabIndex = 20
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(945, 66)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 31)
        Me.TextBox6.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(285, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 29)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "MARTIAL STATU"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(303, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 29)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "PASSPORT ID"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(784, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 42)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "add cash"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(505, 169)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(121, 31)
        Me.TextBox7.TabIndex = 25
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(945, 123)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 31)
        Me.TextBox8.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(744, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 29)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "BALANCE"
        '
        'Database11DataSet1
        '
        Me.Database11DataSet1.DataSetName = "Database11DataSet1"
        Me.Database11DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "customer"
        Me.CustomerBindingSource1.DataSource = Me.Database11DataSet1
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'Database11DataSet2
        '
        Me.Database11DataSet2.DataSetName = "Database11DataSet2"
        Me.Database11DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource2
        '
        Me.CustomerBindingSource2.DataMember = "customer"
        Me.CustomerBindingSource2.DataSource = Me.Database11DataSet2
        '
        'CustomerTableAdapter2
        '
        Me.CustomerTableAdapter2.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(363, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 45)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "serch"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn, Me.RISDENTDataGridViewTextBoxColumn, Me.WORKDataGridViewTextBoxColumn, Me.ACOUNTIDDataGridViewTextBoxColumn, Me.ACOUNTPASSWORDDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.ACOUNTTYPEDataGridViewTextBoxColumn, Me.AMREGENALSTATUESDataGridViewTextBoxColumn, Me.PASSPORTIDDataGridViewTextBoxColumn, Me.AMOUNTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(0, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1240, 164)
        Me.DataGridView1.TabIndex = 30
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "phonenumber"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "phonenumber"
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        '
        'RISDENTDataGridViewTextBoxColumn
        '
        Me.RISDENTDataGridViewTextBoxColumn.DataPropertyName = "RISDENT"
        Me.RISDENTDataGridViewTextBoxColumn.HeaderText = "RISDENT"
        Me.RISDENTDataGridViewTextBoxColumn.Name = "RISDENTDataGridViewTextBoxColumn"
        '
        'WORKDataGridViewTextBoxColumn
        '
        Me.WORKDataGridViewTextBoxColumn.DataPropertyName = "WORK"
        Me.WORKDataGridViewTextBoxColumn.HeaderText = "WORK"
        Me.WORKDataGridViewTextBoxColumn.Name = "WORKDataGridViewTextBoxColumn"
        '
        'ACOUNTIDDataGridViewTextBoxColumn
        '
        Me.ACOUNTIDDataGridViewTextBoxColumn.DataPropertyName = "ACOUNTID"
        Me.ACOUNTIDDataGridViewTextBoxColumn.HeaderText = "ACOUNTID"
        Me.ACOUNTIDDataGridViewTextBoxColumn.Name = "ACOUNTIDDataGridViewTextBoxColumn"
        '
        'ACOUNTPASSWORDDataGridViewTextBoxColumn
        '
        Me.ACOUNTPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "ACOUNTPASSWORD"
        Me.ACOUNTPASSWORDDataGridViewTextBoxColumn.HeaderText = "ACOUNTPASSWORD"
        Me.ACOUNTPASSWORDDataGridViewTextBoxColumn.Name = "ACOUNTPASSWORDDataGridViewTextBoxColumn"
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        '
        'ACOUNTTYPEDataGridViewTextBoxColumn
        '
        Me.ACOUNTTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACOUNTTYPE"
        Me.ACOUNTTYPEDataGridViewTextBoxColumn.HeaderText = "ACOUNTTYPE"
        Me.ACOUNTTYPEDataGridViewTextBoxColumn.Name = "ACOUNTTYPEDataGridViewTextBoxColumn"
        '
        'AMREGENALSTATUESDataGridViewTextBoxColumn
        '
        Me.AMREGENALSTATUESDataGridViewTextBoxColumn.DataPropertyName = "AMREGENAL STATUES"
        Me.AMREGENALSTATUESDataGridViewTextBoxColumn.HeaderText = "AMREGENAL STATUES"
        Me.AMREGENALSTATUESDataGridViewTextBoxColumn.Name = "AMREGENALSTATUESDataGridViewTextBoxColumn"
        '
        'PASSPORTIDDataGridViewTextBoxColumn
        '
        Me.PASSPORTIDDataGridViewTextBoxColumn.DataPropertyName = "PASSPORTID"
        Me.PASSPORTIDDataGridViewTextBoxColumn.HeaderText = "PASSPORTID"
        Me.PASSPORTIDDataGridViewTextBoxColumn.Name = "PASSPORTIDDataGridViewTextBoxColumn"
        '
        'AMOUNTDataGridViewTextBoxColumn
        '
        Me.AMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.Name = "AMOUNTDataGridViewTextBoxColumn"
        '
        'CustomerBindingSource3
        '
        Me.CustomerBindingSource3.DataMember = "customer"
        Me.CustomerBindingSource3.DataSource = Me.Database11DataSet5
        '
        'Database11DataSet5
        '
        Me.Database11DataSet5.DataSetName = "Database11DataSet5"
        Me.Database11DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter3
        '
        Me.CustomerTableAdapter3.ClearBeforeFill = True
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(505, 243)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 31)
        Me.TextBox9.TabIndex = 31
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1110, 66)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 42)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "view"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1110, 123)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 42)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "reset"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1110, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(118, 41)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(945, 243)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 31)
        Me.TextBox10.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(663, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Label12"
        Me.Label12.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1240, 426)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database11DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database11DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database11DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Database11DataSet As BankAcount.Database11DataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As BankAcount.Database11DataSetTableAdapters.customerTableAdapter
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Database11DataSet1 As BankAcount.Database11DataSet1
    Friend WithEvents CustomerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter1 As BankAcount.Database11DataSet1TableAdapters.customerTableAdapter
    Friend WithEvents Database11DataSet2 As BankAcount.Database11DataSet2
    Friend WithEvents CustomerBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter2 As BankAcount.Database11DataSet2TableAdapters.customerTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database11DataSet5 As BankAcount.Database11DataSet5
    Friend WithEvents CustomerBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter3 As BankAcount.Database11DataSet5TableAdapters.customerTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RISDENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WORKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACOUNTIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACOUNTPASSWORDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACOUNTTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMREGENALSTATUESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PASSPORTIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
