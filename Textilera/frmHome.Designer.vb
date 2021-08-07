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
        Me.OperacionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MáquinasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.CrearUnBalanceoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerBalanceosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeEstilosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarOperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeBalanceosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerBalanceosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.MenuStrip.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.EstilosToolStripMenuItem, Me.BalanceosToolStripMenuItem, Me.MiCuentaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1222, 33)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(63, 29)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'EstilosToolStripMenuItem
        '
        Me.EstilosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.EstilosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeEstilosToolStripMenuItem, Me.AñadirOperacionesToolStripMenuItem, Me.OperacionesToolStripMenuItem1, Me.MáquinasToolStripMenuItem1, Me.BalanceosToolStripMenuItem1, Me.UsuariosToolStripMenuItem1})
        Me.EstilosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstilosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.EstilosToolStripMenuItem.Name = "EstilosToolStripMenuItem"
        Me.EstilosToolStripMenuItem.Size = New System.Drawing.Size(96, 29)
        Me.EstilosToolStripMenuItem.Text = "Controles"
        '
        'ControlDeEstilosToolStripMenuItem
        '
        Me.ControlDeEstilosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ControlDeEstilosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.ControlDeEstilosToolStripMenuItem.Name = "ControlDeEstilosToolStripMenuItem"
        Me.ControlDeEstilosToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ControlDeEstilosToolStripMenuItem.Text = "Categorías"
        '
        'AñadirOperacionesToolStripMenuItem
        '
        Me.AñadirOperacionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.AñadirOperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeEstilosToolStripMenuItem1, Me.AsignarOperacionesToolStripMenuItem})
        Me.AñadirOperacionesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.AñadirOperacionesToolStripMenuItem.Name = "AñadirOperacionesToolStripMenuItem"
        Me.AñadirOperacionesToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AñadirOperacionesToolStripMenuItem.Text = "Estilos"
        '
        'OperacionesToolStripMenuItem1
        '
        Me.OperacionesToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.OperacionesToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro
        Me.OperacionesToolStripMenuItem1.Name = "OperacionesToolStripMenuItem1"
        Me.OperacionesToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.OperacionesToolStripMenuItem1.Text = "Operaciones"
        '
        'MáquinasToolStripMenuItem1
        '
        Me.MáquinasToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.MáquinasToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro
        Me.MáquinasToolStripMenuItem1.Name = "MáquinasToolStripMenuItem1"
        Me.MáquinasToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.MáquinasToolStripMenuItem1.Text = "Máquinas"
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.UsuariosToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.UsuariosToolStripMenuItem1.Text = "Usuarios"
        '
        'MiCuentaToolStripMenuItem
        '
        Me.MiCuentaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.MiCuentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MiCuentaToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiCuentaToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.MiCuentaToolStripMenuItem.Name = "MiCuentaToolStripMenuItem"
        Me.MiCuentaToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.MiCuentaToolStripMenuItem.Text = "Mi cuenta"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.EditarToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'BalanceosToolStripMenuItem
        '
        Me.BalanceosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BalanceosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUnBalanceoToolStripMenuItem, Me.VerBalanceosToolStripMenuItem, Me.GenerarReporteToolStripMenuItem})
        Me.BalanceosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.BalanceosToolStripMenuItem.Name = "BalanceosToolStripMenuItem"
        Me.BalanceosToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.BalanceosToolStripMenuItem.Text = "Balanceos"
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.panelContenedor.Location = New System.Drawing.Point(0, 33)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1222, 694)
        Me.panelContenedor.TabIndex = 1
        '
        'CrearUnBalanceoToolStripMenuItem
        '
        Me.CrearUnBalanceoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.CrearUnBalanceoToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.CrearUnBalanceoToolStripMenuItem.Name = "CrearUnBalanceoToolStripMenuItem"
        Me.CrearUnBalanceoToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.CrearUnBalanceoToolStripMenuItem.Text = "Crear un balanceo"
        '
        'VerBalanceosToolStripMenuItem
        '
        Me.VerBalanceosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.VerBalanceosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.VerBalanceosToolStripMenuItem.Name = "VerBalanceosToolStripMenuItem"
        Me.VerBalanceosToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.VerBalanceosToolStripMenuItem.Text = "Ver balanceos"
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GenerarReporteToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.GenerarReporteToolStripMenuItem.Text = "Generar reporte"
        '
        'ControlDeEstilosToolStripMenuItem1
        '
        Me.ControlDeEstilosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ControlDeEstilosToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro
        Me.ControlDeEstilosToolStripMenuItem1.Name = "ControlDeEstilosToolStripMenuItem1"
        Me.ControlDeEstilosToolStripMenuItem1.Size = New System.Drawing.Size(239, 26)
        Me.ControlDeEstilosToolStripMenuItem1.Text = "Control de estilos"
        '
        'AsignarOperacionesToolStripMenuItem
        '
        Me.AsignarOperacionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.AsignarOperacionesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.AsignarOperacionesToolStripMenuItem.Name = "AsignarOperacionesToolStripMenuItem"
        Me.AsignarOperacionesToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.AsignarOperacionesToolStripMenuItem.Text = "Asignar operaciones"
        '
        'BalanceosToolStripMenuItem1
        '
        Me.BalanceosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BalanceosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeBalanceosToolStripMenuItem, Me.VerBalanceosToolStripMenuItem1, Me.GenerarReporteToolStripMenuItem1})
        Me.BalanceosToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro
        Me.BalanceosToolStripMenuItem1.Name = "BalanceosToolStripMenuItem1"
        Me.BalanceosToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.BalanceosToolStripMenuItem1.Text = "Balanceos"
        '
        'ControlDeBalanceosToolStripMenuItem
        '
        Me.ControlDeBalanceosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ControlDeBalanceosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro
        Me.ControlDeBalanceosToolStripMenuItem.Name = "ControlDeBalanceosToolStripMenuItem"
        Me.ControlDeBalanceosToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ControlDeBalanceosToolStripMenuItem.Text = "Control de balanceos"
        '
        'VerBalanceosToolStripMenuItem1
        '
        Me.VerBalanceosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.VerBalanceosToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro
        Me.VerBalanceosToolStripMenuItem1.Name = "VerBalanceosToolStripMenuItem1"
        Me.VerBalanceosToolStripMenuItem1.Size = New System.Drawing.Size(249, 26)
        Me.VerBalanceosToolStripMenuItem1.Text = "Ver balanceos"
        '
        'GenerarReporteToolStripMenuItem1
        '
        Me.GenerarReporteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GenerarReporteToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro
        Me.GenerarReporteToolStripMenuItem1.Name = "GenerarReporteToolStripMenuItem1"
        Me.GenerarReporteToolStripMenuItem1.Size = New System.Drawing.Size(249, 26)
        Me.GenerarReporteToolStripMenuItem1.Text = "Generar reporte"
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
    Friend WithEvents BalanceosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUnBalanceoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerBalanceosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeEstilosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AsignarOperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BalanceosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ControlDeBalanceosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerBalanceosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem1 As ToolStripMenuItem
End Class
