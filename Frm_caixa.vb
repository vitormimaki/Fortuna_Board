Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports Microsoft.Office.Interop.Access

Public Class Frm_caixa
    Private Sub Frm_caixa_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Frm_login.Show()
    End Sub

    Private Sub Frm_caixa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                SQL = "select * from tb_pedidos where ID_COM= '" & txt_comanda.Text & "' and ENTREGUE = 0"
                rs = db.Execute(SQL)
                If rs.EOF = False Then
                    SQL = "update tb_pedidos set ENTREGUE = 1 where ID_COM = '" & txt_comanda.Text & "'"
                    rs = db.Execute(SQL)
                    MsgBox("Venda Realizada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_comanda.Clear()
                    dgv_caixa.Rows.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Encontrar Comanda!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub

    Private Sub txt_comanda_TextChanged(sender As Object, e As EventArgs) Handles txt_comanda.TextChanged
        Try
            SQL = "select * from tb_pedidos where ID_COM= '" & txt_comanda.Text & "' and ENTREGUE= 0"
            rs = db.Execute(SQL)
            Dim total As Double
            total = 0
            If rs.EOF = False Then
                With dgv_caixa
                    cont = 1
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(cont, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, "R$ " & CDbl(rs.Fields(6).Value), rs.Fields(7).Value, "R$ " & CDbl(rs.Fields(8).Value))
                        total = total + CDbl(rs.Fields(8).Value)
                        rs.MoveNext()
                        cont = cont + 1
                    Loop
                End With
                txt_total.Text = "R$" & total
            Else
                dgv_caixa.Rows.Clear()
                txt_total.Text = "R$00,00"
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Erro ao Encontrar Comanda!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub
End Class