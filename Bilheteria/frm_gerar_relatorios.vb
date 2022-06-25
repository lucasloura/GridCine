Public Class Gerar_relatorio
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        frm_gerente.ShowDialog()
        Me.Close()
    End Sub
End Class