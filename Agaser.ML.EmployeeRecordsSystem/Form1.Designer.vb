<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonDeleteAll = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(445, 252)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Management System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "List of Employees"
        '
        'ButtonCreate
        '
        Me.ButtonCreate.BackColor = System.Drawing.Color.Blue
        Me.ButtonCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreate.ForeColor = System.Drawing.Color.White
        Me.ButtonCreate.Location = New System.Drawing.Point(508, 241)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(121, 27)
        Me.ButtonCreate.TabIndex = 3
        Me.ButtonCreate.Text = "+ Add Employee"
        Me.ButtonCreate.UseVisualStyleBackColor = False
        '
        'ButtonRead
        '
        Me.ButtonRead.BackColor = System.Drawing.Color.Blue
        Me.ButtonRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRead.ForeColor = System.Drawing.Color.White
        Me.ButtonRead.Location = New System.Drawing.Point(635, 241)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(121, 27)
        Me.ButtonRead.TabIndex = 4
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.Color.Blue
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(635, 274)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(121, 27)
        Me.ButtonUpdate.TabIndex = 5
        Me.ButtonUpdate.Text = "Update Employee"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Blue
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(508, 307)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(121, 27)
        Me.ButtonDelete.TabIndex = 6
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Blue
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(508, 274)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(121, 27)
        Me.ButtonEdit.TabIndex = 7
        Me.ButtonEdit.Text = "Edit Details"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(-4, -8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(807, 51)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(569, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Employee Details"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(573, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(573, 164)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(202, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(573, 138)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(202, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(573, 112)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(202, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(573, 190)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(202, 20)
        Me.TextBox5.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(518, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(485, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Department :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(516, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Salary :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(504, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Position :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(537, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "ID :"
        '
        'ButtonDeleteAll
        '
        Me.ButtonDeleteAll.BackColor = System.Drawing.Color.Blue
        Me.ButtonDeleteAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteAll.ForeColor = System.Drawing.Color.White
        Me.ButtonDeleteAll.Location = New System.Drawing.Point(635, 307)
        Me.ButtonDeleteAll.Name = "ButtonDeleteAll"
        Me.ButtonDeleteAll.Size = New System.Drawing.Size(121, 27)
        Me.ButtonDeleteAll.TabIndex = 20
        Me.ButtonDeleteAll.Text = "Delete All"
        Me.ButtonDeleteAll.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonDeleteAll)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonDeleteAll As Button
End Class
