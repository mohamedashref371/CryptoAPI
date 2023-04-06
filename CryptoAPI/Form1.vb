Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class CryptoAPI
    Dim n As Integer
    Dim int As Integer
    Dim rand = New Random
    Dim plainFile As Byte() = {}
    Dim cipherFile As Byte() = {}

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        about.ForeColor = Color.FromArgb(rand.next(0, 256), rand.next(0, 256), rand.next(0, 256))
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        Timer1.Stop()
        Form2.Show()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        doc.Top = -VScrollBar1.Value
    End Sub

    Private Sub CryptoAPI_Key(sender As Object, e As KeyEventArgs) Handles about.KeyDown
        If e.KeyCode = Keys.Q Then
            BackgroundImage = Nothing
            ForeColor = Color.Black
            Choose.ForeColor = Color.Black
            about.FlatStyle = FlatStyle.Standard
            SaveK.FlatStyle = FlatStyle.Standard
            openP.FlatStyle = FlatStyle.Standard : saveP.FlatStyle = FlatStyle.Standard
            openC.FlatStyle = FlatStyle.Standard : saveC.FlatStyle = FlatStyle.Standard
            crypt.FlatStyle = FlatStyle.Standard : dcrypt.FlatStyle = FlatStyle.Standard
            rndm.FlatStyle = FlatStyle.Standard
            q.Visible = False
        End If
    End Sub

    Private Sub KeyBoxes(i As Integer)
        LKey.Visible = True : Num.Visible = False : key1.Visible = False : key2.Visible = False : key3.Visible = False : SaveK.Visible = False
        If i = -1 Then
            LKey.Visible = False
        ElseIf i = 0 Then
            Num.Visible = True
        ElseIf i = 1 Then
            SaveK.Visible = True
            key1.Size = New Size(828, 27)
            key1.Visible = True
        ElseIf i = 2 Then

        ElseIf i = 3 Then
            SaveK.Visible = True
            key1.Size = New Size(272, 27)
            key1.Visible = True : key2.Visible = True : key3.Visible = True
        End If
    End Sub

    Private Sub AESKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AESKey.SelectedIndexChanged
        KeyBits.Text = (AESKey.SelectedItem * 8).ToString + " bits"
    End Sub

    Private Sub crypto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles crypto.SelectedIndexChanged
        n = crypto.SelectedIndex
        doc.Location = Nothing
        doc.Text = Document.Document(n)
        VScrollBar1.Maximum = doc.Height - Panel1.Location.Y + 10
        kLength.Visible = False : NumK.Visible = False : AESKey.Visible = False : KeyBits.Visible = False
        crypt.Text = "Encryption" : dcrypt.Text = "Decryption"
        rndm.Visible = True : str.Visible = False
        If n = 0 Or n = 5 Then
            If n = 0 Then
                Num.Minimum = -9999
            ElseIf n = 5 Then
                Num.Minimum = 1
            End If
            KeyBoxes(0)
        ElseIf n = 1 Then
            KeyBoxes(1)
            key1.Text = SimpleSubstitutionKey(256)
        ElseIf n = 2 Then
            KeyBoxes(1)
            NumK.Maximum = 256
            kLength.Visible = True : NumK.Visible = True
            int = NumK.Value
            key1.Text = SimpleSubstitutionKey(int)
        ElseIf n = 3 Or n = 4 Then
            KeyBoxes(1)
            NumK.Value = 10 : NumK.Maximum = 9999
            kLength.Visible = True : NumK.Visible = True
            int = NumK.Value
            str.Visible = True
            key1.Text = CipherKey(int, str.Checked)
        ElseIf n = 6 Then
            KeyBoxes(1)
            str.Visible = True
            key1.Text = CipherKey(8, str.Checked)
        ElseIf n = 7 Then
            KeyBoxes(3)
            str.Visible = True
            key1.Text = CipherKey(8, str.Checked)
            key2.Text = CipherKey(8, str.Checked)
            key3.Text = CipherKey(8, str.Checked)
        ElseIf n = 8 Then
            KeyBoxes(1)
            kLength.Visible = True : AESKey.Visible = True : KeyBits.Visible = True
            str.Visible = True
            key1.Text = CipherKey(AESKey.SelectedItem, str.Checked)
        ElseIf n = 9 Then
            KeyBoxes(1)
            crypt.Text = "Compute Hash" : dcrypt.Text = "Check Hash"
            rndm.Visible = False
        End If
    End Sub

    Sub swap(ByRef a As Object, ByRef b As Object)
        Dim c As Object = a : a = b : b = c
    End Sub

    Sub KeyError()
        MsgBox("Error in the key!")
    End Sub

    Private Sub CryptoAPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crypto.SelectedIndex = 0
        AESKey.SelectedIndex = 0
        Dim encoding As Encoding = Encoding.UTF8
        If Not CheckHash(encoding.GetBytes(Form2.LMhmd.Text), Form2.I) Or Not CheckHash(encoding.GetBytes(Form2.supervision.Text), Form2.Dr) Then
            End
        End If
    End Sub

    Private Sub openP_Click(sender As Object, e As EventArgs) Handles openP.Click
        If Open.ShowDialog = DialogResult.OK Then
            linkP.Text = Open.FileName
            plainFile = My.Computer.FileSystem.ReadAllBytes(linkP.Text)
        End If
    End Sub

    Private Sub saveP_Click(sender As Object, e As EventArgs) Handles saveP.Click
        If Save.ShowDialog = DialogResult.OK Then
            linkP.Text = Save.FileName
            My.Computer.FileSystem.WriteAllBytes(linkP.Text, plainFile, False)
        End If
    End Sub

    Private Sub openC_Click(sender As Object, e As EventArgs) Handles openC.Click
        If Open.ShowDialog = DialogResult.OK Then
            linkC.Text = Open.FileName
            cipherFile = My.Computer.FileSystem.ReadAllBytes(linkC.Text)
        End If
    End Sub

    Private Sub saveC_Click(sender As Object, e As EventArgs) Handles saveC.Click
        If Save.ShowDialog = DialogResult.OK Then
            linkC.Text = Save.FileName
            My.Computer.FileSystem.WriteAllBytes(linkC.Text, cipherFile, False)
        End If
    End Sub

    Private Sub SaveK_Click(sender As Object, e As EventArgs) Handles SaveK.Click
        If Save.ShowDialog = DialogResult.OK Then
            Dim s As String = ""
            If key1.Visible Then s += "key : " + key1.Text
            If key2.Visible Then s += Environment.NewLine + "key2: " + key2.Text
            If key3.Visible Then s += Environment.NewLine + "key3: " + key3.Text
            My.Computer.FileSystem.WriteAllText(Save.FileName, s, False)
        End If
    End Sub

    Private Sub crypt_Click(sender As Object, e As EventArgs) Handles crypt.Click
        If n = 0 Then
            cipherFile = CaesarShift(plainFile.ToArray, Num.Value)
        ElseIf n = 1 Then
            Dim key As Byte() = SimpleSubstitutionKey(key1.Text, True)
            If key.Length = 256 Then
                cipherFile = SimpleSubstitution(plainFile.ToArray, key)
            Else
                KeyError()
                Exit Sub
            End If
        ElseIf n = 2 Then
            cipherFile = PlayfairCipher(plainFile.ToArray, PlayfairCipherKey(key1.Text), True)
        ElseIf n = 3 Then
            cipherFile = VigenèreCipher(plainFile.ToArray, Split(key1.Text, True).ToArray, True, False)
        ElseIf n = 4 Then
            cipherFile = VigenèreCipher(plainFile.ToArray, Split(key1.Text, True).ToArray, True, True)
        ElseIf n = 5 Then
            cipherFile = TranspositionCipher(plainFile.ToArray, Num.Value, True)
        ElseIf n = 6 Then
            Dim key As Byte() = Split(key1.Text, True).ToArray
            If key.Length = 8 Then
                cipherFile = DES(plainFile.ToArray, key, True)
            Else
                KeyError()
                Exit Sub
            End If
        ElseIf n = 7 Then
            Dim keyA As Byte() = Split(key1.Text, True).ToArray
            Dim keyB As Byte() = Split(key2.Text, True).ToArray
            Dim keyC As Byte() = Split(key3.Text, True).ToArray
            If keyA.Length = 8 And keyB.Length = 8 And keyC.Length = 8 Then
                cipherFile = TripleDES(plainFile.ToArray, keyA, keyB, keyC, True)
            Else
                KeyError()
                Exit Sub
            End If
        ElseIf n = 8 Then
            Dim key As Byte() = Split(key1.Text, True).ToArray
            If key.Length = 16 Or key.Length = 24 Or key.Length = 32 Then
                cipherFile = AES(plainFile.ToArray, key, True)
            Else
                KeyError()
                Exit Sub
            End If
        ElseIf n = 9 Then ' not encryption method
            key1.Text = ComputeHash(plainFile)
            Exit Sub
        End If
        linkC.Text = "ciphertext.txt"
    End Sub

    Private Sub dcrypt_Click(sender As Object, e As EventArgs) Handles dcrypt.Click
        If n = 0 Then
            plainFile = CaesarShift(cipherFile.ToArray, -1 * Num.Value)
        ElseIf n = 1 Then
            Dim key As Byte() = SimpleSubstitutionKey(key1.Text, False)
            If key.Length = 256 Then
                plainFile = SimpleSubstitution(cipherFile.ToArray, key)
            Else
                KeyError()
                Exit Sub
            End If
        ElseIf n = 2 Then
            plainFile = PlayfairCipher(cipherFile.ToArray, PlayfairCipherKey(key1.Text), False)
        ElseIf n = 3 Then
            plainFile = VigenèreCipher(cipherFile.ToArray, Split(key1.Text, True).ToArray, False, False)
        ElseIf n = 4 Then
            plainFile = VigenèreCipher(cipherFile.ToArray, Split(key1.Text, True).ToArray, False, True)
        ElseIf n = 5 Then
            plainFile = TranspositionCipher(cipherFile.ToArray, Num.Value, False)
        ElseIf n = 6 Then
            Dim key As Byte() = Split(key1.Text, True).ToArray
            If key.Length = 8 Then
                plainFile = DES(cipherFile.ToArray, key, False)
            Else
                KeyError()
                Exit Sub
            End If
        ElseIf n = 7 Then
            Dim keyA As Byte() = Split(key1.Text, True).ToArray
            Dim keyB As Byte() = Split(key2.Text, True).ToArray
            Dim keyC As Byte() = Split(key3.Text, True).ToArray
            If keyA.Length = 8 And keyB.Length = 8 And keyC.Length = 8 Then
                plainFile = TripleDES(cipherFile.ToArray, keyA, keyB, keyC, False)
            Else
                KeyError()
                Exit Sub
            End If
        ElseIf n = 8 Then
            Dim key As Byte() = Split(key1.Text, True).ToArray
            If key.Length = 16 Or key.Length = 24 Or key.Length = 32 Then
                plainFile = AES(cipherFile.ToArray, key, False)
            Else
                KeyError()
                Exit Sub
            End If
        ElseIf n = 9 Then ' Check the integrity of the text
            MsgBox(CheckHash(plainFile, key1.Text))
            Exit Sub
        End If
        linkP.Text = "plaintext.txt"
    End Sub

    Private Sub rndm_Click(sender As Object, e As EventArgs) Handles rndm.Click
        If n = 0 Then                                       ' Caesar Shift
            Num.Value = rand.Next(1, 256)
        ElseIf n = 1 Then                                   ' Simple Substitution Cipher
            key1.Text = SimpleSubstitutionKey(256)
        ElseIf n = 2 Then                                   ' Playfair Cipher
            int = NumK.Value
            key1.Text = SimpleSubstitutionKey(int)          ' same method
        ElseIf n = 3 Or n = 4 Then
            int = NumK.Value
            key1.Text = CipherKey(int, str.Checked)
        ElseIf n = 5 Then
            Num.Value = rand.Next(5, 50)
        ElseIf n = 6 Then
            key1.Text = CipherKey(8, str.Checked)
        ElseIf n = 7 Then
            key1.Text = CipherKey(8, str.Checked)
            key2.Text = CipherKey(8, str.Checked)
            key3.Text = CipherKey(8, str.Checked)
        ElseIf n = 8 Then
            key1.Text = CipherKey(AESKey.SelectedItem, str.Checked)
        End If
    End Sub
    '-------------------------------------------------------

    ' Caesar Shift
    Function CaesarShift(text As Byte(), shift As Integer) As Byte()
        For i = 0 To text.Length - 1
            text(i) = modulo(text(i) + shift, 256)
        Next
        Return text
    End Function
    '-------------------------------------------------------

    ' Simple Substitution Cipher
    Function SimpleSubstitutionKey(length As Integer) As String ' create a key
        Dim temp As New List(Of Byte)
        Dim temp1 As New List(Of Byte)
        For i = 0 To 255
            temp.Add(i)
        Next
        While temp.Count > 256 - length
            Dim j As Integer = rand.Next(0, temp.Count)
            temp1.Add(temp(j)) : temp.RemoveAt(j)
        End While
        Dim s As String = ""
        For i = 0 To length - 1
            s += temp1(i).ToString
            If i < length - 1 Then s += ", "
        Next
        Return s
    End Function

    Function Split(key1 As String, repeat As Boolean) As List(Of Byte)
        Dim key As New List(Of Byte)
        Try
            Dim temp() As String = {}
            temp = key1.Split(",")
            For i = 0 To temp.Length - 1
                If Not key.Contains(temp(i)) Or repeat Then
                    key.Add(modulo(temp(i), 256))
                End If
            Next
            Return key
        Catch ex As Exception
            Dim encoding As Encoding = Encoding.UTF8
            If repeat Then
                Return encoding.GetBytes(key1).ToList
            Else
                Dim byt As Byte
                For i = 0 To key1.Length - 1
                    byt = Convert.ToByte(key1(i))
                    If Not key.Contains(byt) Then
                        key.Add(byt)
                    End If
                Next
                Return key
            End If
        End Try
    End Function

    Function SimpleSubstitutionKey(key1 As String, encrypt As Boolean) As Byte() ' key of encryption and decryption
        Dim key As List(Of Byte) = Split(key1, False)
        If Not encrypt And key.Count = 256 Then
            Dim key2 As New List(Of Byte)
            For i = 0 To 255
                key2.Add(i)
            Next
            For i = 0 To 255
                For j = i + 1 To 255
                    If key(i) > key(j) Then
                        swap(key(i), key(j)) : swap(key2(i), key2(j))
                    End If
                Next
            Next
            Return key2.ToArray
        End If
        Return key.ToArray
    End Function

    Function SimpleSubstitution(text As Byte(), key As Byte()) As Byte()
        For i = 0 To text.Length - 1
            text(i) = key(text(i))
        Next
        Return text
    End Function
    '-------------------------------------------------------

    ' Playfair Cipher
    Function PlayfairCipherKey(key1 As String) As Byte(,)
        Dim key As List(Of Byte) = Split(key1, False)
        Dim key2(15, 15) As Byte ' 16*16 matrix
        Dim temp1 As New List(Of Byte)
        For i = 0 To 255
            temp1.Add(i)
        Next
        For i = 0 To key.Count - 1
            temp1.Remove(key(i))
        Next
        key.AddRange(temp1)
        Dim k As Integer = 0
        For i = 0 To 15
            For j = 0 To 15
                key2(i, j) = key(k)
                k += 1
            Next
        Next
        Return key2
    End Function

    Function f(x As Boolean) As Integer
        Return -(2 * x + 1) ' false = 0 and true = -1
    End Function

    Function modulo(x As Integer, y As Integer) As Integer
        If x >= 0 Or y < 0 Then
            Return x Mod y
        End If
        While x < 0
            x += y
        End While
        Return x
    End Function

    Function PlayfairCipher(text As Byte(), key As Byte(,), encrypt As Boolean) As Byte()
        Dim pointer As Integer = 0

        ' Text correction part. Is it possible to do without it?
        If encrypt And False Then
            Dim temptext As List(Of Byte) = text.ToList
            While pointer < temptext.Count - 1
                If temptext(pointer) = temptext(pointer + 1) And temptext(pointer) > 0 Then
                    temptext.Insert(pointer + 1, 0)
                ElseIf temptext(pointer) = temptext(pointer + 1) Then
                    temptext.Insert(pointer + 1, 255)
                End If
                pointer += 2
            End While
            If temptext.Count Mod 2 = 1 And temptext.Last > 0 Then
                temptext.Add(0)
            ElseIf temptext.Count Mod 2 = 1 Then
                temptext.Add(255)
            End If
            text = temptext.ToArray
        End If

        ' Text encryption and decryption part
        Dim speedKey(255, 1) As Byte ' 256*2 matrix for more speed
        For i = 0 To 15
            For j = 0 To 15
                speedKey(key(i, j), 0) = i
                speedKey(key(i, j), 1) = j
            Next
        Next
        pointer = 0
        Dim shift As Integer = f(encrypt) ' f(false) = -1 and f(true) = +1
        Dim x1, x2, y1, y2 As Integer
        While pointer < text.Count - 1 ' It is time!  :'(
            x1 = speedKey(text(pointer), 0)
            y1 = speedKey(text(pointer), 1)
            x2 = speedKey(text(pointer + 1), 0)
            y2 = speedKey(text(pointer + 1), 1)
            If x1 = x2 And y1 = y2 Then ' This condition will only be true if the correction part is abandoned.
                x1 += shift : x2 += shift
                y1 += shift : y2 += shift
            ElseIf x1 = x2 Then
                y1 += shift : y2 += shift
            ElseIf y1 = y2 Then
                x1 += shift : x2 += shift
            Else
                swap(y1, y2)
            End If
            text(pointer) = key(modulo(x1, 16), modulo(y1, 16))
            text(pointer + 1) = key(modulo(x2, 16), modulo(y2, 16))
            pointer += 2
        End While
        Return text
    End Function
    '-------------------------------------------------------

    ' Vigenère Cipher and Autokey Cipher
    Function CipherKey(length As Integer, str As Boolean) As String ' create a key
        Dim s As String = ""
        For i = 0 To length - 1
            If str Then
                Dim byt As Byte = rand.Next(33, 127)
                s += Convert.ToChar(byt) ' 33 -> 126
            Else
                s += rand.Next(0, 256).ToString
                If i < length - 1 Then s += ", "
            End If
        Next
        Return s
    End Function

    Function VigenèreCipher(text As Byte(), key As Byte(), encrypt As Boolean, autoKey As Boolean) As Byte()
        Dim temp As New List(Of Byte)
        For i = 0 To text.Length - 1
            If encrypt And autoKey And i <= text.Length - key.Length Then
                temp.Add(text(i))
            End If
            If autoKey And i >= key.Length Then
                If encrypt Then
                    text(i) = (text(i) + 1 * temp(i - key.Length)) Mod 256
                Else
                    text(i) = modulo(text(i) - 1 * text(i - key.Length), 256)
                End If
            Else
                text(i) = modulo(text(i) + f(encrypt) * key(i Mod key.Length), 256)
            End If
        Next
        Return text
    End Function
    '-------------------------------------------------------

    ' Transposition Cipher
    Function TranspositionCipher(text As Byte(), key As Integer, encrypt As Boolean) As Byte()
        Dim row As Integer = Math.Ceiling(text.Length / key)
        Dim matrix(row - 1, key - 1) As Byte ' x-1 instead of x in visual basic
        Dim full As Integer = text.Length - (row - 1) * key
        Dim counter As Integer = 0

        If encrypt Then
            For i = 0 To text.Length - 1
                matrix((i - i Mod key) / key, i Mod key) = text(i)
            Next
        End If
        For j = 0 To key - 1
            For i = 0 To row - 1
                If full = 0 And i = row - 1 Then
                Else
                    swap(text(counter), matrix(i, j))
                    counter += 1
                    If i = row - 1 Then full -= 1
                End If
            Next
        Next
        If Not encrypt Then
            For i = 0 To text.Length - 1
                text(i) = matrix((i - i Mod key) / key, i Mod key)
            Next
        End If
        Return text
    End Function
    '----------------------------------------------------------------------------



    ' It is very difficult to build an iron winged dragon from scratch.
    ' Do winged dragons have wings? :/
    ' Only now I have to go to a library to find out.

    Sub BlackBox(ByRef crypt As Object, ByRef text As Byte(), encrypt As Boolean)
        If encrypt Then
            Dim memoryStream As New MemoryStream()
            Dim cryptoStream As New CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write)

            cryptoStream.Write(text, 0, text.Length)
            cryptoStream.FlushFinalBlock()

            text = memoryStream.ToArray()
        Else
            Try
                Dim memoryStream As New MemoryStream(text)
                Dim cryptoStream As New CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read)

                cryptoStream.Read(text, 0, text.Length)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    ' Data Encryption Standard (DES)
    Function DES(text As Byte(), key As Byte(), encrypt As Boolean) As Byte()
        Dim DEScrypt As New DESCryptoServiceProvider()
        DEScrypt.Key = key
        DEScrypt.IV = key

        BlackBox(DEScrypt, text, encrypt)

        Return text
    End Function

    ' Winged dragon with three heads.

    ' 3 keys are better than one, right?
    ' 3-KEY Triple DES
    Function TripleDESXXX1(text As Byte(), key1 As Byte(), key2 As Byte(), key3 As Byte(), encrypt As Boolean) As Byte()
        If encrypt Then
            DES(text, key1, True)
            DES(text, key2, False) ' Decryption
            DES(text, key3, True)
        Else
            DES(text, key3, False)
            DES(text, key2, True)
            DES(text, key1, False)
        End If
        Return text
    End Function ' This does not work when decryption.

    Function TripleDESXXX2(text As Byte(), key1 As Byte(), key2 As Byte(), key3 As Byte(), encrypt As Boolean) As Byte()
        If encrypt Then
            text = DES(text, key1, True)
            text = DES(text, key2, True) ' I have to do that, I'm sorry.
            text = DES(text, key3, True)
        Else
            text = DES(text, key3, False)
            text = DES(text, key2, False) ' And accordingly this too.
            text = DES(text, key1, False)
        End If
        Return text
    End Function ' And this also does not work when decryption.

    Function TripleDES(text As Byte(), key1 As Byte(), key2 As Byte(), key3 As Byte(), encrypt As Boolean) As Byte()
        Dim TDES As New TripleDESCryptoServiceProvider()
        TDES.Key = key1.Concat(key2).Concat(key3).ToArray()
        TDES.Mode = CipherMode.ECB
        TDES.Padding = PaddingMode.PKCS7

        BlackBox(TDES, text, encrypt)

        Return text
    End Function ' This works. So I can't talk to the three heads separately.
    '-------------------------------------------------------

    ' The winged dragons are crying in the corner, but why?
    ' The stories about dragons are old, because many monsters that are much more powerful than them have now appeared.

    ' Advanced Encryption Standard (AES)
    Function AES(text As Byte(), key As Byte(), encrypt As Boolean) As Byte()
        Dim AEScrypt As New AesCryptoServiceProvider()
        AEScrypt.BlockSize = 128
        AEScrypt.Key = key
        AEScrypt.IV = key.Take(16).ToArray
        AEScrypt.Mode = CipherMode.CBC
        AEScrypt.Padding = PaddingMode.PKCS7

        BlackBox(AEScrypt, text, encrypt)

        Return text
    End Function
    '-------------------------------------------------------

    ' SHA-256 (not encryption method)
    Function ComputeHash(text As Byte()) As String
        Dim SHA256 As SHA256 = SHA256.Create()
        Return Convert.ToBase64String(SHA256.ComputeHash(text))
    End Function

    Function CheckHash(text As Byte(), hash256 As String) As Boolean
        Return ComputeHash(text).Equals(hash256)
    End Function
End Class