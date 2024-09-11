<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_gerente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_gerente))
        PictureBox1 = New PictureBox()
        btn_sair = New Button()
        btn_estoques = New Button()
        btn_relat = New Button()
        btn_gerenciar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(123, 121)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btn_sair
        ' 
        btn_sair.AutoEllipsis = True
        btn_sair.BackColor = Color.DarkRed
        btn_sair.Cursor = Cursors.Hand
        btn_sair.FlatStyle = FlatStyle.Popup
        btn_sair.Font = New Font("Modern No. 20", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        btn_sair.ForeColor = Color.Yellow
        btn_sair.Location = New Point(310, 336)
        btn_sair.Name = "btn_sair"
        btn_sair.Size = New Size(168, 59)
        btn_sair.TabIndex = 7
        btn_sair.Text = "SAIR"
        btn_sair.UseVisualStyleBackColor = False
        ' 
        ' btn_estoques
        ' 
        btn_estoques.AutoEllipsis = True
        btn_estoques.BackColor = Color.DarkRed
        btn_estoques.Cursor = Cursors.Hand
        btn_estoques.FlatStyle = FlatStyle.Popup
        btn_estoques.Font = New Font("Modern No. 20", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        btn_estoques.ForeColor = Color.Yellow
        btn_estoques.Location = New Point(310, 248)
        btn_estoques.Name = "btn_estoques"
        btn_estoques.Size = New Size(168, 59)
        btn_estoques.TabIndex = 8
        btn_estoques.Text = "GERENCIAR CARDÁPIO"
        btn_estoques.UseVisualStyleBackColor = False
        ' 
        ' btn_relat
        ' 
        btn_relat.AutoEllipsis = True
        btn_relat.BackColor = Color.DarkRed
        btn_relat.Cursor = Cursors.Hand
        btn_relat.FlatStyle = FlatStyle.Popup
        btn_relat.Font = New Font("Modern No. 20", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        btn_relat.ForeColor = Color.Yellow
        btn_relat.Location = New Point(310, 162)
        btn_relat.Name = "btn_relat"
        btn_relat.Size = New Size(168, 59)
        btn_relat.TabIndex = 9
        btn_relat.Text = "RELATÓRIOS"
        btn_relat.UseVisualStyleBackColor = False
        ' 
        ' btn_gerenciar
        ' 
        btn_gerenciar.AutoEllipsis = True
        btn_gerenciar.BackColor = Color.DarkRed
        btn_gerenciar.Cursor = Cursors.Hand
        btn_gerenciar.FlatStyle = FlatStyle.Popup
        btn_gerenciar.Font = New Font("Modern No. 20", 14.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        btn_gerenciar.ForeColor = Color.Yellow
        btn_gerenciar.Location = New Point(310, 74)
        btn_gerenciar.Name = "btn_gerenciar"
        btn_gerenciar.Size = New Size(168, 59)
        btn_gerenciar.TabIndex = 10
        btn_gerenciar.Text = "GERENCIAR FUNCIONÁRIOS"
        btn_gerenciar.UseVisualStyleBackColor = False
        ' 
        ' Frm_gerente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gabriel_neris_taverna_detalhe1_final
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btn_gerenciar)
        Controls.Add(btn_relat)
        Controls.Add(btn_estoques)
        Controls.Add(btn_sair)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Frm_gerente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ACESSO DO GERENTE"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_estoques As Button
    Friend WithEvents btn_relat As Button
    Friend WithEvents btn_gerenciar As Button
End Class
