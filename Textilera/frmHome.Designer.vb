<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstilosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeEstilosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirOperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeEstilosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarOperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MáquinasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeBalanceosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerBalanceosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.GhostWhite
        Me.MenuStrip.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.EstilosToolStripMenuItem, Me.MiCuentaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1222, 33)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(63, 29)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'EstilosToolStripMenuItem
        '
        Me.EstilosToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.EstilosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeEstilosToolStripMenuItem, Me.AñadirOperacionesToolStripMenuItem, Me.OperacionesToolStripMenuItem1, Me.MáquinasToolStripMenuItem1, Me.BalanceosToolStripMenuItem1, Me.UsuariosToolStripMenuItem1})
        Me.EstilosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstilosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EstilosToolStripMenuItem.Name = "EstilosToolStripMenuItem"
        Me.EstilosToolStripMenuItem.Size = New System.Drawing.Size(96, 29)
        Me.EstilosToolStripMenuItem.Text = "Controles"
        '
        'ControlDeEstilosToolStripMenuItem
        '
        Me.ControlDeEstilosToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.ControlDeEstilosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ControlDeEstilosToolStripMenuItem.Name = "ControlDeEstilosToolStripMenuItem"
        Me.ControlDeEstilosToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ControlDeEstilosToolStripMenuItem.Text = "Categorías"
        '
        'AñadirOperacionesToolStripMenuItem
        '
        Me.AñadirOperacionesToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.AñadirOperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeEstilosToolStripMenuItem1, Me.AsignarOperacionesToolStripMenuItem})
        Me.AñadirOperacionesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AñadirOperacionesToolStripMenuItem.Name = "AñadirOperacionesToolStripMenuItem"
        Me.AñadirOperacionesToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AñadirOperacionesToolStripMenuItem.Text = "Estilos"
        '
        'ControlDeEstilosToolStripMenuItem1
        '
        Me.ControlDeEstilosToolStripMenuItem1.BackColor = System.Drawing.Color.GhostWhite
        Me.ControlDeEstilosToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ControlDeEstilosToolStripMenuItem1.Name = "ControlDeEstilosToolStripMenuItem1"
        Me.ControlDeEstilosToolStripMenuItem1.Size = New System.Drawing.Size(239, 26)
        Me.ControlDeEstilosToolStripMenuItem1.Text = "Control de estilos"
        '
        'AsignarOperacionesToolStripMenuItem
        '
        Me.AsignarOperacionesToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.AsignarOperacionesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AsignarOperacionesToolStripMenuItem.Name = "AsignarOperacionesToolStripMenuItem"
        Me.AsignarOperacionesToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.AsignarOperacionesToolStripMenuItem.Text = "Asignar operaciones"
        '
        'OperacionesToolStripMenuItem1
        '
        Me.OperacionesToolStripMenuItem1.BackColor = System.Drawing.Color.GhostWhite
        Me.OperacionesToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.OperacionesToolStripMenuItem1.Name = "OperacionesToolStripMenuItem1"
        Me.OperacionesToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.OperacionesToolStripMenuItem1.Text = "Operaciones"
        '
        'MáquinasToolStripMenuItem1
        '
        Me.MáquinasToolStripMenuItem1.BackColor = System.Drawing.Color.GhostWhite
        Me.MáquinasToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.MáquinasToolStripMenuItem1.Name = "MáquinasToolStripMenuItem1"
        Me.MáquinasToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.MáquinasToolStripMenuItem1.Text = "Máquinas"
        '
        'BalanceosToolStripMenuItem1
        '
        Me.BalanceosToolStripMenuItem1.BackColor = System.Drawing.Color.GhostWhite
        Me.BalanceosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeBalanceosToolStripMenuItem, Me.VerBalanceosToolStripMenuItem1, Me.GenerarReporteToolStripMenuItem1})
        Me.BalanceosToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.BalanceosToolStripMenuItem1.Name = "BalanceosToolStripMenuItem1"
        Me.BalanceosToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.BalanceosToolStripMenuItem1.Text = "Balanceos"
        '
        'ControlDeBalanceosToolStripMenuItem
        '
        Me.ControlDeBalanceosToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.ControlDeBalanceosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ControlDeBalanceosToolStripMenuItem.Name = "ControlDeBalanceosToolStripMenuItem"
        Me.ControlDeBalanceosToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ControlDeBalanceosToolStripMenuItem.Text = "Control de balanceos"
        '
        'VerBalanceosToolStripMenuItem1
        '
        Me.VerBalanceosToolStripMenuItem1.BackColor = System.Drawing.Color.GhostWhite
        Me.VerBalanceosToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.VerBalanceosToolStripMenuItem1.Name = "VerBalanceosToolStripMenuItem1"
        Me.VerBalanceosToolStripMenuItem1.Size = New System.Drawing.Size(249, 26)
        Me.VerBalanceosToolStripMenuItem1.Text = "Ver balanceos"
        '
        'GenerarReporteToolStripMenuItem1
        '
        Me.GenerarReporteToolStripMenuItem1.BackColor = System.Drawing.Color.GhostWhite
        Me.GenerarReporteToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.GenerarReporteToolStripMenuItem1.Name = "GenerarReporteToolStripMenuItem1"
        Me.GenerarReporteToolStripMenuItem1.Size = New System.Drawing.Size(249, 26)
        Me.GenerarReporteToolStripMenuItem1.Text = "Generar reporte"
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.BackColor = System.Drawing.Color.GhostWhite
        Me.UsuariosToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.UsuariosToolStripMenuItem1.Text = "Usuarios"
        '
        'MiCuentaToolStripMenuItem
        '
        Me.MiCuentaToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.MiCuentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MiCuentaToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiCuentaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MiCuentaToolStripMenuItem.Name = "MiCuentaToolStripMenuItem"
        Me.MiCuentaToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.MiCuentaToolStripMenuItem.Text = "Mi cuenta"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.EditarToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.GhostWhite
        Me.panelContenedor.Controls.Add(Me.Panel1)
        Me.panelContenedor.Controls.Add(Me.lbNombre)
        Me.panelContenedor.Controls.Add(Me.PictureBox1)
        Me.panelContenedor.Controls.Add(Me.Label2)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.panelContenedor.Location = New System.Drawing.Point(0, 33)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1222, 694)
        Me.panelContenedor.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(567, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 694)
        Me.Panel1.TabIndex = 114
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbNombre.Location = New System.Drawing.Point(156, 434)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(0, 38)
        Me.lbNombre.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.GhostWhite
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(182, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 44)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Bienvenido!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Textilera.My.Resources.Resources.ppp1
        Me.PictureBox1.Location = New System.Drawing.Point(205, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 179)
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Textilera.My.Resources.Resources.t
        Me.PictureBox2.Location = New System.Drawing.Point(85, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(465, 454)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1222, 727)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmHome"
        Me.Text = "frmHome"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstilosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeEstilosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirOperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MáquinasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ControlDeEstilosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AsignarOperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BalanceosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ControlDeBalanceosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerBalanceosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
