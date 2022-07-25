<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.img_usuario = New System.Windows.Forms.PictureBox()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.btn_esqueceu_senha = New System.Windows.Forms.Button()
        Me.btn_trocar_tema = New System.Windows.Forms.Button()
        CType(Me.img_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(285, 202)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(195, 27)
        Me.txt_senha.TabIndex = 1
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.Red
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_confirmar.Location = New System.Drawing.Point(203, 305)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(152, 39)
        Me.btn_confirmar.TabIndex = 3
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'img_usuario
        '
        Me.img_usuario.BackColor = System.Drawing.Color.Black
        Me.img_usuario.BackgroundImage = CType(resources.GetObject("img_usuario.BackgroundImage"), System.Drawing.Image)
        Me.img_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_usuario.Location = New System.Drawing.Point(81, 87)
        Me.img_usuario.Name = "img_usuario"
        Me.img_usuario.Size = New System.Drawing.Size(163, 157)
        Me.img_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_usuario.TabIndex = 7
        Me.img_usuario.TabStop = False
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_cpf.Location = New System.Drawing.Point(281, 98)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(37, 21)
        Me.lbl_cpf.TabIndex = 18
        Me.lbl_cpf.Text = "CPF"
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_senha.Location = New System.Drawing.Point(281, 178)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(54, 21)
        Me.lbl_senha.TabIndex = 19
        Me.lbl_senha.Text = "Senha"
        '
        'txt_cpf
        '
        Me.txt_cpf.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(285, 122)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(195, 27)
        Me.txt_cpf.TabIndex = 0
        '
        'btn_esqueceu_senha
        '
        Me.btn_esqueceu_senha.BackColor = System.Drawing.Color.Black
        Me.btn_esqueceu_senha.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_esqueceu_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_esqueceu_senha.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_esqueceu_senha.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_esqueceu_senha.Location = New System.Drawing.Point(275, 225)
        Me.btn_esqueceu_senha.Name = "btn_esqueceu_senha"
        Me.btn_esqueceu_senha.Size = New System.Drawing.Size(119, 24)
        Me.btn_esqueceu_senha.TabIndex = 4
        Me.btn_esqueceu_senha.Text = "Esqueceu a senha?"
        Me.btn_esqueceu_senha.UseVisualStyleBackColor = False
        '
        'btn_trocar_tema
        '
        Me.btn_trocar_tema.BackgroundImage = CType(resources.GetObject("btn_trocar_tema.BackgroundImage"), System.Drawing.Image)
        Me.btn_trocar_tema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_trocar_tema.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_trocar_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_trocar_tema.Location = New System.Drawing.Point(503, 30)
        Me.btn_trocar_tema.Name = "btn_trocar_tema"
        Me.btn_trocar_tema.Size = New System.Drawing.Size(35, 35)
        Me.btn_trocar_tema.TabIndex = 60
        Me.btn_trocar_tema.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(559, 378)
        Me.Controls.Add(Me.btn_trocar_tema)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.img_usuario)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_esqueceu_senha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GridCine"
        CType(Me.img_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents img_usuario As PictureBox
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents btn_esqueceu_senha As Button
    Friend WithEvents btn_trocar_tema As Button
End Class
