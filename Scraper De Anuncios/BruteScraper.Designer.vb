<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BruteScraper
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
        Me.BtnGOO = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnCOPIAR = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TimerProcurar = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCopiarTodos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnGOO
        '
        Me.BtnGOO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGOO.Location = New System.Drawing.Point(16, 15)
        Me.BtnGOO.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BtnGOO.Name = "BtnGOO"
        Me.BtnGOO.Size = New System.Drawing.Size(163, 50)
        Me.BtnGOO.TabIndex = 0
        Me.BtnGOO.Text = "GOO!!"
        Me.BtnGOO.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 28
        Me.ListBox1.Location = New System.Drawing.Point(16, 85)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(635, 310)
        Me.ListBox1.TabIndex = 1
        '
        'BtnCOPIAR
        '
        Me.BtnCOPIAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCOPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCOPIAR.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCOPIAR.Location = New System.Drawing.Point(316, 14)
        Me.BtnCOPIAR.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BtnCOPIAR.Name = "BtnCOPIAR"
        Me.BtnCOPIAR.Size = New System.Drawing.Size(181, 50)
        Me.BtnCOPIAR.TabIndex = 2
        Me.BtnCOPIAR.Text = "Copiar Selecionado!!"
        Me.BtnCOPIAR.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(189, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(191, 56)
        Me.WebBrowser1.TabIndex = 3
        Me.WebBrowser1.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "10000000"
        '
        'BtnCopiarTodos
        '
        Me.BtnCopiarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopiarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiarTodos.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiarTodos.Location = New System.Drawing.Point(511, 14)
        Me.BtnCopiarTodos.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BtnCopiarTodos.Name = "BtnCopiarTodos"
        Me.BtnCopiarTodos.Size = New System.Drawing.Size(136, 50)
        Me.BtnCopiarTodos.TabIndex = 2
        Me.BtnCopiarTodos.Text = "Copiar Todos"
        Me.BtnCopiarTodos.UseVisualStyleBackColor = True
        Me.BtnCopiarTodos.Visible = False
        '
        'BruteScraper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 410)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnGOO)
        Me.Controls.Add(Me.BtnCopiarTodos)
        Me.Controls.Add(Me.BtnCOPIAR)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "BruteScraper"
        Me.Text = "Brute Scraper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGOO As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnCOPIAR As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TimerProcurar As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCopiarTodos As Button
End Class
