<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_checar_pedidos
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_noite = New System.Windows.Forms.RadioButton()
        Me.rb_tarde = New System.Windows.Forms.RadioButton()
        Me.rb_manha = New System.Windows.Forms.RadioButton()
        Me.ccb_periodo = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_final = New System.Windows.Forms.DateTimePicker()
        Me.dtp_inico = New System.Windows.Forms.DateTimePicker()
        Me.ccb_dia = New System.Windows.Forms.CheckBox()
        Me.cmb_operador = New System.Windows.Forms.ComboBox()
        Me.ccb_operador = New System.Windows.Forms.CheckBox()
        Me.ccb_filme = New System.Windows.Forms.CheckBox()
        Me.cmb_filmes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cancelar.Location = New System.Drawing.Point(107, 407)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(164, 43)
        Me.btn_cancelar.TabIndex = 20
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.Red
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_confirmar.Location = New System.Drawing.Point(288, 407)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(164, 43)
        Me.btn_confirmar.TabIndex = 19
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Filtros"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_filmes)
        Me.GroupBox1.Controls.Add(Me.ccb_filme)
        Me.GroupBox1.Controls.Add(Me.rb_noite)
        Me.GroupBox1.Controls.Add(Me.rb_tarde)
        Me.GroupBox1.Controls.Add(Me.rb_manha)
        Me.GroupBox1.Controls.Add(Me.ccb_periodo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp_final)
        Me.GroupBox1.Controls.Add(Me.dtp_inico)
        Me.GroupBox1.Controls.Add(Me.ccb_dia)
        Me.GroupBox1.Controls.Add(Me.cmb_operador)
        Me.GroupBox1.Controls.Add(Me.ccb_operador)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 319)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'rb_noite
        '
        Me.rb_noite.AutoSize = True
        Me.rb_noite.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rb_noite.Enabled = False
        Me.rb_noite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rb_noite.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_noite.Location = New System.Drawing.Point(206, 197)
        Me.rb_noite.Name = "rb_noite"
        Me.rb_noite.Size = New System.Drawing.Size(61, 22)
        Me.rb_noite.TabIndex = 9
        Me.rb_noite.TabStop = True
        Me.rb_noite.Text = "Noite"
        Me.rb_noite.UseVisualStyleBackColor = False
        '
        'rb_tarde
        '
        Me.rb_tarde.AutoSize = True
        Me.rb_tarde.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rb_tarde.Enabled = False
        Me.rb_tarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rb_tarde.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_tarde.Location = New System.Drawing.Point(134, 197)
        Me.rb_tarde.Name = "rb_tarde"
        Me.rb_tarde.Size = New System.Drawing.Size(64, 22)
        Me.rb_tarde.TabIndex = 8
        Me.rb_tarde.TabStop = True
        Me.rb_tarde.Text = "Tarde"
        Me.rb_tarde.UseVisualStyleBackColor = False
        '
        'rb_manha
        '
        Me.rb_manha.AutoSize = True
        Me.rb_manha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rb_manha.Enabled = False
        Me.rb_manha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rb_manha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_manha.Location = New System.Drawing.Point(48, 197)
        Me.rb_manha.Name = "rb_manha"
        Me.rb_manha.Size = New System.Drawing.Size(71, 22)
        Me.rb_manha.TabIndex = 7
        Me.rb_manha.TabStop = True
        Me.rb_manha.Text = "Manhā"
        Me.rb_manha.UseVisualStyleBackColor = False
        '
        'ccb_periodo
        '
        Me.ccb_periodo.AutoSize = True
        Me.ccb_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ccb_periodo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ccb_periodo.Location = New System.Drawing.Point(48, 169)
        Me.ccb_periodo.Name = "ccb_periodo"
        Me.ccb_periodo.Size = New System.Drawing.Size(79, 22)
        Me.ccb_periodo.TabIndex = 6
        Me.ccb_periodo.Text = "Periodo"
        Me.ccb_periodo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(254, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "à"
        '
        'dtp_final
        '
        Me.dtp_final.Enabled = False
        Me.dtp_final.Location = New System.Drawing.Point(276, 124)
        Me.dtp_final.Name = "dtp_final"
        Me.dtp_final.Size = New System.Drawing.Size(200, 20)
        Me.dtp_final.TabIndex = 4
        '
        'dtp_inico
        '
        Me.dtp_inico.Enabled = False
        Me.dtp_inico.Location = New System.Drawing.Point(48, 124)
        Me.dtp_inico.Name = "dtp_inico"
        Me.dtp_inico.Size = New System.Drawing.Size(200, 20)
        Me.dtp_inico.TabIndex = 3
        '
        'ccb_dia
        '
        Me.ccb_dia.AutoSize = True
        Me.ccb_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ccb_dia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ccb_dia.Location = New System.Drawing.Point(48, 95)
        Me.ccb_dia.Name = "ccb_dia"
        Me.ccb_dia.Size = New System.Drawing.Size(49, 22)
        Me.ccb_dia.TabIndex = 2
        Me.ccb_dia.Text = "Dia"
        Me.ccb_dia.UseVisualStyleBackColor = True
        '
        'cmb_operador
        '
        Me.cmb_operador.Enabled = False
        Me.cmb_operador.FormattingEnabled = True
        Me.cmb_operador.Location = New System.Drawing.Point(48, 267)
        Me.cmb_operador.Name = "cmb_operador"
        Me.cmb_operador.Size = New System.Drawing.Size(248, 21)
        Me.cmb_operador.TabIndex = 1
        '
        'ccb_operador
        '
        Me.ccb_operador.AutoSize = True
        Me.ccb_operador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ccb_operador.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ccb_operador.Location = New System.Drawing.Point(48, 239)
        Me.ccb_operador.Name = "ccb_operador"
        Me.ccb_operador.Size = New System.Drawing.Size(90, 22)
        Me.ccb_operador.TabIndex = 0
        Me.ccb_operador.Text = "Operador"
        Me.ccb_operador.UseVisualStyleBackColor = True
        '
        'ccb_filme
        '
        Me.ccb_filme.AutoSize = True
        Me.ccb_filme.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ccb_filme.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ccb_filme.Location = New System.Drawing.Point(48, 28)
        Me.ccb_filme.Name = "ccb_filme"
        Me.ccb_filme.Size = New System.Drawing.Size(63, 22)
        Me.ccb_filme.TabIndex = 10
        Me.ccb_filme.Text = "Filme"
        Me.ccb_filme.UseVisualStyleBackColor = True
        '
        'cmb_filmes
        '
        Me.cmb_filmes.FormattingEnabled = True
        Me.cmb_filmes.Location = New System.Drawing.Point(48, 56)
        Me.cmb_filmes.Name = "cmb_filmes"
        Me.cmb_filmes.Size = New System.Drawing.Size(248, 21)
        Me.cmb_filmes.TabIndex = 21
        '
        'checar_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(547, 488)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "checar_pedidos"
        Me.Text = "Checar Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ccb_filme As CheckBox
    Friend WithEvents rb_noite As RadioButton
    Friend WithEvents rb_tarde As RadioButton
    Friend WithEvents rb_manha As RadioButton
    Friend WithEvents ccb_periodo As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_final As DateTimePicker
    Friend WithEvents dtp_inico As DateTimePicker
    Friend WithEvents ccb_dia As CheckBox
    Friend WithEvents cmb_operador As ComboBox
    Friend WithEvents ccb_operador As CheckBox
    Friend WithEvents cmb_filmes As ComboBox
End Class
