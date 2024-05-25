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
        Me.data_container = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.idInput = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.Label()
        Me.Insert = New System.Windows.Forms.Button()
        Me.fNameInput = New System.Windows.Forms.TextBox()
        Me.emailInput = New System.Windows.Forms.TextBox()
        Me.lNameInput = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.Label()
        Me.LName = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.Label()
        CType(Me.data_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_container
        '
        Me.data_container.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_container.BackgroundColor = System.Drawing.SystemColors.Control
        Me.data_container.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_container.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.data_container.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.data_container.Location = New System.Drawing.Point(0, 354)
        Me.data_container.Name = "data_container"
        Me.data_container.RowHeadersWidth = 60
        Me.data_container.Size = New System.Drawing.Size(800, 247)
        Me.data_container.TabIndex = 35
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(39, 298)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(364, 20)
        Me.label1.TabIndex = 34
        Me.label1.Text = "Records can be only deleted/updated with id"
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(339, 249)
        Me.delete.Margin = New System.Windows.Forms.Padding(2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(81, 35)
        Me.delete.TabIndex = 33
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(191, 249)
        Me.update.Margin = New System.Windows.Forms.Padding(2)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(81, 35)
        Me.update.TabIndex = 32
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'idInput
        '
        Me.idInput.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idInput.Location = New System.Drawing.Point(191, 16)
        Me.idInput.Margin = New System.Windows.Forms.Padding(2)
        Me.idInput.Name = "idInput"
        Me.idInput.Size = New System.Drawing.Size(229, 27)
        Me.idInput.TabIndex = 31
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(32, 21)
        Me.id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(23, 20)
        Me.id.TabIndex = 30
        Me.id.Text = "Id"
        '
        'Insert
        '
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Location = New System.Drawing.Point(36, 249)
        Me.Insert.Margin = New System.Windows.Forms.Padding(2)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(81, 35)
        Me.Insert.TabIndex = 29
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'fNameInput
        '
        Me.fNameInput.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fNameInput.Location = New System.Drawing.Point(191, 69)
        Me.fNameInput.Margin = New System.Windows.Forms.Padding(2)
        Me.fNameInput.Name = "fNameInput"
        Me.fNameInput.Size = New System.Drawing.Size(229, 27)
        Me.fNameInput.TabIndex = 26
        '
        'emailInput
        '
        Me.emailInput.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailInput.Location = New System.Drawing.Point(191, 189)
        Me.emailInput.Margin = New System.Windows.Forms.Padding(2)
        Me.emailInput.Name = "emailInput"
        Me.emailInput.Size = New System.Drawing.Size(229, 27)
        Me.emailInput.TabIndex = 27
        '
        'lNameInput
        '
        Me.lNameInput.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNameInput.Location = New System.Drawing.Point(191, 129)
        Me.lNameInput.Margin = New System.Windows.Forms.Padding(2)
        Me.lNameInput.Name = "lNameInput"
        Me.lNameInput.Size = New System.Drawing.Size(229, 27)
        Me.lNameInput.TabIndex = 28
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(32, 194)
        Me.email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(123, 20)
        Me.email.TabIndex = 23
        Me.email.Text = "Email Address : "
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(32, 134)
        Me.LName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(98, 20)
        Me.LName.TabIndex = 24
        Me.LName.Text = "Last Name : "
        '
        'fName
        '
        Me.fName.AutoSize = True
        Me.fName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fName.Location = New System.Drawing.Point(32, 74)
        Me.fName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(98, 20)
        Me.fName.TabIndex = 25
        Me.fName.Text = "First Name : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 601)
        Me.Controls.Add(Me.data_container)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.idInput)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.fNameInput)
        Me.Controls.Add(Me.emailInput)
        Me.Controls.Add(Me.lNameInput)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.fName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.data_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents data_container As DataGridView
    Private WithEvents label1 As Label
    Private WithEvents delete As Button
    Private WithEvents update As Button
    Private WithEvents idInput As TextBox
    Private WithEvents id As Label
    Private WithEvents Insert As Button
    Private WithEvents fNameInput As TextBox
    Private WithEvents emailInput As TextBox
    Private WithEvents lNameInput As TextBox
    Private WithEvents email As Label
    Private WithEvents LName As Label
    Private WithEvents fName As Label
End Class
