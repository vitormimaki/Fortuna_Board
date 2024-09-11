Imports Microsoft.Office.Interop
Public Class Frm_gerente
    Private Sub btn_gerenciar_Click(sender As Object, e As EventArgs) Handles btn_gerenciar.Click
        Me.Hide()
        frm_cadastro.ShowDialog()
    End Sub

    Private Sub btn_estoques_Click(sender As Object, e As EventArgs) Handles btn_estoques.Click
        Me.Hide()
        Cadastro_cardapio.ShowDialog()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Hide()
        Frm_login.Show()
    End Sub
    Private Sub Frm_gerente_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Frm_login.Show()
    End Sub

    Private Sub btn_relat_Click(sender As Object, e As EventArgs) Handles btn_relat.Click
        Try
            MSA.DoCmd.OpenReport(ReportName:="relat_funcionarios", View:=Access.AcView.acViewPreview)
            MSA.DoCmd.OpenReport(ReportName:="relat_vendas", View:=Access.AcView.acViewPreview)
        Catch ex As Exception
            MsgBox("Erro ao Gerar Relatórios", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class