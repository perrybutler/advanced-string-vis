
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace AdvancedStringVisualizer
    Partial Public Class StringVisualizer
        Inherits Form
        Private _nullInd As Boolean = True
        Private _content As String = ""

        Public Sub New(ByVal content As String, ByVal nullInd As Boolean)
            InitializeComponent()
            _content = content
            lblOriginalLength.Text = "Original length: " & _content.Length
            cboEncoding1.SelectedIndex = 0
            cboEncoding2.SelectedIndex = 3
            ShowText1()
            ShowText2()
            'txtText1.Text = content
            '_nullInd = nullInd
            'If Not nullInd Then
            '    Label1.Text = "Len: " & content.Length.ToString("N0")
            '    Dim hexBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(content)
            '    Dim hexString As New StringBuilder(content.Length * 3)
            '    For i As Integer = 0 To content.Length - 1
            '        hexString.Append(hexBytes(i).ToString("X2") + " ")
            '    Next
            '    txtText2.Text = hexString.ToString()
            'End If
        End Sub

        Private Sub txtHex_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            SelectText()
        End Sub

        Private Sub txtHex_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Select Case e.KeyCode
                Case Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.[End], Keys.Home, _
                 Keys.PageDown, Keys.PageUp
                    SelectText()
                    Exit Select
            End Select
        End Sub

        Private Sub txtText_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            SelectHex()
        End Sub

        Private Sub txtText_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Select Case e.KeyCode
                Case Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.[End], Keys.Home, _
                 Keys.PageDown, Keys.PageUp
                    SelectHex()
                    Exit Select
            End Select
        End Sub

        Private Sub SelectHex()
            If Not _nullInd AndAlso txtText2.Text.Length > 0 Then
                Dim caretPos As Integer = txtText1.SelectionStart
                txtText2.SelectionStart = caretPos * 3
                txtText2.SelectionLength = 2
                txtText2.ScrollToCaret()
            End If
        End Sub

        Private Sub SelectText()
            If Not _nullInd AndAlso txtText1.Text.Length > 0 Then
                Dim caretPos As Integer = txtText2.SelectionStart
                txtText1.SelectionStart = caretPos / 3
                txtText1.SelectionLength = 1
                txtText1.ScrollToCaret()
            End If
        End Sub

        Private Sub StringVisualizer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
        Private Sub InitializeComponent()
            Me.btnClose = New System.Windows.Forms.Button
            Me.lblLen1 = New System.Windows.Forms.Label
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.lblPos1 = New System.Windows.Forms.Label
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
            Me.txtText1 = New System.Windows.Forms.TextBox
            Me.Panel4 = New System.Windows.Forms.Panel
            Me.Panel2 = New System.Windows.Forms.Panel
            Me.chkWrap1 = New System.Windows.Forms.CheckBox
            Me.cboEncoding1 = New System.Windows.Forms.ComboBox
            Me.chkPurgeNulls1 = New System.Windows.Forms.CheckBox
            Me.txtText2 = New System.Windows.Forms.TextBox
            Me.Panel5 = New System.Windows.Forms.Panel
            Me.lblPos2 = New System.Windows.Forms.Label
            Me.Panel3 = New System.Windows.Forms.Panel
            Me.chkWrap2 = New System.Windows.Forms.CheckBox
            Me.cboEncoding2 = New System.Windows.Forms.ComboBox
            Me.chkPurgeNulls2 = New System.Windows.Forms.CheckBox
            Me.lblOriginalLength = New System.Windows.Forms.Label
            Me.lblLen2 = New System.Windows.Forms.Label
            Me.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Location = New System.Drawing.Point(348, 4)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(75, 23)
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'lblLen1
            '
            Me.lblLen1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblLen1.Location = New System.Drawing.Point(92, 5)
            Me.lblLen1.Name = "lblLen1"
            Me.lblLen1.Size = New System.Drawing.Size(115, 13)
            Me.lblLen1.TabIndex = 5
            Me.lblLen1.Text = "Len: 999999"
            Me.lblLen1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblOriginalLength)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 272)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(427, 32)
            Me.Panel1.TabIndex = 6
            '
            'lblPos1
            '
            Me.lblPos1.AutoSize = True
            Me.lblPos1.Location = New System.Drawing.Point(4, 5)
            Me.lblPos1.Name = "lblPos1"
            Me.lblPos1.Size = New System.Drawing.Size(37, 13)
            Me.lblPos1.TabIndex = 7
            Me.lblPos1.Text = "Pos: 0"
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.txtText1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
            Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.txtText2)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
            Me.SplitContainer1.Size = New System.Drawing.Size(427, 272)
            Me.SplitContainer1.SplitterDistance = 214
            Me.SplitContainer1.TabIndex = 10
            '
            'txtText1
            '
            Me.txtText1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtText1.Location = New System.Drawing.Point(0, 28)
            Me.txtText1.Multiline = True
            Me.txtText1.Name = "txtText1"
            Me.txtText1.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtText1.Size = New System.Drawing.Size(214, 220)
            Me.txtText1.TabIndex = 8
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.lblPos1)
            Me.Panel4.Controls.Add(Me.lblLen1)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel4.Location = New System.Drawing.Point(0, 248)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(214, 24)
            Me.Panel4.TabIndex = 10
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.chkWrap1)
            Me.Panel2.Controls.Add(Me.cboEncoding1)
            Me.Panel2.Controls.Add(Me.chkPurgeNulls1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(214, 28)
            Me.Panel2.TabIndex = 9
            '
            'chkWrap1
            '
            Me.chkWrap1.AutoSize = True
            Me.chkWrap1.Checked = True
            Me.chkWrap1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkWrap1.Location = New System.Drawing.Point(156, 8)
            Me.chkWrap1.Name = "chkWrap1"
            Me.chkWrap1.Size = New System.Drawing.Size(52, 17)
            Me.chkWrap1.TabIndex = 8
            Me.chkWrap1.Text = "Wrap"
            Me.chkWrap1.UseVisualStyleBackColor = True
            '
            'cboEncoding1
            '
            Me.cboEncoding1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboEncoding1.FormattingEnabled = True
            Me.cboEncoding1.Items.AddRange(New Object() {"ASCII", "UTF-8", "Unicode", "Hex", "Byte", "Binary"})
            Me.cboEncoding1.Location = New System.Drawing.Point(4, 4)
            Me.cboEncoding1.Name = "cboEncoding1"
            Me.cboEncoding1.Size = New System.Drawing.Size(68, 21)
            Me.cboEncoding1.TabIndex = 8
            '
            'chkPurgeNulls1
            '
            Me.chkPurgeNulls1.AutoSize = True
            Me.chkPurgeNulls1.Location = New System.Drawing.Point(76, 8)
            Me.chkPurgeNulls1.Name = "chkPurgeNulls1"
            Me.chkPurgeNulls1.Size = New System.Drawing.Size(80, 17)
            Me.chkPurgeNulls1.TabIndex = 7
            Me.chkPurgeNulls1.Text = "Purge Nulls"
            Me.chkPurgeNulls1.UseVisualStyleBackColor = True
            '
            'txtText2
            '
            Me.txtText2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtText2.Location = New System.Drawing.Point(0, 28)
            Me.txtText2.Multiline = True
            Me.txtText2.Name = "txtText2"
            Me.txtText2.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtText2.Size = New System.Drawing.Size(209, 220)
            Me.txtText2.TabIndex = 3
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.lblLen2)
            Me.Panel5.Controls.Add(Me.lblPos2)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 248)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(209, 24)
            Me.Panel5.TabIndex = 11
            '
            'lblPos2
            '
            Me.lblPos2.AutoSize = True
            Me.lblPos2.Location = New System.Drawing.Point(4, 5)
            Me.lblPos2.Name = "lblPos2"
            Me.lblPos2.Size = New System.Drawing.Size(37, 13)
            Me.lblPos2.TabIndex = 7
            Me.lblPos2.Text = "Pos: 0"
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.chkWrap2)
            Me.Panel3.Controls.Add(Me.cboEncoding2)
            Me.Panel3.Controls.Add(Me.chkPurgeNulls2)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(209, 28)
            Me.Panel3.TabIndex = 10
            '
            'chkWrap2
            '
            Me.chkWrap2.AutoSize = True
            Me.chkWrap2.Checked = True
            Me.chkWrap2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkWrap2.Location = New System.Drawing.Point(156, 8)
            Me.chkWrap2.Name = "chkWrap2"
            Me.chkWrap2.Size = New System.Drawing.Size(52, 17)
            Me.chkWrap2.TabIndex = 9
            Me.chkWrap2.Text = "Wrap"
            Me.chkWrap2.UseVisualStyleBackColor = True
            '
            'cboEncoding2
            '
            Me.cboEncoding2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboEncoding2.FormattingEnabled = True
            Me.cboEncoding2.Items.AddRange(New Object() {"ASCII", "UTF-8", "Unicode", "Hex", "Byte", "Binary"})
            Me.cboEncoding2.Location = New System.Drawing.Point(4, 4)
            Me.cboEncoding2.Name = "cboEncoding2"
            Me.cboEncoding2.Size = New System.Drawing.Size(68, 21)
            Me.cboEncoding2.TabIndex = 8
            '
            'chkPurgeNulls2
            '
            Me.chkPurgeNulls2.AutoSize = True
            Me.chkPurgeNulls2.Location = New System.Drawing.Point(76, 8)
            Me.chkPurgeNulls2.Name = "chkPurgeNulls2"
            Me.chkPurgeNulls2.Size = New System.Drawing.Size(80, 17)
            Me.chkPurgeNulls2.TabIndex = 7
            Me.chkPurgeNulls2.Text = "Purge Nulls"
            Me.chkPurgeNulls2.UseVisualStyleBackColor = True
            '
            'lblOriginalLength
            '
            Me.lblOriginalLength.AutoSize = True
            Me.lblOriginalLength.Location = New System.Drawing.Point(4, 11)
            Me.lblOriginalLength.Name = "lblOriginalLength"
            Me.lblOriginalLength.Size = New System.Drawing.Size(86, 13)
            Me.lblOriginalLength.TabIndex = 6
            Me.lblOriginalLength.Text = "Original length: 0"
            '
            'lblLen2
            '
            Me.lblLen2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblLen2.Location = New System.Drawing.Point(88, 5)
            Me.lblLen2.Name = "lblLen2"
            Me.lblLen2.Size = New System.Drawing.Size(115, 13)
            Me.lblLen2.TabIndex = 8
            Me.lblLen2.Text = "Len: 999999"
            Me.lblLen2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'StringVisualizer
            '
            Me.ClientSize = New System.Drawing.Size(427, 304)
            Me.Controls.Add(Me.SplitContainer1)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "StringVisualizer"
            Me.Text = "Advanced String Visualizer"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel1.PerformLayout()
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            Me.SplitContainer1.Panel2.PerformLayout()
            Me.SplitContainer1.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnClose As System.Windows.Forms.Button

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
        Friend WithEvents lblLen1 As System.Windows.Forms.Label

        Private Sub txtText_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            Try
                lblPos1.Text = "Pos: " & txtText1.SelectionStart
                txtText2.Select(txtText1.SelectionStart * 3, 2)
            Catch ex As Exception

            End Try
        End Sub

        Friend WithEvents lblPos1 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Friend WithEvents txtText1 As System.Windows.Forms.TextBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents chkPurgeNulls1 As System.Windows.Forms.CheckBox
        Friend WithEvents txtText2 As System.Windows.Forms.TextBox
        Friend WithEvents cboEncoding1 As System.Windows.Forms.ComboBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents cboEncoding2 As System.Windows.Forms.ComboBox
        Friend WithEvents chkPurgeNulls2 As System.Windows.Forms.CheckBox

        Private Sub cboEncoding1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEncoding1.SelectedIndexChanged
            ShowText1()
        End Sub

        Private Sub cboEncoding2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEncoding2.SelectedIndexChanged
            ShowText2()
        End Sub

        Private Sub chkPurgeNulls1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPurgeNulls1.CheckedChanged
            ShowText1()
        End Sub

        Private Sub chkPurgeNulls2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPurgeNulls2.CheckedChanged
            ShowText2()
        End Sub

        Private Sub chkWrap1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWrap1.CheckedChanged
            If chkWrap1.Checked = True Then
                txtText1.WordWrap = True
            Else
                txtText1.WordWrap = False
            End If
        End Sub

        Private Sub chkWrap2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWrap2.CheckedChanged
            If chkWrap2.Checked = True Then
                txtText2.WordWrap = True
            Else
                txtText2.WordWrap = False
            End If
        End Sub

        Sub ShowText1()
            Dim s As String = ""
            Select Case cboEncoding1.Text
                Case "ASCII"
                    s = _content
                Case "UTF-8"
                    Dim b() As Byte = System.Text.Encoding.ASCII.GetBytes(_content)
                    s = System.Text.Encoding.UTF8.GetString(b)
                Case "Unicode"
                    Dim b() As Byte = System.Text.Encoding.ASCII.GetBytes(_content)
                    s = System.Text.Encoding.Unicode.GetString(b)
                Case "Hex"
                    s = ToHex(_content)
                Case "Byte"
                    Dim b() As Byte = System.Text.Encoding.ASCII.GetBytes(_content)
                    s = b.ToString
            End Select
            If chkPurgeNulls1.Checked = True Then
                s = PurgeNulls(s)
            End If
            txtText1.Text = s
            lblLen1.Text = "Length: " & txtText1.Text.Length
        End Sub

        Sub ShowText2()
            Dim s As String = ""
            Select Case cboEncoding2.Text
                Case "ASCII"
                    s = _content
                Case "UTF-8"
                    Dim b() As Byte = System.Text.Encoding.ASCII.GetBytes(_content)
                    s = System.Text.Encoding.UTF8.GetString(b)
                Case "Unicode"
                    Dim b() As Byte = System.Text.Encoding.ASCII.GetBytes(_content)
                    s = System.Text.Encoding.Unicode.GetString(b)
                Case "Hex"
                    s = ToHex(_content)
                Case "Byte"
                    Dim b() As Byte = System.Text.Encoding.ASCII.GetBytes(_content)
                    s = b.ToString
            End Select
            If chkPurgeNulls2.Checked = True Then
                s = PurgeNulls(s)
            End If
            txtText2.Text = s
            lblLen2.Text = "Length: " & txtText2.Text.Length
        End Sub

        Function PurgeNulls(ByVal content As String) As String
            Return content.Replace(vbNullChar, "_")
        End Function

        Function ToHex(ByVal content As String) As String
            Dim hexBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(content)
            Dim hexString As New StringBuilder(content.Length * 3)
            For i As Integer = 0 To content.Length - 1
                hexString.Append(hexBytes(i).ToString("X2") + " ")
            Next
            Return hexString.ToString()
        End Function
        Friend WithEvents chkWrap1 As System.Windows.Forms.CheckBox
        Friend WithEvents chkWrap2 As System.Windows.Forms.CheckBox
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents lblPos2 As System.Windows.Forms.Label

        Private Sub txtText1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtText1.MouseClick
            lblPos1.Text = "Pos: " & txtText1.SelectionStart
        End Sub

        Private Sub txtText1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtText1.TextChanged
            lblPos1.Text = "Pos: " & txtText1.SelectionStart
        End Sub

        Private Sub txtText2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtText2.MouseClick
            lblPos2.Text = "Pos: " & txtText2.SelectionStart
        End Sub

        Private Sub txtText2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtText2.TextChanged
            lblPos2.Text = "Pos: " & txtText2.SelectionStart
        End Sub
        Friend WithEvents lblOriginalLength As System.Windows.Forms.Label
        Friend WithEvents lblLen2 As System.Windows.Forms.Label
    End Class
End Namespace