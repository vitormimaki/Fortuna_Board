Public Class Cadastro_cardapio

    Dim fotoA, fotoJ As Integer

    Private Sub Cadastro_cardapio_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        fotoA = 0
        fotoJ = 0
    End Sub
    Private Sub Cadastro_cardapio_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Frm_gerente.Show()
    End Sub
    Private Sub img_foto_ali_Click(sender As Object, e As EventArgs) Handles img_foto_ali.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO DO ALIMENTO"
                .InitialDirectory = Application.StartupPath & "Fotos"
                .ShowDialog()
                dir_foto = .FileName
                img_foto_ali.Load(dir_foto)
                fotoA = 1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub img_foto_jog_Click(sender As Object, e As EventArgs) Handles img_foto_jog.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO DO JOGO"
                .InitialDirectory = Application.StartupPath & "Fotos"
                .ShowDialog()
                dir_foto = .FileName
                img_foto_jog.Load(dir_foto)
                fotoJ = 1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub btn_cadastro_ali_Click(sender As Object, e As EventArgs) Handles btn_cadastro_ali.Click
        Try
            If txt_cod_ali.Text IsNot "" And IsNumeric(txt_cod_ali.Text) And txt_nome_ali.Text IsNot "" And txt_prec_ali.Text IsNot "" And txt_un_ali.Text IsNot "" And fotoA = 1 Then
                SQL = "select * from tb_produtos where COD= '" & txt_cod_ali.Text & "'"
                rs = db.Execute(SQL)

                If rs.EOF = True Then
                    SQL = "insert into tb_produtos values('" & txt_cod_ali.Text & "', " &
                                                          "'" & txt_nome_ali.Text & "', " &
                                                          "'" & dir_foto & "', " &
                                                          "'" & txt_un_ali.Text & "', " &
                                                          "'" & CDbl(txt_prec_ali.Text) & "', " &
                                                          "'0')"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cod_ali.Clear()
                    txt_nome_ali.Clear()
                    txt_un_ali.Clear()
                    txt_prec_ali.Clear()
                    img_foto_ali.Load("imagens\Comida.png")
                    fotoA = 0
                Else
                    resp = MsgBox("Deseja Atualizar os Dados do Alimento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        SQL = "update tb_produtos set NOME= '" & txt_nome_ali.Text & "', " &
                                                     "FOTO= '" & img_foto_ali.ImageLocation & "', " &
                                                       "UN= '" & txt_un_ali.Text & "', " &
                                                  "PC_UNIT= '" & CDbl(txt_prec_ali.Text) & "' where COD= '" & txt_cod_ali.Text & "'"
                        rs = db.Execute(UCase(SQL))

                        MsgBox("Dados Atualizados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        txt_cod_ali.Clear()
                        txt_nome_ali.Clear()
                        txt_un_ali.Clear()
                        txt_prec_ali.Clear()
                        img_foto_ali.Load("imagens\Comida.png")
                        fotoA = 0
                    End If
                End If
            Else
                If (IsNumeric(txt_cod_ali.Text) = False) Then
                    MsgBox("O Código do Produto deve Ser um Número!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Exit Sub
                End If
                MsgBox("Todos os Campos Devem ser Preenchidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro Ao Acessar o Banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_cadastro_jog_Click(sender As Object, e As EventArgs) Handles btn_cadastro_jog.Click
        Try
            If txt_cod_jog.Text IsNot "" And IsNumeric(txt_cod_jog.Text) And txt_nome_jog.Text IsNot "" And txt_prec_jog.Text IsNot "" And txt_un_jog.Text IsNot "" And fotoJ = 1 Then
                SQL = "select * from tb_produtos where COD= '" & txt_cod_jog.Text & "'"
                rs = db.Execute(SQL)

                If rs.EOF = True Then
                    SQL = "insert into tb_produtos values('" & txt_cod_jog.Text & "', " &
                                                          "'" & txt_nome_jog.Text & "', " &
                                                          "'" & dir_foto & "', " &
                                                          "'" & txt_un_jog.Text & "', " &
                                                          "'" & CDbl(txt_prec_jog.Text) & "', " &
                                                          "'1')"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cod_jog.Clear()
                    txt_nome_jog.Clear()
                    txt_un_jog.Clear()
                    txt_prec_jog.Clear()
                    img_foto_jog.Load("imagens\Game.png")
                    fotoJ = 0
                Else
                    resp = MsgBox("Deseja Atualizar os Dados do Jogo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        SQL = "update tb_produtos set NOME= '" & txt_nome_jog.Text & "', " &
                                                     "FOTO= '" & img_foto_jog.ImageLocation & "', " &
                                                       "UN= '" & txt_un_jog.Text & "', " &
                                                  "PC_UNIT= '" & CDbl(txt_prec_jog.Text) & "' where COD= '" & txt_cod_jog.Text & "'"
                        rs = db.Execute(UCase(SQL))

                        MsgBox("Dados Atualizados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        txt_cod_jog.Clear()
                        txt_nome_jog.Clear()
                        txt_un_jog.Clear()
                        txt_prec_jog.Clear()
                        img_foto_jog.Load("imagens\Game.png")
                        fotoJ = 0
                    End If
                End If
            Else
                If (IsNumeric(txt_cod_jog.Text) = False) Then
                    MsgBox("O Código do Produto deve Ser um Número!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Exit Sub
                End If
                MsgBox("Todos os Campos Devem ser Preenchidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro Ao Acessar o Banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub txt_cod_ali_LostFocus(sender As Object, e As EventArgs) Handles txt_cod_ali.LostFocus
        Try
            SQL = "select * from tb_produtos where COD= '" & txt_cod_ali.Text & "'"

            rs = db.Execute(SQL)

            If rs.EOF = False Then
                If rs.Fields(5).Value = "0" Then
                    TabControl1.SelectTab(0)
                    txt_nome_ali.Text = rs.Fields(1).Value
                    img_foto_ali.Load(rs.Fields(2).Value)
                    fotoA = 1
                    txt_un_ali.Text = rs.Fields(3).Value
                    txt_prec_ali.Text = rs.Fields(4).Value
                Else
                    TabControl1.SelectTab(1)
                    txt_cod_jog.Text = txt_cod_ali.Text
                    txt_cod_ali.Text = ""
                    txt_nome_jog.Text = rs.Fields(1).Value
                    img_foto_jog.Load(rs.Fields(2).Value)
                    fotoJ = 1
                    txt_un_jog.Text = rs.Fields(3).Value
                    txt_prec_jog.Text = rs.Fields(4).Value
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro Ao Acessar o Banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub txt_cod_jog_LostFocus(sender As Object, e As EventArgs) Handles txt_cod_jog.LostFocus
        Try
            SQL = "select * from tb_produtos where COD= '" & txt_cod_jog.Text & "'"

            rs = db.Execute(SQL)

            If rs.EOF = False Then
                If rs.Fields(5).Value = "0" Then
                    TabControl1.SelectTab(0)
                    txt_cod_ali.Text = txt_cod_jog.Text
                    txt_cod_jog.Text = ""
                    txt_nome_ali.Text = rs.Fields(1).Value
                    img_foto_ali.Load(rs.Fields(2).Value)
                    fotoA = 1
                    txt_un_ali.Text = rs.Fields(3).Value
                    txt_prec_ali.Text = rs.Fields(4).Value

                Else
                    TabControl1.SelectTab(1)
                    txt_nome_jog.Text = rs.Fields(1).Value
                    img_foto_jog.Load(rs.Fields(2).Value)
                    fotoJ = 1
                    txt_un_jog.Text = rs.Fields(3).Value
                    txt_prec_jog.Text = rs.Fields(4).Value

                End If
            End If
        Catch ex As Exception
            MsgBox("Erro Ao Acessar o Banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub txt_cod_ali_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_ali.DoubleClick
        txt_cod_ali.Clear()
        txt_nome_ali.Clear()
        txt_un_ali.Clear()
        txt_prec_ali.Clear()
        img_foto_ali.Load("imagens\Comida.png")
        fotoA = 0
    End Sub
    Private Sub txt_cod_jog_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod_jog.DoubleClick
        txt_cod_jog.Clear()
        txt_nome_jog.Clear()
        txt_un_jog.Clear()
        txt_prec_jog.Clear()
        img_foto_jog.Load("imagens\Game.png")
        fotoJ = 0
    End Sub
End Class