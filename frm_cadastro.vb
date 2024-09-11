Imports System.Net.Security

Public Class frm_cadastro

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO DO FUNCIONÁRIO"
                .InitialDirectory = Application.StartupPath & "Fotos"
                .ShowDialog()
                dir_foto = .FileName
                img_foto.Load(dir_foto)
                foto = 1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If txt_cpf.Text IsNot "" And txt_nome.Text IsNot "" And txt_cep.Text IsNot "" And txt_comp.Text IsNot "" And txt_fone.Text IsNot "" And txt_email.Text IsNot "" And foto = 1 Then
                SQL = "select * from tb_usuarios where CPF='" & txt_cpf.Text & "'"
                rs = db.Execute(SQL)

                If rs.EOF = True Then
                    SQL = "insert into tb_usuarios values ('" & txt_cpf.Text & "', " &
                                                          "'" & cmb_data.Value & "', " &
                                                          "'" & txt_nome.Text & "', " &
                                                          "'" & dir_foto & "', " &
                                                          "'" & txt_cep.Text & "', " &
                                                          "'" & txt_endereco.Text & "', " &
                                                          "'" & txt_comp.Text & "', " &
                                                          "'" & txt_bairro.Text & "', " &
                                                          "'" & txt_cidade.Text & "', " &
                                                          "'" & txt_uf.Text & "', " &
                                                          "'" & txt_fone.Text & "', " &
                                                          "'" & txt_email.Text & "')"
                    rs = db.Execute(UCase(SQL))

                    If cmb_cargo.SelectedIndex = 0 Then
                        cargo = 0
                    ElseIf cmb_cargo.SelectedIndex = 1 Then
                        cargo = 2
                    ElseIf cmb_cargo.SelectedIndex = 2 Then
                        cargo = 1
                    End If

                    SQL = "insert into tb_login values ('" & txt_cpf.Text & "', " &
                                                       "'" & txt_cpf.Text & "', " &
                                                       "'123', " &
                                                       "'" & cargo & "')"
                    rs = db.Execute(UCase(SQL))

                    MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_pesquisar.Clear()
                    txt_cpf.Clear()
                    limpar_dados()
                Else
                    resp = MsgBox("Deseja Atualizar os Dados do Funcionário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        SQL = "update tb_usuarios set CEP= '" & txt_cep.Text & "', " &
                                                "ENDERECO= '" & txt_endereco.Text & "', " &
                                                "NUM_COMP= '" & txt_comp.Text & "', " &
                                                  "BAIRRO= '" & txt_bairro.Text & "', " &
                                                  "CIDADE= '" & txt_cidade.Text & "', " &
                                                      "UF= '" & txt_uf.Text & "', " &
                                                    "FONE= '" & txt_fone.Text & "', " &
                                                   "EMAIL= '" & txt_email.Text & "' where CPF= '" & txt_cpf.Text & "'"
                        rs = db.Execute(UCase(SQL))

                        MsgBox("Dados Atualizados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        txt_pesquisar.Clear()
                        txt_cpf.Clear()
                        limpar_dados()
                    End If
                    txt_nome.Enabled = True
                    img_foto.Enabled = True
                    cmb_data.Enabled = True
                    cmb_cargo.Enabled = True
                End If
            Else
                MsgBox("Todos os Campos Devem ser Preenchidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro Ao Gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            SQL = "select * from tb_cep where CEP='" & txt_cep.Text & "'"

            rs = db.Execute(UCase(SQL))

            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_comp.Focus()
            End If

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_cadastro_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Frm_gerente.Show()
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            SQL = "select * from tb_usuarios where CPF= '" & txt_cpf.Text & "'"

            rs = db.Execute(SQL)

            If rs.EOF = True Then
                limpar_dados()
            Else
                cmb_data.Value = rs.Fields(1).Value
                txt_nome.Text = rs.Fields(2).Value
                img_foto.Load(rs.Fields(3).Value)
                txt_cep.Text = rs.Fields(4).Value
                txt_endereco.Text = rs.Fields(5).Value
                txt_comp.Text = rs.Fields(6).Value
                txt_bairro.Text = rs.Fields(7).Value
                txt_cidade.Text = rs.Fields(8).Value
                txt_uf.Text = rs.Fields(9).Value
                txt_fone.Text = rs.Fields(10).Value
                txt_email.Text = rs.Fields(11).Value

                SQL = "select * from tb_login where CPF= '" & txt_cpf.Text & "'"
                rs = db.Execute(SQL)

                If rs.Fields(3).Value = 0 Then
                    cmb_cargo.SelectedIndex = 0
                ElseIf rs.Fields(3).Value = 1 Then
                    cmb_cargo.SelectedIndex = 1
                ElseIf rs.Fields(3).Value = 2 Then
                    cmb_cargo.SelectedIndex = 2
                End If

                txt_nome.Enabled = False
                img_foto.Enabled = False
                cmb_data.Enabled = False
                cmb_cargo.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Erro Ao Acessar o Banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub frm_cadastro_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txt_cpf.Focus()
        foto = 0
        carregar_dados()
        carregar_tipos()
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            resp = MsgBox("Deseja Excluir os Dados do Funcionário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                SQL = "delete from tb_usuarios where CPF= '" & txt_cpf.Text & "'"
                rs = db.Execute(SQL)
                SQL = "delete from tb_login where CPF= '" & txt_cpf.Text & "'"
                rs = db.Execute(SQL)
                limpar_dados()
                MsgBox("Dados Excluídos com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            txt_nome.Enabled = True
            img_foto.Enabled = True
            cmb_data.Enabled = True
            cmb_cargo.Enabled = True
        Catch ex As Exception
            MsgBox("Erro Ao Encontrar Funcionário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_pesquisar_TextChanged(sender As Object, e As EventArgs)
        Try
            SQL = "select * from tb_usuarios where " & cmb_tipo.Text & " like '" & txt_pesquisar.Text & "%'"
            rs = db.Execute(SQL)
            With dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub



    Private Sub dgv_dados_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "Select * From tb_usuarios where CPF= '" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'Explorando a aba dados pessoais
                        txt_cpf.Text = rs.Fields(0).Value
                        cmb_data.Value = rs.Fields(1).Value
                        txt_nome.Text = rs.Fields(2).Value
                        img_foto.Load(rs.Fields(3).Value)
                        txt_cep.Text = rs.Fields(4).Value
                        txt_endereco.Text = rs.Fields(5).Value
                        txt_comp.Text = rs.Fields(6).Value
                        txt_bairro.Text = rs.Fields(7).Value
                        txt_cidade.Text = rs.Fields(8).Value
                        txt_uf.Text = rs.Fields(9).Value
                        txt_fone.Text = rs.Fields(10).Value
                        txt_email.Text = rs.Fields(11).Value

                        SQL = "select * from tb_login where CPF= '" & txt_cpf.Text & "'"
                        rs = db.Execute(SQL)

                        If rs.Fields(3).Value = 0 Then
                            cmb_cargo.SelectedIndex = 0
                        ElseIf rs.Fields(3).Value = 1 Then
                            cmb_cargo.SelectedIndex = 1
                        ElseIf rs.Fields(3).Value = 2 Then
                            cmb_cargo.SelectedIndex = 2
                        End If
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "Select * From tb_usuarios where CPF= '" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja Excluir os Dados do Funcionário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = vbYes Then
                            SQL = "delete from tb_usuarios where CPF= '" & txt_cpf.Text & "'"
                            rs = db.Execute(SQL)
                            SQL = "delete from tb_login where CPF= '" & txt_cpf.Text & "'"
                            rs = db.Execute(SQL)
                            limpar_dados()
                            MsgBox("Dados Excluídos com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        End If
                        txt_nome.Enabled = True
                        img_foto.Enabled = True
                        cmb_data.Enabled = True
                        cmb_cargo.Enabled = True
                    End If
                Else
                    Exit Sub
                End If
                carregar_dados()
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        txt_cpf.Clear()
        cmb_data.Value = Today
        cmb_cargo.SelectedValue = ""
        txt_nome.Clear()
        img_foto.Load("icones\perfil.png")
        txt_cep.Clear()
        txt_endereco.Clear()
        txt_comp.Clear()
        txt_bairro.Clear()
        txt_cidade.Clear()
        txt_uf.Clear()
        txt_fone.Clear()
        txt_email.Clear()
        txt_nome.Enabled = True
        img_foto.Enabled = True
        cmb_data.Enabled = True
        cmb_cargo.Enabled = True
    End Sub
End Class
