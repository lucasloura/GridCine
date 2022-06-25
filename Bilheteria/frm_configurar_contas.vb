Public Class frm_configurar_contas

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_cpf.Text = "   .   .   -" Or txt_nome.Text = "" Or
               txt_email.Text = "" Or txt_senha.Text = "" Or
               (rb_operador.Checked Or rb_gerente.Checked) = False Or
               (rb_ativo.Checked Or rb_bloqueado.Checked) = False Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                If rb_operador.Checked = True Then
                    tipo_conta = "operador"
                Else
                    tipo_conta = "gerente"
                End If
                If rb_ativo.Checked = True Then
                    status = "ativo"
                Else
                    status = "bloqueado"
                End If
                sql = "select cpf from tb_funcionarios where cpf = '" & txt_cpf.Text & "' "
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    sql = "select id_conta from tb_funcionarios"
                    rs = db.Execute(UCase(sql))
                    cont = 0
                    While rs.EOF = False
                        cont = cont + 1
                        rs.MoveNext()
                    End While
                    sql = "insert into tb_funcionarios values ('" & txt_cpf.Text & "', '" & txt_nome.Text & "', " &
                                                              "'" & txt_email.Text & "', '" & txt_senha.Text & "', " &
                                                              "'" & tipo_conta & "', '" & status & "', " & cont & ")"
                    rs = db.Execute(sql)
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    limpar_cadastro()
                Else
                    sql = "update tb_funcionarios set nome = '" & txt_nome.Text & "', email = '" & txt_email.Text & "', " &
                                                   " senha = '" & txt_senha.Text & "', tipo_conta = '" & tipo_conta & "', " &
                                                  " status = '" & status & "' where cpf = '" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    limpar_cadastro()
                End If
            End If
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar/atualizar os dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub configurar_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        carregar_dados()
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_funcionarios where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nome.Focus()
            Else
                txt_nome.Text = rs.Fields(1).Value
                txt_email.Text = rs.Fields(2).Value
                txt_senha.Text = rs.Fields(3).Value
                If rs.Fields(4).Value = "operador" Then
                    rb_operador.Checked = True
                    rb_gerente.Checked = False
                Else
                    rb_operador.Checked = False
                    rb_gerente.Checked = True
                End If
                If rs.Fields(5).Value = "ativo" Then
                    rb_ativo.Checked = True
                    rb_bloqueado.Checked = False
                Else
                    rb_ativo.Checked = False
                    rb_bloqueado.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao consultar cpf!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_cadastro()
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            sql = "select cpf, nome, tipo_conta, status from tb_funcionarios where nome like '" & txt_pesquisa.Text & "%'"
            rs = db.Execute(sql)
            With dgv_contas
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao pesquisar na listagem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick
        Try
            With dgv_contas
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_funcionarios where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        tab_contas.SelectTab(0)
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_email.Text = rs.Fields(2).Value
                        txt_senha.Text = rs.Fields(3).Value
                        If rs.Fields(4).Value = "operador" Then
                            rb_operador.Checked = True
                            rb_gerente.Checked = False
                        Else
                            rb_operador.Checked = False
                            rb_gerente.Checked = True
                        End If
                        If rs.Fields(5).Value = "ativo" Then
                            rb_ativo.Checked = True
                            rb_bloqueado.Checked = False
                        Else
                            rb_ativo.Checked = False
                            rb_bloqueado.Checked = True
                        End If
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    resp = MsgBox("O CPF " & aux_cpf & " será excluido do sistema", MsgBoxStyle.Information + vbOKCancel, "ATENÇÃO")
                    If resp = MsgBoxResult.Ok Then
                        sql = "delete * from tb_funcionarios where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao editar/excluir", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub tab_contas_SelectedIndexChanged() Handles tab_contas.SelectedIndexChanged
        If tab_contas.SelectedIndex = 1 Then
            btn_salvar.Enabled = False
        Else
            btn_salvar.Enabled = True
        End If
    End Sub

End Class