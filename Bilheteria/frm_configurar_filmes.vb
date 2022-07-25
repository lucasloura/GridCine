Public Class checar_filmes
    Dim caminho_poster As String
    Dim cont_check As Integer

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub checar_filmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        limpar_filme()
        carregar_dados_filme()
        carregar_disponibilidade_salas()
        carregar_cmb_filmes()
        carregar_cmb_filmes_sessoes()
        carregar_cmb_salas()
        limpar_salas()
        data = dtp_data.Value.Date
    End Sub

    Private Sub img_poster_Click(sender As Object, e As EventArgs) Handles img_poster.Click
        Try
            With OpenFileDialog1
                .InitialDirectory = Application.StartupPath & "\fotos\"
                .Title = "SELECIONE UM POSTER"
                .ShowDialog()
                diretorio = .FileName
                img_poster.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If tab_configurar_filmes.SelectedIndex = 2 Then
            Try
                If diretorio = "" Or txt_titulo.Text = "" Or txt_preco.Text = "" Or (rb_sim.Checked = False And rb_nao.Checked = False) Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    If rb_sim.Checked = True Then
                        em_cartaz = "sim"
                    Else
                        em_cartaz = "nao"
                    End If
                    sql = "select * from tb_filmes where titulo = '" & txt_titulo.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = True Then
                        sql = "select * from tb_filmes"
                        rs = db.Execute(sql)
                        cont = 0
                        Do While rs.EOF = False
                            cont = cont + 1
                            rs.MoveNext()
                        Loop
                        sql = "insert into tb_filmes values (" & cont & ", '" & txt_titulo.Text & "', '" & txt_preco.Text & "', '" & diretorio & "', '" & em_cartaz & "')"
                        rs = db.Execute(UCase(sql))
                        MsgBox("Filme cadastrado com sucesso!")
                    Else
                        sql = "update tb_filmes set preco = '" & txt_preco.Text & "', poster = '" & diretorio & "', em_cartaz = '" & em_cartaz & "' where titulo = '" & txt_titulo.Text & "'"
                        rs = db.Execute(UCase(sql))
                        MsgBox("Informações do filme atualizadas com sucesso!")
                    End If
                    limpar_filme()
                    carregar_dados_filme()
                    carregar_cmb_filmes()
                    carregar_cmb_filmes_sessoes()
                End If
            Catch ex As Exception
                MsgBox("Erro ao cadastrar/atualizar informações do filme", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        ElseIf tab_configurar_filmes.SelectedIndex = 4 Then
            Try
                If cb_sala_01.Checked = True Then
                    statusSala = "disponivel"
                Else
                    statusSala = "indisponivel"
                End If
                sql = "update tb_salas set status = '" & statusSala & "', hor1 = '" & txt_sala01_hor1.Text & "', hor2 = '" & txt_sala01_hor2.Text & "', hor3 = '" & txt_sala01_hor3.Text & "', hor4 = '" & txt_sala01_hor4.Text & "', hor5 = '" & txt_sala01_hor5.Text & "' where sala = 1"
                db.Execute(UCase(sql))

                If cb_sala_02.Checked = True Then
                    statusSala = "disponivel"
                Else
                    statusSala = "indisponivel"
                End If
                sql = "update tb_salas set status = '" & statusSala & "', hor1 = '" & txt_sala02_hor1.Text & "', hor2 = '" & txt_sala02_hor2.Text & "', hor3 = '" & txt_sala02_hor3.Text & "', hor4 = '" & txt_sala02_hor4.Text & "', hor5 = '" & txt_sala02_hor5.Text & "' where sala = 2"
                db.Execute(UCase(sql))

                If cb_sala_03.Checked = True Then
                    statusSala = "disponivel"
                Else
                    statusSala = "indisponivel"
                End If
                sql = "update tb_salas set status = '" & statusSala & "', hor1 = '" & txt_sala03_hor1.Text & "', hor2 = '" & txt_sala03_hor2.Text & "', hor3 = '" & txt_sala03_hor3.Text & "', hor4 = '" & txt_sala03_hor4.Text & "', hor5 = '" & txt_sala03_hor5.Text & "' where sala = 3"
                db.Execute(UCase(sql))

                If cb_sala_04.Checked = True Then
                    statusSala = "disponivel"
                Else
                    statusSala = "indisponivel"
                End If
                sql = "update tb_salas set status = '" & statusSala & "', hor1 = '" & txt_sala04_hor1.Text & "', hor2 = '" & txt_sala04_hor2.Text & "', hor3 = '" & txt_sala04_hor3.Text & "', hor4 = '" & txt_sala04_hor4.Text & "', hor5 = '" & txt_sala04_hor5.Text & "' where sala = 4"
                db.Execute(UCase(sql))

                MsgBox("Disponibilidade das salas gravada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_disponibilidade_salas()
            Catch ex As Exception
                MsgBox("Erro ao gravar informações das salas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        ElseIf tab_configurar_filmes.SelectedIndex = 0 Then
            Try
                If cmb_filmes.Text = "" Or cmb_salas.Text = "" Then
                    MsgBox("Selecione um filme e uma sala!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    If cb_horario1.Checked = True And cb_horario1.Enabled = True Then
                        sql = "select id_sessao, id_filme, data, sala, horario from tb_sessoes where id_filme = " & id_filme & "" &
                                                                                                               " and data = '" & data & "'" &
                                                                                                               " and sala = " & cmb_salas.Text & "" &
                                                                                                               " and horario = '" & cb_horario1.Text & "'"
                        rs = db.Execute(UCase(sql))
                        If rs.EOF = True Then
                            sql = "select id_sessao from tb_sessoes"
                            rs = db.Execute(UCase(sql))
                            cont = 0
                            While rs.EOF = False
                                cont = cont + 1
                                rs.MoveNext()
                            End While
                            sql = "insert into tb_sessoes (id_sessao, id_filme, data, sala, horario, confirmado) " &
                                          "values (" & cont & ", " & id_filme & ", '" & data & "', " & cmb_salas.Text & ", '" & cb_horario1.Text & "', 1)"
                            rs = db.Execute(UCase(sql))
                        Else
                            sql = "update tb_sessoes set confirmado = 1 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario1.Text & "'"
                            rs = db.Execute(UCase(sql))
                        End If
                    Else
                        sql = "update tb_sessoes set confirmado = 0 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario1.Text & "'"
                        rs = db.Execute(UCase(sql))
                    End If
                    If cb_horario2.Checked = True And cb_horario2.Enabled = True Then
                        sql = "select id_sessao, id_filme, data, sala, horario from tb_sessoes where id_filme = " & id_filme & "" &
                                                                                                               " and data = '" & data & "'" &
                                                                                                               " and sala = " & cmb_salas.Text & "" &
                                                                                                               " and horario = '" & cb_horario2.Text & "'"
                        rs = db.Execute(UCase(sql))
                        If rs.EOF = True Then
                            sql = "select id_sessao from tb_sessoes"
                            rs = db.Execute(UCase(sql))
                            cont = 0
                            While rs.EOF = False
                                cont = cont + 1
                                rs.MoveNext()
                            End While
                            sql = "insert into tb_sessoes (id_sessao, id_filme, data, sala, horario, confirmado) " &
                                          "values (" & cont & ", " & id_filme & ", '" & data & "', " & cmb_salas.Text & ", '" & cb_horario2.Text & "', 1)"
                            rs = db.Execute(UCase(sql))
                        Else
                            sql = "update tb_sessoes set confirmado = 1 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario2.Text & "'"
                            rs = db.Execute(UCase(sql))
                        End If
                    Else
                        sql = "update tb_sessoes set confirmado = 0 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario2.Text & "'"
                        rs = db.Execute(UCase(sql))
                    End If
                    If cb_horario3.Checked = True And cb_horario3.Enabled = True Then
                        sql = "select id_sessao, id_filme, data, sala, horario from tb_sessoes where id_filme = " & id_filme & "" &
                                                                                                               " and data = '" & data & "'" &
                                                                                                               " and sala = " & cmb_salas.Text & "" &
                                                                                                               " and horario = '" & cb_horario3.Text & "'"
                        rs = db.Execute(UCase(sql))
                        If rs.EOF = True Then
                            sql = "select id_sessao from tb_sessoes"
                            rs = db.Execute(UCase(sql))
                            cont = 0
                            While rs.EOF = False
                                cont = cont + 1
                                rs.MoveNext()
                            End While
                            sql = "insert into tb_sessoes (id_sessao, id_filme, data, sala, horario, confirmado) " &
                                          "values (" & cont & ", " & id_filme & ", '" & data & "', " & cmb_salas.Text & ", '" & cb_horario3.Text & "', 1)"
                            rs = db.Execute(UCase(sql))
                        Else
                            sql = "update tb_sessoes set confirmado = 1 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario3.Text & "'"
                            rs = db.Execute(UCase(sql))
                        End If
                    Else
                        sql = "update tb_sessoes set confirmado = 0 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario3.Text & "'"
                        rs = db.Execute(UCase(sql))
                    End If
                    If cb_horario4.Checked = True And cb_horario4.Enabled = True Then
                        sql = "select id_sessao, id_filme, data, sala, horario from tb_sessoes where id_filme = " & id_filme & "" &
                                                                                                               " and data = '" & data & "'" &
                                                                                                               " and sala = " & cmb_salas.Text & "" &
                                                                                                               " and horario = '" & cb_horario4.Text & "'"
                        rs = db.Execute(UCase(sql))
                        If rs.EOF = True Then
                            sql = "select id_sessao from tb_sessoes"
                            rs = db.Execute(UCase(sql))
                            cont = 0
                            While rs.EOF = False
                                cont = cont + 1
                                rs.MoveNext()
                            End While
                            sql = "insert into tb_sessoes (id_sessao, id_filme, data, sala, horario, confirmado) " &
                                          "values (" & cont & ", " & id_filme & ", '" & data & "', " & cmb_salas.Text & ", '" & cb_horario4.Text & "', 1)"
                            rs = db.Execute(UCase(sql))
                        Else
                            sql = "update tb_sessoes set confirmado = 1 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario4.Text & "'"
                            rs = db.Execute(UCase(sql))
                        End If
                    Else
                        sql = "update tb_sessoes set confirmado = 0 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario4.Text & "'"
                        rs = db.Execute(UCase(sql))
                    End If
                    If cb_horario5.Checked = True And cb_horario5.Enabled = True Then
                        sql = "select id_sessao, id_filme, data, sala, horario from tb_sessoes where id_filme = " & id_filme & "" &
                                                                                                               " and data = '" & data & "'" &
                                                                                                               " and sala = " & cmb_salas.Text & "" &
                                                                                                               " and horario = '" & cb_horario5.Text & "'"
                        rs = db.Execute(UCase(sql))
                        If rs.EOF = True Then
                            sql = "select id_sessao from tb_sessoes"
                            rs = db.Execute(UCase(sql))
                            cont = 0
                            While rs.EOF = False
                                cont = cont + 1
                                rs.MoveNext()
                            End While
                            sql = "insert into tb_sessoes (id_sessao, id_filme, data, sala, horario, confirmado) " &
                                          "values (" & cont & ", " & id_filme & ", '" & data & "', " & cmb_salas.Text & ", '" & cb_horario5.Text & "', 1)"
                            rs = db.Execute(UCase(sql))
                        Else
                            sql = "update tb_sessoes set confirmado = 1 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario5.Text & "'"
                            rs = db.Execute(UCase(sql))
                        End If
                    Else
                        sql = "update tb_sessoes set confirmado = 0 where id_filme = " & id_filme & " and data = '" & data & "' and sala = " & cmb_salas.Text & " and horario = '" & cb_horario5.Text & "'"
                        rs = db.Execute(UCase(sql))
                    End If
                    MsgBox("Programação atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Catch ex As Exception
                MsgBox("Erro ao atualizar a programação!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txt_titulo_DoubleClick(sender As Object, e As EventArgs) Handles txt_titulo.DoubleClick
        limpar_filme()
    End Sub

    Private Sub txt_titulo_LostFocus(sender As Object, e As EventArgs) Handles txt_titulo.LostFocus
        Try
            sql = "Select * from tb_filmes where titulo = '" & txt_titulo.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = True Then
                txt_preco.Focus()
            Else
                txt_titulo.Text = rs.Fields(1).Value
                txt_preco.Text = rs.Fields(2).Value
                diretorio = rs.Fields(3).Value
                Try
                    img_poster.Load(diretorio)
                Catch ex As Exception
                    MsgBox("Erro ao carregar pôster", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End Try

                If rs.Fields(4).Value = "SIM" Then
                    rb_sim.Checked = True
                    rb_nao.Checked = False
                Else
                    rb_sim.Checked = False
                    rb_nao.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar informações do filme", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cb_somente_cartaz_CheckedChanged(sender As Object, e As EventArgs) Handles cb_somente_cartaz.CheckedChanged
        carregar_dados_filme()
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        sql = "select id_filme, titulo, preco, em_cartaz from tb_filmes where titulo like '%" & txt_pesquisa.Text & "%' order by titulo asc"
        rs = db.Execute(UCase(sql))
        With dgv_filmes
            .Rows.Clear()
            Do While rs.EOF = False
                If cb_somente_cartaz.Checked = False Then
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                Else
                    If rs.Fields(3).Value = "SIM" Then
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                    End If
                End If
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub dgv_filmes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_filmes.CellContentClick
        Try
            With dgv_filmes
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_titulo = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_filmes where titulo = '" & aux_titulo & "'"
                    rs = db.Execute(UCase(sql))
                    If rs.EOF = False Then
                        tab_configurar_filmes.SelectTab(2)
                        txt_titulo.Text = rs.Fields(1).Value
                        txt_preco.Text = rs.Fields(2).Value
                        diretorio = rs.Fields(3).Value
                        Try
                            img_poster.Load(diretorio)
                        Catch ex As Exception
                            MsgBox("Erro ao carregar pôster", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        End Try

                        If rs.Fields(4).Value = "SIM" Then
                            rb_sim.Checked = True
                            rb_nao.Checked = False
                        Else
                            rb_sim.Checked = False
                            rb_nao.Checked = True
                        End If
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar informações do filme", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cb_sala_01_CheckedChanged(sender As Object, e As EventArgs) Handles cb_sala_01.CheckedChanged
        If cb_sala_01.Checked = False Then
            txt_sala01_hor1.Enabled = False
            txt_sala01_hor2.Enabled = False
            txt_sala01_hor3.Enabled = False
            txt_sala01_hor4.Enabled = False
            txt_sala01_hor5.Enabled = False
        Else
            txt_sala01_hor1.Enabled = True
            txt_sala01_hor2.Enabled = True
            txt_sala01_hor3.Enabled = True
            txt_sala01_hor4.Enabled = True
            txt_sala01_hor5.Enabled = True
        End If
    End Sub

    Private Sub cb_sala_02_CheckedChanged(sender As Object, e As EventArgs) Handles cb_sala_02.CheckedChanged
        If cb_sala_02.Checked = False Then
            txt_sala02_hor1.Enabled = False
            txt_sala02_hor2.Enabled = False
            txt_sala02_hor3.Enabled = False
            txt_sala02_hor4.Enabled = False
            txt_sala02_hor5.Enabled = False
        Else
            txt_sala02_hor1.Enabled = True
            txt_sala02_hor2.Enabled = True
            txt_sala02_hor3.Enabled = True
            txt_sala02_hor4.Enabled = True
            txt_sala02_hor5.Enabled = True
        End If
    End Sub

    Private Sub cb_sala_03_CheckedChanged(sender As Object, e As EventArgs) Handles cb_sala_03.CheckedChanged
        If cb_sala_03.Checked = False Then
            txt_sala03_hor1.Enabled = False
            txt_sala03_hor2.Enabled = False
            txt_sala03_hor3.Enabled = False
            txt_sala03_hor4.Enabled = False
            txt_sala03_hor5.Enabled = False
        Else
            txt_sala03_hor1.Enabled = True
            txt_sala03_hor2.Enabled = True
            txt_sala03_hor3.Enabled = True
            txt_sala03_hor4.Enabled = True
            txt_sala03_hor5.Enabled = True
        End If
    End Sub

    Private Sub cb_sala_04_CheckedChanged(sender As Object, e As EventArgs) Handles cb_sala_04.CheckedChanged
        If cb_sala_04.Checked = False Then
            txt_sala04_hor1.Enabled = False
            txt_sala04_hor2.Enabled = False
            txt_sala04_hor3.Enabled = False
            txt_sala04_hor4.Enabled = False
            txt_sala04_hor5.Enabled = False
        Else
            txt_sala04_hor1.Enabled = True
            txt_sala04_hor2.Enabled = True
            txt_sala04_hor3.Enabled = True
            txt_sala04_hor4.Enabled = True
            txt_sala04_hor5.Enabled = True
        End If
    End Sub

    Private Sub cmb_filmes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filmes.SelectedIndexChanged
        Try
            sql = "select id_filme from tb_filmes where titulo = '" & cmb_filmes.Text & "'"
            rs = db.Execute(UCase(sql))
            id_filme = rs.Fields(0).Value
        Catch ex As Exception
            MsgBox("Erro ao buscar informações do filme", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        cb_horario1.Enabled = True
        cb_horario2.Enabled = True
        cb_horario3.Enabled = True
        cb_horario4.Enabled = True
        cb_horario5.Enabled = True
        If cmb_salas.Text <> "" Then
            conferir_salas()
        End If
    End Sub

    Private Sub dtp_data_ValueChanged(sender As Object, e As EventArgs) Handles dtp_data.ValueChanged
        Try
            data = dtp_data.Value.Date
            If cmb_filmes.Text <> "" And cmb_salas.Text <> "" Then
                conferir_salas()
            End If
        Catch ex As Exception
            MsgBox("deu ruim no dtp_data")
        End Try
    End Sub

    Private Sub cmb_salas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_salas.SelectedIndexChanged
        limpar_salas()
        Try
            If cmb_salas.Text <> "" Then
                sql = "select hor1, hor2, hor3, hor4, hor5 from tb_salas where sala = " & cmb_salas.Text & ""
                rs = db.Execute(UCase(sql))
                cb_horario1.Text = rs.Fields(0).Value
                cb_horario2.Text = rs.Fields(1).Value
                cb_horario3.Text = rs.Fields(2).Value
                cb_horario4.Text = rs.Fields(3).Value
                cb_horario5.Text = rs.Fields(4).Value
            Else
                cb_horario1.Text = ""
                cb_horario2.Text = ""
                cb_horario3.Text = ""
                cb_horario4.Text = ""
                cb_horario5.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar informações da sala", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            sql = "select horario, confirmado from tb_sessoes where id_filme = " & id_filme & "" &
                                                  " and data = '" & data & "'" &
                                                  " and sala = " & cmb_salas.Text & ""
            rs = db.Execute(UCase(sql))
            While rs.EOF = False
                If rs.Fields(1).Value = 1 Then
                    If rs.Fields(0).Value = cb_horario1.Text Then
                        cb_horario1.Checked = True
                    End If
                    If rs.Fields(0).Value = cb_horario2.Text Then
                        cb_horario2.Checked = True
                    End If
                    If rs.Fields(0).Value = cb_horario3.Text Then
                        cb_horario3.Checked = True
                    End If
                    If rs.Fields(0).Value = cb_horario4.Text Then
                        cb_horario4.Checked = True
                    End If
                    If rs.Fields(0).Value = cb_horario5.Text Then
                        cb_horario5.Checked = True
                    End If
                End If
                rs.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("Erro ao checar disponibilidade das salas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            If cmb_filmes.Text <> "" Then
                conferir_salas()
            End If
        Catch ex As Exception
            MsgBox("Erro ao limpar salas")
        End Try
    End Sub

    Sub tab_configurar_filmes_SelectedIndexChanged() Handles tab_configurar_filmes.SelectedIndexChanged
        If tab_configurar_filmes.SelectedIndex = 3 Or tab_configurar_filmes.SelectedIndex = 1 Then
            btn_salvar.Enabled = False
        Else
            btn_salvar.Enabled = True
        End If
    End Sub

    Private Sub dgv_sessoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_sessoes.CellContentClick
        Try
            With dgv_sessoes
                If .CurrentRow.Cells(3).Selected = True Then
                    sql = "select id_filme from tb_filmes where titulo = '" & cmb_filmes_sessoes.Text & "'"
                    rs = db.Execute(UCase(sql))
                    If rs.EOF = False Then
                        sql = "select data, sala from tb_sessoes where id_filme = " & rs.Fields(0).Value & " and data = " & .CurrentRow.Cells(0).Value & " and sala = " & .CurrentRow.Cells(1).Value & " and confirmado = 1 order by data asc"
                        rs = db.Execute(UCase(sql))
                        tab_configurar_filmes.SelectTab(0)
                        cmb_filmes.Text = cmb_filmes_sessoes.Text
                        dtp_data.Value = Convert.ToDateTime(.CurrentRow.Cells(0).Value)
                        cmb_salas.Text = .CurrentRow.Cells(1).Value
                        carregar_cmb_filmes_sessoes()
                        .Rows.Clear()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao transferir informações da sessão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cmb_filmes_sessoes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filmes_sessoes.SelectedIndexChanged
        Try
            sql = "select id_filme from tb_filmes where titulo = '" & cmb_filmes_sessoes.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                sql = "select data, sala, horario from tb_sessoes where id_filme = " & rs.Fields(0).Value & " and data >= '" & Now.ToString("dd/MM/yyyy") & "' and horario >= '" & Now.ToString("HH:mm") & "' and confirmado = 1 order by data asc"
                rs = db.Execute(UCase(sql))
                dgv_sessoes.Rows.Clear()
                If rs.EOF = False Then
                    With dgv_sessoes
                        .Rows.Clear()
                        data = rs.Fields(0).Value
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing)
                        While rs.EOF = False
                            If rs.Fields(0).Value <> data Then
                                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing)
                                data = rs.Fields(0).Value
                            End If
                            rs.MoveNext()
                        End While
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar sessões", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class