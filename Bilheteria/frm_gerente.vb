Public Class frm_gerente

    Private Sub btn_encerrar_sessao_Click(sender As Object, e As EventArgs) Handles btn_encerrar_sessao.Click
        Me.Close()
    End Sub

    Private Sub gerente_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        frm_login.Show()
        frm_login.BringToFront()
        frm_login.txt_cpf.Focus()
        cont = 0
    End Sub
    Private Sub btn_checar_pedidos_icone_Click(sender As Object, e As EventArgs) Handles btn_checar_pedidos_icone.Click
        frm_checar_pedidos.ShowDialog()
    End Sub

    Private Sub btn_checar_pedidos_Click(sender As Object, e As EventArgs) Handles btn_checar_pedidos.Click
        frm_checar_pedidos.ShowDialog()
    End Sub

    Private Sub btn_checar_filmes_icone_Click(sender As Object, e As EventArgs) Handles btn_checar_filmes_icone.Click
        checar_filmes.ShowDialog()
    End Sub

    Private Sub btn_checar_filmes_Click(sender As Object, e As EventArgs) Handles btn_checar_filmes.Click
        checar_filmes.ShowDialog()
    End Sub

    Private Sub btn_configurar_contas_icone_Click(sender As Object, e As EventArgs) Handles btn_configurar_contas_icone.Click
        frm_configurar_contas.ShowDialog()
    End Sub

    Private Sub btn_configurar_contas_Click(sender As Object, e As EventArgs) Handles btn_configurar_contas.Click
        frm_configurar_contas.ShowDialog()
    End Sub

    Private Sub btn_consultar_registros_icone_Click(sender As Object, e As EventArgs) Handles btn_consultar_registros_icone.Click
        frm_consultar_registros.ShowDialog()
    End Sub

    Private Sub btn_consultar_registros_Click(sender As Object, e As EventArgs) Handles btn_consultar_registros.Click
        frm_consultar_registros.ShowDialog()
    End Sub

    Private Sub gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = nome
        lbl_cargo.Text = cargo
        trocar_tema()
    End Sub

    Private Sub btn_trocar_tema_Click(sender As Object, e As EventArgs) Handles btn_trocar_tema.Click
        If btn_trocar_tema.BackColor = Color.Black Then
            tema = "claro"
        Else
            tema = "escuro"
        End If
        trocar_tema()
    End Sub
End Class