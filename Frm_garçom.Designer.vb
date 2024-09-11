<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_garçom
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_garçom))
        btn_alimento = New PictureBox()
        btn_jogo = New PictureBox()
        lbl_jogos = New Label()
        lbl_alimentos = New Label()
        Label2 = New Label()
        btn_pedidos = New Button()
        CType(btn_alimento, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_jogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_alimento
        ' 
        btn_alimento.BackColor = Color.Transparent
        btn_alimento.Cursor = Cursors.Hand
        btn_alimento.Image = CType(resources.GetObject("btn_alimento.Image"), Image)
        btn_alimento.Location = New Point(437, 122)
        btn_alimento.Name = "btn_alimento"
        btn_alimento.Size = New Size(120, 120)
        btn_alimento.SizeMode = PictureBoxSizeMode.StretchImage
        btn_alimento.TabIndex = 0
        btn_alimento.TabStop = False
        ' 
        ' btn_jogo
        ' 
        btn_jogo.BackColor = Color.Transparent
        btn_jogo.Cursor = Cursors.Hand
        btn_jogo.Image = CType(resources.GetObject("btn_jogo.Image"), Image)
        btn_jogo.Location = New Point(132, 122)
        btn_jogo.Name = "btn_jogo"
        btn_jogo.Size = New Size(120, 120)
        btn_jogo.SizeMode = PictureBoxSizeMode.StretchImage
        btn_jogo.TabIndex = 1
        btn_jogo.TabStop = False
        ' 
        ' lbl_jogos
        ' 
        lbl_jogos.AutoSize = True
        lbl_jogos.BackColor = Color.Transparent
        lbl_jogos.Font = New Font("Viner Hand ITC", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lbl_jogos.Location = New Point(145, 249)
        lbl_jogos.Name = "lbl_jogos"
        lbl_jogos.Size = New Size(104, 47)
        lbl_jogos.TabIndex = 2
        lbl_jogos.Text = "JOGOS"
        ' 
        ' lbl_alimentos
        ' 
        lbl_alimentos.AutoSize = True
        lbl_alimentos.BackColor = Color.Transparent
        lbl_alimentos.Font = New Font("Viner Hand ITC", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lbl_alimentos.Location = New Point(398, 249)
        lbl_alimentos.Name = "lbl_alimentos"
        lbl_alimentos.Size = New Size(204, 47)
        lbl_alimentos.TabIndex = 3
        lbl_alimentos.Text = "ALIMENTOS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Viner Hand ITC", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(253, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 47)
        Label2.TabIndex = 4
        Label2.Text = "CARDÁPIOS"
        ' 
        ' btn_pedidos
        ' 
        btn_pedidos.BackColor = Color.LemonChiffon
        btn_pedidos.FlatStyle = FlatStyle.Popup
        btn_pedidos.Font = New Font("Viner Hand ITC", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn_pedidos.Location = New Point(283, 299)
        btn_pedidos.Name = "btn_pedidos"
        btn_pedidos.Size = New Size(131, 39)
        btn_pedidos.TabIndex = 0
        btn_pedidos.Text = "VER PEDIDOS"
        btn_pedidos.UseVisualStyleBackColor = False
        ' 
        ' Frm_garçom
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(694, 390)
        Controls.Add(btn_pedidos)
        Controls.Add(Label2)
        Controls.Add(lbl_alimentos)
        Controls.Add(lbl_jogos)
        Controls.Add(btn_jogo)
        Controls.Add(btn_alimento)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Frm_garçom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CARDÁPIOS"
        CType(btn_alimento, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_jogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_alimento As PictureBox
    Friend WithEvents btn_jogo As PictureBox
    Friend WithEvents lbl_jogos As Label
    Friend WithEvents lbl_alimentos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_pedidos As Button
End Class
