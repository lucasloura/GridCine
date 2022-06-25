<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_operador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_operador))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.lbl_gridcine = New System.Windows.Forms.Label()
        Me.btn_encerrar_sessao = New System.Windows.Forms.Button()
        Me.img_poster_operador = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_trocar_tema = New System.Windows.Forms.Button()
        Me.btn_prox_hor_3d = New System.Windows.Forms.Button()
        Me.btn_prox_hor = New System.Windows.Forms.Button()
        Me.btn_tit_prox_hor_3d = New System.Windows.Forms.Button()
        Me.btn_tit_prox_hor = New System.Windows.Forms.Button()
        Me.btn_titulo = New System.Windows.Forms.Button()
        Me.btn_seta_esq = New System.Windows.Forms.Button()
        Me.btn_seta_dir = New System.Windows.Forms.Button()
        Me.btn_realizar_venda = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_underline = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_poster_operador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        Me.lbl_nome.TabIndex = 22
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
        Me.lbl_cargo.TabIndex = 23
        Me.lbl_cargo.Text = "(cargo)"
        Me.lbl_cargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_gridcine
        '
        Me.lbl_gridcine.AutoSize = True
        Me.lbl_gridcine.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gridcine.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_gridcine.Location = New System.Drawing.Point(517, 56)
        Me.lbl_gridcine.Name = "lbl_gridcine"
        Me.lbl_gridcine.Size = New System.Drawing.Size(232, 56)
        Me.lbl_gridcine.TabIndex = 24
        Me.lbl_gridcine.Text = "GridCine"
        '
        'btn_encerrar_sessao
        '
        Me.btn_encerrar_sessao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encerrar_sessao.Location = New System.Drawing.Point(12, 118)
        Me.btn_encerrar_sessao.Name = "btn_encerrar_sessao"
        Me.btn_encerrar_sessao.Size = New System.Drawing.Size(104, 23)
        Me.btn_encerrar_sessao.TabIndex = 3
        Me.btn_encerrar_sessao.Text = "Encerrar sessao"
        Me.btn_encerrar_sessao.UseVisualStyleBackColor = True
        '
        'img_poster_operador
        '
        Me.img_poster_operador.BackColor = System.Drawing.Color.Black
        Me.img_poster_operador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_poster_operador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_poster_operador.ErrorImage = CType(resources.GetObject("img_poster_operador.ErrorImage"), System.Drawing.Image)
        Me.img_poster_operador.Image = CType(resources.GetObject("img_poster_operador.Image"), System.Drawing.Image)
        Me.img_poster_operador.InitialImage = CType(resources.GetObject("img_poster_operador.InitialImage"), System.Drawing.Image)
        Me.img_poster_operador.Location = New System.Drawing.Point(146, 83)
        Me.img_poster_operador.Name = "img_poster_operador"
        Me.img_poster_operador.Size = New System.Drawing.Size(177, 281)
        Me.img_poster_operador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_poster_operador.TabIndex = 5
        Me.img_poster_operador.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.btn_trocar_tema)
        Me.GroupBox1.Controls.Add(Me.btn_prox_hor_3d)
        Me.GroupBox1.Controls.Add(Me.btn_prox_hor)
        Me.GroupBox1.Controls.Add(Me.btn_tit_prox_hor_3d)
        Me.GroupBox1.Controls.Add(Me.btn_tit_prox_hor)
        Me.GroupBox1.Controls.Add(Me.btn_titulo)
        Me.GroupBox1.Controls.Add(Me.btn_seta_esq)
        Me.GroupBox1.Controls.Add(Me.btn_seta_dir)
        Me.GroupBox1.Controls.Add(Me.btn_realizar_venda)
        Me.GroupBox1.Controls.Add(Me.img_poster_operador)
        Me.GroupBox1.Location = New System.Drawing.Point(-4, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 559)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'btn_trocar_tema
        '
        Me.btn_trocar_tema.BackgroundImage = CType(resources.GetObject("btn_trocar_tema.BackgroundImage"), System.Drawing.Image)
        Me.btn_trocar_tema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_trocar_tema.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_trocar_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_trocar_tema.Location = New System.Drawing.Point(745, 20)
        Me.btn_trocar_tema.Name = "btn_trocar_tema"
        Me.btn_trocar_tema.Size = New System.Drawing.Size(35, 35)
        Me.btn_trocar_tema.TabIndex = 59
        Me.btn_trocar_tema.UseVisualStyleBackColor = True
        '
        'btn_prox_hor_3d
        '
        Me.btn_prox_hor_3d.BackColor = System.Drawing.Color.Black
        Me.btn_prox_hor_3d.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_prox_hor_3d.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prox_hor_3d.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prox_hor_3d.ForeColor = System.Drawing.Color.White
        Me.btn_prox_hor_3d.Location = New System.Drawing.Point(359, 319)
        Me.btn_prox_hor_3d.Name = "btn_prox_hor_3d"
        Me.btn_prox_hor_3d.Size = New System.Drawing.Size(329, 36)
        Me.btn_prox_hor_3d.TabIndex = 58
        Me.btn_prox_hor_3d.Text = "[ HOR1 - HOR2 - HOR3 - HOR4 ]"
        Me.btn_prox_hor_3d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prox_hor_3d.UseVisualStyleBackColor = False
        '
        'btn_prox_hor
        '
        Me.btn_prox_hor.BackColor = System.Drawing.Color.Black
        Me.btn_prox_hor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_prox_hor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prox_hor.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prox_hor.ForeColor = System.Drawing.Color.White
        Me.btn_prox_hor.Location = New System.Drawing.Point(359, 198)
        Me.btn_prox_hor.Name = "btn_prox_hor"
        Me.btn_prox_hor.Size = New System.Drawing.Size(329, 36)
        Me.btn_prox_hor.TabIndex = 57
        Me.btn_prox_hor.Text = "[ HOR1 - HOR2 - HOR3 - HOR4 ]"
        Me.btn_prox_hor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prox_hor.UseVisualStyleBackColor = False
        '
        'btn_tit_prox_hor_3d
        '
        Me.btn_tit_prox_hor_3d.BackColor = System.Drawing.Color.White
        Me.btn_tit_prox_hor_3d.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_tit_prox_hor_3d.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tit_prox_hor_3d.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tit_prox_hor_3d.ForeColor = System.Drawing.Color.Black
        Me.btn_tit_prox_hor_3d.Location = New System.Drawing.Point(350, 263)
        Me.btn_tit_prox_hor_3d.Name = "btn_tit_prox_hor_3d"
        Me.btn_tit_prox_hor_3d.Size = New System.Drawing.Size(230, 36)
        Me.btn_tit_prox_hor_3d.TabIndex = 56
        Me.btn_tit_prox_hor_3d.Text = "Próximas Sessões (3D)"
        Me.btn_tit_prox_hor_3d.UseVisualStyleBackColor = False
        '
        'btn_tit_prox_hor
        '
        Me.btn_tit_prox_hor.BackColor = System.Drawing.Color.White
        Me.btn_tit_prox_hor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_tit_prox_hor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tit_prox_hor.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tit_prox_hor.ForeColor = System.Drawing.Color.Black
        Me.btn_tit_prox_hor.Location = New System.Drawing.Point(350, 136)
        Me.btn_tit_prox_hor.Name = "btn_tit_prox_hor"
        Me.btn_tit_prox_hor.Size = New System.Drawing.Size(189, 36)
        Me.btn_tit_prox_hor.TabIndex = 55
        Me.btn_tit_prox_hor.Text = "Próximas Sessões"
        Me.btn_tit_prox_hor.UseVisualStyleBackColor = False
        '
        'btn_titulo
        '
        Me.btn_titulo.BackColor = System.Drawing.Color.Red
        Me.btn_titulo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_titulo.ForeColor = System.Drawing.Color.White
        Me.btn_titulo.Location = New System.Drawing.Point(146, 370)
        Me.btn_titulo.Name = "btn_titulo"
        Me.btn_titulo.Size = New System.Drawing.Size(176, 36)
        Me.btn_titulo.TabIndex = 54
        Me.btn_titulo.Text = "[ TITULO ]"
        Me.btn_titulo.UseVisualStyleBackColor = False
        '
        'btn_seta_esq
        '
        Me.btn_seta_esq.BackgroundImage = CType(resources.GetObject("btn_seta_esq.BackgroundImage"), System.Drawing.Image)
        Me.btn_seta_esq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_seta_esq.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_seta_esq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seta_esq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_seta_esq.Location = New System.Drawing.Point(27, 155)
        Me.btn_seta_esq.Name = "btn_seta_esq"
        Me.btn_seta_esq.Size = New System.Drawing.Size(46, 129)
        Me.btn_seta_esq.TabIndex = 2
        Me.btn_seta_esq.UseVisualStyleBackColor = True
        '
        'btn_seta_dir
        '
        Me.btn_seta_dir.BackgroundImage = CType(resources.GetObject("btn_seta_dir.BackgroundImage"), System.Drawing.Image)
        Me.btn_seta_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_seta_dir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_seta_dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seta_dir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_seta_dir.Location = New System.Drawing.Point(739, 155)
        Me.btn_seta_dir.Name = "btn_seta_dir"
        Me.btn_seta_dir.Size = New System.Drawing.Size(46, 129)
        Me.btn_seta_dir.TabIndex = 1
        Me.btn_seta_dir.UseVisualStyleBackColor = True
        '
        'btn_realizar_venda
        '
        Me.btn_realizar_venda.BackColor = System.Drawing.Color.Red
        Me.btn_realizar_venda.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_realizar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_realizar_venda.Font = New System.Drawing.Font("Segoe UI Semibold", 15.25!, System.Drawing.FontStyle.Bold)
        Me.btn_realizar_venda.ForeColor = System.Drawing.Color.White
        Me.btn_realizar_venda.Location = New System.Drawing.Point(297, 472)
        Me.btn_realizar_venda.Name = "btn_realizar_venda"
        Me.btn_realizar_venda.Size = New System.Drawing.Size(217, 42)
        Me.btn_realizar_venda.TabIndex = 0
        Me.btn_realizar_venda.Text = "Realizar Venda"
        Me.btn_realizar_venda.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Label1"
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
        Me.lbl_underline.TabIndex = 60
        Me.lbl_underline.Text = "___________"
        '
        'frm_operador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(804, 717)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_gridcine)
        Me.Controls.Add(Me.lbl_cargo)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.btn_encerrar_sessao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_underline)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_operador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GridCine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_poster_operador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_cargo As Label
    Friend WithEvents lbl_gridcine As Label
    Friend WithEvents btn_encerrar_sessao As Button
    Friend WithEvents img_poster_operador As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_realizar_venda As Button
    Friend WithEvents btn_seta_esq As Button
    Friend WithEvents btn_seta_dir As Button
    Friend WithEvents btn_titulo As Button
    Friend WithEvents btn_prox_hor_3d As Button
    Friend WithEvents btn_prox_hor As Button
    Friend WithEvents btn_tit_prox_hor_3d As Button
    Friend WithEvents btn_tit_prox_hor As Button
    Friend WithEvents btn_trocar_tema As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_underline As Label
End Class
