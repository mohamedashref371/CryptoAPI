<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LMhmd = New System.Windows.Forms.Label()
        Me.B = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.Label()
        Me.University = New System.Windows.Forms.Label()
        Me.supervision = New System.Windows.Forms.Label()
        Me.IDnumber = New System.Windows.Forms.Label()
        Me.ProjectDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LMhmd
        '
        Me.LMhmd.AutoSize = True
        Me.LMhmd.BackColor = System.Drawing.Color.Transparent
        Me.LMhmd.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LMhmd.ForeColor = System.Drawing.Color.Yellow
        Me.LMhmd.Location = New System.Drawing.Point(34, 9)
        Me.LMhmd.Name = "LMhmd"
        Me.LMhmd.Size = New System.Drawing.Size(471, 24)
        Me.LMhmd.TabIndex = 2
        Me.LMhmd.Text = "This project was created by Mohamed Ashref Sayed"
        '
        'B
        '
        Me.B.AutoSize = True
        Me.B.BackColor = System.Drawing.Color.Transparent
        Me.B.Font = New System.Drawing.Font("Tahoma", 27.0!)
        Me.B.Image = Global.CryptoAPI.My.Resources.Resources.blue_ruby
        Me.B.Location = New System.Drawing.Point(484, 189)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(52, 43)
        Me.B.TabIndex = 31
        Me.B.Text = "   "
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.BackColor = System.Drawing.Color.Transparent
        Me.A.Font = New System.Drawing.Font("Tahoma", 27.0!)
        Me.A.Image = Global.CryptoAPI.My.Resources.Resources.red_ruby
        Me.A.Location = New System.Drawing.Point(12, 189)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(52, 43)
        Me.A.TabIndex = 30
        Me.A.Text = "   "
        '
        'University
        '
        Me.University.AutoSize = True
        Me.University.BackColor = System.Drawing.Color.Transparent
        Me.University.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.University.ForeColor = System.Drawing.Color.Aqua
        Me.University.Location = New System.Drawing.Point(33, 140)
        Me.University.MaximumSize = New System.Drawing.Size(538, 0)
        Me.University.Name = "University"
        Me.University.Size = New System.Drawing.Size(470, 72)
        Me.University.TabIndex = 32
        Me.University.Text = "Department of Mathematics and Computer Science, Faculty of Science, Al-Azhar Univ" &
    "ersity," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nasr City, Cairo, Egypt"
        Me.University.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'supervision
        '
        Me.supervision.AutoSize = True
        Me.supervision.BackColor = System.Drawing.Color.Transparent
        Me.supervision.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.supervision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.supervision.Location = New System.Drawing.Point(79, 79)
        Me.supervision.MaximumSize = New System.Drawing.Size(538, 0)
        Me.supervision.Name = "supervision"
        Me.supervision.Size = New System.Drawing.Size(365, 48)
        Me.supervision.TabIndex = 33
        Me.supervision.Text = "Under the supervision of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dr. AbdAllah Adel Mohammed AlHabshy"
        Me.supervision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IDnumber
        '
        Me.IDnumber.AutoSize = True
        Me.IDnumber.BackColor = System.Drawing.Color.Transparent
        Me.IDnumber.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.IDnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IDnumber.Location = New System.Drawing.Point(157, 37)
        Me.IDnumber.MaximumSize = New System.Drawing.Size(538, 0)
        Me.IDnumber.Name = "IDnumber"
        Me.IDnumber.Size = New System.Drawing.Size(206, 24)
        Me.IDnumber.TabIndex = 34
        Me.IDnumber.Text = "ID number: 20191075"
        Me.IDnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProjectDate
        '
        Me.ProjectDate.AutoSize = True
        Me.ProjectDate.BackColor = System.Drawing.Color.Transparent
        Me.ProjectDate.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.ProjectDate.ForeColor = System.Drawing.Color.White
        Me.ProjectDate.Location = New System.Drawing.Point(208, 218)
        Me.ProjectDate.MaximumSize = New System.Drawing.Size(538, 0)
        Me.ProjectDate.Name = "ProjectDate"
        Me.ProjectDate.Size = New System.Drawing.Size(114, 24)
        Me.ProjectDate.TabIndex = 35
        Me.ProjectDate.Text = "2023/03/22"
        Me.ProjectDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(548, 241)
        Me.Controls.Add(Me.ProjectDate)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.IDnumber)
        Me.Controls.Add(Me.supervision)
        Me.Controls.Add(Me.University)
        Me.Controls.Add(Me.LMhmd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LMhmd As Label
    Friend WithEvents A As Label
    Friend WithEvents B As Label
    Friend WithEvents University As Label
    Friend WithEvents supervision As Label
    Friend WithEvents IDnumber As Label
    Friend WithEvents ProjectDate As Label
End Class
