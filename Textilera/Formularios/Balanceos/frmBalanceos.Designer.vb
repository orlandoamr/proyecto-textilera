<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtEstiloId = New System.Windows.Forms.TextBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgvBalanceos = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cicloseg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstandarMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstandarHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocenasOperador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOperadores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParejaBalanceo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilizacionOperador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUtilizacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOperadores = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDocenasMinuto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDocenasHora = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDocenasSemana = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgvBalanceos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnBuscar.Image = Global.Textilera.My.Resources.Resources.Search_icon
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(801, 120)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(75, 0, 75, 0)
        Me.btnBuscar.Size = New System.Drawing.Size(365, 50)
        Me.btnBuscar.TabIndex = 60
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtEstiloId
        '
        Me.txtEstiloId.AccessibleName = "estilo"
        Me.txtEstiloId.Enabled = False
        Me.txtEstiloId.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstiloId.Location = New System.Drawing.Point(801, 89)
        Me.txtEstiloId.MaxLength = 15
        Me.txtEstiloId.Name = "txtEstiloId"
        Me.txtEstiloId.Size = New System.Drawing.Size(365, 25)
        Me.txtEstiloId.TabIndex = 59
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.ForeColor = System.Drawing.Color.Black
        Me.lbCodigo.Location = New System.Drawing.Point(797, 66)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(154, 20)
        Me.lbCodigo.TabIndex = 58
        Me.lbCodigo.Text = "Seleccione un estilo"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNuevo.Image = Global.Textilera.My.Resources.Resources.Plus_icon
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.Location = New System.Drawing.Point(803, 624)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(75, 0, 75, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(363, 50)
        Me.btnNuevo.TabIndex = 63
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnGuardar.Image = Global.Textilera.My.Resources.Resources.Save_icon
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(803, 566)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(75, 0, 75, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(363, 50)
        Me.btnGuardar.TabIndex = 62
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'dgvBalanceos
        '
        Me.dgvBalanceos.AllowUserToAddRows = False
        Me.dgvBalanceos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBalanceos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBalanceos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBalanceos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBalanceos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBalanceos.ColumnHeadersHeight = 35
        Me.dgvBalanceos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBalanceos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.IDOperacion, Me.NombreOperacion, Me.Cicloseg, Me.EstandarMin, Me.EstandarHora, Me.DocenasOperador, Me.NumOperadores, Me.ParejaBalanceo, Me.UtilizacionOperador})
        Me.dgvBalanceos.EnableHeadersVisualStyles = False
        Me.dgvBalanceos.Location = New System.Drawing.Point(72, 66)
        Me.dgvBalanceos.Name = "dgvBalanceos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBalanceos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBalanceos.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvBalanceos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBalanceos.RowTemplate.Height = 24
        Me.dgvBalanceos.Size = New System.Drawing.Size(650, 531)
        Me.dgvBalanceos.TabIndex = 61
        '
        'Numero
        '
        Me.Numero.HeaderText = "#Operacion"
        Me.Numero.Name = "Numero"
        Me.Numero.Width = 117
        '
        'IDOperacion
        '
        Me.IDOperacion.HeaderText = "Id Operacion"
        Me.IDOperacion.Name = "IDOperacion"
        Me.IDOperacion.Width = 124
        '
        'NombreOperacion
        '
        Me.NombreOperacion.HeaderText = "Nombre de la Operación"
        Me.NombreOperacion.Name = "NombreOperacion"
        Me.NombreOperacion.Width = 206
        '
        'Cicloseg
        '
        Me.Cicloseg.HeaderText = "Ciclo Seg"
        Me.Cicloseg.Name = "Cicloseg"
        Me.Cicloseg.Width = 96
        '
        'EstandarMin
        '
        Me.EstandarMin.HeaderText = "Estándar docenas/min"
        Me.EstandarMin.Name = "EstandarMin"
        Me.EstandarMin.Width = 189
        '
        'EstandarHora
        '
        Me.EstandarHora.HeaderText = "Estandar docenas/hor"
        Me.EstandarHora.Name = "EstandarHora"
        Me.EstandarHora.Width = 186
        '
        'DocenasOperador
        '
        Me.DocenasOperador.HeaderText = "Docenas/Operador"
        Me.DocenasOperador.Name = "DocenasOperador"
        Me.DocenasOperador.Width = 167
        '
        'NumOperadores
        '
        Me.NumOperadores.HeaderText = "#Operadores"
        Me.NumOperadores.Name = "NumOperadores"
        Me.NumOperadores.Width = 124
        '
        'ParejaBalanceo
        '
        Me.ParejaBalanceo.HeaderText = "Pareja Balanceo"
        Me.ParejaBalanceo.Name = "ParejaBalanceo"
        Me.ParejaBalanceo.Width = 147
        '
        'UtilizacionOperador
        '
        Me.UtilizacionOperador.HeaderText = "%UtilizacionOperador"
        Me.UtilizacionOperador.Name = "UtilizacionOperador"
        Me.UtilizacionOperador.Width = 180
        '
        'txtUtilizacion
        '
        Me.txtUtilizacion.AccessibleName = "estilo"
        Me.txtUtilizacion.Enabled = False
        Me.txtUtilizacion.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilizacion.Location = New System.Drawing.Point(801, 234)
        Me.txtUtilizacion.MaxLength = 15
        Me.txtUtilizacion.Name = "txtUtilizacion"
        Me.txtUtilizacion.Size = New System.Drawing.Size(180, 25)
        Me.txtUtilizacion.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(797, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "%Utilización requerido"
        '
        'txtOperadores
        '
        Me.txtOperadores.AccessibleName = "estilo"
        Me.txtOperadores.Enabled = False
        Me.txtOperadores.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperadores.Location = New System.Drawing.Point(987, 234)
        Me.txtOperadores.MaxLength = 15
        Me.txtOperadores.Name = "txtOperadores"
        Me.txtOperadores.Size = New System.Drawing.Size(180, 25)
        Me.txtOperadores.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(983, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Cant. Operadores"
        '
        'txtDocenasMinuto
        '
        Me.txtDocenasMinuto.AccessibleName = "estilo"
        Me.txtDocenasMinuto.Enabled = False
        Me.txtDocenasMinuto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocenasMinuto.Location = New System.Drawing.Point(986, 307)
        Me.txtDocenasMinuto.MaxLength = 15
        Me.txtDocenasMinuto.Name = "txtDocenasMinuto"
        Me.txtDocenasMinuto.Size = New System.Drawing.Size(180, 25)
        Me.txtDocenasMinuto.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(982, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Meta docenas/día"
        '
        'txtDocenasHora
        '
        Me.txtDocenasHora.AccessibleName = "estilo"
        Me.txtDocenasHora.Enabled = False
        Me.txtDocenasHora.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocenasHora.Location = New System.Drawing.Point(800, 307)
        Me.txtDocenasHora.MaxLength = 15
        Me.txtDocenasHora.Name = "txtDocenasHora"
        Me.txtDocenasHora.Size = New System.Drawing.Size(180, 25)
        Me.txtDocenasHora.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(796, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Meta docenas/hora"
        '
        'txtDocenasSemana
        '
        Me.txtDocenasSemana.AccessibleName = "estilo"
        Me.txtDocenasSemana.Enabled = False
        Me.txtDocenasSemana.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocenasSemana.Location = New System.Drawing.Point(800, 380)
        Me.txtDocenasSemana.MaxLength = 15
        Me.txtDocenasSemana.Name = "txtDocenasSemana"
        Me.txtDocenasSemana.Size = New System.Drawing.Size(180, 25)
        Me.txtDocenasSemana.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(796, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 20)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Meta docenas/semana"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.Black
        Me.chkEstado.Location = New System.Drawing.Point(801, 454)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(102, 24)
        Me.chkEstado.TabIndex = 77
        Me.chkEstado.Text = "Habilitado"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(797, 433)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Estado"
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.Textilera.My.Resources.Resources.Delete_icon
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.Location = New System.Drawing.Point(21, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btnCerrar.Size = New System.Drawing.Size(45, 42)
        Me.btnCerrar.TabIndex = 110
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmBalanceos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 694)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDocenasSemana)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDocenasMinuto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDocenasHora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOperadores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUtilizacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvBalanceos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtEstiloId)
        Me.Controls.Add(Me.lbCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBalanceos"
        Me.Text = "frmBalanceos"
        CType(Me.dgvBalanceos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtEstiloId As TextBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dgvBalanceos As DataGridView
    Friend WithEvents txtUtilizacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOperadores As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDocenasMinuto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDocenasHora As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDocenasSemana As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents IDOperacion As DataGridViewTextBoxColumn
    Friend WithEvents NombreOperacion As DataGridViewTextBoxColumn
    Friend WithEvents Cicloseg As DataGridViewTextBoxColumn
    Friend WithEvents EstandarMin As DataGridViewTextBoxColumn
    Friend WithEvents EstandarHora As DataGridViewTextBoxColumn
    Friend WithEvents DocenasOperador As DataGridViewTextBoxColumn
    Friend WithEvents NumOperadores As DataGridViewTextBoxColumn
    Friend WithEvents ParejaBalanceo As DataGridViewTextBoxColumn
    Friend WithEvents UtilizacionOperador As DataGridViewTextBoxColumn
    Friend WithEvents btnCerrar As Button
End Class
