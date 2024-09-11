Public Class Frm_pedidos
    Private Sub Frm_pedidos_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        cmb_nome.Items.Clear()
        Frm_garçom.Show()
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        Try
            If txt_cod.Text = "" Or txt_comanda.Text = "" Or txt_qtde.Text = "" Then
                MsgBox("Preencha Todos os Campos para Efetuar a Venda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                SQL = "select * from tb_produtos where COD= '" & txt_cod.Text & "'"
                rs = db.Execute(SQL)
                Dim aux As New ADODB.Recordset
                SQL = "select count(*) from tb_pedidos"
                aux = db.Execute(SQL)

                SQL = "insert into tb_pedidos values ('" & aux.Fields(0).Value & "', " &
                                                         "'" & txt_comanda.Text & "', " &
                                                         "'" & txt_cod.Text & "', " &
                                                         "'" & rs.Fields(1).Value & "', " &
                                                         "'" & rs.Fields(5).Value & "', " &
                                                         "'" & rs.Fields(3).Value & "', " &
                                                         "'" & rs.Fields(4).Value & "', " &
                                                         "'" & txt_qtde.Text & "', " &
                                                         "'" & txt_precTot.Text & "', " &
                                                         "0)"
                rs = db.Execute(SQL)
                MsgBox("Pedido Realizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_comanda.Clear()
                txt_qtde.Clear()
                txt_cod.Clear()
                txt_precTot.Clear()
                txt_precu.Clear()
                cmb_nome.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Erro ao Efetuar o Pedido", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub Frm_pedidos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            SQL = "select * from tb_produtos where TIPO= '" & pedido & "'"
            rs = db.Execute(SQL)
            Do While rs.EOF = False
                cmb_nome.Items.Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Falha ao Reunir Produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub cmb_nome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nome.SelectedIndexChanged
        Try
            SQL = "select * from tb_produtos where NOME= '" & cmb_nome.Text & "'"
            rs = db.Execute(SQL)

            txt_cod.Text = rs.Fields(0).Value
            txt_precu.Text = rs.Fields(4).Value
            img_prod.Load(rs.Fields(2).Value)

            If txt_qtde.Text IsNot "" And IsNumeric(txt_qtde.Text) Then
                txt_precTot.Text = Int(txt_qtde.Text) * CDbl(txt_precu.Text)
            End If

        Catch ex As Exception
            MsgBox("Falha ao Acessar o Banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub txt_qtde_TextChanged(sender As Object, e As EventArgs) Handles txt_qtde.TextChanged
        If IsNumeric(txt_qtde.Text) And txt_cod.Text IsNot "" Then
            txt_precTot.Text = Int(txt_qtde.Text) * CDbl(txt_precu.Text)
        End If
    End Sub
End Class