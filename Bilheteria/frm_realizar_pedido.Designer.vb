<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_realizar_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_realizar_pedido))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_qtde = New System.Windows.Forms.Label()
        Me.rb_meia = New System.Windows.Forms.RadioButton()
        Me.btn_salas = New System.Windows.Forms.Button()
        Me.lbl_data_horario_sala = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grp_ingressos = New System.Windows.Forms.GroupBox()
        Me.rb_inteira = New System.Windows.Forms.RadioButton()
        Me.txt_quantidade = New System.Windows.Forms.MaskedTextBox()
        Me.txt_valor_total = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_total_pagar = New System.Windows.Forms.Label()
        Me.grp_mets_pagto = New System.Windows.Forms.GroupBox()
        Me.rb_pix = New System.Windows.Forms.RadioButton()
        Me.rb_cartao_debito = New System.Windows.Forms.RadioButton()
        Me.rb_dinheiro = New System.Windows.Forms.RadioButton()
        Me.rb_cartao_credito = New System.Windows.Forms.RadioButton()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.cmb_filmes_pedido = New System.Windows.Forms.ComboBox()
        Me.lbl_lugares = New System.Windows.Forms.Label()
        Me.grp_ingressos.SuspendLayout()
        Me.grp_mets_pagto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(46, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Filme"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(465, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Preço"
        '
        'txt_valor
        '
        Me.txt_valor.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_valor.Location = New System.Drawing.Point(483, 70)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.ReadOnly = True
        Me.txt_valor.Size = New System.Drawing.Size(70, 27)
        Me.txt_valor.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Ingressos"
        '
        'lbl_qtde
        '
        Me.lbl_qtde.AutoSize = True
        Me.lbl_qtde.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qtde.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_qtde.Location = New System.Drawing.Point(30, 44)
        Me.lbl_qtde.Name = "lbl_qtde"
        Me.lbl_qtde.Size = New System.Drawing.Size(47, 21)
        Me.lbl_qtde.TabIndex = 18
        Me.lbl_qtde.Text = "Qtde"
        '
        'rb_meia
        '
        Me.rb_meia.AutoSize = True
        Me.rb_meia.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_meia.ForeColor = System.Drawing.Color.White
        Me.rb_meia.Location = New System.Drawing.Point(165, 75)
        Me.rb_meia.Name = "rb_meia"
        Me.rb_meia.Size = New System.Drawing.Size(64, 25)
        Me.rb_meia.TabIndex = 20
        Me.rb_meia.TabStop = True
        Me.rb_meia.Text = "Meia"
        Me.rb_meia.UseVisualStyleBackColor = True
        '
        'btn_salas
        '
        Me.btn_salas.BackColor = System.Drawing.Color.Red
        Me.btn_salas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_salas.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_salas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salas.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_salas.Location = New System.Drawing.Point(227, 298)
        Me.btn_salas.Name = "btn_salas"
        Me.btn_salas.Size = New System.Drawing.Size(191, 42)
        Me.btn_salas.TabIndex = 25
        Me.btn_salas.Text = "Selecionar Sessão"
        Me.btn_salas.UseVisualStyleBackColor = False
        '
        'lbl_data_horario_sala
        '
        Me.lbl_data_horario_sala.AutoSize = True
        Me.lbl_data_horario_sala.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_horario_sala.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_data_horario_sala.Location = New System.Drawing.Point(424, 298)
        Me.lbl_data_horario_sala.Name = "lbl_data_horario_sala"
        Me.lbl_data_horario_sala.Size = New System.Drawing.Size(206, 21)
        Me.lbl_data_horario_sala.TabIndex = 26
        Me.lbl_data_horario_sala.Text = "[ Data ] | [ Horário ] | [ Sala ]"
        Me.lbl_data_horario_sala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Red
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(194, 23)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Método de Pagamento"
        '
        'grp_ingressos
        '
        Me.grp_ingressos.Controls.Add(Me.rb_inteira)
        Me.grp_ingressos.Controls.Add(Me.txt_quantidade)
        Me.grp_ingressos.Controls.Add(Me.txt_valor_total)
        Me.grp_ingressos.Controls.Add(Me.Label9)
        Me.grp_ingressos.Controls.Add(Me.lbl_total_pagar)
        Me.grp_ingressos.Controls.Add(Me.lbl_qtde)
        Me.grp_ingressos.Controls.Add(Me.rb_meia)
        Me.grp_ingressos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_ingressos.Location = New System.Drawing.Point(40, 127)
        Me.grp_ingressos.Name = "grp_ingressos"
        Me.grp_ingressos.Size = New System.Drawing.Size(541, 137)
        Me.grp_ingressos.TabIndex = 28
        Me.grp_ingressos.TabStop = False
        Me.grp_ingressos.Text = "GroupBox1"
        '
        'rb_inteira
        '
        Me.rb_inteira.AutoSize = True
        Me.rb_inteira.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_inteira.ForeColor = System.Drawing.Color.White
        Me.rb_inteira.Location = New System.Drawing.Point(165, 44)
        Me.rb_inteira.Name = "rb_inteira"
        Me.rb_inteira.Size = New System.Drawing.Size(75, 25)
        Me.rb_inteira.TabIndex = 28
        Me.rb_inteira.TabStop = True
        Me.rb_inteira.Text = "Inteira"
        Me.rb_inteira.UseVisualStyleBackColor = True
        '
        'txt_quantidade
        '
        Me.txt_quantidade.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_quantidade.Location = New System.Drawing.Point(34, 68)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(43, 27)
        Me.txt_quantidade.TabIndex = 27
        Me.txt_quantidade.ValidatingType = GetType(Integer)
        '
        'txt_valor_total
        '
        Me.txt_valor_total.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_valor_total.Location = New System.Drawing.Point(429, 58)
        Me.txt_valor_total.Name = "txt_valor_total"
        Me.txt_valor_total.ReadOnly = True
        Me.txt_valor_total.Size = New System.Drawing.Size(72, 27)
        Me.txt_valor_total.TabIndex = 31
        '
        'lbl_total_pagar
        '
        Me.lbl_total_pagar.AutoSize = True
        Me.lbl_total_pagar.BackColor = System.Drawing.Color.Black
        Me.lbl_total_pagar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_pagar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_total_pagar.Location = New System.Drawing.Point(314, 58)
        Me.lbl_total_pagar.Name = "lbl_total_pagar"
        Me.lbl_total_pagar.Size = New System.Drawing.Size(102, 21)
        Me.lbl_total_pagar.TabIndex = 30
        Me.lbl_total_pagar.Text = "Total a Pagar"
        '
        'grp_mets_pagto
        '
        Me.grp_mets_pagto.Controls.Add(Me.Label15)
        Me.grp_mets_pagto.Controls.Add(Me.rb_pix)
        Me.grp_mets_pagto.Controls.Add(Me.rb_cartao_debito)
        Me.grp_mets_pagto.Controls.Add(Me.rb_dinheiro)
        Me.grp_mets_pagto.Controls.Add(Me.rb_cartao_credito)
        Me.grp_mets_pagto.Location = New System.Drawing.Point(40, 376)
        Me.grp_mets_pagto.Name = "grp_mets_pagto"
        Me.grp_mets_pagto.Size = New System.Drawing.Size(541, 115)
        Me.grp_mets_pagto.TabIndex = 29
        Me.grp_mets_pagto.TabStop = False
        Me.grp_mets_pagto.Text = "GroupBox2"
        '
        'rb_pix
        '
        Me.rb_pix.AutoSize = True
        Me.rb_pix.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_pix.ForeColor = System.Drawing.Color.White
        Me.rb_pix.Location = New System.Drawing.Point(326, 67)
        Me.rb_pix.Name = "rb_pix"
        Me.rb_pix.Size = New System.Drawing.Size(52, 25)
        Me.rb_pix.TabIndex = 31
        Me.rb_pix.TabStop = True
        Me.rb_pix.Text = "PIX"
        Me.rb_pix.UseVisualStyleBackColor = True
        '
        'rb_cartao_debito
        '
        Me.rb_cartao_debito.AutoSize = True
        Me.rb_cartao_debito.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_cartao_debito.ForeColor = System.Drawing.Color.White
        Me.rb_cartao_debito.Location = New System.Drawing.Point(42, 67)
        Me.rb_cartao_debito.Name = "rb_cartao_debito"
        Me.rb_cartao_debito.Size = New System.Drawing.Size(153, 25)
        Me.rb_cartao_debito.TabIndex = 31
        Me.rb_cartao_debito.TabStop = True
        Me.rb_cartao_debito.Text = "Cartão de Débito"
        Me.rb_cartao_debito.UseVisualStyleBackColor = True
        '
        'rb_dinheiro
        '
        Me.rb_dinheiro.AutoSize = True
        Me.rb_dinheiro.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_dinheiro.ForeColor = System.Drawing.Color.White
        Me.rb_dinheiro.Location = New System.Drawing.Point(326, 36)
        Me.rb_dinheiro.Name = "rb_dinheiro"
        Me.rb_dinheiro.Size = New System.Drawing.Size(90, 25)
        Me.rb_dinheiro.TabIndex = 30
        Me.rb_dinheiro.TabStop = True
        Me.rb_dinheiro.Text = "Dinheiro"
        Me.rb_dinheiro.UseVisualStyleBackColor = True
        '
        'rb_cartao_credito
        '
        Me.rb_cartao_credito.AutoSize = True
        Me.rb_cartao_credito.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_cartao_credito.ForeColor = System.Drawing.Color.White
        Me.rb_cartao_credito.Location = New System.Drawing.Point(42, 36)
        Me.rb_cartao_credito.Name = "rb_cartao_credito"
        Me.rb_cartao_credito.Size = New System.Drawing.Size(158, 25)
        Me.rb_cartao_credito.TabIndex = 30
        Me.rb_cartao_credito.TabStop = True
        Me.rb_cartao_credito.Text = "Cartão de Crédito"
        Me.rb_cartao_credito.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cancelar.Location = New System.Drawing.Point(158, 538)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(130, 33)
        Me.btn_cancelar.TabIndex = 33
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.Red
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_confirmar.Location = New System.Drawing.Point(343, 538)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(130, 33)
        Me.btn_confirmar.TabIndex = 32
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'cmb_filmes_pedido
        '
        Me.cmb_filmes_pedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filmes_pedido.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_filmes_pedido.FormattingEnabled = True
        Me.cmb_filmes_pedido.Location = New System.Drawing.Point(59, 69)
        Me.cmb_filmes_pedido.Name = "cmb_filmes_pedido"
        Me.cmb_filmes_pedido.Size = New System.Drawing.Size(332, 28)
        Me.cmb_filmes_pedido.TabIndex = 13
        '
        'lbl_lugares
        '
        Me.lbl_lugares.AutoSize = True
        Me.lbl_lugares.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lugares.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_lugares.Location = New System.Drawing.Point(424, 319)
        Me.lbl_lugares.Name = "lbl_lugares"
        Me.lbl_lugares.Size = New System.Drawing.Size(175, 21)
        Me.lbl_lugares.TabIndex = 34
        Me.lbl_lugares.Text = "[ Assentos Escolhidos ]"
        Me.lbl_lugares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_realizar_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(625, 607)
        Me.Controls.Add(Me.lbl_lugares)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_filmes_pedido)
        Me.Controls.Add(Me.lbl_data_horario_sala)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grp_ingressos)
        Me.Controls.Add(Me.btn_salas)
        Me.Controls.Add(Me.grp_mets_pagto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_realizar_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Venda"
        Me.grp_ingressos.ResumeLayout(False)
        Me.grp_ingressos.PerformLayout()
        Me.grp_mets_pagto.ResumeLayout(False)
        Me.grp_mets_pagto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_valor As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_qtde As Label
    Friend WithEvents rb_meia As RadioButton
    Friend WithEvents btn_salas As Button
    Friend WithEvents lbl_data_horario_sala As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents grp_ingressos As GroupBox
    Friend WithEvents grp_mets_pagto As GroupBox
    Friend WithEvents rb_pix As RadioButton
    Friend WithEvents rb_cartao_debito As RadioButton
    Friend WithEvents rb_dinheiro As RadioButton
    Friend WithEvents rb_cartao_credito As RadioButton
    Friend WithEvents lbl_total_pagar As Label
    Friend WithEvents txt_valor_total As MaskedTextBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents cmb_filmes_pedido As ComboBox
    Friend WithEvents txt_quantidade As MaskedTextBox
    Friend WithEvents rb_inteira As RadioButton
    Friend WithEvents lbl_lugares As Label
End Class
