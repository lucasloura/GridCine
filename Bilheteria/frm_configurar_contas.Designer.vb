<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_configurar_contas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_configurar_contas))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.tab_contas = New System.Windows.Forms.TabControl()
        Me.tab_page_individual = New System.Windows.Forms.TabPage()
        Me.gb_status_conta = New System.Windows.Forms.GroupBox()
        Me.rb_bloqueado = New System.Windows.Forms.RadioButton()
        Me.rb_ativo = New System.Windows.Forms.RadioButton()
        Me.lbl_status_conta = New System.Windows.Forms.Label()
        Me.gb_tipo_conta = New System.Windows.Forms.GroupBox()
        Me.rb_gerente = New System.Windows.Forms.RadioButton()
        Me.rb_operador = New System.Windows.Forms.RadioButton()
        Me.lbl_tipo_conta = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.tab_page_listagem = New System.Windows.Forms.TabPage()
        Me.txt_pesquisa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_contas = New System.Windows.Forms.DataGridView()
        Me.dgv_contas_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_contas_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_contas_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_contas_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_contas_editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgv_contas_excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.tab_contas.SuspendLayout()
        Me.tab_page_individual.SuspendLayout()
        Me.gb_status_conta.SuspendLayout()
        Me.gb_tipo_conta.SuspendLayout()
        Me.tab_page_listagem.SuspendLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dados Pessoais"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(20, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Operacional"
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.Red
        Me.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_salvar.Location = New System.Drawing.Point(293, 452)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(130, 33)
        Me.btn_salvar.TabIndex = 9
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'tab_contas
        '
        Me.tab_contas.Controls.Add(Me.tab_page_individual)
        Me.tab_contas.Controls.Add(Me.tab_page_listagem)
        Me.tab_contas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_contas.Location = New System.Drawing.Point(26, 16)
        Me.tab_contas.Name = "tab_contas"
        Me.tab_contas.SelectedIndex = 0
        Me.tab_contas.Size = New System.Drawing.Size(478, 407)
        Me.tab_contas.TabIndex = 0
        '
        'tab_page_individual
        '
        Me.tab_page_individual.BackColor = System.Drawing.Color.Black
        Me.tab_page_individual.Controls.Add(Me.gb_status_conta)
        Me.tab_page_individual.Controls.Add(Me.gb_tipo_conta)
        Me.tab_page_individual.Controls.Add(Me.txt_senha)
        Me.tab_page_individual.Controls.Add(Me.Label2)
        Me.tab_page_individual.Controls.Add(Me.lbl_senha)
        Me.tab_page_individual.Controls.Add(Me.txt_email)
        Me.tab_page_individual.Controls.Add(Me.lbl_email)
        Me.tab_page_individual.Controls.Add(Me.txt_nome)
        Me.tab_page_individual.Controls.Add(Me.Label7)
        Me.tab_page_individual.Controls.Add(Me.lbl_nome)
        Me.tab_page_individual.Controls.Add(Me.txt_cpf)
        Me.tab_page_individual.Controls.Add(Me.lbl_cpf)
        Me.tab_page_individual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_page_individual.Location = New System.Drawing.Point(4, 26)
        Me.tab_page_individual.Name = "tab_page_individual"
        Me.tab_page_individual.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_page_individual.Size = New System.Drawing.Size(470, 377)
        Me.tab_page_individual.TabIndex = 0
        Me.tab_page_individual.Text = "Individual"
        '
        'gb_status_conta
        '
        Me.gb_status_conta.Controls.Add(Me.rb_bloqueado)
        Me.gb_status_conta.Controls.Add(Me.rb_ativo)
        Me.gb_status_conta.Controls.Add(Me.lbl_status_conta)
        Me.gb_status_conta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_status_conta.Location = New System.Drawing.Point(240, 260)
        Me.gb_status_conta.Name = "gb_status_conta"
        Me.gb_status_conta.Size = New System.Drawing.Size(206, 87)
        Me.gb_status_conta.TabIndex = 8
        Me.gb_status_conta.TabStop = False
        '
        'rb_bloqueado
        '
        Me.rb_bloqueado.AutoSize = True
        Me.rb_bloqueado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_bloqueado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_bloqueado.Location = New System.Drawing.Point(93, 42)
        Me.rb_bloqueado.Name = "rb_bloqueado"
        Me.rb_bloqueado.Size = New System.Drawing.Size(100, 24)
        Me.rb_bloqueado.TabIndex = 8
        Me.rb_bloqueado.Text = "Bloqueado"
        Me.rb_bloqueado.UseVisualStyleBackColor = True
        '
        'rb_ativo
        '
        Me.rb_ativo.AutoSize = True
        Me.rb_ativo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_ativo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_ativo.Location = New System.Drawing.Point(25, 42)
        Me.rb_ativo.Name = "rb_ativo"
        Me.rb_ativo.Size = New System.Drawing.Size(62, 24)
        Me.rb_ativo.TabIndex = 7
        Me.rb_ativo.Text = "Ativo"
        Me.rb_ativo.UseVisualStyleBackColor = True
        '
        'lbl_status_conta
        '
        Me.lbl_status_conta.AutoSize = True
        Me.lbl_status_conta.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status_conta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_status_conta.Location = New System.Drawing.Point(21, 18)
        Me.lbl_status_conta.Name = "lbl_status_conta"
        Me.lbl_status_conta.Size = New System.Drawing.Size(55, 21)
        Me.lbl_status_conta.TabIndex = 5
        Me.lbl_status_conta.Text = "Status"
        '
        'gb_tipo_conta
        '
        Me.gb_tipo_conta.Controls.Add(Me.rb_gerente)
        Me.gb_tipo_conta.Controls.Add(Me.rb_operador)
        Me.gb_tipo_conta.Controls.Add(Me.lbl_tipo_conta)
        Me.gb_tipo_conta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_tipo_conta.Location = New System.Drawing.Point(27, 260)
        Me.gb_tipo_conta.Name = "gb_tipo_conta"
        Me.gb_tipo_conta.Size = New System.Drawing.Size(215, 87)
        Me.gb_tipo_conta.TabIndex = 6
        Me.gb_tipo_conta.TabStop = False
        '
        'rb_gerente
        '
        Me.rb_gerente.AutoSize = True
        Me.rb_gerente.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_gerente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_gerente.Location = New System.Drawing.Point(116, 42)
        Me.rb_gerente.Name = "rb_gerente"
        Me.rb_gerente.Size = New System.Drawing.Size(79, 24)
        Me.rb_gerente.TabIndex = 6
        Me.rb_gerente.Text = "Gerente"
        Me.rb_gerente.UseVisualStyleBackColor = True
        '
        'rb_operador
        '
        Me.rb_operador.AutoSize = True
        Me.rb_operador.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_operador.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_operador.Location = New System.Drawing.Point(19, 42)
        Me.rb_operador.Name = "rb_operador"
        Me.rb_operador.Size = New System.Drawing.Size(91, 24)
        Me.rb_operador.TabIndex = 5
        Me.rb_operador.Text = "Operador"
        Me.rb_operador.UseVisualStyleBackColor = True
        '
        'lbl_tipo_conta
        '
        Me.lbl_tipo_conta.AutoSize = True
        Me.lbl_tipo_conta.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_conta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_tipo_conta.Location = New System.Drawing.Point(15, 18)
        Me.lbl_tipo_conta.Name = "lbl_tipo_conta"
        Me.lbl_tipo_conta.Size = New System.Drawing.Size(113, 21)
        Me.lbl_tipo_conta.TabIndex = 5
        Me.lbl_tipo_conta.Text = "Tipo de Conta"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(299, 164)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(147, 27)
        Me.txt_senha.TabIndex = 4
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_senha.Location = New System.Drawing.Point(296, 140)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(54, 21)
        Me.lbl_senha.TabIndex = 17
        Me.lbl_senha.Text = "Senha"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(27, 164)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(240, 27)
        Me.txt_email.TabIndex = 3
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_email.Location = New System.Drawing.Point(23, 140)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(55, 21)
        Me.lbl_email.TabIndex = 15
        Me.lbl_email.Text = "E-Mail"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(183, 82)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(263, 27)
        Me.txt_nome.TabIndex = 2
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_nome.Location = New System.Drawing.Point(179, 57)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(55, 21)
        Me.lbl_nome.TabIndex = 13
        Me.lbl_nome.Text = "Nome"
        '
        'txt_cpf
        '
        Me.txt_cpf.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(27, 82)
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
        Me.lbl_cpf.Location = New System.Drawing.Point(23, 57)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(37, 21)
        Me.lbl_cpf.TabIndex = 10
        Me.lbl_cpf.Text = "CPF"
        '
        'tab_page_listagem
        '
        Me.tab_page_listagem.BackColor = System.Drawing.Color.Black
        Me.tab_page_listagem.Controls.Add(Me.txt_pesquisa)
        Me.tab_page_listagem.Controls.Add(Me.Label8)
        Me.tab_page_listagem.Controls.Add(Me.dgv_contas)
        Me.tab_page_listagem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tab_page_listagem.Location = New System.Drawing.Point(4, 26)
        Me.tab_page_listagem.Name = "tab_page_listagem"
        Me.tab_page_listagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_page_listagem.Size = New System.Drawing.Size(470, 377)
        Me.tab_page_listagem.TabIndex = 1
        Me.tab_page_listagem.Text = "Listagem"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txt_pesquisa.Location = New System.Drawing.Point(27, 60)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(231, 26)
        Me.txt_pesquisa.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(20, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Pesquisar por nome: "
        '
        'dgv_contas
        '
        Me.dgv_contas.AllowUserToAddRows = False
        Me.dgv_contas.AllowUserToDeleteRows = False
        Me.dgv_contas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_contas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_contas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_contas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_contas_cpf, Me.dgv_contas_nome, Me.dgv_contas_tipo, Me.dgv_contas_status, Me.dgv_contas_editar, Me.dgv_contas_excluir})
        Me.dgv_contas.Location = New System.Drawing.Point(6, 98)
        Me.dgv_contas.Name = "dgv_contas"
        Me.dgv_contas.ReadOnly = True
        Me.dgv_contas.Size = New System.Drawing.Size(458, 273)
        Me.dgv_contas.TabIndex = 1
        '
        'dgv_contas_cpf
        '
        Me.dgv_contas_cpf.HeaderText = "CPF"
        Me.dgv_contas_cpf.Name = "dgv_contas_cpf"
        Me.dgv_contas_cpf.ReadOnly = True
        Me.dgv_contas_cpf.Width = 54
        '
        'dgv_contas_nome
        '
        Me.dgv_contas_nome.HeaderText = "Nome"
        Me.dgv_contas_nome.Name = "dgv_contas_nome"
        Me.dgv_contas_nome.ReadOnly = True
        Me.dgv_contas_nome.Width = 69
        '
        'dgv_contas_tipo
        '
        Me.dgv_contas_tipo.HeaderText = "Tipo"
        Me.dgv_contas_tipo.Name = "dgv_contas_tipo"
        Me.dgv_contas_tipo.ReadOnly = True
        Me.dgv_contas_tipo.Width = 59
        '
        'dgv_contas_status
        '
        Me.dgv_contas_status.HeaderText = "Status"
        Me.dgv_contas_status.Name = "dgv_contas_status"
        Me.dgv_contas_status.ReadOnly = True
        Me.dgv_contas_status.Width = 68
        '
        'dgv_contas_editar
        '
        Me.dgv_contas_editar.HeaderText = "Editar"
        Me.dgv_contas_editar.Image = CType(resources.GetObject("dgv_contas_editar.Image"), System.Drawing.Image)
        Me.dgv_contas_editar.Name = "dgv_contas_editar"
        Me.dgv_contas_editar.ReadOnly = True
        Me.dgv_contas_editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_contas_editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgv_contas_editar.Width = 67
        '
        'dgv_contas_excluir
        '
        Me.dgv_contas_excluir.HeaderText = "Excluir"
        Me.dgv_contas_excluir.Image = CType(resources.GetObject("dgv_contas_excluir.Image"), System.Drawing.Image)
        Me.dgv_contas_excluir.Name = "dgv_contas_excluir"
        Me.dgv_contas_excluir.ReadOnly = True
        Me.dgv_contas_excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_contas_excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgv_contas_excluir.Width = 70
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_voltar.Location = New System.Drawing.Point(113, 452)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 33)
        Me.btn_voltar.TabIndex = 10
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_configurar_contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(528, 521)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.tab_contas)
        Me.Controls.Add(Me.btn_salvar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_configurar_contas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Contas"
        Me.tab_contas.ResumeLayout(False)
        Me.tab_page_individual.ResumeLayout(False)
        Me.tab_page_individual.PerformLayout()
        Me.gb_status_conta.ResumeLayout(False)
        Me.gb_status_conta.PerformLayout()
        Me.gb_tipo_conta.ResumeLayout(False)
        Me.gb_tipo_conta.PerformLayout()
        Me.tab_page_listagem.ResumeLayout(False)
        Me.tab_page_listagem.PerformLayout()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_salvar As Button
    Friend WithEvents tab_contas As TabControl
    Friend WithEvents tab_page_individual As TabPage
    Friend WithEvents tab_page_listagem As TabPage
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_senha As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents gb_tipo_conta As GroupBox
    Friend WithEvents rb_gerente As RadioButton
    Friend WithEvents rb_operador As RadioButton
    Friend WithEvents lbl_tipo_conta As Label
    Friend WithEvents gb_status_conta As GroupBox
    Friend WithEvents rb_bloqueado As RadioButton
    Friend WithEvents rb_ativo As RadioButton
    Friend WithEvents lbl_status_conta As Label
    Friend WithEvents dgv_contas As DataGridView
    Friend WithEvents txt_pesquisa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_contas_cpf As DataGridViewTextBoxColumn
    Friend WithEvents dgv_contas_nome As DataGridViewTextBoxColumn
    Friend WithEvents dgv_contas_tipo As DataGridViewTextBoxColumn
    Friend WithEvents dgv_contas_status As DataGridViewTextBoxColumn
    Friend WithEvents dgv_contas_editar As DataGridViewImageColumn
    Friend WithEvents dgv_contas_excluir As DataGridViewImageColumn
End Class
