Imports Microsoft.Office.Interop
Public Class Frm_garçom

    Private Sub btn_jogo_MouseHover(sender As Object, e As EventArgs) Handles btn_jogo.MouseHover
        btn_jogo.Size = New Size(150, 150)
        lbl_jogos.Location = New Point(145, 259)
    End Sub

    Private Sub btn_alimento_MouseHover(sender As Object, e As EventArgs) Handles btn_alimento.MouseHover
        btn_alimento.Size = New Size(150, 150)
        lbl_alimentos.Location = New Point(398, 259)
    End Sub
    Private Sub Frm_garçom_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        btn_alimento.Size = New Size(120, 120)
        btn_jogo.Size = New Size(120, 120)
        lbl_alimentos.Location = New Point(398, 249)
        lbl_jogos.Location = New Point(145, 249)
    End Sub
    Private Sub btn_pedidos_MouseHover(sender As Object, e As EventArgs) Handles btn_pedidos.MouseHover
        btn_alimento.Size = New Size(120, 120)
        btn_jogo.Size = New Size(120, 120)
        lbl_alimentos.Location = New Point(398, 249)
        lbl_jogos.Location = New Point(145, 249)
    End Sub

    Private Sub Frm_garçom_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Frm_login.Show()
    End Sub

    Private Sub btn_alimento_Click(sender As Object, e As EventArgs) Handles btn_alimento.Click
        pedido = 0 'Alimento
        Me.Hide()
        Frm_pedidos.ShowDialog()
    End Sub

    Private Sub btn_jogo_Click(sender As Object, e As EventArgs) Handles btn_jogo.Click
        pedido = 1 'Jogo
        Me.Hide()
        Frm_pedidos.ShowDialog()
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        Try
            MSA.DoCmd.OpenReport(ReportName:="relat_pedidos_clientes", View:=Access.AcView.acViewPreview)
        Catch ex As Exception
            MsgBox("Erro ao Gerar Relatório", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class