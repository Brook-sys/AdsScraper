<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScraperAnuncios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScraperAnuncios))
        Me.lblERRO = New System.Windows.Forms.Label()
        Me.BTNScrap = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ListBoxGIF = New System.Windows.Forms.ListBox()
        Me.LabelGIF = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxMP4 = New System.Windows.Forms.ListBox()
        Me.MediaPlayerMP4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.RadioMP4 = New System.Windows.Forms.RadioButton()
        Me.RadioGIF = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioManual = New System.Windows.Forms.RadioButton()
        Me.RadioAutomatico = New System.Windows.Forms.RadioButton()
        Me.BTNIniciarParar = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PictureBoxGIF = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MediaPlayerMP4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxGIF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblERRO
        '
        Me.lblERRO.AutoSize = True
        Me.lblERRO.BackColor = System.Drawing.Color.Black
        Me.lblERRO.ForeColor = System.Drawing.Color.Red
        Me.lblERRO.Location = New System.Drawing.Point(347, 54)
        Me.lblERRO.Name = "lblERRO"
        Me.lblERRO.Size = New System.Drawing.Size(208, 18)
        Me.lblERRO.TabIndex = 3
        Me.lblERRO.Text = "Opção RedTube Selecionado"
        '
        'BTNScrap
        '
        Me.BTNScrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNScrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNScrap.Location = New System.Drawing.Point(135, 179)
        Me.BTNScrap.Name = "BTNScrap"
        Me.BTNScrap.Size = New System.Drawing.Size(103, 42)
        Me.BTNScrap.TabIndex = 4
        Me.BTNScrap.Text = "Scrap"
        Me.BTNScrap.UseVisualStyleBackColor = True
        Me.BTNScrap.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Location = New System.Drawing.Point(231, 9)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(52, 20)
        Me.WebBrowser1.TabIndex = 7
        Me.WebBrowser1.Visible = False
        '
        'ListBoxGIF
        '
        Me.ListBoxGIF.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ListBoxGIF.ForeColor = System.Drawing.Color.White
        Me.ListBoxGIF.FormattingEnabled = True
        Me.ListBoxGIF.ItemHeight = 18
        Me.ListBoxGIF.Location = New System.Drawing.Point(6, 228)
        Me.ListBoxGIF.Name = "ListBoxGIF"
        Me.ListBoxGIF.Size = New System.Drawing.Size(336, 130)
        Me.ListBoxGIF.TabIndex = 8
        Me.ListBoxGIF.Visible = False
        '
        'LabelGIF
        '
        Me.LabelGIF.AutoSize = True
        Me.LabelGIF.Location = New System.Drawing.Point(3, 207)
        Me.LabelGIF.Name = "LabelGIF"
        Me.LabelGIF.Size = New System.Drawing.Size(88, 18)
        Me.LabelGIF.TabIndex = 9
        Me.LabelGIF.Text = "Lista Gif:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 41)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Scraper"
        '
        'ListBoxMP4
        '
        Me.ListBoxMP4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ListBoxMP4.ForeColor = System.Drawing.Color.White
        Me.ListBoxMP4.FormattingEnabled = True
        Me.ListBoxMP4.ItemHeight = 18
        Me.ListBoxMP4.Location = New System.Drawing.Point(6, 228)
        Me.ListBoxMP4.Name = "ListBoxMP4"
        Me.ListBoxMP4.Size = New System.Drawing.Size(336, 130)
        Me.ListBoxMP4.TabIndex = 14
        '
        'MediaPlayerMP4
        '
        Me.MediaPlayerMP4.Enabled = True
        Me.MediaPlayerMP4.Location = New System.Drawing.Point(347, 0)
        Me.MediaPlayerMP4.Name = "MediaPlayerMP4"
        Me.MediaPlayerMP4.OcxState = CType(resources.GetObject("MediaPlayerMP4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayerMP4.Size = New System.Drawing.Size(454, 387)
        Me.MediaPlayerMP4.TabIndex = 17
        '
        'RadioMP4
        '
        Me.RadioMP4.AutoSize = True
        Me.RadioMP4.Checked = True
        Me.RadioMP4.Location = New System.Drawing.Point(10, 45)
        Me.RadioMP4.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioMP4.Name = "RadioMP4"
        Me.RadioMP4.Size = New System.Drawing.Size(50, 22)
        Me.RadioMP4.TabIndex = 0
        Me.RadioMP4.TabStop = True
        Me.RadioMP4.Text = "MP4"
        Me.RadioMP4.UseVisualStyleBackColor = True
        '
        'RadioGIF
        '
        Me.RadioGIF.AutoSize = True
        Me.RadioGIF.Location = New System.Drawing.Point(10, 26)
        Me.RadioGIF.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioGIF.Name = "RadioGIF"
        Me.RadioGIF.Size = New System.Drawing.Size(50, 22)
        Me.RadioGIF.TabIndex = 1
        Me.RadioGIF.Text = "GIF"
        Me.RadioGIF.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioGIF)
        Me.GroupBox1.Controls.Add(Me.RadioMP4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(261, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(80, 78)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formato"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(7, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 122)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Site"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Link:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(6, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 25)
        Me.TextBox1.TabIndex = 21
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"RedTube", "PornHub", "Konachan", "Pegar Apartir do Scraper", "Customizado"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 26)
        Me.ComboBox1.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioManual)
        Me.GroupBox3.Controls.Add(Me.RadioAutomatico)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(219, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(122, 78)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modo"
        '
        'RadioManual
        '
        Me.RadioManual.AutoSize = True
        Me.RadioManual.Checked = True
        Me.RadioManual.Location = New System.Drawing.Point(10, 26)
        Me.RadioManual.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioManual.Name = "RadioManual"
        Me.RadioManual.Size = New System.Drawing.Size(74, 22)
        Me.RadioManual.TabIndex = 1
        Me.RadioManual.TabStop = True
        Me.RadioManual.Text = "Manual"
        Me.RadioManual.UseVisualStyleBackColor = True
        '
        'RadioAutomatico
        '
        Me.RadioAutomatico.AutoSize = True
        Me.RadioAutomatico.Location = New System.Drawing.Point(10, 45)
        Me.RadioAutomatico.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioAutomatico.Name = "RadioAutomatico"
        Me.RadioAutomatico.Size = New System.Drawing.Size(106, 22)
        Me.RadioAutomatico.TabIndex = 0
        Me.RadioAutomatico.Text = "Automatico"
        Me.RadioAutomatico.UseVisualStyleBackColor = True
        '
        'BTNIniciarParar
        '
        Me.BTNIniciarParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIniciarParar.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIniciarParar.ForeColor = System.Drawing.Color.Lime
        Me.BTNIniciarParar.Location = New System.Drawing.Point(135, 179)
        Me.BTNIniciarParar.Name = "BTNIniciarParar"
        Me.BTNIniciarParar.Size = New System.Drawing.Size(103, 42)
        Me.BTNIniciarParar.TabIndex = 20
        Me.BTNIniciarParar.Text = "Iniciar"
        Me.BTNIniciarParar.UseVisualStyleBackColor = True
        Me.BTNIniciarParar.Visible = False
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Pesquisar a Imagem?"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(179, 360)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(50, 22)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.Text = "Sim"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(231, 361)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(50, 22)
        Me.RadioButton2.TabIndex = 22
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Não"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'PictureBoxGIF
        '
        Me.PictureBoxGIF.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBoxGIF.ImageLocation = ""
        Me.PictureBoxGIF.Location = New System.Drawing.Point(347, 0)
        Me.PictureBoxGIF.Name = "PictureBoxGIF"
        Me.PictureBoxGIF.Size = New System.Drawing.Size(417, 376)
        Me.PictureBoxGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxGIF.TabIndex = 6
        Me.PictureBoxGIF.TabStop = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(289, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 36)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ScraperAnuncios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 383)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNIniciarParar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MediaPlayerMP4)
        Me.Controls.Add(Me.ListBoxMP4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelGIF)
        Me.Controls.Add(Me.ListBoxGIF)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.PictureBoxGIF)
        Me.Controls.Add(Me.BTNScrap)
        Me.Controls.Add(Me.lblERRO)
        Me.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ScraperAnuncios"
        Me.Text = "Scraper De Anuncios"
        CType(Me.MediaPlayerMP4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxGIF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblERRO As Label
    Friend WithEvents BTNScrap As Button
    Friend WithEvents PictureBoxGIF As PictureBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents ListBoxGIF As ListBox
    Friend WithEvents LabelGIF As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxMP4 As ListBox
    Friend WithEvents MediaPlayerMP4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents RadioMP4 As RadioButton
    Friend WithEvents RadioGIF As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioManual As RadioButton
    Friend WithEvents RadioAutomatico As RadioButton
    Friend WithEvents BTNIniciarParar As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button1 As Button
End Class
