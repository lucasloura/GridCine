Module mod_geral
    'Variavel para o formulario de assento
    Public assentos As String
    Public qtde_assentos, id_sessao, tp_ingresso As Integer
    Public preco_ingresso As Double

    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql, sql_aux As String
    Public nome, cargo, tipo_conta, status, aux_cpf, resp As String
    Public cont, cont_aux, id_filme, sala, metPagto As Integer
    Public aux_titulo, statusSala, data As String
    Public banco = Application.StartupPath & "\banco_de_dados\bd_bilheteria.mdb"
    'Variável para o formulário do operador
    Public titulo, poster, horario, em_cartaz As String
    Public id_conta As Integer
    'Variável para a troca de temas
    Public tema, corPrm, corSec

    Sub conectar_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & banco)
            'MsgBox("Conexao feita com o banco!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            'MsgBox("Nao foi possivel conectar ao Banco de Dados", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atençao")
        End Try

    End Sub

    Sub limpar_cadastro()
        Try
            With frm_configurar_contas
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_email.Clear()
                .txt_senha.Clear()
                .rb_operador.Checked = False
                .rb_gerente.Checked = False
                .rb_ativo.Checked = False
                .rb_bloqueado.Checked = False
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub limpar_login()
        Try
            With frm_login
                .txt_cpf.Clear()
                .txt_senha.Clear()
                .txt_cpf.Focus()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub carregar_dados()
        Try
            sql = "select cpf, nome, tipo_conta, status from tb_funcionarios order by nome asc"
            rs = db.Execute(sql)
            With frm_configurar_contas.dgv_contas
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados na listagem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_filme()
        Try
            diretorio = ""
            With checar_filmes
                .img_poster.Load(Application.StartupPath & "\icones\poster_novo.png")
                .txt_titulo.Clear()
                .txt_preco.Clear()
                .rb_sim.Checked = False
                .rb_nao.Checked = False
                .txt_titulo.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar filme!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dados_filme()
        Try
            sql = "select id_filme, titulo, preco, em_cartaz from tb_filmes order by id_filme asc"
            rs = db.Execute(UCase(sql))
            With checar_filmes.dgv_filmes
                .Rows.Clear()
                Do While rs.EOF = False
                    If checar_filmes.cb_somente_cartaz.Checked = False Then
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                    Else
                        If rs.Fields(3).Value = "SIM" Then
                            .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                        End If
                    End If
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception

        End Try

    End Sub

    Sub carregar_disponibilidade_salas()
        Try
            sql = "select status, hor1, hor2, hor3, hor4, hor5 from tb_salas"
            rs = db.Execute(UCase(sql))
            With checar_filmes
                .txt_sala01_hor1.Text = rs.Fields(1).Value
                .txt_sala01_hor2.Text = rs.Fields(2).Value
                .txt_sala01_hor3.Text = rs.Fields(3).Value
                .txt_sala01_hor4.Text = rs.Fields(4).Value
                .txt_sala01_hor5.Text = rs.Fields(5).Value
                If rs.Fields(0).Value = "DISPONIVEL" Then
                    .cb_sala_01.Checked = True
                Else
                    .cb_sala_01.Checked = False
                End If
                rs.MoveNext()
                .txt_sala02_hor1.Text = rs.Fields(1).Value
                .txt_sala02_hor2.Text = rs.Fields(2).Value
                .txt_sala02_hor3.Text = rs.Fields(3).Value
                .txt_sala02_hor4.Text = rs.Fields(4).Value
                .txt_sala02_hor5.Text = rs.Fields(5).Value
                If rs.Fields(0).Value = "DISPONIVEL" Then
                    .cb_sala_02.Checked = True
                Else
                    .cb_sala_02.Checked = False
                End If
                rs.MoveNext()
                .txt_sala03_hor1.Text = rs.Fields(1).Value
                .txt_sala03_hor2.Text = rs.Fields(2).Value
                .txt_sala03_hor3.Text = rs.Fields(3).Value
                .txt_sala03_hor4.Text = rs.Fields(4).Value
                .txt_sala03_hor5.Text = rs.Fields(5).Value
                If rs.Fields(0).Value = "DISPONIVEL" Then
                    .cb_sala_03.Checked = True
                Else
                    .cb_sala_03.Checked = False
                End If
                rs.MoveNext()
                .txt_sala04_hor1.Text = rs.Fields(1).Value
                .txt_sala04_hor2.Text = rs.Fields(2).Value
                .txt_sala04_hor3.Text = rs.Fields(3).Value
                .txt_sala04_hor4.Text = rs.Fields(4).Value
                .txt_sala04_hor5.Text = rs.Fields(5).Value
                If rs.Fields(0).Value = "DISPONIVEL" Then
                    .cb_sala_04.Checked = True
                Else
                    .cb_sala_04.Checked = False
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar a disponibilidade das salas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cmb_filmes()
        Try
            sql = "select titulo, em_cartaz from tb_filmes"
            rs = db.Execute(UCase(sql))
            With checar_filmes.cmb_filmes
                .Items.Clear()
                While rs.EOF = False
                    If rs.Fields(1).Value = "SIM" Then
                        .Items.Add(rs.Fields(0).Value)
                    End If
                    rs.MoveNext()
                End While
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar cmb_filmes", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cmb_salas()
        Try
            sql = "select sala from tb_salas"
            rs = db.Execute(UCase(sql))
            With checar_filmes.cmb_salas
                .Items.Clear()
                While rs.EOF = False
                    .Items.Add(rs.Fields(0).Value)
                    rs.MoveNext()
                End While
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar cmb_filmes", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_salas()
        With checar_filmes
            .cb_horario1.Checked = False
            .cb_horario2.Checked = False
            .cb_horario3.Checked = False
            .cb_horario4.Checked = False
            .cb_horario5.Checked = False
            .cb_horario1.Enabled = True
            .cb_horario2.Enabled = True
            .cb_horario3.Enabled = True
            .cb_horario4.Enabled = True
            .cb_horario5.Enabled = True
        End With
    End Sub

    Sub conferir_salas()
        Try
            With checar_filmes
                sql = "select id_filme, horario, confirmado from tb_sessoes where data = '" & data & "' and sala = " & .cmb_salas.Text & ""
                rs = db.Execute(UCase(sql))
                While rs.EOF = False
                    If rs.Fields(0).Value <> id_filme And rs.Fields(2).Value = 1 Then
                        If rs.Fields(1).Value = .cb_horario1.Text Then
                            .cb_horario1.Checked = True
                            .cb_horario1.Enabled = False
                        End If
                        If rs.Fields(1).Value = .cb_horario2.Text Then
                            .cb_horario2.Checked = True
                            .cb_horario2.Enabled = False
                        End If
                        If rs.Fields(1).Value = .cb_horario3.Text Then
                            .cb_horario3.Checked = True
                            .cb_horario3.Enabled = False
                        End If
                        If rs.Fields(1).Value = .cb_horario4.Text Then
                            .cb_horario4.Checked = True
                            .cb_horario4.Enabled = False
                        End If
                        If rs.Fields(1).Value = .cb_horario5.Text Then
                            .cb_horario5.Checked = True
                            .cb_horario5.Enabled = False
                        End If
                    End If
                    rs.MoveNext()
                End While
            End With
        Catch ex As Exception
            MsgBox("Erro ao conferir salas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cmb_filmes_sessoes()
        Try
            sql = "select titulo, em_cartaz from tb_filmes"
            rs = db.Execute(UCase(sql))
            With checar_filmes.cmb_filmes_sessoes
                .Items.Clear()
                While rs.EOF = False
                    If rs.Fields(1).Value = "SIM" Then
                        .Items.Add(rs.Fields(0).Value)
                    End If
                    rs.MoveNext()
                End While
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar cmb_filmes_sessoes", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub buscar_titulo()
        Try
            sql_aux = "select titulo from tb_filmes where id_filme = " & id_filme & ""
            rs = db.Execute(UCase(sql_aux))
            If rs.EOF = False Then
                frm_operador.btn_titulo.Text = rs.Fields(0).Value
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar título do filme", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub buscar_poster()
        Try
            sql_aux = "select poster from tb_filmes where id_filme = " & id_filme & ""
            rs = db.Execute(UCase(sql_aux))
            If rs.EOF = False Then
                frm_operador.img_poster_operador.Load(rs.Fields(0).Value)
            End If
        Catch ex As Exception
            '           MsgBox("Erro ao carregar poster do filme", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cmb_filmes_pedido()
        Try
            sql = "select titulo from tb_filmes where em_cartaz = 'SIM'"
            rs = db.Execute(UCase(sql))
            With frm_realizar_pedido.cmb_filmes_pedido
                .Items.Clear()
                While rs.EOF = False
                    .Items.Add(rs.Fields(0).Value)
                    rs.MoveNext()
                End While
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar cmb_filmes_pedido", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_sessao()
        With frm_sessao
            .btn_A1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A1.Enabled = False
            .btn_A2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A2.Enabled = False
            .btn_A3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A3.Enabled = False
            .btn_A4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A4.Enabled = False
            .btn_A5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A5.Enabled = False
            .btn_A6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A6.Enabled = False
            .btn_A7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A7.Enabled = False
            .btn_A8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A8.Enabled = False
            .btn_A9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A9.Enabled = False
            .btn_A10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A10.Enabled = False
            .btn_A11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A11.Enabled = False
            .btn_A12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_A12.Enabled = False
            .btn_B1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B1.Enabled = False
            .btn_B2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B2.Enabled = False
            .btn_B3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B3.Enabled = False
            .btn_B4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B4.Enabled = False
            .btn_B5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B5.Enabled = False
            .btn_B6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B6.Enabled = False
            .btn_B7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B7.Enabled = False
            .btn_B8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B8.Enabled = False
            .btn_B9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B9.Enabled = False
            .btn_B10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B10.Enabled = False
            .btn_B11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B11.Enabled = False
            .btn_B12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_B12.Enabled = False
            .btn_C1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C1.Enabled = False
            .btn_C2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C2.Enabled = False
            .btn_C3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C3.Enabled = False
            .btn_C4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C4.Enabled = False
            .btn_C5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C5.Enabled = False
            .btn_C6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C6.Enabled = False
            .btn_C7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C7.Enabled = False
            .btn_C8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C8.Enabled = False
            .btn_C9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C9.Enabled = False
            .btn_C10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C10.Enabled = False
            .btn_C11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C11.Enabled = False
            .btn_C12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_C12.Enabled = False
            .btn_D1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D1.Enabled = False
            .btn_D2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D2.Enabled = False
            .btn_D3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D3.Enabled = False
            .btn_D4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D4.Enabled = False
            .btn_D5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D5.Enabled = False
            .btn_D6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D6.Enabled = False
            .btn_D7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D7.Enabled = False
            .btn_D8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D8.Enabled = False
            .btn_D9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D9.Enabled = False
            .btn_D10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D10.Enabled = False
            .btn_D11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D11.Enabled = False
            .btn_D12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_D12.Enabled = False
            .btn_E2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E2.Enabled = False
            .btn_E3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E3.Enabled = False
            .btn_E4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E4.Enabled = False
            .btn_E5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E5.Enabled = False
            .btn_E6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E6.Enabled = False
            .btn_E7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E7.Enabled = False
            .btn_E8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E8.Enabled = False
            .btn_E9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E9.Enabled = False
            .btn_E10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E10.Enabled = False
            .btn_E11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_indisponivel.png")
            .btn_E11.Enabled = False
        End With
    End Sub

    Sub consultar_sessao()
        sql = "select a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12," &
                     "b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12," &
                     "c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12," &
                     "d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12," &
                         "e2, e3, e4, e5, e6, e7, e8, e9, e10, e11 " &
              "from tb_sessoes where id_sessao = " & id_sessao & ""
        rs = db.Execute(UCase(sql))
        If rs.EOF = False Then
            assentos = ""
            cont = 0
            With frm_sessao
                If rs.Fields(0).Value = 0 Then
                    .btn_A1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A1.Enabled = True
                    .btn_A1.BackColor = Color.Black
                ElseIf rs.Fields(0).Value = 1 Then
                    .btn_A1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A1.Enabled = True
                    .btn_A1.BackColor = Color.Empty
                    assentos = assentos + "A1 "
                    cont = cont + 1
                End If
                If rs.Fields(1).Value = 0 Then
                    .btn_A2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A2.Enabled = True
                    .btn_A2.BackColor = Color.Black
                ElseIf rs.Fields(1).Value = 1 Then
                    .btn_A2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A2.Enabled = True
                    .btn_A2.BackColor = Color.Empty
                    assentos = assentos + "A2 "
                    cont = cont + 1
                End If
                If rs.Fields(2).Value = 0 Then
                    .btn_A3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A3.Enabled = True
                    .btn_A3.BackColor = Color.Black
                ElseIf rs.Fields(2).Value = 1 Then
                    .btn_A3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A3.Enabled = True
                    .btn_A3.BackColor = Color.Empty
                    assentos = assentos + "A3 "
                    cont = cont + 1
                End If
                If rs.Fields(3).Value = 0 Then
                    .btn_A4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A4.Enabled = True
                    .btn_A4.BackColor = Color.Black
                ElseIf rs.Fields(3).Value = 1 Then
                    .btn_A4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A4.Enabled = True
                    .btn_A4.BackColor = Color.Empty
                    assentos = assentos + "A4 "
                    cont = cont + 1
                End If
                If rs.Fields(4).Value = 0 Then
                    .btn_A5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A5.Enabled = True
                    .btn_A5.BackColor = Color.Black
                ElseIf rs.Fields(4).Value = 1 Then
                    .btn_A5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A5.Enabled = True
                    .btn_A5.BackColor = Color.Empty
                    assentos = assentos + "A5 "
                    cont = cont + 1
                End If
                If rs.Fields(5).Value = 0 Then
                    .btn_A6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A6.Enabled = True
                    .btn_A6.BackColor = Color.Black
                ElseIf rs.Fields(5).Value = 1 Then
                    .btn_A6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A6.Enabled = True
                    .btn_A6.BackColor = Color.Empty
                    assentos = assentos + "A6 "
                    cont = cont + 1
                End If
                If rs.Fields(6).Value = 0 Then
                    .btn_A7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A7.Enabled = True
                    .btn_A7.BackColor = Color.Black
                ElseIf rs.Fields(6).Value = 1 Then
                    .btn_A7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A7.Enabled = True
                    .btn_A7.BackColor = Color.Empty
                    assentos = assentos + "A7 "
                    cont = cont + 1
                End If
                If rs.Fields(7).Value = 0 Then
                    .btn_A8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A8.Enabled = True
                    .btn_A8.BackColor = Color.Black
                ElseIf rs.Fields(7).Value = 1 Then
                    .btn_A8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A8.Enabled = True
                    .btn_A8.BackColor = Color.Empty
                    assentos = assentos + "A8 "
                    cont = cont + 1
                End If
                If rs.Fields(8).Value = 0 Then
                    .btn_A9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A9.Enabled = True
                    .btn_A9.BackColor = Color.Black
                ElseIf rs.Fields(8).Value = 1 Then
                    .btn_A9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A9.Enabled = True
                    .btn_A9.BackColor = Color.Empty
                    assentos = assentos + "A9 "
                    cont = cont + 1
                End If
                If rs.Fields(9).Value = 0 Then
                    .btn_A10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A10.Enabled = True
                    .btn_A10.BackColor = Color.Black
                ElseIf rs.Fields(9).Value = 1 Then
                    .btn_A10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A10.Enabled = True
                    .btn_A10.BackColor = Color.Empty
                    assentos = assentos + "A10 "
                    cont = cont + 1
                End If
                If rs.Fields(10).Value = 0 Then
                    .btn_A11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A11.Enabled = True
                    .btn_A11.BackColor = Color.Black
                ElseIf rs.Fields(10).Value = 1 Then
                    .btn_A11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A11.Enabled = True
                    .btn_A11.BackColor = Color.Empty
                    assentos = assentos + "A11 "
                    cont = cont + 1
                End If
                If rs.Fields(11).Value = 0 Then
                    .btn_A12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_A12.Enabled = True
                    .btn_A12.BackColor = Color.Black
                ElseIf rs.Fields(11).Value = 1 Then
                    .btn_A12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_A12.Enabled = True
                    .btn_A12.BackColor = Color.Empty
                    assentos = assentos + "A12 "
                    cont = cont + 1
                End If
                '
                If rs.Fields(12).Value = 0 Then
                    .btn_B1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B1.Enabled = True
                    .btn_B1.BackColor = Color.Black
                ElseIf rs.Fields(12).Value = 1 Then
                    .btn_B1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B1.Enabled = True
                    .btn_B1.BackColor = Color.Empty
                    assentos = assentos + "B1 "
                    cont = cont + 1
                End If
                If rs.Fields(13).Value = 0 Then
                    .btn_B2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B2.Enabled = True
                    .btn_B2.BackColor = Color.Black
                ElseIf rs.Fields(13).Value = 1 Then
                    .btn_B2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B2.Enabled = True
                    .btn_B2.BackColor = Color.Empty
                    assentos = assentos + "B2 "
                    cont = cont + 1
                End If
                If rs.Fields(14).Value = 0 Then
                    .btn_B3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B3.Enabled = True
                    .btn_B3.BackColor = Color.Black
                ElseIf rs.Fields(14).Value = 1 Then
                    .btn_B3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B3.Enabled = True
                    .btn_B3.BackColor = Color.Empty
                    assentos = assentos + "B3 "
                    cont = cont + 1
                End If
                If rs.Fields(15).Value = 0 Then
                    .btn_B4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B4.Enabled = True
                    .btn_B4.BackColor = Color.Black
                ElseIf rs.Fields(15).Value = 1 Then
                    .btn_B4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B4.Enabled = True
                    .btn_B4.BackColor = Color.Empty
                    assentos = assentos + "B4 "
                    cont = cont + 1
                End If
                If rs.Fields(16).Value = 0 Then
                    .btn_B5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B5.Enabled = True
                    .btn_B5.BackColor = Color.Black
                ElseIf rs.Fields(16).Value = 1 Then
                    .btn_B5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B5.Enabled = True
                    .btn_B5.BackColor = Color.Empty
                    assentos = assentos + "B5 "
                    cont = cont + 1
                End If
                If rs.Fields(17).Value = 0 Then
                    .btn_B6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B6.Enabled = True
                    .btn_B6.BackColor = Color.Black
                ElseIf rs.Fields(17).Value = 1 Then
                    .btn_B6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B6.Enabled = True
                    .btn_B6.BackColor = Color.Empty
                    assentos = assentos + "B6 "
                    cont = cont + 1
                End If
                If rs.Fields(18).Value = 0 Then
                    .btn_B7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B7.Enabled = True
                    .btn_B7.BackColor = Color.Black
                ElseIf rs.Fields(18).Value = 1 Then
                    .btn_B7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B7.Enabled = True
                    .btn_B7.BackColor = Color.Empty
                    assentos = assentos + "B7 "
                    cont = cont + 1
                End If
                If rs.Fields(19).Value = 0 Then
                    .btn_B8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B8.Enabled = True
                    .btn_B8.BackColor = Color.Black
                ElseIf rs.Fields(19).Value = 1 Then
                    .btn_B8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B8.Enabled = True
                    .btn_B8.BackColor = Color.Empty
                    assentos = assentos + "B8 "
                    cont = cont + 1
                End If
                If rs.Fields(20).Value = 0 Then
                    .btn_B9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B9.Enabled = True
                    .btn_B9.BackColor = Color.Black
                ElseIf rs.Fields(20).Value = 1 Then
                    .btn_B9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B9.Enabled = True
                    .btn_B9.BackColor = Color.Empty
                    assentos = assentos + "B9 "
                    cont = cont + 1
                End If
                If rs.Fields(21).Value = 0 Then
                    .btn_B10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B10.Enabled = True
                    .btn_B10.BackColor = Color.Black
                ElseIf rs.Fields(21).Value = 1 Then
                    .btn_B10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B10.Enabled = True
                    .btn_B10.BackColor = Color.Empty
                    assentos = assentos + "B10 "
                    cont = cont + 1
                End If
                If rs.Fields(22).Value = 0 Then
                    .btn_B11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B11.Enabled = True
                    .btn_B11.BackColor = Color.Black
                ElseIf rs.Fields(22).Value = 1 Then
                    .btn_B11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B11.Enabled = True
                    .btn_B11.BackColor = Color.Empty
                    assentos = assentos + "B11 "
                    cont = cont + 1
                End If
                If rs.Fields(23).Value = 0 Then
                    .btn_B12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_B12.Enabled = True
                    .btn_B12.BackColor = Color.Black
                ElseIf rs.Fields(23).Value = 1 Then
                    .btn_B12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_B12.Enabled = True
                    .btn_B12.BackColor = Color.Empty
                    assentos = assentos + "B12 "
                    cont = cont + 1
                End If
                '
                If rs.Fields(24).Value = 0 Then
                    .btn_C1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C1.Enabled = True
                    .btn_C1.BackColor = Color.Black
                ElseIf rs.Fields(24).Value = 1 Then
                    .btn_C1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C1.Enabled = True
                    .btn_C1.BackColor = Color.Empty
                    assentos = assentos + "C1 "
                    cont = cont + 1
                End If
                If rs.Fields(25).Value = 0 Then
                    .btn_C2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C2.Enabled = True
                    .btn_C2.BackColor = Color.Black
                ElseIf rs.Fields(25).Value = 1 Then
                    .btn_C2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C2.Enabled = True
                    .btn_C2.BackColor = Color.Empty
                    assentos = assentos + "C2 "
                    cont = cont + 1
                End If
                If rs.Fields(26).Value = 0 Then
                    .btn_C3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C3.Enabled = True
                    .btn_C3.BackColor = Color.Black
                ElseIf rs.Fields(26).Value = 1 Then
                    .btn_C3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C3.Enabled = True
                    .btn_C3.BackColor = Color.Empty
                    assentos = assentos + "C3 "
                    cont = cont + 1
                End If
                If rs.Fields(27).Value = 0 Then
                    .btn_C4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C4.Enabled = True
                    .btn_C4.BackColor = Color.Black
                ElseIf rs.Fields(27).Value = 1 Then
                    .btn_C4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C4.Enabled = True
                    .btn_C4.BackColor = Color.Empty
                    assentos = assentos + "C4 "
                    cont = cont + 1
                End If
                If rs.Fields(28).Value = 0 Then
                    .btn_C5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C5.Enabled = True
                    .btn_C5.BackColor = Color.Black
                ElseIf rs.Fields(28).Value = 1 Then
                    .btn_C5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C5.Enabled = True
                    .btn_C5.BackColor = Color.Empty
                    assentos = assentos + "C5 "
                    cont = cont + 1
                End If
                If rs.Fields(29).Value = 0 Then
                    .btn_C6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C6.Enabled = True
                    .btn_C6.BackColor = Color.Black
                ElseIf rs.Fields(29).Value = 1 Then
                    .btn_C6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C6.Enabled = True
                    .btn_C6.BackColor = Color.Empty
                    assentos = assentos + "C6 "
                    cont = cont + 1
                End If
                If rs.Fields(30).Value = 0 Then
                    .btn_C7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C7.Enabled = True
                    .btn_C7.BackColor = Color.Black
                ElseIf rs.Fields(30).Value = 1 Then
                    .btn_C7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C7.Enabled = True
                    .btn_C7.BackColor = Color.Empty
                    assentos = assentos + "C7 "
                    cont = cont + 1
                End If
                If rs.Fields(31).Value = 0 Then
                    .btn_C8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C8.Enabled = True
                    .btn_C8.BackColor = Color.Black
                ElseIf rs.Fields(31).Value = 1 Then
                    .btn_C8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C8.Enabled = True
                    .btn_C8.BackColor = Color.Empty
                    assentos = assentos + "C8 "
                    cont = cont + 1
                End If
                If rs.Fields(32).Value = 0 Then
                    .btn_C9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C9.Enabled = True
                    .btn_C9.BackColor = Color.Black
                ElseIf rs.Fields(32).Value = 1 Then
                    .btn_C9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C9.Enabled = True
                    .btn_C9.BackColor = Color.Empty
                    assentos = assentos + "C9 "
                    cont = cont + 1
                End If
                If rs.Fields(33).Value = 0 Then
                    .btn_C10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C10.Enabled = True
                    .btn_C10.BackColor = Color.Black
                ElseIf rs.Fields(33).Value = 1 Then
                    .btn_C10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C10.Enabled = True
                    .btn_C10.BackColor = Color.Empty
                    assentos = assentos + "C10 "
                    cont = cont + 1
                End If
                If rs.Fields(34).Value = 0 Then
                    .btn_C11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C11.Enabled = True
                    .btn_C11.BackColor = Color.Black
                ElseIf rs.Fields(34).Value = 1 Then
                    .btn_C11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C11.Enabled = True
                    .btn_C11.BackColor = Color.Empty
                    assentos = assentos + "C11 "
                    cont = cont + 1
                End If
                If rs.Fields(35).Value = 0 Then
                    .btn_C12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_C12.Enabled = True
                    .btn_C12.BackColor = Color.Black
                ElseIf rs.Fields(35).Value = 1 Then
                    .btn_C12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_C12.Enabled = True
                    .btn_C12.BackColor = Color.Empty
                    assentos = assentos + "C12 "
                    cont = cont + 1
                End If
                '
                If rs.Fields(36).Value = 0 Then
                    .btn_D1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D1.Enabled = True
                    .btn_D1.BackColor = Color.Black
                ElseIf rs.Fields(36).Value = 1 Then
                    .btn_D1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D1.Enabled = True
                    .btn_D1.BackColor = Color.Empty
                    assentos = assentos + "D1 "
                    cont = cont + 1
                End If
                If rs.Fields(37).Value = 0 Then
                    .btn_D2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D2.Enabled = True
                    .btn_D2.BackColor = Color.Black
                ElseIf rs.Fields(37).Value = 1 Then
                    .btn_D2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D2.Enabled = True
                    .btn_D2.BackColor = Color.Empty
                    assentos = assentos + "D2 "
                    cont = cont + 1
                End If
                If rs.Fields(38).Value = 0 Then
                    .btn_D3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D3.Enabled = True
                    .btn_D3.BackColor = Color.Black
                ElseIf rs.Fields(38).Value = 1 Then
                    .btn_D3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D3.Enabled = True
                    .btn_D3.BackColor = Color.Empty
                    assentos = assentos + "D3 "
                    cont = cont + 1
                End If
                If rs.Fields(39).Value = 0 Then
                    .btn_D4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D4.Enabled = True
                    .btn_D4.BackColor = Color.Black
                ElseIf rs.Fields(39).Value = 1 Then
                    .btn_D4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D4.Enabled = True
                    .btn_D4.BackColor = Color.Empty
                    assentos = assentos + "D4 "
                    cont = cont + 1
                End If
                If rs.Fields(40).Value = 0 Then
                    .btn_D5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D5.Enabled = True
                    .btn_D5.BackColor = Color.Black
                ElseIf rs.Fields(40).Value = 1 Then
                    .btn_D5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D5.Enabled = True
                    .btn_D5.BackColor = Color.Empty
                    assentos = assentos + "D5 "
                    cont = cont + 1
                End If
                If rs.Fields(41).Value = 0 Then
                    .btn_D6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D6.Enabled = True
                    .btn_D6.BackColor = Color.Black
                ElseIf rs.Fields(41).Value = 1 Then
                    .btn_D6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D6.Enabled = True
                    .btn_D6.BackColor = Color.Empty
                    assentos = assentos + "D6 "
                    cont = cont + 1
                End If
                If rs.Fields(42).Value = 0 Then
                    .btn_D7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D7.Enabled = True
                    .btn_D7.BackColor = Color.Black
                ElseIf rs.Fields(42).Value = 1 Then
                    .btn_D7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D7.Enabled = True
                    .btn_D7.BackColor = Color.Empty
                    assentos = assentos + "D7 "
                    cont = cont + 1
                End If
                If rs.Fields(43).Value = 0 Then
                    .btn_D8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D8.Enabled = True
                    .btn_D8.BackColor = Color.Black
                ElseIf rs.Fields(43).Value = 1 Then
                    .btn_D8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D8.Enabled = True
                    .btn_D8.BackColor = Color.Empty
                    assentos = assentos + "D8 "
                    cont = cont + 1
                End If
                If rs.Fields(44).Value = 0 Then
                    .btn_D9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D9.Enabled = True
                    .btn_D9.BackColor = Color.Black
                ElseIf rs.Fields(44).Value = 1 Then
                    .btn_D9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D9.Enabled = True
                    .btn_D9.BackColor = Color.Empty
                    assentos = assentos + "D9 "
                    cont = cont + 1
                End If
                If rs.Fields(45).Value = 0 Then
                    .btn_D10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D10.Enabled = True
                    .btn_D10.BackColor = Color.Black
                ElseIf rs.Fields(45).Value = 1 Then
                    .btn_D10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D10.Enabled = True
                    .btn_D10.BackColor = Color.Empty
                    assentos = assentos + "D10 "
                    cont = cont + 1
                End If
                If rs.Fields(46).Value = 0 Then
                    .btn_D11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D11.Enabled = True
                    .btn_D11.BackColor = Color.Black
                ElseIf rs.Fields(46).Value = 1 Then
                    .btn_D11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D11.Enabled = True
                    .btn_D11.BackColor = Color.Empty
                    assentos = assentos + "D11 "
                    cont = cont + 1
                End If
                If rs.Fields(47).Value = 0 Then
                    .btn_D12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_D12.Enabled = True
                    .btn_D12.BackColor = Color.Black
                ElseIf rs.Fields(47).Value = 1 Then
                    .btn_D12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_D12.Enabled = True
                    .btn_D12.BackColor = Color.Empty
                    assentos = assentos + "D12 "
                    cont = cont + 1
                End If
                '
                If rs.Fields(48).Value = 0 Then
                    .btn_E2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E2.Enabled = True
                    .btn_E2.BackColor = Color.Black
                ElseIf rs.Fields(48).Value = 1 Then
                    .btn_E2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E2.Enabled = True
                    .btn_E2.BackColor = Color.Empty
                    assentos = assentos + "E1 "
                    cont = cont + 1
                End If
                If rs.Fields(49).Value = 0 Then
                    .btn_E3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E3.Enabled = True
                    .btn_E3.BackColor = Color.Black
                ElseIf rs.Fields(49).Value = 1 Then
                    .btn_E3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E3.Enabled = True
                    .btn_E3.BackColor = Color.Empty
                    assentos = assentos + "E3 "
                    cont = cont + 1
                End If
                If rs.Fields(50).Value = 0 Then
                    .btn_E4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E4.Enabled = True
                    .btn_E4.BackColor = Color.Black
                ElseIf rs.Fields(50).Value = 1 Then
                    .btn_E4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E4.Enabled = True
                    .btn_E4.BackColor = Color.Empty
                    assentos = assentos + "E4 "
                    cont = cont + 1
                End If
                If rs.Fields(51).Value = 0 Then
                    .btn_E5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E5.Enabled = True
                    .btn_E5.BackColor = Color.Black
                ElseIf rs.Fields(51).Value = 1 Then
                    .btn_E5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E5.Enabled = True
                    .btn_E5.BackColor = Color.Empty
                    assentos = assentos + "E5 "
                    cont = cont + 1
                End If
                If rs.Fields(52).Value = 0 Then
                    .btn_E6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E6.Enabled = True
                    .btn_E6.BackColor = Color.Black
                ElseIf rs.Fields(52).Value = 1 Then
                    .btn_E6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E6.Enabled = True
                    .btn_E6.BackColor = Color.Empty
                    assentos = assentos + "E6 "
                    cont = cont + 1
                End If
                If rs.Fields(53).Value = 0 Then
                    .btn_E7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E7.Enabled = True
                    .btn_E7.BackColor = Color.Black
                ElseIf rs.Fields(53).Value = 1 Then
                    .btn_E7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E7.Enabled = True
                    .btn_E7.BackColor = Color.Empty
                    assentos = assentos + "E7 "
                    cont = cont + 1
                End If
                If rs.Fields(54).Value = 0 Then
                    .btn_E8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E8.Enabled = True
                    .btn_E8.BackColor = Color.Black
                ElseIf rs.Fields(54).Value = 1 Then
                    .btn_E8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E8.Enabled = True
                    .btn_E8.BackColor = Color.Empty
                    assentos = assentos + "E8 "
                    cont = cont + 1
                End If
                If rs.Fields(55).Value = 0 Then
                    .btn_E9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E9.Enabled = True
                    .btn_E9.BackColor = Color.Black
                ElseIf rs.Fields(55).Value = 1 Then
                    .btn_E9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E9.Enabled = True
                    .btn_E9.BackColor = Color.Empty
                    assentos = assentos + "E9 "
                    cont = cont + 1
                End If
                If rs.Fields(56).Value = 0 Then
                    .btn_E10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E10.Enabled = True
                    .btn_E10.BackColor = Color.Black
                ElseIf rs.Fields(56).Value = 1 Then
                    .btn_E10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E10.Enabled = True
                    .btn_E10.BackColor = Color.Empty
                    assentos = assentos + "E10 "
                    cont = cont + 1
                End If
                If rs.Fields(57).Value = 0 Then
                    .btn_E11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
                    .btn_E11.Enabled = True
                    .btn_E11.BackColor = Color.Black
                ElseIf rs.Fields(57).Value = 1 Then
                    .btn_E11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                    .btn_E11.Enabled = True
                    .btn_E11.BackColor = Color.Empty
                    assentos = assentos + "E11 "
                    cont = cont + 1
                End If
                .txt_assentos.Text = assentos
            End With
        End If
    End Sub

    Sub cancelar_pedido()
        sql = "select a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12," &
                     "b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12," &
                     "c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12," &
                     "d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12," &
                         "e2, e3, e4, e5, e6, e7, e8, e9, e10, e11 " &
              "from tb_sessoes where id_sessao = " & id_sessao & ""
        rs = db.Execute(UCase(sql))
        If rs.EOF = False Then
            If rs.Fields(0).Value = 1 Then
                sql_aux = "update tb_sessoes set A1 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(1).Value = 1 Then
                sql_aux = "update tb_sessoes set A2 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(2).Value = 1 Then
                sql_aux = "update tb_sessoes set A3 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(3).Value = 1 Then
                sql_aux = "update tb_sessoes set A4 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(4).Value = 1 Then
                sql_aux = "update tb_sessoes set A5 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(5).Value = 1 Then
                sql_aux = "update tb_sessoes set A6 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(6).Value = 1 Then
                sql_aux = "update tb_sessoes set A7 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(7).Value = 1 Then
                sql_aux = "update tb_sessoes set A8 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(8).Value = 1 Then
                sql_aux = "update tb_sessoes set A9 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(9).Value = 1 Then
                sql_aux = "update tb_sessoes set A10 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(10).Value = 1 Then
                sql_aux = "update tb_sessoes set A11 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(11).Value = 1 Then
                sql_aux = "update tb_sessoes set A12 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(12).Value = 1 Then
                sql_aux = "update tb_sessoes set B1 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(13).Value = 1 Then
                sql_aux = "update tb_sessoes set B2 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(14).Value = 1 Then
                sql_aux = "update tb_sessoes set B3 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(15).Value = 1 Then
                sql_aux = "update tb_sessoes set B4 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(16).Value = 1 Then
                sql_aux = "update tb_sessoes set B5 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(17).Value = 1 Then
                sql_aux = "update tb_sessoes set B6 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(18).Value = 1 Then
                sql_aux = "update tb_sessoes set B7 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(19).Value = 1 Then
                sql_aux = "update tb_sessoes set B8 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(20).Value = 1 Then
                sql_aux = "update tb_sessoes set B9 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(21).Value = 1 Then
                sql_aux = "update tb_sessoes set B10 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(22).Value = 1 Then
                sql_aux = "update tb_sessoes set B11 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(23).Value = 1 Then
                sql_aux = "update tb_sessoes set B12 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(24).Value = 1 Then
                sql_aux = "update tb_sessoes set C1 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(25).Value = 1 Then
                sql_aux = "update tb_sessoes set C2 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(26).Value = 1 Then
                sql_aux = "update tb_sessoes set C3 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(27).Value = 1 Then
                sql_aux = "update tb_sessoes set C4 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(28).Value = 1 Then
                sql_aux = "update tb_sessoes set C5 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(29).Value = 1 Then
                sql_aux = "update tb_sessoes set C6 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(30).Value = 1 Then
                sql_aux = "update tb_sessoes set C7 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(31).Value = 1 Then
                sql_aux = "update tb_sessoes set C8 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(32).Value = 1 Then
                sql_aux = "update tb_sessoes set C9 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(33).Value = 1 Then
                sql_aux = "update tb_sessoes set C10 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(34).Value = 1 Then
                sql_aux = "update tb_sessoes set C11 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(35).Value = 1 Then
                sql_aux = "update tb_sessoes set C12 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(36).Value = 1 Then
                sql_aux = "update tb_sessoes set D1 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(37).Value = 1 Then
                sql_aux = "update tb_sessoes set D2 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(38).Value = 1 Then
                sql_aux = "update tb_sessoes set D3 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(39).Value = 1 Then
                sql_aux = "update tb_sessoes set D4 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(40).Value = 1 Then
                sql_aux = "update tb_sessoes set D5 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(41).Value = 1 Then
                sql_aux = "update tb_sessoes set D6 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(42).Value = 1 Then
                sql_aux = "update tb_sessoes set D7 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(43).Value = 1 Then
                sql_aux = "update tb_sessoes set D8 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(44).Value = 1 Then
                sql_aux = "update tb_sessoes set D9 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(45).Value = 1 Then
                sql_aux = "update tb_sessoes set D10 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(46).Value = 1 Then
                sql_aux = "update tb_sessoes set D11 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(47).Value = 1 Then
                sql_aux = "update tb_sessoes set D12 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(48).Value = 1 Then
                sql_aux = "update tb_sessoes set E2 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(49).Value = 1 Then
                sql_aux = "update tb_sessoes set E3 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(50).Value = 1 Then
                sql_aux = "update tb_sessoes set E4 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(51).Value = 1 Then
                sql_aux = "update tb_sessoes set E5 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(52).Value = 1 Then
                sql_aux = "update tb_sessoes set E6 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(53).Value = 1 Then
                sql_aux = "update tb_sessoes set E7 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(54).Value = 1 Then
                sql_aux = "update tb_sessoes set E8 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(55).Value = 1 Then
                sql_aux = "update tb_sessoes set E9 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(56).Value = 1 Then
                sql_aux = "update tb_sessoes set E10 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(57).Value = 1 Then
                sql_aux = "update tb_sessoes set E11 = 0 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
        End If
    End Sub

    Sub confirmar_pedido()
        sql = "select a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12," &
             "b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12," &
             "c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12," &
             "d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12," &
                 "e2, e3, e4, e5, e6, e7, e8, e9, e10, e11 " &
      "from tb_sessoes where id_sessao = " & id_sessao & ""
        rs = db.Execute(UCase(sql))
        If rs.EOF = False Then
            If rs.Fields(0).Value = 1 Then
                sql_aux = "update tb_sessoes set A1 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(1).Value = 1 Then
                sql_aux = "update tb_sessoes set A2 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(2).Value = 1 Then
                sql_aux = "update tb_sessoes set A3 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(3).Value = 1 Then
                sql_aux = "update tb_sessoes set A4 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(4).Value = 1 Then
                sql_aux = "update tb_sessoes set A5 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(5).Value = 1 Then
                sql_aux = "update tb_sessoes set A6 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(6).Value = 1 Then
                sql_aux = "update tb_sessoes set A7 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(7).Value = 1 Then
                sql_aux = "update tb_sessoes set A8 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(8).Value = 1 Then
                sql_aux = "update tb_sessoes set A9 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(9).Value = 1 Then
                sql_aux = "update tb_sessoes set A10 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(10).Value = 1 Then
                sql_aux = "update tb_sessoes set A11 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(11).Value = 1 Then
                sql_aux = "update tb_sessoes set A12 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(12).Value = 1 Then
                sql_aux = "update tb_sessoes set B1 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(13).Value = 1 Then
                sql_aux = "update tb_sessoes set B2 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(14).Value = 1 Then
                sql_aux = "update tb_sessoes set B3 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(15).Value = 1 Then
                sql_aux = "update tb_sessoes set B4 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(16).Value = 1 Then
                sql_aux = "update tb_sessoes set B5 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(17).Value = 1 Then
                sql_aux = "update tb_sessoes set B6 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(18).Value = 1 Then
                sql_aux = "update tb_sessoes set B7 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(19).Value = 1 Then
                sql_aux = "update tb_sessoes set B8 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(20).Value = 1 Then
                sql_aux = "update tb_sessoes set B9 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(21).Value = 1 Then
                sql_aux = "update tb_sessoes set B10 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(22).Value = 1 Then
                sql_aux = "update tb_sessoes set B11 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(23).Value = 1 Then
                sql_aux = "update tb_sessoes set B12 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(24).Value = 1 Then
                sql_aux = "update tb_sessoes set C1 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(25).Value = 1 Then
                sql_aux = "update tb_sessoes set C2 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(26).Value = 1 Then
                sql_aux = "update tb_sessoes set C3 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(27).Value = 1 Then
                sql_aux = "update tb_sessoes set C4 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(28).Value = 1 Then
                sql_aux = "update tb_sessoes set C5 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(29).Value = 1 Then
                sql_aux = "update tb_sessoes set C6 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(30).Value = 1 Then
                sql_aux = "update tb_sessoes set C7 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(31).Value = 1 Then
                sql_aux = "update tb_sessoes set C8 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(32).Value = 1 Then
                sql_aux = "update tb_sessoes set C9 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(33).Value = 1 Then
                sql_aux = "update tb_sessoes set C10 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(34).Value = 1 Then
                sql_aux = "update tb_sessoes set C11 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(35).Value = 1 Then
                sql_aux = "update tb_sessoes set C12 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(36).Value = 1 Then
                sql_aux = "update tb_sessoes set D1 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(37).Value = 1 Then
                sql_aux = "update tb_sessoes set D2 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(38).Value = 1 Then
                sql_aux = "update tb_sessoes set D3 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(39).Value = 1 Then
                sql_aux = "update tb_sessoes set D4 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(40).Value = 1 Then
                sql_aux = "update tb_sessoes set D5 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(41).Value = 1 Then
                sql_aux = "update tb_sessoes set D6 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(42).Value = 1 Then
                sql_aux = "update tb_sessoes set D7 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(43).Value = 1 Then
                sql_aux = "update tb_sessoes set D8 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(44).Value = 1 Then
                sql_aux = "update tb_sessoes set D9 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(45).Value = 1 Then
                sql_aux = "update tb_sessoes set D10 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(46).Value = 1 Then
                sql_aux = "update tb_sessoes set D11 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(47).Value = 1 Then
                sql_aux = "update tb_sessoes set D12 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(48).Value = 1 Then
                sql_aux = "update tb_sessoes set E2 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(49).Value = 1 Then
                sql_aux = "update tb_sessoes set E3 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(50).Value = 1 Then
                sql_aux = "update tb_sessoes set E4 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(51).Value = 1 Then
                sql_aux = "update tb_sessoes set E5 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(52).Value = 1 Then
                sql_aux = "update tb_sessoes set E6 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(53).Value = 1 Then
                sql_aux = "update tb_sessoes set E7 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(54).Value = 1 Then
                sql_aux = "update tb_sessoes set E8 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(55).Value = 1 Then
                sql_aux = "update tb_sessoes set E9 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(56).Value = 1 Then
                sql_aux = "update tb_sessoes set E10 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
            If rs.Fields(57).Value = 1 Then
                sql_aux = "update tb_sessoes set E11 = 2 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql_aux))
            End If
        End If
    End Sub

    Sub limpar_pedido()
        Try
            With frm_realizar_pedido
                carregar_cmb_filmes_pedido()
                .txt_valor.Text = ""
                .txt_quantidade.Text = "0"
                .rb_inteira.Checked = True
                .rb_meia.Checked = False
                .txt_valor_total.Text = ""
                assentos = ""
                .rb_cartao_credito.Checked = False
                .rb_cartao_debito.Checked = False
                .rb_dinheiro.Checked = False
                .rb_pix.Checked = False
                .lbl_lugares.Text = ""
                .lbl_data_horario_sala.Text = ""
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar pedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub trocar_tema()
        Try
            If tema = "claro" Then
                corPrm = "Black"
                corSec = "White"
                frm_login.btn_trocar_tema.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\tema_escuro.png")
                frm_login.img_usuario.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\usuario_pr.png")
                frm_operador.btn_trocar_tema.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\tema_escuro.png")
                frm_operador.btn_seta_esq.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\seta_esq_pr.png")
                frm_operador.btn_seta_dir.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\seta_dir_pr.png")
                frm_gerente.btn_trocar_tema.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\tema_escuro.png")
            Else
                corPrm = "White"
                corSec = "Black"
                frm_login.btn_trocar_tema.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\tema_claro_2.png")
                frm_login.img_usuario.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\usuario_br.png")
                frm_operador.btn_trocar_tema.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\tema_claro_2.png")
                frm_operador.btn_seta_esq.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\seta_esq_br.png")
                frm_operador.btn_seta_dir.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\seta_dir_br.png")
                frm_gerente.btn_trocar_tema.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\tema_claro_2.png")
            End If
        Catch ex As Exception
            MsgBox("Erro ao trocar de tema", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            With frm_login
                .btn_trocar_tema.BackColor = Color.FromName(corSec)
                .btn_trocar_tema.FlatAppearance.BorderColor = Color.FromName(corSec)
                .btn_trocar_tema.ForeColor = Color.FromName(corPrm)
                .img_usuario.BackColor = Color.FromName(corSec)
                .lbl_cpf.BackColor = Color.FromName(corSec)
                .lbl_cpf.ForeColor = Color.FromName(corPrm)
                .lbl_senha.BackColor = Color.FromName(corSec)
                .lbl_senha.ForeColor = Color.FromName(corPrm)
                .btn_esqueceu_senha.BackColor = Color.FromName(corSec)
                .btn_esqueceu_senha.FlatAppearance.BorderColor = Color.FromName(corSec)
                .btn_esqueceu_senha.ForeColor = Color.DimGray
            End With
            frm_login.BackColor = Color.FromName(corSec)
        Catch ex As Exception
            MsgBox("Erro ao aplicar o tema " & tema & " na tela de login", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            With frm_esqueceu_senha
                .lbl_cpf.BackColor = Color.FromName(corSec)
                .lbl_cpf.ForeColor = Color.FromName(corPrm)
                .lbl_nome_completo.BackColor = Color.FromName(corSec)
                .lbl_nome_completo.ForeColor = Color.FromName(corPrm)
                .lbl_email.BackColor = Color.FromName(corSec)
                .lbl_email.ForeColor = Color.FromName(corPrm)
            End With
            frm_esqueceu_senha.BackColor = Color.FromName(corSec)
        Catch ex As Exception
            MsgBox("Erro ao aplicar o tema " & tema & " na tela de recuperar senha", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            With frm_operador
                .GroupBox1.BackColor = Color.FromName(corSec)
                .btn_trocar_tema.BackColor = Color.FromName(corSec)
                .btn_trocar_tema.FlatAppearance.BorderColor = Color.FromName(corSec)
                .btn_trocar_tema.ForeColor = Color.FromName(corPrm)
                .btn_seta_esq.FlatAppearance.BorderColor = Color.FromName(corSec)
                .btn_seta_dir.FlatAppearance.BorderColor = Color.FromName(corSec)
                .btn_tit_prox_hor.BackColor = Color.FromName(corPrm)
                .btn_tit_prox_hor.FlatAppearance.BorderColor = Color.FromName(corPrm)
                .btn_tit_prox_hor.ForeColor = Color.FromName(corSec)
                .btn_prox_hor.BackColor = Color.FromName(corSec)
                .btn_prox_hor.FlatAppearance.BorderColor = Color.FromName(corSec)
                .btn_prox_hor.ForeColor = Color.FromName(corPrm)
                .btn_tit_prox_hor_3d.BackColor = Color.FromName(corPrm)
                .btn_tit_prox_hor_3d.FlatAppearance.BorderColor = Color.FromName(corPrm)
                .btn_tit_prox_hor_3d.ForeColor = Color.FromName(corSec)
                .btn_prox_hor_3d.BackColor = Color.FromName(corSec)
                .btn_prox_hor_3d.FlatAppearance.BorderColor = Color.FromName(corSec)
                .btn_prox_hor_3d.ForeColor = Color.FromName(corPrm)
            End With
        Catch ex As Exception
            MsgBox("Erro ao aplicar o tema " & tema & " no menu principal do operador", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            With frm_realizar_pedido
                .lbl_qtde.BackColor = Color.FromName(corSec)
                .lbl_qtde.ForeColor = Color.FromName(corPrm)
                .rb_inteira.BackColor = Color.FromName(corSec)
                .rb_inteira.ForeColor = Color.FromName(corPrm)
                .rb_meia.BackColor = Color.FromName(corSec)
                .rb_meia.ForeColor = Color.FromName(corPrm)
                .lbl_total_pagar.BackColor = Color.FromName(corSec)
                .lbl_total_pagar.ForeColor = Color.FromName(corPrm)
                .grp_ingressos.BackColor = Color.FromName(corSec)
                .grp_ingressos.ForeColor = Color.FromName(corPrm)
                .lbl_data_horario_sala.BackColor = Color.FromName(corSec)
                .lbl_data_horario_sala.ForeColor = Color.FromName(corPrm)
                .lbl_lugares.BackColor = Color.FromName(corSec)
                .lbl_lugares.ForeColor = Color.FromName(corPrm)
                .grp_mets_pagto.BackColor = Color.FromName(corSec)
                .grp_mets_pagto.ForeColor = Color.FromName(corPrm)
                .rb_cartao_credito.BackColor = Color.FromName(corSec)
                .rb_cartao_credito.ForeColor = Color.FromName(corPrm)
                .rb_cartao_debito.BackColor = Color.FromName(corSec)
                .rb_cartao_debito.ForeColor = Color.FromName(corPrm)
                .rb_dinheiro.BackColor = Color.FromName(corSec)
                .rb_dinheiro.ForeColor = Color.FromName(corPrm)
                .rb_pix.BackColor = Color.FromName(corSec)
                .rb_pix.ForeColor = Color.FromName(corPrm)
            End With
            frm_realizar_pedido.BackColor = Color.FromName(corSec)
        Catch ex As Exception
            MsgBox("Erro ao aplicar o tema " & tema & " na página de venda de ingressos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            With frm_sessao
                .btn_fundo.BackColor = Color.FromName(corSec)
                .btn_fundo.ForeColor = Color.FromName(corSec)
                .lbl_assentos_selecionados.BackColor = Color.FromName(corSec)
                .lbl_assentos_selecionados.ForeColor = Color.FromName(corPrm)
            End With
        Catch ex As Exception
            MsgBox("Erro ao aplicar o tema " & tema & " na página de escolha de sessão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            With frm_gerente
                .GroupBox1.BackColor = Color.FromName(corSec)
                .btn_trocar_tema.BackColor = Color.FromName(corSec)
                .btn_trocar_tema.FlatAppearance.BorderColor = Color.FromName(corSec)
                .btn_trocar_tema.ForeColor = Color.FromName(corPrm)
                .btn_checar_filmes.BackColor = Color.FromName(corPrm)
                .btn_checar_filmes.FlatAppearance.BorderColor = Color.FromName(corPrm)
                .btn_checar_filmes.ForeColor = Color.FromName(corSec)
                .btn_checar_pedidos.BackColor = Color.FromName(corPrm)
                .btn_checar_pedidos.FlatAppearance.BorderColor = Color.FromName(corPrm)
                .btn_checar_pedidos.ForeColor = Color.FromName(corSec)
                .btn_configurar_contas.BackColor = Color.FromName(corPrm)
                .btn_configurar_contas.FlatAppearance.BorderColor = Color.FromName(corPrm)
                .btn_configurar_contas.ForeColor = Color.FromName(corSec)
                .btn_consultar_registros.BackColor = Color.FromName(corPrm)
                .btn_consultar_registros.FlatAppearance.BorderColor = Color.FromName(corPrm)
                .btn_consultar_registros.ForeColor = Color.FromName(corSec)
            End With
        Catch ex As Exception
            MsgBox("Erro ao aplicar o tema " & tema & " na página inicial do gerente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            With frm_configurar_contas
                .tab_page_individual.BackColor = Color.FromName(corSec)
                .tab_page_individual.ForeColor = Color.FromName(corPrm)
                .lbl_cpf.BackColor = Color.FromName(corSec)
                .lbl_cpf.ForeColor = Color.FromName(corPrm)
                .lbl_nome.BackColor = Color.FromName(corSec)
                .lbl_nome.ForeColor = Color.FromName(corPrm)
                .lbl_email.BackColor = Color.FromName(corSec)
                .lbl_email.ForeColor = Color.FromName(corPrm)
                .lbl_senha.BackColor = Color.FromName(corSec)
                .lbl_senha.ForeColor = Color.FromName(corPrm)
                .gb_tipo_conta.BackColor = Color.FromName(corSec)
                .gb_tipo_conta.ForeColor = Color.FromName(corPrm)
                .lbl_tipo_conta.BackColor = Color.FromName(corSec)
                .lbl_tipo_conta.ForeColor = Color.FromName(corPrm)
                .rb_operador.BackColor = Color.FromName(corSec)
                .rb_operador.ForeColor = Color.FromName(corPrm)
                .rb_gerente.BackColor = Color.FromName(corSec)
                .rb_gerente.ForeColor = Color.FromName(corPrm)
                .gb_status_conta.BackColor = Color.FromName(corSec)
                .gb_status_conta.ForeColor = Color.FromName(corPrm)
                .lbl_status_conta.BackColor = Color.FromName(corSec)
                .lbl_status_conta.ForeColor = Color.FromName(corPrm)
                .rb_ativo.BackColor = Color.FromName(corSec)
                .rb_ativo.ForeColor = Color.FromName(corPrm)
                .rb_bloqueado.BackColor = Color.FromName(corSec)
                .rb_bloqueado.ForeColor = Color.FromName(corPrm)
                .tab_page_listagem.BackColor = Color.FromName(corSec)
                .dgv_contas.BackgroundColor = Color.FromName(corSec)
            End With
            frm_configurar_contas.BackColor = Color.FromName(corSec)
        Catch ex As Exception
            MsgBox("Erro ao aplicar o tema " & tema & " na página de configuração de contas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            With checar_filmes
                .tab_page_programacao.BackColor = Color.FromName(corSec)
                .tab_page_programacao.ForeColor = Color.FromName(corPrm)
                .cb_horario1.BackColor = Color.FromName(corSec)
                .cb_horario1.ForeColor = Color.FromName(corPrm)
                .cb_horario2.BackColor = Color.FromName(corSec)
                .cb_horario2.ForeColor = Color.FromName(corPrm)
                .cb_horario3.BackColor = Color.FromName(corSec)
                .cb_horario3.ForeColor = Color.FromName(corPrm)
                .cb_horario4.BackColor = Color.FromName(corSec)
                .cb_horario4.ForeColor = Color.FromName(corPrm)
                .cb_horario5.BackColor = Color.FromName(corSec)
                .cb_horario5.ForeColor = Color.FromName(corPrm)
                .tab_page_sessoes.BackColor = Color.FromName(corSec)
                .dgv_sessoes.BackgroundColor = Color.FromName(corSec)
                .tab_page_individual.BackColor = Color.FromName(corSec)
                .tab_page_individual.ForeColor = Color.FromName(corPrm)
                .lbl_titulo.BackColor = Color.FromName(corSec)
                .lbl_titulo.ForeColor = Color.FromName(corPrm)
                .lbl_preco_ingresso.BackColor = Color.FromName(corSec)
                .lbl_preco_ingresso.ForeColor = Color.FromName(corPrm)
                .lbl_em_cartaz.BackColor = Color.FromName(corSec)
                .lbl_em_cartaz.ForeColor = Color.FromName(corPrm)
                .rb_sim.BackColor = Color.FromName(corSec)
                .rb_sim.ForeColor = Color.FromName(corPrm)
                .rb_nao.BackColor = Color.FromName(corSec)
                .rb_nao.ForeColor = Color.FromName(corPrm)
                .tab_page_listagem.BackColor = Color.FromName(corSec)
                .dgv_filmes.BackgroundColor = Color.FromName(corSec)
                .cb_somente_cartaz.BackColor = Color.FromName(corSec)
                .cb_somente_cartaz.ForeColor = Color.FromName(corPrm)
                .tab_page_salas.BackColor = Color.FromName(corSec)
                .tab_page_salas.ForeColor = Color.FromName(corPrm)
                .cb_sala_01.BackColor = Color.FromName(corSec)
                .cb_sala_01.ForeColor = Color.FromName(corPrm)
                .cb_sala_02.BackColor = Color.FromName(corSec)
                .cb_sala_02.ForeColor = Color.FromName(corPrm)
                .cb_sala_03.BackColor = Color.FromName(corSec)
                .cb_sala_03.ForeColor = Color.FromName(corPrm)
                .cb_sala_04.BackColor = Color.FromName(corSec)
                .cb_sala_04.ForeColor = Color.FromName(corPrm)
            End With
            checar_filmes.BackColor = Color.FromName(corSec)
        Catch ex As Exception
            MsgBox("Erro ao aplicar o tema " & tema & " na página de configuração de filmes", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
