Imports Microsoft.Office.Interop
Module mod_geral
    Public dir_foto, SQL, resp, aux_cpf As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public pedido, cargo, ver, cont, foto As Integer
    Public dir_banco = Application.StartupPath & "Banco\fortuna_board.accdb"
    Public MSA As New Access.Application

    Sub Conecta_Banco()
        Try
            MSA.OpenCurrentDatabase(filepath:=dir_banco, Exclusive:=False)
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dir_banco)
        Catch ex As Exception
            MsgBox("Erro ao Conectar com o banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            SQL = "select * from tb_usuarios order by nome asc"
            rs = db.Execute(SQL)
            With frm_cadastro.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipos()
        Try
            With frm_cadastro.cmb_tipo.Items
                .Add("CPF")
                .Add("NOME")
            End With
            frm_cadastro.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar os tipos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_dados()
        Try
            With frm_cadastro
                .cmb_data.Value = Today
                .cmb_cargo.SelectedValue = ""
                .txt_nome.Clear()
                .img_foto.Load("icones\perfil.png")
                .txt_cep.Clear()
                .txt_endereco.Clear()
                .txt_comp.Clear()
                .txt_bairro.Clear()
                .txt_cidade.Clear()
                .txt_uf.Clear()
                .txt_fone.Clear()
                .txt_email.Clear()
            End With
        Catch ex As Exception
            MsgBox("Erro ao Localizar Dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
