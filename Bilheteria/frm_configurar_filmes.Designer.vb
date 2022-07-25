<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checar_filmes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checar_filmes))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.img_poster = New System.Windows.Forms.PictureBox()
        Me.tab_configurar_filmes = New System.Windows.Forms.TabControl()
        Me.tab_page_programacao = New System.Windows.Forms.TabPage()
        Me.cb_horario3 = New System.Windows.Forms.CheckBox()
        Me.cb_horario5 = New System.Windows.Forms.CheckBox()
        Me.cb_horario2 = New System.Windows.Forms.CheckBox()
        Me.cb_horario4 = New System.Windows.Forms.CheckBox()
        Me.cb_horario1 = New System.Windows.Forms.CheckBox()
        Me.cmb_salas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_data = New System.Windows.Forms.DateTimePicker()
        Me.cmb_filmes = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tab_page_sessoes = New System.Windows.Forms.TabPage()
        Me.dgv_sessoes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmb_filmes_sessoes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tab_page_individual = New System.Windows.Forms.TabPage()
        Me.rb_nao = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rb_sim = New System.Windows.Forms.RadioButton()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_preco_ingresso = New System.Windows.Forms.Label()
        Me.lbl_em_cartaz = New System.Windows.Forms.Label()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.txt_preco = New System.Windows.Forms.MaskedTextBox()
        Me.tab_page_listagem = New System.Windows.Forms.TabPage()
        Me.cb_somente_cartaz = New System.Windows.Forms.CheckBox()
        Me.txt_pesquisa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_filmes = New System.Windows.Forms.DataGridView()
        Me.dgv_filmes_id_filme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_filmes_titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_filmes_preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_filmes_em_cartaz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_contas_editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tab_page_salas = New System.Windows.Forms.TabPage()
        Me.txt_sala04_hor5 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala04_hor4 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala04_hor3 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala04_hor2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala04_hor1 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala03_hor5 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala03_hor4 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala03_hor3 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala03_hor2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala03_hor1 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala02_hor5 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala02_hor4 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala02_hor3 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala02_hor2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala02_hor1 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala01_hor5 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala01_hor4 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala01_hor3 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sala01_hor2 = New System.Windows.Forms.MaskedTextBox()
        Me.cb_sala_04 = New System.Windows.Forms.CheckBox()
        Me.cb_sala_03 = New System.Windows.Forms.CheckBox()
        Me.cb_sala_02 = New System.Windows.Forms.CheckBox()
        Me.txt_sala01_hor1 = New System.Windows.Forms.MaskedTextBox()
        Me.cb_sala_01 = New System.Windows.Forms.CheckBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.img_poster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_configurar_filmes.SuspendLayout()
        Me.tab_page_programacao.SuspendLayout()
        Me.tab_page_sessoes.SuspendLayout()
        CType(Me.dgv_sessoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_page_individual.SuspendLayout()
        Me.tab_page_listagem.SuspendLayout()
        CType(Me.dgv_filmes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_page_salas.SuspendLayout()
        Me.SuspendLayout()
        '
        'img_poster
        '
        Me.img_poster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_poster.Location = New System.Drawing.Point(295, 51)
        Me.img_poster.Name = "img_poster"
        Me.img_poster.Size = New System.Drawing.Size(149, 215)
        Me.img_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_poster.TabIndex = 6
        Me.img_poster.TabStop = False
        '
        'tab_configurar_filmes
        '
        Me.tab_configurar_filmes.Controls.Add(Me.tab_page_programacao)
        Me.tab_configurar_filmes.Controls.Add(Me.tab_page_sessoes)
        Me.tab_configurar_filmes.Controls.Add(Me.tab_page_individual)
        Me.tab_configurar_filmes.Controls.Add(Me.tab_page_listagem)
        Me.tab_configurar_filmes.Controls.Add(Me.tab_page_salas)
        Me.tab_configurar_filmes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_configurar_filmes.Location = New System.Drawing.Point(31, 31)
        Me.tab_configurar_filmes.Name = "tab_configurar_filmes"
        Me.tab_configurar_filmes.SelectedIndex = 0
        Me.tab_configurar_filmes.Size = New System.Drawing.Size(485, 342)
        Me.tab_configurar_filmes.TabIndex = 15
        '
        'tab_page_programacao
        '
        Me.tab_page_programacao.BackColor = System.Drawing.Color.Black
        Me.tab_page_programacao.Controls.Add(Me.cb_horario3)
        Me.tab_page_programacao.Controls.Add(Me.cb_horario5)
        Me.tab_page_programacao.Controls.Add(Me.cb_horario2)
        Me.tab_page_programacao.Controls.Add(Me.cb_horario4)
        Me.tab_page_programacao.Controls.Add(Me.cb_horario1)
        Me.tab_page_programacao.Controls.Add(Me.cmb_salas)
        Me.tab_page_programacao.Controls.Add(Me.Label3)
        Me.tab_page_programacao.Controls.Add(Me.dtp_data)
        Me.tab_page_programacao.Controls.Add(Me.cmb_filmes)
        Me.tab_page_programacao.Controls.Add(Me.Label6)
        Me.tab_page_programacao.Controls.Add(Me.Label5)
        Me.tab_page_programacao.Controls.Add(Me.Label4)
        Me.tab_page_programacao.Location = New System.Drawing.Point(4, 26)
        Me.tab_page_programacao.Name = "tab_page_programacao"
        Me.tab_page_programacao.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_page_programacao.Size = New System.Drawing.Size(477, 312)
        Me.tab_page_programacao.TabIndex = 2
        Me.tab_page_programacao.Text = "Programação"
        '
        'cb_horario3
        '
        Me.cb_horario3.AutoSize = True
        Me.cb_horario3.BackColor = System.Drawing.Color.Black
        Me.cb_horario3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cb_horario3.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_horario3.Location = New System.Drawing.Point(336, 220)
        Me.cb_horario3.Name = "cb_horario3"
        Me.cb_horario3.Size = New System.Drawing.Size(32, 24)
        Me.cb_horario3.TabIndex = 20
        Me.cb_horario3.Text = " "
        Me.cb_horario3.UseVisualStyleBackColor = False
        '
        'cb_horario5
        '
        Me.cb_horario5.AutoSize = True
        Me.cb_horario5.BackColor = System.Drawing.Color.Black
        Me.cb_horario5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cb_horario5.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_horario5.Location = New System.Drawing.Point(237, 260)
        Me.cb_horario5.Name = "cb_horario5"
        Me.cb_horario5.Size = New System.Drawing.Size(32, 24)
        Me.cb_horario5.TabIndex = 19
        Me.cb_horario5.Text = " "
        Me.cb_horario5.UseVisualStyleBackColor = False
        '
        'cb_horario2
        '
        Me.cb_horario2.AutoSize = True
        Me.cb_horario2.BackColor = System.Drawing.Color.Black
        Me.cb_horario2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cb_horario2.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_horario2.Location = New System.Drawing.Point(237, 220)
        Me.cb_horario2.Name = "cb_horario2"
        Me.cb_horario2.Size = New System.Drawing.Size(32, 24)
        Me.cb_horario2.TabIndex = 19
        Me.cb_horario2.Text = " "
        Me.cb_horario2.UseVisualStyleBackColor = False
        '
        'cb_horario4
        '
        Me.cb_horario4.AutoSize = True
        Me.cb_horario4.BackColor = System.Drawing.Color.Black
        Me.cb_horario4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cb_horario4.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_horario4.Location = New System.Drawing.Point(136, 260)
        Me.cb_horario4.Name = "cb_horario4"
        Me.cb_horario4.Size = New System.Drawing.Size(32, 24)
        Me.cb_horario4.TabIndex = 18
        Me.cb_horario4.Text = " "
        Me.cb_horario4.UseVisualStyleBackColor = False
        '
        'cb_horario1
        '
        Me.cb_horario1.AutoSize = True
        Me.cb_horario1.BackColor = System.Drawing.Color.Black
        Me.cb_horario1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cb_horario1.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_horario1.Location = New System.Drawing.Point(136, 220)
        Me.cb_horario1.Name = "cb_horario1"
        Me.cb_horario1.Size = New System.Drawing.Size(32, 24)
        Me.cb_horario1.TabIndex = 17
        Me.cb_horario1.Text = " "
        Me.cb_horario1.UseVisualStyleBackColor = False
        '
        'cmb_salas
        '
        Me.cmb_salas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_salas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_salas.FormattingEnabled = True
        Me.cmb_salas.Location = New System.Drawing.Point(35, 220)
        Me.cmb_salas.Name = "cmb_salas"
        Me.cmb_salas.Size = New System.Drawing.Size(39, 28)
        Me.cmb_salas.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(129, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Horários"
        '
        'dtp_data
        '
        Me.dtp_data.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_data.Location = New System.Drawing.Point(35, 140)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(320, 27)
        Me.dtp_data.TabIndex = 6
        '
        'cmb_filmes
        '
        Me.cmb_filmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filmes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_filmes.FormattingEnabled = True
        Me.cmb_filmes.Location = New System.Drawing.Point(35, 60)
        Me.cmb_filmes.Name = "cmb_filmes"
        Me.cmb_filmes.Size = New System.Drawing.Size(320, 28)
        Me.cmb_filmes.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(20, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Sala"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(20, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Dia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(20, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Filme"
        '
        'tab_page_sessoes
        '
        Me.tab_page_sessoes.BackColor = System.Drawing.Color.Black
        Me.tab_page_sessoes.Controls.Add(Me.dgv_sessoes)
        Me.tab_page_sessoes.Controls.Add(Me.cmb_filmes_sessoes)
        Me.tab_page_sessoes.Controls.Add(Me.Label7)
        Me.tab_page_sessoes.Location = New System.Drawing.Point(4, 26)
        Me.tab_page_sessoes.Name = "tab_page_sessoes"
        Me.tab_page_sessoes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_page_sessoes.Size = New System.Drawing.Size(477, 312)
        Me.tab_page_sessoes.TabIndex = 4
        Me.tab_page_sessoes.Text = "Sessões"
        '
        'dgv_sessoes
        '
        Me.dgv_sessoes.AllowUserToAddRows = False
        Me.dgv_sessoes.AllowUserToDeleteRows = False
        Me.dgv_sessoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_sessoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_sessoes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_sessoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_sessoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_sessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sessoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewImageColumn1})
        Me.dgv_sessoes.Location = New System.Drawing.Point(35, 105)
        Me.dgv_sessoes.Name = "dgv_sessoes"
        Me.dgv_sessoes.ReadOnly = True
        Me.dgv_sessoes.Size = New System.Drawing.Size(364, 201)
        Me.dgv_sessoes.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sala"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 57
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Horario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 78
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 67
        '
        'cmb_filmes_sessoes
        '
        Me.cmb_filmes_sessoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filmes_sessoes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_filmes_sessoes.FormattingEnabled = True
        Me.cmb_filmes_sessoes.Location = New System.Drawing.Point(35, 60)
        Me.cmb_filmes_sessoes.Name = "cmb_filmes_sessoes"
        Me.cmb_filmes_sessoes.Size = New System.Drawing.Size(320, 28)
        Me.cmb_filmes_sessoes.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(20, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Filme"
        '
        'tab_page_individual
        '
        Me.tab_page_individual.BackColor = System.Drawing.Color.Black
        Me.tab_page_individual.Controls.Add(Me.rb_nao)
        Me.tab_page_individual.Controls.Add(Me.Label8)
        Me.tab_page_individual.Controls.Add(Me.img_poster)
        Me.tab_page_individual.Controls.Add(Me.rb_sim)
        Me.tab_page_individual.Controls.Add(Me.lbl_titulo)
        Me.tab_page_individual.Controls.Add(Me.lbl_preco_ingresso)
        Me.tab_page_individual.Controls.Add(Me.lbl_em_cartaz)
        Me.tab_page_individual.Controls.Add(Me.txt_titulo)
        Me.tab_page_individual.Controls.Add(Me.txt_preco)
        Me.tab_page_individual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_page_individual.Location = New System.Drawing.Point(4, 26)
        Me.tab_page_individual.Name = "tab_page_individual"
        Me.tab_page_individual.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_page_individual.Size = New System.Drawing.Size(477, 312)
        Me.tab_page_individual.TabIndex = 0
        Me.tab_page_individual.Text = "Individual"
        '
        'rb_nao
        '
        Me.rb_nao.AutoSize = True
        Me.rb_nao.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_nao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_nao.Location = New System.Drawing.Point(93, 233)
        Me.rb_nao.Name = "rb_nao"
        Me.rb_nao.Size = New System.Drawing.Size(55, 24)
        Me.rb_nao.TabIndex = 20
        Me.rb_nao.Text = "Não"
        Me.rb_nao.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(20, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Filme"
        '
        'rb_sim
        '
        Me.rb_sim.AutoSize = True
        Me.rb_sim.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_sim.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_sim.Location = New System.Drawing.Point(35, 233)
        Me.rb_sim.Name = "rb_sim"
        Me.rb_sim.Size = New System.Drawing.Size(52, 24)
        Me.rb_sim.TabIndex = 19
        Me.rb_sim.Text = "Sim"
        Me.rb_sim.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_titulo.Location = New System.Drawing.Point(31, 68)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(52, 21)
        Me.lbl_titulo.TabIndex = 13
        Me.lbl_titulo.Text = "Título"
        '
        'lbl_preco_ingresso
        '
        Me.lbl_preco_ingresso.AutoSize = True
        Me.lbl_preco_ingresso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preco_ingresso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_preco_ingresso.Location = New System.Drawing.Point(31, 139)
        Me.lbl_preco_ingresso.Name = "lbl_preco_ingresso"
        Me.lbl_preco_ingresso.Size = New System.Drawing.Size(143, 21)
        Me.lbl_preco_ingresso.TabIndex = 17
        Me.lbl_preco_ingresso.Text = "Preço do Ingresso"
        '
        'lbl_em_cartaz
        '
        Me.lbl_em_cartaz.AutoSize = True
        Me.lbl_em_cartaz.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_em_cartaz.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_em_cartaz.Location = New System.Drawing.Point(31, 209)
        Me.lbl_em_cartaz.Name = "lbl_em_cartaz"
        Me.lbl_em_cartaz.Size = New System.Drawing.Size(79, 21)
        Me.lbl_em_cartaz.TabIndex = 18
        Me.lbl_em_cartaz.Text = "Em cartaz"
        '
        'txt_titulo
        '
        Me.txt_titulo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titulo.Location = New System.Drawing.Point(35, 92)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(222, 27)
        Me.txt_titulo.TabIndex = 2
        '
        'txt_preco
        '
        Me.txt_preco.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_preco.Location = New System.Drawing.Point(35, 163)
        Me.txt_preco.Mask = "$ 00.00"
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(81, 27)
        Me.txt_preco.TabIndex = 0
        '
        'tab_page_listagem
        '
        Me.tab_page_listagem.BackColor = System.Drawing.Color.Black
        Me.tab_page_listagem.Controls.Add(Me.cb_somente_cartaz)
        Me.tab_page_listagem.Controls.Add(Me.txt_pesquisa)
        Me.tab_page_listagem.Controls.Add(Me.Label2)
        Me.tab_page_listagem.Controls.Add(Me.dgv_filmes)
        Me.tab_page_listagem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tab_page_listagem.Location = New System.Drawing.Point(4, 26)
        Me.tab_page_listagem.Name = "tab_page_listagem"
        Me.tab_page_listagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_page_listagem.Size = New System.Drawing.Size(477, 312)
        Me.tab_page_listagem.TabIndex = 1
        Me.tab_page_listagem.Text = "Listagem"
        '
        'cb_somente_cartaz
        '
        Me.cb_somente_cartaz.AutoSize = True
        Me.cb_somente_cartaz.Checked = True
        Me.cb_somente_cartaz.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_somente_cartaz.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_somente_cartaz.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_somente_cartaz.Location = New System.Drawing.Point(291, 64)
        Me.cb_somente_cartaz.Name = "cb_somente_cartaz"
        Me.cb_somente_cartaz.Size = New System.Drawing.Size(180, 23)
        Me.cb_somente_cartaz.TabIndex = 15
        Me.cb_somente_cartaz.Text = "só exibir filmes em cartaz"
        Me.cb_somente_cartaz.UseVisualStyleBackColor = True
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_pesquisa.Location = New System.Drawing.Point(35, 60)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(248, 27)
        Me.txt_pesquisa.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Pesquisar por título: "
        '
        'dgv_filmes
        '
        Me.dgv_filmes.AllowUserToAddRows = False
        Me.dgv_filmes.AllowUserToDeleteRows = False
        Me.dgv_filmes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_filmes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_filmes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_filmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_filmes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_filmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_filmes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_filmes_id_filme, Me.dgv_filmes_titulo, Me.dgv_filmes_preco, Me.dgv_filmes_em_cartaz, Me.dgv_contas_editar})
        Me.dgv_filmes.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_filmes.Location = New System.Drawing.Point(6, 105)
        Me.dgv_filmes.Name = "dgv_filmes"
        Me.dgv_filmes.ReadOnly = True
        Me.dgv_filmes.Size = New System.Drawing.Size(465, 201)
        Me.dgv_filmes.TabIndex = 2
        '
        'dgv_filmes_id_filme
        '
        Me.dgv_filmes_id_filme.HeaderText = "ID"
        Me.dgv_filmes_id_filme.Name = "dgv_filmes_id_filme"
        Me.dgv_filmes_id_filme.ReadOnly = True
        Me.dgv_filmes_id_filme.Visible = False
        Me.dgv_filmes_id_filme.Width = 50
        '
        'dgv_filmes_titulo
        '
        Me.dgv_filmes_titulo.HeaderText = "Titulo"
        Me.dgv_filmes_titulo.Name = "dgv_filmes_titulo"
        Me.dgv_filmes_titulo.ReadOnly = True
        Me.dgv_filmes_titulo.Width = 65
        '
        'dgv_filmes_preco
        '
        Me.dgv_filmes_preco.HeaderText = "Preco"
        Me.dgv_filmes_preco.Name = "dgv_filmes_preco"
        Me.dgv_filmes_preco.ReadOnly = True
        Me.dgv_filmes_preco.Width = 66
        '
        'dgv_filmes_em_cartaz
        '
        Me.dgv_filmes_em_cartaz.HeaderText = "Em Cartaz"
        Me.dgv_filmes_em_cartaz.Name = "dgv_filmes_em_cartaz"
        Me.dgv_filmes_em_cartaz.ReadOnly = True
        Me.dgv_filmes_em_cartaz.Width = 92
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
        'tab_page_salas
        '
        Me.tab_page_salas.BackColor = System.Drawing.Color.Black
        Me.tab_page_salas.Controls.Add(Me.txt_sala04_hor5)
        Me.tab_page_salas.Controls.Add(Me.txt_sala04_hor4)
        Me.tab_page_salas.Controls.Add(Me.txt_sala04_hor3)
        Me.tab_page_salas.Controls.Add(Me.txt_sala04_hor2)
        Me.tab_page_salas.Controls.Add(Me.txt_sala04_hor1)
        Me.tab_page_salas.Controls.Add(Me.txt_sala03_hor5)
        Me.tab_page_salas.Controls.Add(Me.txt_sala03_hor4)
        Me.tab_page_salas.Controls.Add(Me.txt_sala03_hor3)
        Me.tab_page_salas.Controls.Add(Me.txt_sala03_hor2)
        Me.tab_page_salas.Controls.Add(Me.txt_sala03_hor1)
        Me.tab_page_salas.Controls.Add(Me.txt_sala02_hor5)
        Me.tab_page_salas.Controls.Add(Me.txt_sala02_hor4)
        Me.tab_page_salas.Controls.Add(Me.txt_sala02_hor3)
        Me.tab_page_salas.Controls.Add(Me.txt_sala02_hor2)
        Me.tab_page_salas.Controls.Add(Me.txt_sala02_hor1)
        Me.tab_page_salas.Controls.Add(Me.txt_sala01_hor5)
        Me.tab_page_salas.Controls.Add(Me.txt_sala01_hor4)
        Me.tab_page_salas.Controls.Add(Me.txt_sala01_hor3)
        Me.tab_page_salas.Controls.Add(Me.txt_sala01_hor2)
        Me.tab_page_salas.Controls.Add(Me.cb_sala_04)
        Me.tab_page_salas.Controls.Add(Me.cb_sala_03)
        Me.tab_page_salas.Controls.Add(Me.cb_sala_02)
        Me.tab_page_salas.Controls.Add(Me.txt_sala01_hor1)
        Me.tab_page_salas.Controls.Add(Me.cb_sala_01)
        Me.tab_page_salas.Location = New System.Drawing.Point(4, 26)
        Me.tab_page_salas.Name = "tab_page_salas"
        Me.tab_page_salas.Size = New System.Drawing.Size(477, 312)
        Me.tab_page_salas.TabIndex = 3
        Me.tab_page_salas.Text = "Salas"
        '
        'txt_sala04_hor5
        '
        Me.txt_sala04_hor5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala04_hor5.Location = New System.Drawing.Point(369, 251)
        Me.txt_sala04_hor5.Mask = "00:00"
        Me.txt_sala04_hor5.Name = "txt_sala04_hor5"
        Me.txt_sala04_hor5.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala04_hor5.TabIndex = 70
        Me.txt_sala04_hor5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala04_hor4
        '
        Me.txt_sala04_hor4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala04_hor4.Location = New System.Drawing.Point(289, 251)
        Me.txt_sala04_hor4.Mask = "00:00"
        Me.txt_sala04_hor4.Name = "txt_sala04_hor4"
        Me.txt_sala04_hor4.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala04_hor4.TabIndex = 69
        Me.txt_sala04_hor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala04_hor3
        '
        Me.txt_sala04_hor3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala04_hor3.Location = New System.Drawing.Point(209, 251)
        Me.txt_sala04_hor3.Mask = "00:00"
        Me.txt_sala04_hor3.Name = "txt_sala04_hor3"
        Me.txt_sala04_hor3.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala04_hor3.TabIndex = 68
        Me.txt_sala04_hor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala04_hor2
        '
        Me.txt_sala04_hor2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala04_hor2.Location = New System.Drawing.Point(129, 251)
        Me.txt_sala04_hor2.Mask = "00:00"
        Me.txt_sala04_hor2.Name = "txt_sala04_hor2"
        Me.txt_sala04_hor2.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala04_hor2.TabIndex = 67
        Me.txt_sala04_hor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala04_hor1
        '
        Me.txt_sala04_hor1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala04_hor1.Location = New System.Drawing.Point(49, 251)
        Me.txt_sala04_hor1.Mask = "00:00"
        Me.txt_sala04_hor1.Name = "txt_sala04_hor1"
        Me.txt_sala04_hor1.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala04_hor1.TabIndex = 66
        Me.txt_sala04_hor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala03_hor5
        '
        Me.txt_sala03_hor5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala03_hor5.Location = New System.Drawing.Point(369, 186)
        Me.txt_sala03_hor5.Mask = "00:00"
        Me.txt_sala03_hor5.Name = "txt_sala03_hor5"
        Me.txt_sala03_hor5.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala03_hor5.TabIndex = 65
        Me.txt_sala03_hor5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala03_hor4
        '
        Me.txt_sala03_hor4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala03_hor4.Location = New System.Drawing.Point(289, 186)
        Me.txt_sala03_hor4.Mask = "00:00"
        Me.txt_sala03_hor4.Name = "txt_sala03_hor4"
        Me.txt_sala03_hor4.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala03_hor4.TabIndex = 64
        Me.txt_sala03_hor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala03_hor3
        '
        Me.txt_sala03_hor3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala03_hor3.Location = New System.Drawing.Point(209, 186)
        Me.txt_sala03_hor3.Mask = "00:00"
        Me.txt_sala03_hor3.Name = "txt_sala03_hor3"
        Me.txt_sala03_hor3.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala03_hor3.TabIndex = 63
        Me.txt_sala03_hor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala03_hor2
        '
        Me.txt_sala03_hor2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala03_hor2.Location = New System.Drawing.Point(129, 186)
        Me.txt_sala03_hor2.Mask = "00:00"
        Me.txt_sala03_hor2.Name = "txt_sala03_hor2"
        Me.txt_sala03_hor2.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala03_hor2.TabIndex = 62
        Me.txt_sala03_hor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala03_hor1
        '
        Me.txt_sala03_hor1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala03_hor1.Location = New System.Drawing.Point(49, 186)
        Me.txt_sala03_hor1.Mask = "00:00"
        Me.txt_sala03_hor1.Name = "txt_sala03_hor1"
        Me.txt_sala03_hor1.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala03_hor1.TabIndex = 61
        Me.txt_sala03_hor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala02_hor5
        '
        Me.txt_sala02_hor5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala02_hor5.Location = New System.Drawing.Point(369, 121)
        Me.txt_sala02_hor5.Mask = "00:00"
        Me.txt_sala02_hor5.Name = "txt_sala02_hor5"
        Me.txt_sala02_hor5.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala02_hor5.TabIndex = 60
        Me.txt_sala02_hor5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala02_hor4
        '
        Me.txt_sala02_hor4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala02_hor4.Location = New System.Drawing.Point(289, 121)
        Me.txt_sala02_hor4.Mask = "00:00"
        Me.txt_sala02_hor4.Name = "txt_sala02_hor4"
        Me.txt_sala02_hor4.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala02_hor4.TabIndex = 59
        Me.txt_sala02_hor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala02_hor3
        '
        Me.txt_sala02_hor3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala02_hor3.Location = New System.Drawing.Point(209, 121)
        Me.txt_sala02_hor3.Mask = "00:00"
        Me.txt_sala02_hor3.Name = "txt_sala02_hor3"
        Me.txt_sala02_hor3.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala02_hor3.TabIndex = 58
        Me.txt_sala02_hor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala02_hor2
        '
        Me.txt_sala02_hor2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala02_hor2.Location = New System.Drawing.Point(129, 121)
        Me.txt_sala02_hor2.Mask = "00:00"
        Me.txt_sala02_hor2.Name = "txt_sala02_hor2"
        Me.txt_sala02_hor2.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala02_hor2.TabIndex = 57
        Me.txt_sala02_hor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala02_hor1
        '
        Me.txt_sala02_hor1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala02_hor1.Location = New System.Drawing.Point(49, 121)
        Me.txt_sala02_hor1.Mask = "00:00"
        Me.txt_sala02_hor1.Name = "txt_sala02_hor1"
        Me.txt_sala02_hor1.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala02_hor1.TabIndex = 56
        Me.txt_sala02_hor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala01_hor5
        '
        Me.txt_sala01_hor5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala01_hor5.Location = New System.Drawing.Point(369, 56)
        Me.txt_sala01_hor5.Mask = "00:00"
        Me.txt_sala01_hor5.Name = "txt_sala01_hor5"
        Me.txt_sala01_hor5.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala01_hor5.TabIndex = 55
        Me.txt_sala01_hor5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala01_hor4
        '
        Me.txt_sala01_hor4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala01_hor4.Location = New System.Drawing.Point(289, 56)
        Me.txt_sala01_hor4.Mask = "00:00"
        Me.txt_sala01_hor4.Name = "txt_sala01_hor4"
        Me.txt_sala01_hor4.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala01_hor4.TabIndex = 54
        Me.txt_sala01_hor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala01_hor3
        '
        Me.txt_sala01_hor3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala01_hor3.Location = New System.Drawing.Point(209, 56)
        Me.txt_sala01_hor3.Mask = "00:00"
        Me.txt_sala01_hor3.Name = "txt_sala01_hor3"
        Me.txt_sala01_hor3.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala01_hor3.TabIndex = 53
        Me.txt_sala01_hor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sala01_hor2
        '
        Me.txt_sala01_hor2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala01_hor2.Location = New System.Drawing.Point(129, 56)
        Me.txt_sala01_hor2.Mask = "00:00"
        Me.txt_sala01_hor2.Name = "txt_sala01_hor2"
        Me.txt_sala01_hor2.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala01_hor2.TabIndex = 52
        Me.txt_sala01_hor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_sala_04
        '
        Me.cb_sala_04.AutoSize = True
        Me.cb_sala_04.BackColor = System.Drawing.Color.Black
        Me.cb_sala_04.Checked = True
        Me.cb_sala_04.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_sala_04.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sala_04.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_sala_04.Location = New System.Drawing.Point(20, 220)
        Me.cb_sala_04.Name = "cb_sala_04"
        Me.cb_sala_04.Size = New System.Drawing.Size(120, 25)
        Me.cb_sala_04.TabIndex = 46
        Me.cb_sala_04.Text = "Sala 04 (3D)"
        Me.cb_sala_04.UseVisualStyleBackColor = False
        '
        'cb_sala_03
        '
        Me.cb_sala_03.AutoSize = True
        Me.cb_sala_03.BackColor = System.Drawing.Color.Black
        Me.cb_sala_03.Checked = True
        Me.cb_sala_03.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_sala_03.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sala_03.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_sala_03.Location = New System.Drawing.Point(20, 155)
        Me.cb_sala_03.Name = "cb_sala_03"
        Me.cb_sala_03.Size = New System.Drawing.Size(120, 25)
        Me.cb_sala_03.TabIndex = 40
        Me.cb_sala_03.Text = "Sala 03 (3D)"
        Me.cb_sala_03.UseVisualStyleBackColor = False
        '
        'cb_sala_02
        '
        Me.cb_sala_02.AutoSize = True
        Me.cb_sala_02.BackColor = System.Drawing.Color.Black
        Me.cb_sala_02.Checked = True
        Me.cb_sala_02.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_sala_02.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sala_02.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_sala_02.Location = New System.Drawing.Point(20, 90)
        Me.cb_sala_02.Name = "cb_sala_02"
        Me.cb_sala_02.Size = New System.Drawing.Size(83, 25)
        Me.cb_sala_02.TabIndex = 34
        Me.cb_sala_02.Text = "Sala 02"
        Me.cb_sala_02.UseVisualStyleBackColor = False
        '
        'txt_sala01_hor1
        '
        Me.txt_sala01_hor1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_sala01_hor1.Location = New System.Drawing.Point(49, 56)
        Me.txt_sala01_hor1.Mask = "00:00"
        Me.txt_sala01_hor1.Name = "txt_sala01_hor1"
        Me.txt_sala01_hor1.Size = New System.Drawing.Size(49, 27)
        Me.txt_sala01_hor1.TabIndex = 29
        Me.txt_sala01_hor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_sala_01
        '
        Me.cb_sala_01.AutoSize = True
        Me.cb_sala_01.BackColor = System.Drawing.Color.Black
        Me.cb_sala_01.Checked = True
        Me.cb_sala_01.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_sala_01.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sala_01.ForeColor = System.Drawing.SystemColors.Control
        Me.cb_sala_01.Location = New System.Drawing.Point(20, 25)
        Me.cb_sala_01.Name = "cb_sala_01"
        Me.cb_sala_01.Size = New System.Drawing.Size(83, 25)
        Me.cb_sala_01.TabIndex = 16
        Me.cb_sala_01.Text = "Sala 01"
        Me.cb_sala_01.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_voltar.Location = New System.Drawing.Point(110, 410)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(130, 33)
        Me.btn_voltar.TabIndex = 17
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.Red
        Me.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_salvar.Location = New System.Drawing.Point(295, 410)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(130, 33)
        Me.btn_salvar.TabIndex = 16
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'checar_filmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(551, 479)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.tab_configurar_filmes)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "checar_filmes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Filmes"
        CType(Me.img_poster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_configurar_filmes.ResumeLayout(False)
        Me.tab_page_programacao.ResumeLayout(False)
        Me.tab_page_programacao.PerformLayout()
        Me.tab_page_sessoes.ResumeLayout(False)
        Me.tab_page_sessoes.PerformLayout()
        CType(Me.dgv_sessoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_page_individual.ResumeLayout(False)
        Me.tab_page_individual.PerformLayout()
        Me.tab_page_listagem.ResumeLayout(False)
        Me.tab_page_listagem.PerformLayout()
        CType(Me.dgv_filmes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_page_salas.ResumeLayout(False)
        Me.tab_page_salas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents img_poster As PictureBox
    Friend WithEvents tab_configurar_filmes As TabControl
    Friend WithEvents tab_page_individual As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_preco_ingresso As Label
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents tab_page_listagem As TabPage
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_salvar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_preco As MaskedTextBox
    Friend WithEvents lbl_em_cartaz As Label
    Friend WithEvents rb_nao As RadioButton
    Friend WithEvents rb_sim As RadioButton
    Friend WithEvents dgv_filmes As DataGridView
    Friend WithEvents txt_pesquisa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_somente_cartaz As CheckBox
    Friend WithEvents tab_page_programacao As TabPage
    Friend WithEvents tab_page_salas As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_sala_03 As CheckBox
    Friend WithEvents cb_sala_02 As CheckBox
    Friend WithEvents txt_sala01_hor1 As MaskedTextBox
    Friend WithEvents cb_sala_01 As CheckBox
    Friend WithEvents cb_sala_04 As CheckBox
    Friend WithEvents txt_sala01_hor5 As MaskedTextBox
    Friend WithEvents txt_sala01_hor4 As MaskedTextBox
    Friend WithEvents txt_sala01_hor3 As MaskedTextBox
    Friend WithEvents txt_sala01_hor2 As MaskedTextBox
    Friend WithEvents txt_sala04_hor5 As MaskedTextBox
    Friend WithEvents txt_sala04_hor4 As MaskedTextBox
    Friend WithEvents txt_sala04_hor3 As MaskedTextBox
    Friend WithEvents txt_sala04_hor2 As MaskedTextBox
    Friend WithEvents txt_sala04_hor1 As MaskedTextBox
    Friend WithEvents txt_sala03_hor5 As MaskedTextBox
    Friend WithEvents txt_sala03_hor4 As MaskedTextBox
    Friend WithEvents txt_sala03_hor3 As MaskedTextBox
    Friend WithEvents txt_sala03_hor2 As MaskedTextBox
    Friend WithEvents txt_sala03_hor1 As MaskedTextBox
    Friend WithEvents txt_sala02_hor5 As MaskedTextBox
    Friend WithEvents txt_sala02_hor4 As MaskedTextBox
    Friend WithEvents txt_sala02_hor3 As MaskedTextBox
    Friend WithEvents txt_sala02_hor2 As MaskedTextBox
    Friend WithEvents txt_sala02_hor1 As MaskedTextBox
    Friend WithEvents cmb_filmes As ComboBox
    Friend WithEvents cb_horario3 As CheckBox
    Friend WithEvents cb_horario5 As CheckBox
    Friend WithEvents cb_horario2 As CheckBox
    Friend WithEvents cb_horario4 As CheckBox
    Friend WithEvents cb_horario1 As CheckBox
    Friend WithEvents cmb_salas As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents tab_page_sessoes As TabPage
    Friend WithEvents dgv_sessoes As DataGridView
    Friend WithEvents cmb_filmes_sessoes As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_filmes_id_filme As DataGridViewTextBoxColumn
    Friend WithEvents dgv_filmes_titulo As DataGridViewTextBoxColumn
    Friend WithEvents dgv_filmes_preco As DataGridViewTextBoxColumn
    Friend WithEvents dgv_filmes_em_cartaz As DataGridViewTextBoxColumn
    Friend WithEvents dgv_contas_editar As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
