<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_login))
        lbl_login = New Label()
        txt_usuario = New TextBox()
        lbl_senha = New Label()
        txt_senha = New TextBox()
        PictureBox1 = New PictureBox()
        btn_login = New Button()
        btn_visualizar = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_visualizar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_login
        ' 
        lbl_login.AutoSize = True
        lbl_login.BackColor = Color.Transparent
        lbl_login.Font = New Font("Modern No. 20", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_login.ForeColor = Color.Yellow
        lbl_login.ImageAlign = ContentAlignment.MiddleRight
        lbl_login.Location = New Point(615, 91)
        lbl_login.Name = "lbl_login"
        lbl_login.Size = New Size(112, 38)
        lbl_login.TabIndex = 0
        lbl_login.Text = "Login"
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Cursor = Cursors.IBeam
        txt_usuario.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txt_usuario.Location = New Point(594, 136)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(152, 35)
        txt_usuario.TabIndex = 0
        ' 
        ' lbl_senha
        ' 
        lbl_senha.AutoSize = True
        lbl_senha.BackColor = Color.Transparent
        lbl_senha.Font = New Font("Modern No. 20", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_senha.ForeColor = Color.Yellow
        lbl_senha.ImageAlign = ContentAlignment.MiddleRight
        lbl_senha.Location = New Point(615, 210)
        lbl_senha.Name = "lbl_senha"
        lbl_senha.Size = New Size(114, 38)
        lbl_senha.TabIndex = 2
        lbl_senha.Text = "Senha"
        ' 
        ' txt_senha
        ' 
        txt_senha.Cursor = Cursors.IBeam
        txt_senha.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txt_senha.Location = New Point(594, 271)
        txt_senha.Name = "txt_senha"
        txt_senha.PasswordChar = "•"c
        txt_senha.Size = New Size(152, 35)
        txt_senha.TabIndex = 1
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
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btn_login
        ' 
        btn_login.AutoEllipsis = True
        btn_login.BackColor = Color.DarkRed
        btn_login.Cursor = Cursors.Hand
        btn_login.FlatAppearance.BorderSize = 2
        btn_login.FlatStyle = FlatStyle.Popup
        btn_login.Font = New Font("Modern No. 20", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        btn_login.ForeColor = Color.Yellow
        btn_login.Location = New Point(615, 335)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(114, 39)
        btn_login.TabIndex = 2
        btn_login.Text = "ENTRAR"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_visualizar
        ' 
        btn_visualizar.Cursor = Cursors.Hand
        btn_visualizar.Image = CType(resources.GetObject("btn_visualizar.Image"), Image)
        btn_visualizar.Location = New Point(752, 271)
        btn_visualizar.Name = "btn_visualizar"
        btn_visualizar.Size = New Size(36, 35)
        btn_visualizar.SizeMode = PictureBoxSizeMode.StretchImage
        btn_visualizar.TabIndex = 5
        btn_visualizar.TabStop = False
        ' 
        ' Frm_login
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        BackgroundImage = My.Resources.Resources.gabriel_neris_taverna_detalhe1_final
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btn_visualizar)
        Controls.Add(btn_login)
        Controls.Add(PictureBox1)
        Controls.Add(txt_senha)
        Controls.Add(lbl_senha)
        Controls.Add(txt_usuario)
        Controls.Add(lbl_login)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Frm_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_visualizar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_login As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_visualizar As PictureBox
End Class
