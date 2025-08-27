<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnresult = New Button()
        btnclear = New Button()
        btnexit = New Button()
        txtsecondnum = New TextBox()
        txtfirstnum = New TextBox()
        lblfirstnum = New Label()
        lblsecondnum = New Label()
        SuspendLayout()
        ' 
        ' btnresult
        ' 
        btnresult.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnresult.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        btnresult.ForeColor = SystemColors.ActiveCaptionText
        btnresult.Location = New Point(25, 170)
        btnresult.Name = "btnresult"
        btnresult.Size = New Size(112, 34)
        btnresult.TabIndex = 0
        btnresult.Text = "Result"
        btnresult.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Silver
        btnclear.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        btnclear.Location = New Point(168, 170)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(112, 34)
        btnclear.TabIndex = 0
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnexit.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        btnexit.Location = New Point(310, 170)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(112, 34)
        btnexit.TabIndex = 0
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' txtsecondnum
        ' 
        txtsecondnum.Location = New Point(248, 81)
        txtsecondnum.Name = "txtsecondnum"
        txtsecondnum.Size = New Size(150, 31)
        txtsecondnum.TabIndex = 1
        ' 
        ' txtfirstnum
        ' 
        txtfirstnum.Location = New Point(52, 81)
        txtfirstnum.Name = "txtfirstnum"
        txtfirstnum.Size = New Size(150, 31)
        txtfirstnum.TabIndex = 1
        ' 
        ' lblfirstnum
        ' 
        lblfirstnum.AutoSize = True
        lblfirstnum.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        lblfirstnum.Location = New Point(52, 53)
        lblfirstnum.Name = "lblfirstnum"
        lblfirstnum.Size = New Size(131, 25)
        lblfirstnum.TabIndex = 2
        lblfirstnum.Text = "First Number"
        ' 
        ' lblsecondnum
        ' 
        lblsecondnum.AutoSize = True
        lblsecondnum.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        lblsecondnum.Location = New Point(248, 53)
        lblsecondnum.Name = "lblsecondnum"
        lblsecondnum.Size = New Size(153, 25)
        lblsecondnum.TabIndex = 2
        lblsecondnum.Text = "Second Number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(462, 235)
        Controls.Add(lblsecondnum)
        Controls.Add(lblfirstnum)
        Controls.Add(txtfirstnum)
        Controls.Add(txtsecondnum)
        Controls.Add(btnexit)
        Controls.Add(btnclear)
        Controls.Add(btnresult)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Simple Addition"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnresult As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents txtsecondnum As TextBox
    Friend WithEvents txtfirstnum As TextBox
    Friend WithEvents lblfirstnum As Label
    Friend WithEvents lblsecondnum As Label

End Class
