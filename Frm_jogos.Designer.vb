<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_pedidos
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_pedidos))
        lbl_ALIMENTO = New Label()
        img_prod = New PictureBox()
        txt_cod = New TextBox()
        txt_precu = New TextBox()
        btn_pedidos = New Button()
        cmb_nome = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_comanda = New TextBox()
        Label4 = New Label()
        txt_precTot = New TextBox()
        Label5 = New Label()
        txt_qtde = New TextBox()
        CType(img_prod, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_ALIMENTO
        ' 
        lbl_ALIMENTO.AutoSize = True
        lbl_ALIMENTO.BackColor = Color.Transparent
        lbl_ALIMENTO.Font = New Font("Modern No. 20", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_ALIMENTO.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lbl_ALIMENTO.Location = New Point(69, 45)
        lbl_ALIMENTO.Name = "lbl_ALIMENTO"
        lbl_ALIMENTO.Size = New Size(391, 34)
        lbl_ALIMENTO.TabIndex = 3
        lbl_ALIMENTO.Text = "SELECIONAR PRODUTO"
        ' 
        ' img_prod
        ' 
        img_prod.BackColor = Color.Transparent
        img_prod.BorderStyle = BorderStyle.FixedSingle
        img_prod.Enabled = False
        img_prod.Image = CType(resources.GetObject("img_prod.Image"), Image)
        img_prod.InitialImage = Nothing
        img_prod.Location = New Point(553, 45)
        img_prod.Name = "img_prod"
        img_prod.Size = New Size(152, 142)
        img_prod.SizeMode = PictureBoxSizeMode.StretchImage
        img_prod.TabIndex = 4
        img_prod.TabStop = False
        ' 
        ' txt_cod
        ' 
        txt_cod.Enabled = False
        txt_cod.Location = New Point(553, 227)
        txt_cod.Name = "txt_cod"
        txt_cod.Size = New Size(152, 23)
        txt_cod.TabIndex = 5
        ' 
        ' txt_precu
        ' 
        txt_precu.Enabled = False
        txt_precu.Location = New Point(553, 290)
        txt_precu.Name = "txt_precu"
        txt_precu.Size = New Size(152, 23)
        txt_precu.TabIndex = 6
        ' 
        ' btn_pedidos
        ' 
        btn_pedidos.BackColor = Color.LemonChiffon
        btn_pedidos.FlatStyle = FlatStyle.Popup
        btn_pedidos.Font = New Font("Viner Hand ITC", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btn_pedidos.Location = New Point(502, 319)
        btn_pedidos.Name = "btn_pedidos"
        btn_pedidos.Size = New Size(243, 66)
        btn_pedidos.TabIndex = 7
        btn_pedidos.Text = "CONFIRMAR PEDIDO"
        btn_pedidos.UseVisualStyleBackColor = False
        ' 
        ' cmb_nome
        ' 
        cmb_nome.Font = New Font("Modern No. 20", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_nome.FormattingEnabled = True
        cmb_nome.Location = New Point(48, 95)
        cmb_nome.Name = "cmb_nome"
        cmb_nome.Size = New Size(431, 32)
        cmb_nome.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(593, 203)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 21)
        Label1.TabIndex = 9
        Label1.Text = "Código"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(553, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 21)
        Label2.TabIndex = 10
        Label2.Text = "Preço Unitário"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(217, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 12
        Label3.Text = "Comanda"
        ' 
        ' txt_comanda
        ' 
        txt_comanda.Location = New Point(185, 227)
        txt_comanda.Name = "txt_comanda"
        txt_comanda.Size = New Size(152, 23)
        txt_comanda.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(207, 338)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 21)
        Label4.TabIndex = 14
        Label4.Text = "Preço Total"
        ' 
        ' txt_precTot
        ' 
        txt_precTot.Enabled = False
        txt_precTot.Location = New Point(185, 362)
        txt_precTot.Name = "txt_precTot"
        txt_precTot.Size = New Size(152, 23)
        txt_precTot.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(207, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 21)
        Label5.TabIndex = 16
        Label5.Text = "Quantidade"
        ' 
        ' txt_qtde
        ' 
        txt_qtde.Location = New Point(185, 299)
        txt_qtde.Name = "txt_qtde"
        txt_qtde.Size = New Size(152, 23)
        txt_qtde.TabIndex = 15
        ' 
        ' Frm_pedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(txt_qtde)
        Controls.Add(Label4)
        Controls.Add(txt_precTot)
        Controls.Add(Label3)
        Controls.Add(txt_comanda)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmb_nome)
        Controls.Add(btn_pedidos)
        Controls.Add(txt_precu)
        Controls.Add(txt_cod)
        Controls.Add(img_prod)
        Controls.Add(lbl_ALIMENTO)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Frm_pedidos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REALIZAR PEDIDO"
        CType(img_prod, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbl_ALIMENTO As Label
    Friend WithEvents img_prod As PictureBox
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents txt_precu As TextBox
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents cmb_nome As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_comanda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_precTot As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_qtde As TextBox
End Class
