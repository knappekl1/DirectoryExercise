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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.txtPattern = New System.Windows.Forms.TextBox()
        Me.ChbRecursive = New System.Windows.Forms.CheckBox()
        Me.lbFiles = New System.Windows.Forms.CheckedListBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnListFiles = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directory:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pattern:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Recursive:"
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(159, 22)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(721, 30)
        Me.txtDirectory.TabIndex = 1
        '
        'txtPattern
        '
        Me.txtPattern.Location = New System.Drawing.Point(159, 72)
        Me.txtPattern.Name = "txtPattern"
        Me.txtPattern.Size = New System.Drawing.Size(127, 30)
        Me.txtPattern.TabIndex = 1
        '
        'ChbRecursive
        '
        Me.ChbRecursive.AutoSize = True
        Me.ChbRecursive.Location = New System.Drawing.Point(159, 119)
        Me.ChbRecursive.Name = "ChbRecursive"
        Me.ChbRecursive.Size = New System.Drawing.Size(22, 21)
        Me.ChbRecursive.TabIndex = 2
        Me.ChbRecursive.UseVisualStyleBackColor = True
        '
        'lbFiles
        '
        Me.lbFiles.CheckOnClick = True
        Me.lbFiles.FormattingEnabled = True
        Me.lbFiles.Location = New System.Drawing.Point(159, 168)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.Size = New System.Drawing.Size(721, 247)
        Me.lbFiles.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(930, 22)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(141, 45)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnListFiles
        '
        Me.btnListFiles.Location = New System.Drawing.Point(930, 85)
        Me.btnListFiles.Name = "btnListFiles"
        Me.btnListFiles.Size = New System.Drawing.Size(141, 45)
        Me.btnListFiles.TabIndex = 4
        Me.btnListFiles.Text = "List Files"
        Me.btnListFiles.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(930, 151)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 45)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 461)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnListFiles)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lbFiles)
        Me.Controls.Add(Me.ChbRecursive)
        Me.Controls.Add(Me.txtPattern)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents txtPattern As TextBox
    Friend WithEvents ChbRecursive As CheckBox
    Friend WithEvents lbFiles As CheckedListBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnListFiles As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
