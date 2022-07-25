Public Class frm_realizar_pedido
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            If cmb_filmes_pedido.Text = "" Or txt_valor.Text = "" Or txt_quantidade.Text = "0" Or (rb_inteira.Checked = False And rb_meia.Checked = False) Or txt_valor_total.Text = "" Or assentos = "" Or (rb_cartao_credito.Checked = False And rb_cartao_debito.Checked = False And rb_dinheiro.Checked = False And rb_pix.Checked = False) Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "select id_venda from tb_ingressos"
                rs = db.Execute(UCase(sql))
                cont = 0
                While rs.EOF = False
                    cont = cont + 1
                    rs.MoveNext()
                End While
                sql = "insert into tb_ingressos values (" & cont & ", " & id_sessao & ", " & qtde_assentos & ", " & tp_ingresso & ", " & metPagto & ", " & id_conta & ")"
                db.Execute(UCase(sql))
                confirmar_pedido()
                MsgBox("Venda realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_pedido()
                btn_salas.Location = New Point(227, 298)
                lbl_data_horario_sala.Location = New Point(424, 298)
                lbl_lugares.Location = New Point(424, 319)
            End If
        Catch ex As Exception
            MsgBox("Erro ao confirmar venda", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_salas_Click(sender As Object, e As EventArgs) Handles btn_salas.Click
        If cmb_filmes_pedido.Text = "" Or txt_quantidade.Text = "0" Then
            MsgBox("Escolha um filme e a quantidade de assentos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            frm_sessao.Show()
        End If
    End Sub

    Private Sub frm_realizar_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_cmb_filmes_pedido()
        qtde_assentos = 0
        preco_ingresso = 0.0
        txt_quantidade.Text = 0
        rb_inteira.Checked = True
        btn_salas.Enabled = False
        assentos = ""
        data = ""
        horario = ""
        lbl_data_horario_sala.Text = ""
        lbl_lugares.Text = ""
        btn_salas.Location = New Point(227, 298)
        lbl_data_horario_sala.Location = New Point(424, 298)
        lbl_lugares.Location = New Point(424, 319)
        trocar_tema()
    End Sub

    Private Sub frm_realizar_pedido_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        cancelar_pedido()
    End Sub

    Private Sub cmb_filmes_pedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filmes_pedido.SelectedIndexChanged
        sql = "select id_filme, preco from tb_filmes where titulo = '" & cmb_filmes_pedido.Text & "'"
        rs = db.Execute(UCase(sql))
        If rs.EOF = False Then
            id_filme = rs.Fields(0).Value
            txt_valor.Text = rs.Fields(1).Value
        End If
        sql = "select data from tb_sessoes where id_filme = " & id_filme & " and data >= '" & Now.ToString("dd/MM/yyyy") & "' and horario >= '" & Now.ToString("HH:mm") & "' and confirmado = 1"
        rs = db.Execute(UCase(sql))
        If rs.EOF = False And txt_quantidade.Text <> "0" Then
            btn_salas.Enabled = True
        Else
            btn_salas.Enabled = False
        End If
        txt_valor_total.Text = FormatCurrency(qtde_assentos * preco_ingresso, , , TriState.True, TriState.True)
    End Sub

    Private Sub txt_quantidade_TextChanged(sender As Object, e As EventArgs) Handles txt_quantidade.TextChanged
        If txt_quantidade.Text <> "" And Integer.TryParse(txt_quantidade.Text, qtde_assentos) Then
            qtde_assentos = CInt(txt_quantidade.Text)
        End If
        If rb_meia.Checked = True Then
            preco_ingresso = preco_ingresso * 0.5
        Else
            preco_ingresso = preco_ingresso * 1
        End If
        txt_valor_total.Text = FormatCurrency(qtde_assentos * preco_ingresso, , , TriState.True, TriState.True)
        If rs.EOF = False And cmb_filmes_pedido.Text <> "" Then
            btn_salas.Enabled = True
        Else
            btn_salas.Enabled = False
        End If
    End Sub

    Private Sub txt_valor_TextChanged(sender As Object, e As EventArgs) Handles txt_valor.TextChanged
        If txt_valor.Text <> "" And Double.TryParse(Replace(Replace(txt_valor.Text, "R$", ""), ",", "."), preco_ingresso) Then
            preco_ingresso = CDbl(Replace(txt_valor.Text, "R$", ""))
        End If
        If txt_quantidade.Text <> "0" Then
            txt_valor_total.Text = FormatCurrency(qtde_assentos * preco_ingresso, , , TriState.True, TriState.True)
        End If
    End Sub

    Private Sub rb_meia_CheckedChanged(sender As Object, e As EventArgs) Handles rb_meia.CheckedChanged
        If txt_valor.Text <> "" Then
            preco_ingresso = CDbl(Replace(txt_valor.Text, "R$", ""))
        End If
        If rb_meia.Checked = True Then
            tp_ingresso = 1
        End If
        preco_ingresso = preco_ingresso * 0.5
        txt_valor_total.Text = FormatCurrency(qtde_assentos * preco_ingresso, , , TriState.True, TriState.True)
    End Sub

    Private Sub rb_inteira_CheckedChanged(sender As Object, e As EventArgs) Handles rb_inteira.CheckedChanged
        If txt_valor.Text <> "" Then
            preco_ingresso = CDbl(Replace(txt_valor.Text, "R$", ""))
        End If
        If rb_inteira.Checked = True Then
            tp_ingresso = 0
        End If
        txt_valor_total.Text = FormatCurrency(qtde_assentos * preco_ingresso, , , TriState.True, TriState.True)
    End Sub

    Private Sub rb_cartao_credito_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cartao_credito.CheckedChanged
        metPagto = 1
    End Sub

    Private Sub rb_cartao_debito_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cartao_debito.CheckedChanged
        metPagto = 2
    End Sub

    Private Sub rb_dinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles rb_dinheiro.CheckedChanged
        metPagto = 3
    End Sub

    Private Sub rb_pix_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pix.CheckedChanged
        metPagto = 4
    End Sub

End Class