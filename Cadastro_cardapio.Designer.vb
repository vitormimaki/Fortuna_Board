<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_cardapio
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cadastro_cardapio))
        TabControl1 = New TabControl()
        TabPage2 = New TabPage()
        txt_un_ali = New TextBox()
        Label10 = New Label()
        btn_cadastro_ali = New Button()
        txt_prec_ali = New TextBox()
        Label4 = New Label()
        txt_nome_ali = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txt_cod_ali = New TextBox()
        img_foto_ali = New PictureBox()
        TabPage3 = New TabPage()
        txt_un_jog = New TextBox()
        Label3 = New Label()
        btn_cadastro_jog = New Button()
        txt_prec_jog = New TextBox()
        Label6 = New Label()
        txt_nome_jog = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        txt_cod_jog = New TextBox()
        img_foto_jog = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(img_foto_ali, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(img_foto_jog, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(60, 29)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeftLayout = True
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(680, 395)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.AntiqueWhite
        TabPage2.Controls.Add(txt_un_ali)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(btn_cadastro_ali)
        TabPage2.Controls.Add(txt_prec_ali)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(txt_nome_ali)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(txt_cod_ali)
        TabPage2.Controls.Add(img_foto_ali)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(672, 367)
        TabPage2.TabIndex = 1
        TabPage2.Text = "ALIMENTOS"
        ' 
        ' txt_un_ali
        ' 
        txt_un_ali.BorderStyle = BorderStyle.FixedSingle
        txt_un_ali.Location = New Point(26, 235)
        txt_un_ali.Name = "txt_un_ali"
        txt_un_ali.Size = New Size(234, 21)
        txt_un_ali.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(26, 200)
        Label10.Name = "Label10"
        Label10.Size = New Size(71, 13)
        Label10.TabIndex = 18
        Label10.Text = "UNIDADES"
        ' 
        ' btn_cadastro_ali
        ' 
        btn_cadastro_ali.BackColor = Color.NavajoWhite
        btn_cadastro_ali.FlatStyle = FlatStyle.Flat
        btn_cadastro_ali.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cadastro_ali.ForeColor = SystemColors.ControlText
        btn_cadastro_ali.Location = New Point(413, 274)
        btn_cadastro_ali.Name = "btn_cadastro_ali"
        btn_cadastro_ali.Size = New Size(237, 53)
        btn_cadastro_ali.TabIndex = 17
        btn_cadastro_ali.Text = "CADASTRAR"
        btn_cadastro_ali.UseVisualStyleBackColor = False
        ' 
        ' txt_prec_ali
        ' 
        txt_prec_ali.BorderStyle = BorderStyle.FixedSingle
        txt_prec_ali.Location = New Point(26, 306)
        txt_prec_ali.Name = "txt_prec_ali"
        txt_prec_ali.Size = New Size(234, 21)
        txt_prec_ali.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(26, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 13)
        Label4.TabIndex = 15
        Label4.Text = "PREÇO UNITÁRIO"
        ' 
        ' txt_nome_ali
        ' 
        txt_nome_ali.BorderStyle = BorderStyle.FixedSingle
        txt_nome_ali.Location = New Point(26, 156)
        txt_nome_ali.Name = "txt_nome_ali"
        txt_nome_ali.Size = New Size(409, 21)
        txt_nome_ali.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(26, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 13)
        Label2.TabIndex = 10
        Label2.Text = "NOME DO PRODUTO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(26, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 13)
        Label1.TabIndex = 8
        Label1.Text = "CÓDIGO DO PRODUTO"
        ' 
        ' txt_cod_ali
        ' 
        txt_cod_ali.BorderStyle = BorderStyle.FixedSingle
        txt_cod_ali.Location = New Point(26, 78)
        txt_cod_ali.Name = "txt_cod_ali"
        txt_cod_ali.Size = New Size(450, 21)
        txt_cod_ali.TabIndex = 7
        ' 
        ' img_foto_ali
        ' 
        img_foto_ali.BorderStyle = BorderStyle.FixedSingle
        img_foto_ali.Cursor = Cursors.Hand
        img_foto_ali.Image = CType(resources.GetObject("img_foto_ali.Image"), Image)
        img_foto_ali.Location = New Point(491, 78)
        img_foto_ali.Name = "img_foto_ali"
        img_foto_ali.Size = New Size(159, 166)
        img_foto_ali.SizeMode = PictureBoxSizeMode.StretchImage
        img_foto_ali.TabIndex = 1
        img_foto_ali.TabStop = False
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.AntiqueWhite
        TabPage3.Controls.Add(txt_un_jog)
        TabPage3.Controls.Add(Label3)
        TabPage3.Controls.Add(btn_cadastro_jog)
        TabPage3.Controls.Add(txt_prec_jog)
        TabPage3.Controls.Add(Label6)
        TabPage3.Controls.Add(txt_nome_jog)
        TabPage3.Controls.Add(Label8)
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(txt_cod_jog)
        TabPage3.Controls.Add(img_foto_jog)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(672, 367)
        TabPage3.TabIndex = 2
        TabPage3.Text = "JOGOS"
        ' 
        ' txt_un_jog
        ' 
        txt_un_jog.BorderStyle = BorderStyle.FixedSingle
        txt_un_jog.Location = New Point(26, 223)
        txt_un_jog.Name = "txt_un_jog"
        txt_un_jog.Size = New Size(234, 21)
        txt_un_jog.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(26, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 13)
        Label3.TabIndex = 19
        Label3.Text = "UNIDADES"
        ' 
        ' btn_cadastro_jog
        ' 
        btn_cadastro_jog.BackColor = Color.NavajoWhite
        btn_cadastro_jog.FlatStyle = FlatStyle.Flat
        btn_cadastro_jog.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cadastro_jog.ForeColor = SystemColors.ControlText
        btn_cadastro_jog.Location = New Point(413, 272)
        btn_cadastro_jog.Name = "btn_cadastro_jog"
        btn_cadastro_jog.Size = New Size(237, 53)
        btn_cadastro_jog.TabIndex = 18
        btn_cadastro_jog.Text = "CADASTRAR"
        btn_cadastro_jog.UseVisualStyleBackColor = False
        ' 
        ' txt_prec_jog
        ' 
        txt_prec_jog.BorderStyle = BorderStyle.FixedSingle
        txt_prec_jog.Location = New Point(26, 291)
        txt_prec_jog.Name = "txt_prec_jog"
        txt_prec_jog.Size = New Size(234, 21)
        txt_prec_jog.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(26, 261)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 13)
        Label6.TabIndex = 15
        Label6.Text = "PREÇO UNITÁRIO"
        ' 
        ' txt_nome_jog
        ' 
        txt_nome_jog.BorderStyle = BorderStyle.FixedSingle
        txt_nome_jog.Location = New Point(26, 152)
        txt_nome_jog.Name = "txt_nome_jog"
        txt_nome_jog.Size = New Size(409, 21)
        txt_nome_jog.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(26, 120)
        Label8.Name = "Label8"
        Label8.Size = New Size(130, 13)
        Label8.TabIndex = 10
        Label8.Text = "NOME DO PRODUTO"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(26, 49)
        Label9.Name = "Label9"
        Label9.Size = New Size(142, 13)
        Label9.TabIndex = 8
        Label9.Text = "CÓDIGO DO PRODUTO"
        ' 
        ' txt_cod_jog
        ' 
        txt_cod_jog.BorderStyle = BorderStyle.FixedSingle
        txt_cod_jog.Location = New Point(26, 78)
        txt_cod_jog.Name = "txt_cod_jog"
        txt_cod_jog.Size = New Size(450, 21)
        txt_cod_jog.TabIndex = 7
        ' 
        ' img_foto_jog
        ' 
        img_foto_jog.BorderStyle = BorderStyle.FixedSingle
        img_foto_jog.Cursor = Cursors.Hand
        img_foto_jog.Image = CType(resources.GetObject("img_foto_jog.Image"), Image)
        img_foto_jog.Location = New Point(491, 78)
        img_foto_jog.Name = "img_foto_jog"
        img_foto_jog.Size = New Size(159, 166)
        img_foto_jog.SizeMode = PictureBoxSizeMode.StretchImage
        img_foto_jog.TabIndex = 1
        img_foto_jog.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Cadastro_cardapio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Cadastro_cardapio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CADASTRO DE CARDÁPIO"
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(img_foto_ali, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(img_foto_jog, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbl_imagem_cadastro As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_prec_jog As TextBox
    Friend WithEvents txt_nome_jog As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cod_jog As TextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents img_foto_ali As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cod_ali As TextBox
    Friend WithEvents txt_nome_ali As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_prec_ali As TextBox
    Friend WithEvents btn_cadastro_ali As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents img_foto_jog As PictureBox
    Friend WithEvents btn_cadastro_jog As Button
    Friend WithEvents txt_un_ali As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_un_jog As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
