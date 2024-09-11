<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label12 = New Label()
        cmb_cargo = New ComboBox()
        Label11 = New Label()
        txt_email = New TextBox()
        txt_fone = New MaskedTextBox()
        Label10 = New Label()
        Label9 = New Label()
        txt_uf = New TextBox()
        Label8 = New Label()
        txt_cidade = New TextBox()
        Label7 = New Label()
        txt_bairro = New TextBox()
        Label6 = New Label()
        txt_comp = New TextBox()
        txt_endereco = New TextBox()
        Label5 = New Label()
        txt_cep = New MaskedTextBox()
        Label4 = New Label()
        txt_nome = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        cmb_data = New DateTimePicker()
        txt_cpf = New MaskedTextBox()
        Label1 = New Label()
        img_foto = New PictureBox()
        TabPage2 = New TabPage()
        dgv_dados = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        ToolStrip1 = New ToolStrip()
        btn_gravar = New ToolStripButton()
        btn_excluir = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStripLabel1 = New ToolStripLabel()
        txt_pesquisar = New ToolStripTextBox()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripLabel2 = New ToolStripLabel()
        cmb_tipo = New ToolStripComboBox()
        OpenFileDialog1 = New OpenFileDialog()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(img_foto, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgv_dados, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(37, 49)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(680, 398)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label12)
        TabPage1.Controls.Add(cmb_cargo)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(txt_email)
        TabPage1.Controls.Add(txt_fone)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(txt_uf)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(txt_cidade)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(txt_bairro)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(txt_comp)
        TabPage1.Controls.Add(txt_endereco)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(txt_cep)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(txt_nome)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(cmb_data)
        TabPage1.Controls.Add(txt_cpf)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(img_foto)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(672, 370)
        TabPage1.TabIndex = 0
        TabPage1.Text = "DADOS PESSOAIS"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(270, 283)
        Label12.Name = "Label12"
        Label12.Size = New Size(50, 13)
        Label12.TabIndex = 24
        Label12.Text = "CARGO"
        ' 
        ' cmb_cargo
        ' 
        cmb_cargo.FormattingEnabled = True
        cmb_cargo.Items.AddRange(New Object() {"Gerente", "Caixa", "Garçom"})
        cmb_cargo.Location = New Point(268, 299)
        cmb_cargo.Name = "cmb_cargo"
        cmb_cargo.Size = New Size(222, 23)
        cmb_cargo.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(27, 283)
        Label11.Name = "Label11"
        Label11.Size = New Size(48, 13)
        Label11.TabIndex = 22
        Label11.Text = "E-MAIL"
        ' 
        ' txt_email
        ' 
        txt_email.BorderStyle = BorderStyle.FixedSingle
        txt_email.Location = New Point(30, 301)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(233, 21)
        txt_email.TabIndex = 21
        ' 
        ' txt_fone
        ' 
        txt_fone.BorderStyle = BorderStyle.FixedSingle
        txt_fone.Location = New Point(538, 246)
        txt_fone.Mask = "(99) 99999-9999"
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(108, 21)
        txt_fone.TabIndex = 20
        txt_fone.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(536, 228)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 13)
        Label10.TabIndex = 19
        Label10.Text = "FONE CONTATO"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(497, 228)
        Label9.Name = "Label9"
        Label9.Size = New Size(23, 13)
        Label9.TabIndex = 18
        Label9.Text = "UF"
        ' 
        ' txt_uf
        ' 
        txt_uf.BorderStyle = BorderStyle.FixedSingle
        txt_uf.Location = New Point(494, 246)
        txt_uf.Name = "txt_uf"
        txt_uf.Size = New Size(39, 21)
        txt_uf.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(265, 228)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 13)
        Label8.TabIndex = 16
        Label8.Text = "CIDADE"
        ' 
        ' txt_cidade
        ' 
        txt_cidade.BorderStyle = BorderStyle.FixedSingle
        txt_cidade.Location = New Point(268, 246)
        txt_cidade.Name = "txt_cidade"
        txt_cidade.Size = New Size(222, 21)
        txt_cidade.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(26, 228)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 13)
        Label7.TabIndex = 14
        Label7.Text = "BAIRRO"
        ' 
        ' txt_bairro
        ' 
        txt_bairro.BorderStyle = BorderStyle.FixedSingle
        txt_bairro.Location = New Point(29, 246)
        txt_bairro.Name = "txt_bairro"
        txt_bairro.Size = New Size(234, 21)
        txt_bairro.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(523, 166)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 13)
        Label6.TabIndex = 12
        Label6.Text = "NUM / COMP."
        ' 
        ' txt_comp
        ' 
        txt_comp.BorderStyle = BorderStyle.FixedSingle
        txt_comp.Location = New Point(526, 184)
        txt_comp.Name = "txt_comp"
        txt_comp.Size = New Size(120, 21)
        txt_comp.TabIndex = 11
        ' 
        ' txt_endereco
        ' 
        txt_endereco.BorderStyle = BorderStyle.FixedSingle
        txt_endereco.Location = New Point(112, 185)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(409, 21)
        txt_endereco.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(109, 167)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 13)
        Label5.TabIndex = 9
        Label5.Text = "ENDEREÇO"
        ' 
        ' txt_cep
        ' 
        txt_cep.BorderStyle = BorderStyle.FixedSingle
        txt_cep.Location = New Point(30, 185)
        txt_cep.Mask = "99999-999"
        txt_cep.Name = "txt_cep"
        txt_cep.Size = New Size(77, 21)
        txt_cep.TabIndex = 8
        txt_cep.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(27, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 13)
        Label4.TabIndex = 7
        Label4.Text = "CEP"
        ' 
        ' txt_nome
        ' 
        txt_nome.BorderStyle = BorderStyle.FixedSingle
        txt_nome.Location = New Point(30, 122)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(450, 21)
        txt_nome.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(27, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 13)
        Label3.TabIndex = 5
        Label3.Text = "NOME DO CLIENTE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(302, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 13)
        Label2.TabIndex = 4
        Label2.Text = "DATA NASCIMENTO"
        ' 
        ' cmb_data
        ' 
        cmb_data.Format = DateTimePickerFormat.Short
        cmb_data.Location = New Point(304, 65)
        cmb_data.Name = "cmb_data"
        cmb_data.Size = New Size(176, 21)
        cmb_data.TabIndex = 3
        cmb_data.Value = New Date(2023, 11, 21, 18, 33, 9, 0)
        ' 
        ' txt_cpf
        ' 
        txt_cpf.BorderStyle = BorderStyle.FixedSingle
        txt_cpf.Location = New Point(26, 64)
        txt_cpf.Mask = "999,999,999-99"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(114, 21)
        txt_cpf.TabIndex = 2
        txt_cpf.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 13)
        Label1.TabIndex = 1
        Label1.Text = "CPF DO CLIENTE"
        ' 
        ' img_foto
        ' 
        img_foto.BorderStyle = BorderStyle.FixedSingle
        img_foto.Cursor = Cursors.Hand
        img_foto.Image = CType(resources.GetObject("img_foto.Image"), Image)
        img_foto.Location = New Point(526, 15)
        img_foto.Name = "img_foto"
        img_foto.Size = New Size(120, 138)
        img_foto.SizeMode = PictureBoxSizeMode.StretchImage
        img_foto.TabIndex = 0
        img_foto.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgv_dados)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(672, 370)
        TabPage2.TabIndex = 1
        TabPage2.Text = "LISTAGEM GERAL"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgv_dados
        ' 
        dgv_dados.AllowUserToAddRows = False
        dgv_dados.AllowUserToDeleteRows = False
        dgv_dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_dados.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgv_dados.Location = New Point(17, 14)
        dgv_dados.Name = "dgv_dados"
        dgv_dados.ReadOnly = True
        dgv_dados.RowHeadersWidth = 51
        dgv_dados.RowTemplate.Height = 24
        dgv_dados.Size = New Size(644, 341)
        dgv_dados.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "N°"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "CPF DO CLIENTE"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "NOME DO CLIENTE"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "EDITAR"
        Column4.Image = CType(resources.GetObject("Column4.Image"), Image)
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "EXCLUIR"
        Column5.Image = CType(resources.GetObject("Column5.Image"), Image)
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.ActiveCaption
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {btn_gravar, btn_excluir, ToolStripSeparator2, ToolStripLabel1, txt_pesquisar, ToolStripSeparator1, ToolStripLabel2, cmb_tipo})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(763, 27)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' btn_gravar
        ' 
        btn_gravar.DisplayStyle = ToolStripItemDisplayStyle.Image
        btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), Image)
        btn_gravar.ImageTransparentColor = Color.Magenta
        btn_gravar.Name = "btn_gravar"
        btn_gravar.Size = New Size(24, 24)
        btn_gravar.Text = "ToolStripButton1"
        btn_gravar.ToolTipText = "Salvar"
        ' 
        ' btn_excluir
        ' 
        btn_excluir.DisplayStyle = ToolStripItemDisplayStyle.Image
        btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), Image)
        btn_excluir.ImageTransparentColor = Color.Magenta
        btn_excluir.Name = "btn_excluir"
        btn_excluir.Size = New Size(24, 24)
        btn_excluir.Text = "ToolStripButton1"
        btn_excluir.ToolTipText = "Excluir"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 27)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(194, 24)
        ToolStripLabel1.Text = "Digite um parâmetro de pesquisa:"
        ' 
        ' txt_pesquisar
        ' 
        txt_pesquisar.BackColor = SystemColors.Info
        txt_pesquisar.Name = "txt_pesquisar"
        txt_pesquisar.Size = New Size(88, 27)
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 27)
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(64, 24)
        ToolStripLabel2.Text = "Selecione:"
        ' 
        ' cmb_tipo
        ' 
        cmb_tipo.BackColor = SystemColors.Info
        cmb_tipo.Name = "cmb_tipo"
        cmb_tipo.Size = New Size(106, 27)
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frm_cadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(763, 513)
        Controls.Add(ToolStrip1)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frm_cadastro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CADASTRO DE USUÁRIOS"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(img_foto, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(dgv_dados, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_comp As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_data As DateTimePicker
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisar As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmb_cargo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_excluir As ToolStripButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
