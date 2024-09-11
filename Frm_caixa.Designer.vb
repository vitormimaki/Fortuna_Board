<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_caixa
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_caixa))
        lbl_f3 = New Label()
        txt_comanda = New TextBox()
        Label1 = New Label()
        dgv_caixa = New DataGridView()
        col_num = New DataGridViewTextBoxColumn()
        col_cod = New DataGridViewTextBoxColumn()
        col_prod = New DataGridViewTextBoxColumn()
        col_un = New DataGridViewTextBoxColumn()
        col_precu = New DataGridViewTextBoxColumn()
        col_qtde = New DataGridViewTextBoxColumn()
        col_sub = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        txt_total = New Label()
        CType(dgv_caixa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_f3
        ' 
        lbl_f3.AutoSize = True
        lbl_f3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lbl_f3.ForeColor = Color.Navy
        lbl_f3.Location = New Point(12, 391)
        lbl_f3.Name = "lbl_f3"
        lbl_f3.Size = New Size(182, 24)
        lbl_f3.TabIndex = 1
        lbl_f3.Text = "F3-Finalizar Venda"
        ' 
        ' txt_comanda
        ' 
        txt_comanda.Cursor = Cursors.IBeam
        txt_comanda.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txt_comanda.Location = New Point(595, 386)
        txt_comanda.Name = "txt_comanda"
        txt_comanda.Size = New Size(152, 35)
        txt_comanda.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(486, 391)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 24)
        Label1.TabIndex = 6
        Label1.Text = "Comanda"
        ' 
        ' dgv_caixa
        ' 
        dgv_caixa.AllowUserToAddRows = False
        dgv_caixa.AllowUserToDeleteRows = False
        dgv_caixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_caixa.Columns.AddRange(New DataGridViewColumn() {col_num, col_cod, col_prod, col_un, col_precu, col_qtde, col_sub})
        dgv_caixa.GridColor = Color.Coral
        dgv_caixa.Location = New Point(12, 29)
        dgv_caixa.Name = "dgv_caixa"
        dgv_caixa.ReadOnly = True
        dgv_caixa.RowHeadersWidth = 51
        dgv_caixa.RowTemplate.Height = 24
        dgv_caixa.Size = New Size(776, 339)
        dgv_caixa.TabIndex = 7
        ' 
        ' col_num
        ' 
        col_num.HeaderText = "N°"
        col_num.Name = "col_num"
        col_num.ReadOnly = True
        col_num.Width = 70
        ' 
        ' col_cod
        ' 
        col_cod.HeaderText = "Código"
        col_cod.Name = "col_cod"
        col_cod.ReadOnly = True
        col_cod.Width = 60
        ' 
        ' col_prod
        ' 
        col_prod.HeaderText = "Produto"
        col_prod.Name = "col_prod"
        col_prod.ReadOnly = True
        col_prod.Width = 270
        ' 
        ' col_un
        ' 
        col_un.HeaderText = "UN"
        col_un.Name = "col_un"
        col_un.ReadOnly = True
        col_un.Width = 70
        ' 
        ' col_precu
        ' 
        col_precu.HeaderText = "Preço"
        col_precu.Name = "col_precu"
        col_precu.ReadOnly = True
        ' 
        ' col_qtde
        ' 
        col_qtde.HeaderText = "QTDE"
        col_qtde.Name = "col_qtde"
        col_qtde.ReadOnly = True
        col_qtde.Width = 70
        ' 
        ' col_sub
        ' 
        col_sub.HeaderText = "Subtotal"
        col_sub.Name = "col_sub"
        col_sub.ReadOnly = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(258, 391)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 24)
        Label2.TabIndex = 8
        Label2.Text = "TOTAL: "
        ' 
        ' txt_total
        ' 
        txt_total.AutoSize = True
        txt_total.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        txt_total.ForeColor = Color.Navy
        txt_total.Location = New Point(355, 391)
        txt_total.Name = "txt_total"
        txt_total.Size = New Size(85, 24)
        txt_total.TabIndex = 9
        txt_total.Text = "R$00,00"
        ' 
        ' Frm_caixa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txt_total)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_comanda)
        Controls.Add(lbl_f3)
        Controls.Add(dgv_caixa)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MaximizeBox = False
        Name = "Frm_caixa"
        StartPosition = FormStartPosition.CenterScreen
        CType(dgv_caixa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbl_f3 As Label
    Friend WithEvents txt_comanda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_caixa As DataGridView
    Friend WithEvents col_num As DataGridViewTextBoxColumn
    Friend WithEvents col_cod As DataGridViewTextBoxColumn
    Friend WithEvents col_prod As DataGridViewTextBoxColumn
    Friend WithEvents col_un As DataGridViewTextBoxColumn
    Friend WithEvents col_precu As DataGridViewTextBoxColumn
    Friend WithEvents col_qtde As DataGridViewTextBoxColumn
    Friend WithEvents col_sub As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_total As Label
End Class
