<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_esqueceu_senha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_esqueceu_senha))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome_completo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Insire suas informações"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_voltar.Location = New System.Drawing.Point(47, 336)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 33)
        Me.btn_voltar.TabIndex = 5
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.Red
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_confirmar.Location = New System.Drawing.Point(239, 336)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(130, 33)
        Me.btn_confirmar.TabIndex = 4
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'txt_cpf
        '
        Me.txt_cpf.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(47, 103)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(124, 27)
        Me.txt_cpf.TabIndex = 1
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_cpf.Location = New System.Drawing.Point(43, 79)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(37, 21)
        Me.lbl_cpf.TabIndex = 23
        Me.lbl_cpf.Text = "CPF"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(47, 251)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(272, 27)
        Me.txt_email.TabIndex = 3
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_email.Location = New System.Drawing.Point(43, 227)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(55, 21)
        Me.lbl_email.TabIndex = 21
        Me.lbl_email.Text = "E-Mail"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(47, 175)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(272, 27)
        Me.txt_nome.TabIndex = 2
        '
        'lbl_nome_completo
        '
        Me.lbl_nome_completo.AutoSize = True
        Me.lbl_nome_completo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_completo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_nome_completo.Location = New System.Drawing.Point(43, 150)
        Me.lbl_nome_completo.Name = "lbl_nome_completo"
        Me.lbl_nome_completo.Size = New System.Drawing.Size(132, 21)
        Me.lbl_nome_completo.TabIndex = 17
        Me.lbl_nome_completo.Text = "Nome Completo"
        '
        'frm_esqueceu_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(421, 418)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_nome_completo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_esqueceu_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_nome_completo As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents txt_cpf As MaskedTextBox
End Class
