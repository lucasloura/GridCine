Public Class frm_esqueceu_senha

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            sql = "select cpf, nome, email, senha from tb_funcionarios where cpf = '" & txt_cpf.Text & "' and nome = '" & txt_nome.Text & "' and email = '" & txt_email.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("CPF: " & rs.Fields(0).Value + vbNewLine & "Senha: " & rs.Fields(3).Value, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                MsgBox("Dados inválidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao consultar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub frm_esqueceu_senha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trocar_tema()
    End Sub
End Class