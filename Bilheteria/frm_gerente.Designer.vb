<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerente))
        Me.lbl_gridcine = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_encerrar_sessao = New System.Windows.Forms.Button()
        Me.btn_checar_pedidos_icone = New System.Windows.Forms.Button()
        Me.lbl_checar_pedidos = New System.Windows.Forms.Label()
        Me.btn_checar_pedidos = New System.Windows.Forms.Button()
        Me.btn_checar_filmes_icone = New System.Windows.Forms.Button()
        Me.btn_configurar_contas_icone = New System.Windows.Forms.Button()
        Me.btn_consultar_registros_icone = New System.Windows.Forms.Button()
        Me.btn_checar_filmes = New System.Windows.Forms.Button()
        Me.btn_configurar_contas = New System.Windows.Forms.Button()
        Me.btn_consultar_registros = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_trocar_tema = New System.Windows.Forms.Button()
        Me.lbl_underline = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_gridcine
        '
        Me.lbl_gridcine.AutoSize = True
        Me.lbl_gridcine.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gridcine.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_gridcine.Location = New System.Drawing.Point(517, 56)
        Me.lbl_gridcine.Name = "lbl_gridcine"
        Me.lbl_gridcine.Size = New System.Drawing.Size(232, 56)
        Me.lbl_gridcine.TabIndex = 23
        Me.lbl_gridcine.Text = "GridCine"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nome.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_nome.Location = New System.Drawing.Point(131, 44)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(73, 25)
        Me.lbl_nome.TabIndex = 21
        Me.lbl_nome.Text = "(nome)"
        Me.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cargo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cargo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_cargo.Location = New System.Drawing.Point(132, 83)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(72, 25)
        Me.lbl_cargo.TabIndex = 20
        Me.lbl_cargo.Text = "(cargo)"
        Me.lbl_cargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'btn_encerrar_sessao
        '
        Me.btn_encerrar_sessao.BackColor = System.Drawing.SystemColors.Control
        Me.btn_encerrar_sessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_encerrar_sessao.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encerrar_sessao.Location = New System.Drawing.Point(12, 118)
        Me.btn_encerrar_sessao.Name = "btn_encerrar_sessao"
        Me.btn_encerrar_sessao.Size = New System.Drawing.Size(104, 23)
        Me.btn_encerrar_sessao.TabIndex = 4
        Me.btn_encerrar_sessao.Text = "Encerrar Sessão"
        Me.btn_encerrar_sessao.UseVisualStyleBackColor = False
        '
        'btn_checar_pedidos_icone
        '
        Me.btn_checar_pedidos_icone.BackColor = System.Drawing.Color.Red
        Me.btn_checar_pedidos_icone.BackgroundImage = CType(resources.GetObject("btn_checar_pedidos_icone.BackgroundImage"), System.Drawing.Image)
        Me.btn_checar_pedidos_icone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_checar_pedidos_icone.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_checar_pedidos_icone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_checar_pedidos_icone.Location = New System.Drawing.Point(482, 54)
        Me.btn_checar_pedidos_icone.Name = "btn_checar_pedidos_icone"
        Me.btn_checar_pedidos_icone.Size = New System.Drawing.Size(180, 180)
        Me.btn_checar_pedidos_icone.TabIndex = 0
        Me.btn_checar_pedidos_icone.UseVisualStyleBackColor = False
        Me.btn_checar_pedidos_icone.Visible = False
        '
        'lbl_checar_pedidos
        '
        Me.lbl_checar_pedidos.AutoSize = True
        Me.lbl_checar_pedidos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_checar_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_checar_pedidos.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_checar_pedidos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_checar_pedidos.Location = New System.Drawing.Point(159, 397)
        Me.lbl_checar_pedidos.Name = "lbl_checar_pedidos"
        Me.lbl_checar_pedidos.Size = New System.Drawing.Size(0, 25)
        Me.lbl_checar_pedidos.TabIndex = 35
        '
        'btn_checar_pedidos
        '
        Me.btn_checar_pedidos.BackColor = System.Drawing.Color.White
        Me.btn_checar_pedidos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_checar_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_checar_pedidos.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checar_pedidos.ForeColor = System.Drawing.Color.Black
        Me.btn_checar_pedidos.Location = New System.Drawing.Point(482, 226)
        Me.btn_checar_pedidos.Name = "btn_checar_pedidos"
        Me.btn_checar_pedidos.Size = New System.Drawing.Size(180, 36)
        Me.btn_checar_pedidos.TabIndex = 36
        Me.btn_checar_pedidos.Text = "Checar Vendas"
        Me.btn_checar_pedidos.UseVisualStyleBackColor = False
        Me.btn_checar_pedidos.Visible = False
        '
        'btn_checar_filmes_icone
        '
        Me.btn_checar_filmes_icone.BackColor = System.Drawing.Color.Red
        Me.btn_checar_filmes_icone.BackgroundImage = CType(resources.GetObject("btn_checar_filmes_icone.BackgroundImage"), System.Drawing.Image)
        Me.btn_checar_filmes_icone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_checar_filmes_icone.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_checar_filmes_icone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_checar_filmes_icone.Location = New System.Drawing.Point(140, 154)
        Me.btn_checar_filmes_icone.Name = "btn_checar_filmes_icone"
        Me.btn_checar_filmes_icone.Size = New System.Drawing.Size(180, 180)
        Me.btn_checar_filmes_icone.TabIndex = 1
        Me.btn_checar_filmes_icone.UseVisualStyleBackColor = False
        '
        'btn_configurar_contas_icone
        '
        Me.btn_configurar_contas_icone.BackColor = System.Drawing.Color.Red
        Me.btn_configurar_contas_icone.BackgroundImage = CType(resources.GetObject("btn_configurar_contas_icone.BackgroundImage"), System.Drawing.Image)
        Me.btn_configurar_contas_icone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_configurar_contas_icone.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_configurar_contas_icone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_configurar_contas_icone.Location = New System.Drawing.Point(482, 154)
        Me.btn_configurar_contas_icone.Name = "btn_configurar_contas_icone"
        Me.btn_configurar_contas_icone.Size = New System.Drawing.Size(180, 180)
        Me.btn_configurar_contas_icone.TabIndex = 2
        Me.btn_configurar_contas_icone.UseVisualStyleBackColor = False
        '
        'btn_consultar_registros_icone
        '
        Me.btn_consultar_registros_icone.BackColor = System.Drawing.Color.Red
        Me.btn_consultar_registros_icone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_consultar_registros_icone.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_consultar_registros_icone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar_registros_icone.Image = CType(resources.GetObject("btn_consultar_registros_icone.Image"), System.Drawing.Image)
        Me.btn_consultar_registros_icone.Location = New System.Drawing.Point(478, 453)
        Me.btn_consultar_registros_icone.Name = "btn_consultar_registros_icone"
        Me.btn_consultar_registros_icone.Size = New System.Drawing.Size(180, 180)
        Me.btn_consultar_registros_icone.TabIndex = 3
        Me.btn_consultar_registros_icone.UseVisualStyleBackColor = False
        Me.btn_consultar_registros_icone.Visible = False
        '
        'btn_checar_filmes
        '
        Me.btn_checar_filmes.BackColor = System.Drawing.Color.White
        Me.btn_checar_filmes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_checar_filmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_checar_filmes.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checar_filmes.ForeColor = System.Drawing.Color.Black
        Me.btn_checar_filmes.Location = New System.Drawing.Point(140, 326)
        Me.btn_checar_filmes.Name = "btn_checar_filmes"
        Me.btn_checar_filmes.Size = New System.Drawing.Size(180, 36)
        Me.btn_checar_filmes.TabIndex = 43
        Me.btn_checar_filmes.Text = "Configurar Filmes"
        Me.btn_checar_filmes.UseVisualStyleBackColor = False
        '
        'btn_configurar_contas
        '
        Me.btn_configurar_contas.BackColor = System.Drawing.Color.White
        Me.btn_configurar_contas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_configurar_contas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_configurar_contas.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_configurar_contas.ForeColor = System.Drawing.Color.Black
        Me.btn_configurar_contas.Location = New System.Drawing.Point(482, 326)
        Me.btn_configurar_contas.Name = "btn_configurar_contas"
        Me.btn_configurar_contas.Size = New System.Drawing.Size(180, 36)
        Me.btn_configurar_contas.TabIndex = 44
        Me.btn_configurar_contas.Text = "Configurar Contas"
        Me.btn_configurar_contas.UseVisualStyleBackColor = False
        '
        'btn_consultar_registros
        '
        Me.btn_consultar_registros.BackColor = System.Drawing.Color.White
        Me.btn_consultar_registros.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_consultar_registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar_registros.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar_registros.ForeColor = System.Drawing.Color.Black
        Me.btn_consultar_registros.Location = New System.Drawing.Point(472, 628)
        Me.btn_consultar_registros.Name = "btn_consultar_registros"
        Me.btn_consultar_registros.Size = New System.Drawing.Size(194, 36)
        Me.btn_consultar_registros.TabIndex = 45
        Me.btn_consultar_registros.Text = "Consultar Registros"
        Me.btn_consultar_registros.UseVisualStyleBackColor = False
        Me.btn_consultar_registros.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.btn_configurar_contas)
        Me.GroupBox1.Controls.Add(Me.btn_configurar_contas_icone)
        Me.GroupBox1.Controls.Add(Me.btn_trocar_tema)
        Me.GroupBox1.Controls.Add(Me.btn_checar_pedidos)
        Me.GroupBox1.Controls.Add(Me.btn_checar_filmes)
        Me.GroupBox1.Controls.Add(Me.btn_checar_filmes_icone)
        Me.GroupBox1.Controls.Add(Me.btn_checar_pedidos_icone)
        Me.GroupBox1.Location = New System.Drawing.Point(-4, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 559)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'btn_trocar_tema
        '
        Me.btn_trocar_tema.BackColor = System.Drawing.Color.Black
        Me.btn_trocar_tema.BackgroundImage = CType(resources.GetObject("btn_trocar_tema.BackgroundImage"), System.Drawing.Image)
        Me.btn_trocar_tema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_trocar_tema.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_trocar_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_trocar_tema.Location = New System.Drawing.Point(745, 20)
        Me.btn_trocar_tema.Name = "btn_trocar_tema"
        Me.btn_trocar_tema.Size = New System.Drawing.Size(35, 35)
        Me.btn_trocar_tema.TabIndex = 60
        Me.btn_trocar_tema.UseVisualStyleBackColor = False
        '
        'lbl_underline
        '
        Me.lbl_underline.AutoSize = True
        Me.lbl_underline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_underline.Font = New System.Drawing.Font("Microsoft Sans Serif", 101.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_underline.ForeColor = System.Drawing.Color.White
        Me.lbl_underline.Location = New System.Drawing.Point(-30, 13)
        Me.lbl_underline.Name = "lbl_underline"
        Me.lbl_underline.Size = New System.Drawing.Size(890, 154)
        Me.lbl_underline.TabIndex = 61
        Me.lbl_underline.Text = "___________"
        '
        'frm_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(804, 717)
        Me.Controls.Add(Me.btn_consultar_registros)
        Me.Controls.Add(Me.lbl_checar_pedidos)
        Me.Controls.Add(Me.btn_encerrar_sessao)
        Me.Controls.Add(Me.lbl_gridcine)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.lbl_cargo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_underline)
        Me.Controls.Add(Me.btn_consultar_registros_icone)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GridCine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_gridcine As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_cargo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_encerrar_sessao As Button
    Friend WithEvents btn_checar_pedidos_icone As Button
    Friend WithEvents lbl_checar_pedidos As Label
    Friend WithEvents btn_checar_pedidos As Button
    Friend WithEvents btn_checar_filmes_icone As Button
    Friend WithEvents btn_configurar_contas_icone As Button
    Friend WithEvents btn_consultar_registros_icone As Button
    Friend WithEvents btn_checar_filmes As Button
    Friend WithEvents btn_configurar_contas As Button
    Friend WithEvents btn_consultar_registros As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_trocar_tema As Button
    Friend WithEvents lbl_underline As Label
End Class
