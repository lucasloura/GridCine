Public Class frm_operador

    Private Sub btn_encerrar_sessao_Click(sender As Object, e As EventArgs) Handles btn_encerrar_sessao.Click
        Me.Close()
    End Sub

    Private Sub operador_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        frm_login.Show()
        frm_login.BringToFront()
        frm_login.txt_cpf.Focus()
        cont = 0
    End Sub

    Private Sub operador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = nome
        lbl_cargo.Text = cargo
        btn_realizar_venda.Focus()
        sql = "select id_filme from tb_filmes where em_cartaz = 'SIM'"
        rs = db.Execute(UCase(sql))
        If rs.EOF = False Then
            id_filme = rs.Fields(0).Value
            buscar_titulo()
            buscar_poster()
        End If
        trocar_tema()
    End Sub

    Private Sub btn_seta_dir_Click(sender As Object, e As EventArgs) Handles btn_seta_dir.Click
        Try
            sql = "select id_filme from tb_filmes where em_cartaz = 'SIM' order by id_filme asc"
            rs = db.Execute(UCase(sql))
            While rs.EOF = False
                If rs.Fields(0).Value = id_filme Then
                    rs.MoveNext()
                    If rs.EOF = True Then
                        rs.MoveFirst()
                    End If
                    id_filme = rs.Fields(0).Value
                    buscar_titulo()
                    buscar_poster()
                    Exit Sub
                End If
                rs.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("Erro ao avançar para o próximo filme", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub btn_seta_esq_Click(sender As Object, e As EventArgs) Handles btn_seta_esq.Click
        Try
            sql = "select id_filme from tb_filmes where em_cartaz = 'SIM' order by id_filme desc"
            rs = db.Execute(UCase(sql))
            While rs.EOF = False
                If rs.Fields(0).Value = id_filme Then
                    rs.MoveNext()
                    If rs.EOF = True Then
                        rs.MoveFirst()
                    End If
                    id_filme = rs.Fields(0).Value
                    buscar_titulo()
                    buscar_poster()
                    Exit Sub
                End If
                rs.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("Erro ao voltar para o filme anterior", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_titulo_TextChanged(sender As Object, e As EventArgs) Handles btn_titulo.TextChanged
        Try
            btn_prox_hor.Text = ""
            btn_prox_hor_3d.Text = ""
            data = DateTime.Today
            sql = "select horario, sala from tb_sessoes where id_filme = " & id_filme & " and data = '" & Now.ToString("dd/MM/yyyy") & "' and horario >= '" & Now.ToString("HH:mm") & "' and confirmado = 1 order by horario asc"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                While rs.EOF = False
                    If rs.Fields(1).Value = 1 Or rs.Fields(1).Value = 2 Then
                        If btn_prox_hor.Text = "" Then
                            btn_prox_hor.Text = rs.Fields(0).Value
                        Else
                            btn_prox_hor.Text = btn_prox_hor.Text & " - " & rs.Fields(0).Value
                        End If
                    Else
                        If btn_prox_hor_3d.Text = "" Then
                            btn_prox_hor_3d.Text = rs.Fields(0).Value
                        Else
                            btn_prox_hor_3d.Text = btn_prox_hor_3d.Text & " - " & rs.Fields(0).Value
                        End If
                    End If
                    rs.MoveNext()
                End While
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar próximas sessões", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_realizar_compra_Click(sender As Object, e As EventArgs) Handles btn_realizar_venda.Click
        frm_realizar_pedido.Show()
    End Sub

    Private Sub btn_titulo_Click(sender As Object, e As EventArgs) Handles btn_titulo.Click
        frm_realizar_pedido.Show()
        frm_realizar_pedido.cmb_filmes_pedido.Text = btn_titulo.Text
    End Sub

    Private Sub btn_trocar_tema_Click(sender As Object, e As EventArgs) Handles btn_trocar_tema.Click
        If GroupBox1.BackColor = Color.Black Then
            tema = "claro"
        Else
            tema = "escuro"
        End If
        trocar_tema()
    End Sub
End Class