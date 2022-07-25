Public Class frm_sessao

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If cont = qtde_assentos Then
            Me.Close()
        Else
            MsgBox("Selecione mais " & qtde_assentos - cont & " assento(s)!")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        assentos = ""
        cancelar_pedido()
        Me.Close()
    End Sub

    Private Sub frm_sessao_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        With frm_realizar_pedido
            .lbl_lugares.Text = assentos
            If assentos <> "" Then
                .lbl_data_horario_sala.Text = cmb_datas.Text & " | " & cmb_horarios.Text & " | " & lbl_sala.Text
                .lbl_data_horario_sala.Location = New Point(354, 298)
                .btn_salas.Location = New Point(157, 298)
                .lbl_lugares.Location = New Point(354, 319)
            Else
                .lbl_data_horario_sala.Text = ""
                .lbl_data_horario_sala.Location = New Point(424, 298)
                .btn_salas.Location = New Point(227, 298)
                .lbl_lugares.Location = New Point(424, 319)
            End If
        End With
    End Sub

    Private Sub frm_sessao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select data from tb_sessoes where id_filme = " & id_filme & " and data >= date() and confirmado = 1 order by data asc"
        rs = db.Execute(UCase(sql))
        With cmb_datas
            .Items.Clear()
            data = rs.Fields(0).Value
            .Items.Add(rs.Fields(0).Value)
            While rs.EOF = False
                If rs.Fields(0).Value <> data Then
                    .Items.Add(rs.Fields(0).Value)
                    data = rs.Fields(0).Value
                End If
                rs.MoveNext()
            End While
            cmb_datas.SelectedIndex = 0
        End With
        limpar_sessao()
        lbl_sala.Text = ""
        assentos = ""
        cont = 0
        If data <> "" Then
            cmb_datas.Text = data
        Else
            data = Now.ToString("dd/MM/yyyy")
        End If
        If horario <> "" Then
            cmb_horarios.Text = horario
        End If
    End Sub

    Private Sub cmb_datas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_datas.SelectedIndexChanged
        sql = "select horario from tb_sessoes where data = '" & cmb_datas.Text & "' and id_filme = " & id_filme & " and data >= date() and confirmado = 1 order by horario asc"
        rs = db.Execute(UCase(sql))
        With cmb_horarios
            .Items.Clear()
            While rs.EOF = False
                If rs.Fields(0).Value >= Now.ToString("HH:mm") Then
                    .Items.Add(rs.Fields(0).Value)
                End If
                rs.MoveNext()
            End While
        End With
        If cmb_datas.Text <> ""
            data = cmb_datas.Text
        End If
        limpar_sessao()
        If cmb_horarios.Text <> "" Then
            consultar_sessao()
        End If
    End Sub

    Private Sub cmb_horarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_horarios.SelectedIndexChanged
        cancelar_pedido()
        sql = "select sala from tb_sessoes where id_filme = " & id_filme & " and data = '" & cmb_datas.Text & "' and horario = '" & cmb_horarios.Text & "' and confirmado = 1 "
        rs = db.Execute(UCase(sql))
        If rs.EOF = False Then
            If rs.Fields(0).Value = 1 Or rs.Fields(0).Value = 2 Then
                lbl_sala.Text = "Sala " & rs.Fields(0).Value
            Else
                lbl_sala.Text = "Sala " & rs.Fields(0).Value & " (3D)"
            End If
            sql = "select id_sessao from tb_sessoes where id_filme = " & id_filme & " and data = '" & cmb_datas.Text & "' and sala = " & rs.Fields(0).Value & " and horario = '" & cmb_horarios.Text & "' and confirmado = 1 "
                rs = db.Execute(UCase(sql))
                If rs.EOF = False Then
                    id_sessao = rs.Fields(0).Value
                End If
            End If
        If cmb_horarios.Text <> "" Then
            horario = cmb_horarios.Text
        End If
        limpar_sessao()
        consultar_sessao()
    End Sub

    Private Sub btn_A1_Click(sender As Object, e As EventArgs) Handles btn_A1.Click
        If btn_A1.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A1.BackColor = Color.Empty
                assentos = assentos + "A1 "
                sql = "update tb_sessoes set A1 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A1.BackColor = Color.Black
            assentos = assentos.Replace("A1 ", "")
            sql = "update tb_sessoes set A1 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A2_Click(sender As Object, e As EventArgs) Handles btn_A2.Click
        If btn_A2.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A2.BackColor = Color.Empty
                assentos = assentos + "A2 "
                sql = "update tb_sessoes set A2 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
                btn_A2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A2.BackColor = Color.Black
            assentos = assentos.Replace("A2 ", "")
            sql = "update tb_sessoes set A2 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A3_Click(sender As Object, e As EventArgs) Handles btn_A3.Click
        If btn_A3.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A3.BackColor = Color.Empty
                assentos = assentos + "A3 "
                sql = "update tb_sessoes set A3 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
                btn_A3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A3.BackColor = Color.Black
            assentos = assentos.Replace("A3 ", "")
            sql = "update tb_sessoes set A3 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A4_Click(sender As Object, e As EventArgs) Handles btn_A4.Click
        If btn_A4.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A4.BackColor = Color.Empty
                assentos = assentos + "A4 "
                sql = "update tb_sessoes set A4 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A4.BackColor = Color.Black
            assentos = assentos.Replace("A4 ", "")
            sql = "update tb_sessoes set A4 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A5_Click(sender As Object, e As EventArgs) Handles btn_A5.Click
        If btn_A5.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A5.BackColor = Color.Empty
                assentos = assentos + "A5 "
                sql = "update tb_sessoes set A5 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A5.BackColor = Color.Black
            assentos = assentos.Replace("A5 ", "")
            sql = "update tb_sessoes set A5 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A6_Click(sender As Object, e As EventArgs) Handles btn_A6.Click
        If btn_A6.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A6.BackColor = Color.Empty
                assentos = assentos + "A6 "
                sql = "update tb_sessoes set A6 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A6.BackColor = Color.Black
            assentos = assentos.Replace("A6 ", "")
            sql = "update tb_sessoes set A6 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A7_Click(sender As Object, e As EventArgs) Handles btn_A7.Click
        If btn_A7.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A7.BackColor = Color.Empty
                assentos = assentos + "A7 "
                sql = "update tb_sessoes set A7 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A7.BackColor = Color.Black
            assentos = assentos.Replace("A7 ", "")
            sql = "update tb_sessoes set A7 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A8_Click(sender As Object, e As EventArgs) Handles btn_A8.Click
        If btn_A8.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A8.BackColor = Color.Empty
                assentos = assentos + "A8 "
                sql = "update tb_sessoes set A8 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A8.BackColor = Color.Black
            assentos = assentos.Replace("A8 ", "")
            sql = "update tb_sessoes set A8 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A9_Click(sender As Object, e As EventArgs) Handles btn_A9.Click
        If btn_A9.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A9.BackColor = Color.Empty
                assentos = assentos + "A9 "
                sql = "update tb_sessoes set A9 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A9.BackColor = Color.Black
            assentos = assentos.Replace("A9 ", "")
            sql = "update tb_sessoes set A9 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A10_Click(sender As Object, e As EventArgs) Handles btn_A10.Click
        If btn_A10.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A10.BackColor = Color.Empty
                assentos = assentos + "A10 "
                sql = "update tb_sessoes set A10 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A10.BackColor = Color.Black
            assentos = assentos.Replace("A10 ", "")
            sql = "update tb_sessoes set A10 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A11_Click(sender As Object, e As EventArgs) Handles btn_A11.Click
        If btn_A11.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A11.BackColor = Color.Empty
                assentos = assentos + "A11 "
                sql = "update tb_sessoes set A11 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A11.BackColor = Color.Black
            assentos = assentos.Replace("A11 ", "")
            sql = "update tb_sessoes set A11 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_A12_Click(sender As Object, e As EventArgs) Handles btn_A12.Click
        If btn_A12.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_A12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_A12.BackColor = Color.Empty
                assentos = assentos + "A12 "
                sql = "update tb_sessoes set A12 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_A12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_A12.BackColor = Color.Black
            assentos = assentos.Replace("A12 ", "")
            sql = "update tb_sessoes set A12 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B1_Click(sender As Object, e As EventArgs) Handles btn_B1.Click
        If btn_B1.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B1.BackColor = Color.Empty
                assentos = assentos + "B1 "
                sql = "update tb_sessoes set B1 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B1.BackColor = Color.Black
            assentos = assentos.Replace("B1 ", "")
            sql = "update tb_sessoes set B1 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B2_Click(sender As Object, e As EventArgs) Handles btn_B2.Click
        If btn_B2.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B2.BackColor = Color.Empty
                assentos = assentos + "B2 "
                sql = "update tb_sessoes set B2 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B2.BackColor = Color.Black
            assentos = assentos.Replace("B2 ", "")
            sql = "update tb_sessoes set B2 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B3_Click(sender As Object, e As EventArgs) Handles btn_B3.Click
        If btn_B3.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B3.BackColor = Color.Empty
                assentos = assentos + "B3 "
                sql = "update tb_sessoes set B3 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B3.BackColor = Color.Black
            assentos = assentos.Replace("B3 ", "")
            sql = "update tb_sessoes set B3 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B4_Click(sender As Object, e As EventArgs) Handles btn_B4.Click
        If btn_B4.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B4.BackColor = Color.Empty
                assentos = assentos + "B4 "
                sql = "update tb_sessoes set B4 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B4.BackColor = Color.Black
            assentos = assentos.Replace("B4 ", "")
            sql = "update tb_sessoes set B4 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B5_Click(sender As Object, e As EventArgs) Handles btn_B5.Click
        If btn_B5.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B5.BackColor = Color.Empty
                assentos = assentos + "B5 "
                sql = "update tb_sessoes set B5 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B5.BackColor = Color.Black
            assentos = assentos.Replace("B5 ", "")
            sql = "update tb_sessoes set B5 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B6_Click(sender As Object, e As EventArgs) Handles btn_B6.Click
        If btn_B6.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B6.BackColor = Color.Empty
                assentos = assentos + "B6 "
                sql = "update tb_sessoes set B6 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B6.BackColor = Color.Black
            assentos = assentos.Replace("B6 ", "")
            sql = "update tb_sessoes set B6 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B7_Click(sender As Object, e As EventArgs) Handles btn_B7.Click
        If btn_B7.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B7.BackColor = Color.Empty
                assentos = assentos + "B7 "
                sql = "update tb_sessoes set B7 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B7.BackColor = Color.Black
            assentos = assentos.Replace("B7 ", "")
            sql = "update tb_sessoes set B7 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B8_Click(sender As Object, e As EventArgs) Handles btn_B8.Click
        If btn_B8.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B8.BackColor = Color.Empty
                assentos = assentos + "B8 "
                sql = "update tb_sessoes set B8 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B8.BackColor = Color.Black
            assentos = assentos.Replace("B8 ", "")
            sql = "update tb_sessoes set B8 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B9_Click(sender As Object, e As EventArgs) Handles btn_B9.Click
        If btn_B9.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B9.BackColor = Color.Empty
                assentos = assentos + "B9 "
                sql = "update tb_sessoes set B9 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B9.BackColor = Color.Black
            assentos = assentos.Replace("B9 ", "")
            sql = "update tb_sessoes set B9 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B10_Click(sender As Object, e As EventArgs) Handles btn_B10.Click
        If btn_B10.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B10.BackColor = Color.Empty
                assentos = assentos + "B10 "
                sql = "update tb_sessoes set B10 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B10.BackColor = Color.Black
            assentos = assentos.Replace("B10 ", "")
            sql = "update tb_sessoes set B10 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B11_Click(sender As Object, e As EventArgs) Handles btn_B11.Click
        If btn_B11.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B11.BackColor = Color.Empty
                assentos = assentos + "B11 "
                sql = "update tb_sessoes set B11 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B11.BackColor = Color.Black
            assentos = assentos.Replace("B11 ", "")
            sql = "update tb_sessoes set B11 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_B12_Click(sender As Object, e As EventArgs) Handles btn_B12.Click
        If btn_B12.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_B12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_B12.BackColor = Color.Empty
                assentos = assentos + "B12 "
                sql = "update tb_sessoes set B12 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_B12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_B12.BackColor = Color.Black
            assentos = assentos.Replace("B12 ", "")
            sql = "update tb_sessoes set B12 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C1_Click(sender As Object, e As EventArgs) Handles btn_C1.Click
        If btn_C1.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C1.BackColor = Color.Empty
                assentos = assentos + "C1 "
                sql = "update tb_sessoes set C1 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C1.BackColor = Color.Black
            assentos = assentos.Replace("C1 ", "")
            sql = "update tb_sessoes set C1 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C2_Click(sender As Object, e As EventArgs) Handles btn_C2.Click
        If btn_C2.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C2.BackColor = Color.Empty
                assentos = assentos + "C2 "
                sql = "update tb_sessoes set C2 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C2.BackColor = Color.Black
            assentos = assentos.Replace("C2 ", "")
            sql = "update tb_sessoes set C2 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C3_Click(sender As Object, e As EventArgs) Handles btn_C3.Click
        If btn_C3.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C3.BackColor = Color.Empty
                assentos = assentos + "C3 "
                sql = "update tb_sessoes set C3 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C3.BackColor = Color.Black
            assentos = assentos.Replace("C3 ", "")
            sql = "update tb_sessoes set C3 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C4_Click(sender As Object, e As EventArgs) Handles btn_C4.Click
        If btn_C4.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C4.BackColor = Color.Empty
                assentos = assentos + "C4 "
                sql = "update tb_sessoes set C4 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C4.BackColor = Color.Black
            assentos = assentos.Replace("C4 ", "")
            sql = "update tb_sessoes set C4 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C5_Click(sender As Object, e As EventArgs) Handles btn_C5.Click
        If btn_C5.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C5.BackColor = Color.Empty
                assentos = assentos + "C5 "
                sql = "update tb_sessoes set C5 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C5.BackColor = Color.Black
            assentos = assentos.Replace("C5 ", "")
            sql = "update tb_sessoes set C5 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C6_Click(sender As Object, e As EventArgs) Handles btn_C6.Click
        If btn_C6.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C6.BackColor = Color.Empty
                assentos = assentos + "C6 "
                sql = "update tb_sessoes set C6 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C6.BackColor = Color.Black
            assentos = assentos.Replace("C6 ", "")
            sql = "update tb_sessoes set C6 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C7_Click(sender As Object, e As EventArgs) Handles btn_C7.Click
        If btn_C7.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C7.BackColor = Color.Empty
                assentos = assentos + "C7 "
                sql = "update tb_sessoes set C7 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C7.BackColor = Color.Black
            assentos = assentos.Replace("C7 ", "")
            sql = "update tb_sessoes set C7 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C8_Click(sender As Object, e As EventArgs) Handles btn_C8.Click
        If btn_C8.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C8.BackColor = Color.Empty
                assentos = assentos + "C8 "
                sql = "update tb_sessoes set C8 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C8.BackColor = Color.Black
            assentos = assentos.Replace("C8 ", "")
            sql = "update tb_sessoes set C8 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C9_Click(sender As Object, e As EventArgs) Handles btn_C9.Click
        If btn_C9.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C9.BackColor = Color.Empty
                assentos = assentos + "C9 "
                sql = "update tb_sessoes set C9 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C9.BackColor = Color.Black
            assentos = assentos.Replace("C9 ", "")
            sql = "update tb_sessoes set C9 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C10_Click(sender As Object, e As EventArgs) Handles btn_C10.Click
        If btn_C10.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C10.BackColor = Color.Empty
                assentos = assentos + "C10 "
                sql = "update tb_sessoes set C10 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C10.BackColor = Color.Black
            assentos = assentos.Replace("C10 ", "")
            sql = "update tb_sessoes set C10 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C11_Click(sender As Object, e As EventArgs) Handles btn_C11.Click
        If btn_C11.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C11.BackColor = Color.Empty
                assentos = assentos + "C11 "
                sql = "update tb_sessoes set C11 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C11.BackColor = Color.Black
            assentos = assentos.Replace("C11 ", "")
            sql = "update tb_sessoes set C11 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_C12_Click(sender As Object, e As EventArgs) Handles btn_C12.Click
        If btn_C12.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_C12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_C12.BackColor = Color.Empty
                assentos = assentos + "C12 "
                sql = "update tb_sessoes set C12 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_C12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_C12.BackColor = Color.Black
            assentos = assentos.Replace("C12 ", "")
            sql = "update tb_sessoes set C12 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D1_Click(sender As Object, e As EventArgs) Handles btn_D1.Click
        If btn_D1.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D1.BackColor = Color.Empty
                assentos = assentos + "D1 "
                sql = "update tb_sessoes set D1 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D1.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D1.BackColor = Color.Black
            assentos = assentos.Replace("D1 ", "")
            sql = "update tb_sessoes set D1 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D2_Click(sender As Object, e As EventArgs) Handles btn_D2.Click
        If btn_D2.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D2.BackColor = Color.Empty
                assentos = assentos + "D2 "
                sql = "update tb_sessoes set D2 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D2.BackColor = Color.Black
            assentos = assentos.Replace("D2 ", "")
            sql = "update tb_sessoes set D2 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D3_Click(sender As Object, e As EventArgs) Handles btn_D3.Click
        If btn_D3.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D3.BackColor = Color.Empty
                assentos = assentos + "D3 "
                sql = "update tb_sessoes set D3 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D3.BackColor = Color.Black
            assentos = assentos.Replace("D3 ", "")
            sql = "update tb_sessoes set D3 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D4_Click(sender As Object, e As EventArgs) Handles btn_D4.Click
        If btn_D4.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D4.BackColor = Color.Empty
                assentos = assentos + "D4 "
                sql = "update tb_sessoes set D4 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D4.BackColor = Color.Black
            assentos = assentos.Replace("D4 ", "")
            sql = "update tb_sessoes set D4 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D5_Click(sender As Object, e As EventArgs) Handles btn_D5.Click
        If btn_D5.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D5.BackColor = Color.Empty
                assentos = assentos + "D5 "
                sql = "update tb_sessoes set D5 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D5.BackColor = Color.Black
            assentos = assentos.Replace("D5 ", "")
            sql = "update tb_sessoes set D5 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D6_Click(sender As Object, e As EventArgs) Handles btn_D6.Click
        If btn_D6.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D6.BackColor = Color.Empty
                assentos = assentos + "D6 "
                sql = "update tb_sessoes set D6 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D6.BackColor = Color.Black
            assentos = assentos.Replace("D6 ", "")
            sql = "update tb_sessoes set D6 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D7_Click(sender As Object, e As EventArgs) Handles btn_D7.Click
        If btn_D7.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D7.BackColor = Color.Empty
                assentos = assentos + "D7 "
                sql = "update tb_sessoes set D7 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D7.BackColor = Color.Black
            assentos = assentos.Replace("D7 ", "")
            sql = "update tb_sessoes set D7 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D8_Click(sender As Object, e As EventArgs) Handles btn_D8.Click
        If btn_D8.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D8.BackColor = Color.Empty
                assentos = assentos + "D8 "
                sql = "update tb_sessoes set D8 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D8.BackColor = Color.Black
            assentos = assentos.Replace("D8 ", "")
            sql = "update tb_sessoes set D8 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D9_Click(sender As Object, e As EventArgs) Handles btn_D9.Click
        If btn_D9.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D9.BackColor = Color.Empty
                assentos = assentos + "D9 "
                sql = "update tb_sessoes set D9 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D9.BackColor = Color.Black
            assentos = assentos.Replace("D9 ", "")
            sql = "update tb_sessoes set D9 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D10_Click(sender As Object, e As EventArgs) Handles btn_D10.Click
        If btn_D10.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D10.BackColor = Color.Empty
                assentos = assentos + "D10 "
                sql = "update tb_sessoes set D10 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D10.BackColor = Color.Black
            assentos = assentos.Replace("D10 ", "")
            sql = "update tb_sessoes set D10 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D11_Click(sender As Object, e As EventArgs) Handles btn_D11.Click
        If btn_D11.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D11.BackColor = Color.Empty
                assentos = assentos + "D11 "
                sql = "update tb_sessoes set D11 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D11.BackColor = Color.Black
            assentos = assentos.Replace("D11 ", "")
            sql = "update tb_sessoes set D11 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_D12_Click(sender As Object, e As EventArgs) Handles btn_D12.Click
        If btn_D12.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_D12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_D12.BackColor = Color.Empty
                assentos = assentos + "D12 "
                sql = "update tb_sessoes set D12 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_D12.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_D12.BackColor = Color.Black
            assentos = assentos.Replace("D12 ", "")
            sql = "update tb_sessoes set D12 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E2_Click(sender As Object, e As EventArgs) Handles btn_E2.Click
        If btn_E2.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E2.BackColor = Color.Empty
                assentos = assentos + "E2 "
                sql = "update tb_sessoes set E2 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E2.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E2.BackColor = Color.Black
            assentos = assentos.Replace("E2 ", "")
            sql = "update tb_sessoes set E2 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E3_Click(sender As Object, e As EventArgs) Handles btn_E3.Click
        If btn_E3.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E3.BackColor = Color.Empty
                assentos = assentos + "E3 "
                sql = "update tb_sessoes set E3 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E3.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E3.BackColor = Color.Black
            assentos = assentos.Replace("E3 ", "")
            sql = "update tb_sessoes set E3 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E4_Click(sender As Object, e As EventArgs) Handles btn_E4.Click
        If btn_E4.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E4.BackColor = Color.Empty
                assentos = assentos + "E4 "
                sql = "update tb_sessoes set E4 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E4.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E4.BackColor = Color.Black
            assentos = assentos.Replace("E4 ", "")
            sql = "update tb_sessoes set E4 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E5_Click(sender As Object, e As EventArgs) Handles btn_E5.Click
        If btn_E5.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E5.BackColor = Color.Empty
                assentos = assentos + "E5 "
                sql = "update tb_sessoes set E5 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E5.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E5.BackColor = Color.Black
            assentos = assentos.Replace("E5 ", "")
            sql = "update tb_sessoes set E5 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E6_Click(sender As Object, e As EventArgs) Handles btn_E6.Click
        If btn_E6.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E6.BackColor = Color.Empty
                assentos = assentos + "E6 "
                sql = "update tb_sessoes set E6 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E6.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E6.BackColor = Color.Black
            assentos = assentos.Replace("E6 ", "")
            sql = "update tb_sessoes set E6 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E7_Click(sender As Object, e As EventArgs) Handles btn_E7.Click
        If btn_E7.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E7.BackColor = Color.Empty
                assentos = assentos + "E7 "
                sql = "update tb_sessoes set E7 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E7.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E7.BackColor = Color.Black
            assentos = assentos.Replace("E7 ", "")
            sql = "update tb_sessoes set E7 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E8_Click(sender As Object, e As EventArgs) Handles btn_E8.Click
        If btn_E8.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E8.BackColor = Color.Empty
                assentos = assentos + "E8 "
                sql = "update tb_sessoes set E8 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E8.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E8.BackColor = Color.Black
            assentos = assentos.Replace("E8 ", "")
            sql = "update tb_sessoes set E8 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E9_Click(sender As Object, e As EventArgs) Handles btn_E9.Click
        If btn_E9.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E9.BackColor = Color.Empty
                assentos = assentos + "E9 "
                sql = "update tb_sessoes set E9 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E9.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E9.BackColor = Color.Black
            assentos = assentos.Replace("E9 ", "")
            sql = "update tb_sessoes set E9 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E10_Click(sender As Object, e As EventArgs) Handles btn_E10.Click
        If btn_E10.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E10.BackColor = Color.Empty
                assentos = assentos + "E10 "
                sql = "update tb_sessoes set E10 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E10.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E10.BackColor = Color.Black
            assentos = assentos.Replace("E10 ", "")
            sql = "update tb_sessoes set E10 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

    Private Sub btn_E11_Click(sender As Object, e As EventArgs) Handles btn_E11.Click
        If btn_E11.BackColor = Color.Black Then
            If cont < qtde_assentos Then
                btn_E11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_selecionado.png")
                btn_E11.BackColor = Color.Empty
                assentos = assentos + "E11 "
                sql = "update tb_sessoes set E11 = 1 where id_sessao = " & id_sessao & ""
                db.Execute(UCase(sql))
                cont = cont + 1
            End If
        Else
            btn_E11.BackgroundImage = Image.FromFile(Application.StartupPath & "\icones\assento_disponivel.png")
            btn_E11.BackColor = Color.Black
            assentos = assentos.Replace("E11 ", "")
            sql = "update tb_sessoes set E11 = 0 where id_sessao = " & id_sessao & ""
            db.Execute(UCase(sql))
            cont = cont - 1
        End If
        txt_assentos.Text = assentos
    End Sub

End Class