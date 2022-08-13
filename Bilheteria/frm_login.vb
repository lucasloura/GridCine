Public Class frm_login
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            If cont < 5 Then
                If LCase(txt_senha.Text) = "gerente" Then
                    nome = ""
                    cargo = "Gerente"
                    id_conta = -2
                    Me.Hide()
                    frm_gerente.Show()
                    limpar_login()
                    Exit Sub
                ElseIf LCase(txt_senha.Text) = "operador" Then
                    nome = ""
                    cargo = "Operador"
                    id_conta = -1
                    Me.Hide()
                    frm_operador.Show()
                    limpar_login()
                    Exit Sub
                ElseIf txt_cpf.Text = "   .   .   -" Or txt_senha.Text = "" Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    If txt_cpf.Text = "   .   .   -" Then
                        txt_cpf.Focus()
                    Else
                        txt_senha.Focus()
                    End If
                Else
                    sql = "select cpf, nome, senha, tipo_conta, status, id_conta from tb_funcionarios where cpf = '" & txt_cpf.Text & "' and senha = '" & txt_senha.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = True Then
                        cont = cont + 1
                        If cont < 5 Then
                            MsgBox("Dados inválidos!" + vbNewLine + "Tentativas restantes: " & 5 - cont, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            txt_cpf.Focus()
                            Exit Sub
                        Else
                            MsgBox("Dados inválidos!" + vbNewLine + "Limite de tentativas excedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            Try
                                sql = "update tb_funcionarios set status = 'bloqueado' where cpf = '" & txt_cpf.Text & "'"
                                db.Execute(sql)
                            Catch ex As Exception

                            End Try
                            Me.Close()
                        End If
                    Else
                        If rs.Fields(4).Value = "bloqueado" Then
                            MsgBox("Conta bloqueada!" + vbNewLine + "Contate a gerência", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            txt_cpf.Focus()
                            Exit Sub
                        Else
                            nome = rs.Fields(1).Value
                            id_conta = rs.Fields(5).Value
                            If rs.Fields(3).Value = "operador" Then
                                cargo = "Operador"
                                Me.Hide()
                                frm_operador.Show()
                                limpar_login()
                                Exit Sub
                            Else
                                cargo = "Gerente"
                                Me.Hide()
                                frm_gerente.Show()
                                limpar_login()
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao fazer login!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cont = 0
        conectar_banco_access()
        tema = "escuro"
    End Sub

    'Private Sub txt_cpf_DoubleClick(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf.DoubleClick
    '    limpar_login()
    'End Sub

    Private Sub btn_esqueceu_senha_Click(sender As Object, e As EventArgs) Handles btn_esqueceu_senha.Click
        frm_esqueceu_senha.Show()
    End Sub

    Private Sub btn_trocar_tema_Click(sender As Object, e As EventArgs) Handles btn_trocar_tema.Click
        If img_usuario.BackColor = Color.Black Then
            tema = "claro"
        Else
            tema = "escuro"
        End If
        trocar_tema()
    End Sub
End Class
