<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CryptoAPI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CryptoAPI))
        Me.ptext = New System.Windows.Forms.Label()
        Me.crypto = New System.Windows.Forms.ComboBox()
        Me.Choose = New System.Windows.Forms.Label()
        Me.openP = New System.Windows.Forms.Button()
        Me.LKey = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.crypt = New System.Windows.Forms.Button()
        Me.dcrypt = New System.Windows.Forms.Button()
        Me.openC = New System.Windows.Forms.Button()
        Me.rndm = New System.Windows.Forms.Button()
        Me.linkP = New System.Windows.Forms.Label()
        Me.linkC = New System.Windows.Forms.Label()
        Me.key1 = New System.Windows.Forms.TextBox()
        Me.Num = New System.Windows.Forms.NumericUpDown()
        Me.saveC = New System.Windows.Forms.Button()
        Me.saveP = New System.Windows.Forms.Button()
        Me.Open = New System.Windows.Forms.OpenFileDialog()
        Me.Save = New System.Windows.Forms.SaveFileDialog()
        Me.SaveK = New System.Windows.Forms.Button()
        Me.doc = New System.Windows.Forms.Label()
        Me.NumK = New System.Windows.Forms.NumericUpDown()
        Me.kLength = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.key2 = New System.Windows.Forms.TextBox()
        Me.key3 = New System.Windows.Forms.TextBox()
        Me.AESKey = New System.Windows.Forms.ComboBox()
        Me.KeyBits = New System.Windows.Forms.Label()
        Me.about = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.q = New System.Windows.Forms.Label()
        Me.str = New System.Windows.Forms.CheckBox()
        CType(Me.Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ptext
        '
        Me.ptext.AutoSize = True
        Me.ptext.BackColor = System.Drawing.Color.Transparent
        Me.ptext.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.ptext.Location = New System.Drawing.Point(12, 72)
        Me.ptext.Name = "ptext"
        Me.ptext.Size = New System.Drawing.Size(95, 24)
        Me.ptext.TabIndex = 0
        Me.ptext.Text = "Plaintext:"
        '
        'crypto
        '
        Me.crypto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.crypto.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.crypto.FormattingEnabled = True
        Me.crypto.Items.AddRange(New Object() {"Caesar Shift", "Simple Substitution Cipher", "Playfair Cipher", "Vigenère Cipher", "Autokey Cipher", "Transposition Cipher", "Data Encryption Standard (DES)", "3-KEY Triple DES", "Advanced Encryption Standard (AES)", "SHA-256 (not encryption method)"})
        Me.crypto.Location = New System.Drawing.Point(308, 6)
        Me.crypto.Name = "crypto"
        Me.crypto.Size = New System.Drawing.Size(347, 32)
        Me.crypto.TabIndex = 1
        '
        'Choose
        '
        Me.Choose.AutoSize = True
        Me.Choose.BackColor = System.Drawing.Color.Transparent
        Me.Choose.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Choose.ForeColor = System.Drawing.Color.Yellow
        Me.Choose.Location = New System.Drawing.Point(12, 9)
        Me.Choose.Name = "Choose"
        Me.Choose.Size = New System.Drawing.Size(290, 24)
        Me.Choose.TabIndex = 2
        Me.Choose.Text = "Choose the encryption method:"
        '
        'openP
        '
        Me.openP.BackColor = System.Drawing.Color.Transparent
        Me.openP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.openP.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.openP.Location = New System.Drawing.Point(127, 67)
        Me.openP.Name = "openP"
        Me.openP.Size = New System.Drawing.Size(115, 36)
        Me.openP.TabIndex = 2
        Me.openP.Text = "Open a file"
        Me.openP.UseVisualStyleBackColor = False
        '
        'LKey
        '
        Me.LKey.AutoSize = True
        Me.LKey.BackColor = System.Drawing.Color.Transparent
        Me.LKey.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LKey.Location = New System.Drawing.Point(12, 146)
        Me.LKey.Name = "LKey"
        Me.LKey.Size = New System.Drawing.Size(50, 24)
        Me.LKey.TabIndex = 6
        Me.LKey.Text = "Key:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ciphertext:"
        '
        'crypt
        '
        Me.crypt.BackColor = System.Drawing.Color.Transparent
        Me.crypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.crypt.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.crypt.Location = New System.Drawing.Point(95, 265)
        Me.crypt.Name = "crypt"
        Me.crypt.Size = New System.Drawing.Size(150, 40)
        Me.crypt.TabIndex = 6
        Me.crypt.Text = "Encryption"
        Me.crypt.UseVisualStyleBackColor = False
        '
        'dcrypt
        '
        Me.dcrypt.BackColor = System.Drawing.Color.Transparent
        Me.dcrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dcrypt.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.dcrypt.Location = New System.Drawing.Point(256, 265)
        Me.dcrypt.Name = "dcrypt"
        Me.dcrypt.Size = New System.Drawing.Size(150, 40)
        Me.dcrypt.TabIndex = 7
        Me.dcrypt.Text = "Decryption"
        Me.dcrypt.UseVisualStyleBackColor = False
        '
        'openC
        '
        Me.openC.BackColor = System.Drawing.Color.Transparent
        Me.openC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.openC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.openC.Location = New System.Drawing.Point(127, 195)
        Me.openC.Name = "openC"
        Me.openC.Size = New System.Drawing.Size(115, 36)
        Me.openC.TabIndex = 4
        Me.openC.Text = "Open a file"
        Me.openC.UseVisualStyleBackColor = False
        '
        'rndm
        '
        Me.rndm.BackColor = System.Drawing.Color.Transparent
        Me.rndm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rndm.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.rndm.Location = New System.Drawing.Point(497, 267)
        Me.rndm.Name = "rndm"
        Me.rndm.Size = New System.Drawing.Size(216, 40)
        Me.rndm.TabIndex = 8
        Me.rndm.Text = "Create a random key"
        Me.rndm.UseVisualStyleBackColor = False
        '
        'linkP
        '
        Me.linkP.AutoSize = True
        Me.linkP.BackColor = System.Drawing.Color.Transparent
        Me.linkP.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.linkP.Location = New System.Drawing.Point(123, 106)
        Me.linkP.Name = "linkP"
        Me.linkP.Size = New System.Drawing.Size(92, 19)
        Me.linkP.TabIndex = 15
        Me.linkP.Text = "plaintext.txt"
        '
        'linkC
        '
        Me.linkC.AutoSize = True
        Me.linkC.BackColor = System.Drawing.Color.Transparent
        Me.linkC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.linkC.Location = New System.Drawing.Point(123, 234)
        Me.linkC.Name = "linkC"
        Me.linkC.Size = New System.Drawing.Size(101, 19)
        Me.linkC.TabIndex = 16
        Me.linkC.Text = "ciphertext.txt"
        '
        'key1
        '
        Me.key1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.key1.Location = New System.Drawing.Point(67, 147)
        Me.key1.Name = "key1"
        Me.key1.Size = New System.Drawing.Size(828, 27)
        Me.key1.TabIndex = 13
        Me.key1.Visible = False
        '
        'Num
        '
        Me.Num.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Num.Location = New System.Drawing.Point(67, 147)
        Me.Num.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Num.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        Me.Num.Name = "Num"
        Me.Num.Size = New System.Drawing.Size(120, 27)
        Me.Num.TabIndex = 12
        '
        'saveC
        '
        Me.saveC.BackColor = System.Drawing.Color.Transparent
        Me.saveC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.saveC.Location = New System.Drawing.Point(283, 195)
        Me.saveC.Name = "saveC"
        Me.saveC.Size = New System.Drawing.Size(163, 36)
        Me.saveC.TabIndex = 5
        Me.saveC.Text = "Save the Ciphertext"
        Me.saveC.UseVisualStyleBackColor = False
        '
        'saveP
        '
        Me.saveP.BackColor = System.Drawing.Color.Transparent
        Me.saveP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveP.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.saveP.Location = New System.Drawing.Point(283, 67)
        Me.saveP.Name = "saveP"
        Me.saveP.Size = New System.Drawing.Size(163, 36)
        Me.saveP.TabIndex = 3
        Me.saveP.Text = "Save the Plaintext"
        Me.saveP.UseVisualStyleBackColor = False
        '
        'SaveK
        '
        Me.SaveK.BackColor = System.Drawing.Color.Transparent
        Me.SaveK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveK.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SaveK.Location = New System.Drawing.Point(787, 106)
        Me.SaveK.Name = "SaveK"
        Me.SaveK.Size = New System.Drawing.Size(108, 36)
        Me.SaveK.TabIndex = 11
        Me.SaveK.Text = "Save the key"
        Me.SaveK.UseVisualStyleBackColor = False
        Me.SaveK.Visible = False
        '
        'doc
        '
        Me.doc.AutoSize = True
        Me.doc.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.doc.Location = New System.Drawing.Point(0, 0)
        Me.doc.MaximumSize = New System.Drawing.Size(880, 0)
        Me.doc.Name = "doc"
        Me.doc.Size = New System.Drawing.Size(96, 23)
        Me.doc.TabIndex = 22
        Me.doc.Text = "Document"
        '
        'NumK
        '
        Me.NumK.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.NumK.Location = New System.Drawing.Point(719, 275)
        Me.NumK.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.NumK.Name = "NumK"
        Me.NumK.Size = New System.Drawing.Size(78, 27)
        Me.NumK.TabIndex = 9
        Me.NumK.Value = New Decimal(New Integer() {256, 0, 0, 0})
        Me.NumK.Visible = False
        '
        'kLength
        '
        Me.kLength.AutoSize = True
        Me.kLength.BackColor = System.Drawing.Color.Transparent
        Me.kLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.kLength.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.kLength.Location = New System.Drawing.Point(715, 253)
        Me.kLength.Name = "kLength"
        Me.kLength.Size = New System.Drawing.Size(82, 19)
        Me.kLength.TabIndex = 24
        Me.kLength.Text = "key length"
        Me.kLength.Visible = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(888, 318)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 331)
        Me.VScrollBar1.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.doc)
        Me.Panel1.Location = New System.Drawing.Point(12, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 331)
        Me.Panel1.TabIndex = 26
        '
        'key2
        '
        Me.key2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.key2.Location = New System.Drawing.Point(345, 147)
        Me.key2.Name = "key2"
        Me.key2.Size = New System.Drawing.Size(272, 27)
        Me.key2.TabIndex = 14
        Me.key2.Visible = False
        '
        'key3
        '
        Me.key3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.key3.Location = New System.Drawing.Point(623, 147)
        Me.key3.Name = "key3"
        Me.key3.Size = New System.Drawing.Size(272, 27)
        Me.key3.TabIndex = 15
        Me.key3.Visible = False
        '
        'AESKey
        '
        Me.AESKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AESKey.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.AESKey.FormattingEnabled = True
        Me.AESKey.Items.AddRange(New Object() {"16", "24", "32"})
        Me.AESKey.Location = New System.Drawing.Point(719, 273)
        Me.AESKey.Name = "AESKey"
        Me.AESKey.Size = New System.Drawing.Size(78, 32)
        Me.AESKey.TabIndex = 10
        Me.AESKey.Visible = False
        '
        'KeyBits
        '
        Me.KeyBits.AutoSize = True
        Me.KeyBits.BackColor = System.Drawing.Color.Transparent
        Me.KeyBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.KeyBits.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.KeyBits.Location = New System.Drawing.Point(803, 282)
        Me.KeyBits.Name = "KeyBits"
        Me.KeyBits.Size = New System.Drawing.Size(57, 17)
        Me.KeyBits.TabIndex = 30
        Me.KeyBits.Text = "128 bits"
        Me.KeyBits.Visible = False
        '
        'about
        '
        Me.about.BackColor = System.Drawing.Color.Transparent
        Me.about.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.about.Location = New System.Drawing.Point(820, 12)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(75, 23)
        Me.about.TabIndex = 0
        Me.about.Text = "About"
        Me.about.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'q
        '
        Me.q.AutoSize = True
        Me.q.BackColor = System.Drawing.Color.Transparent
        Me.q.Location = New System.Drawing.Point(894, 0)
        Me.q.Name = "q"
        Me.q.Size = New System.Drawing.Size(15, 13)
        Me.q.TabIndex = 31
        Me.q.Text = "Q"
        '
        'str
        '
        Me.str.AutoSize = True
        Me.str.BackColor = System.Drawing.Color.Transparent
        Me.str.Location = New System.Drawing.Point(655, 244)
        Me.str.Name = "str"
        Me.str.Size = New System.Drawing.Size(54, 17)
        Me.str.TabIndex = 32
        Me.str.Text = "String"
        Me.str.UseVisualStyleBackColor = False
        Me.str.Visible = False
        '
        'CryptoAPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 651)
        Me.Controls.Add(Me.str)
        Me.Controls.Add(Me.about)
        Me.Controls.Add(Me.KeyBits)
        Me.Controls.Add(Me.AESKey)
        Me.Controls.Add(Me.key3)
        Me.Controls.Add(Me.key2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.kLength)
        Me.Controls.Add(Me.NumK)
        Me.Controls.Add(Me.SaveK)
        Me.Controls.Add(Me.saveP)
        Me.Controls.Add(Me.saveC)
        Me.Controls.Add(Me.Num)
        Me.Controls.Add(Me.key1)
        Me.Controls.Add(Me.linkC)
        Me.Controls.Add(Me.linkP)
        Me.Controls.Add(Me.rndm)
        Me.Controls.Add(Me.openC)
        Me.Controls.Add(Me.dcrypt)
        Me.Controls.Add(Me.crypt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LKey)
        Me.Controls.Add(Me.openP)
        Me.Controls.Add(Me.Choose)
        Me.Controls.Add(Me.crypto)
        Me.Controls.Add(Me.ptext)
        Me.Controls.Add(Me.q)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CryptoAPI"
        Me.Text = "CryptoAPI"
        CType(Me.Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptext As Label
    Friend WithEvents crypto As ComboBox
    Friend WithEvents Choose As Label
    Friend WithEvents openP As Button
    Friend WithEvents LKey As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents crypt As Button
    Friend WithEvents dcrypt As Button
    Friend WithEvents openC As Button
    Friend WithEvents rndm As Button
    Friend WithEvents linkP As Label
    Friend WithEvents linkC As Label
    Friend WithEvents key1 As TextBox
    Friend WithEvents Num As NumericUpDown
    Friend WithEvents saveC As Button
    Friend WithEvents saveP As Button
    Friend WithEvents Open As OpenFileDialog
    Friend WithEvents Save As SaveFileDialog
    Friend WithEvents SaveK As Button
    Friend WithEvents NumK As NumericUpDown
    Friend WithEvents kLength As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents doc As Label
    Friend WithEvents key2 As TextBox
    Friend WithEvents key3 As TextBox
    Friend WithEvents AESKey As ComboBox
    Friend WithEvents KeyBits As Label
    Friend WithEvents about As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents q As Label
    Friend WithEvents str As CheckBox
End Class
