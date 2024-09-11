Imports Microsoft.Office.Interop
Public Class Frm_login
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_Banco()
        txt_usuario.Focus()
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Try
            SQL = "select * from tb_login where LOGIN= '" & txt_usuario.Text & "' " &
                                                "and SENHA= '" & txt_senha.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                MsgBox("Usuário ou Senha Inválidos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_senha.Clear()
                txt_usuario.Clear()
                txt_usuario.Focus()
            Else
                txt_senha.Clear()
                txt_usuario.Clear()
                If (rs.Fields(3).Value = 0) Then 'Acesso do Gerente
                    Me.Hide()
                    Frm_gerente.ShowDialog()
                ElseIf (rs.Fields(3).Value = 1) Then 'Acesso do Garçom
                    Me.Hide()
                    Frm_garçom.ShowDialog()
                ElseIf (rs.Fields(3).Value = 2) Then 'Acesso do Caixa
                    Me.Hide()
                    Frm_caixa.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Conectar com o Banco!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub Frm_login_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txt_usuario.Focus()
        ver = 0
    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        If ver = 0 Then
            btn_visualizar.Load("imagens\visivel.png")
            txt_senha.PasswordChar = ""
            ver = 1
        Else
            btn_visualizar.Load("imagens\oculto.png")
            txt_senha.PasswordChar = "•"
            ver = 0
        End If
    End Sub

    Private Sub Frm_login_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        MSA.CloseCurrentDatabase()
        db.Close()
    End Sub
End Class
