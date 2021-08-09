<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteBalanceo
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BalanceosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Textilera.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BalanceosTableAdapter = New Textilera.DataSet1TableAdapters.BalanceosTableAdapter()
        Me.btnBuscarCategorias = New System.Windows.Forms.Button()
        Me.txtEstiloId = New System.Windows.Forms.TextBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.BalanceosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BalanceosBindingSource
        '
        Me.BalanceosBindingSource.DataMember = "Balanceos"
        Me.BalanceosBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BalanceosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Textilera.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(67, 121)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1074, 546)
        Me.ReportViewer1.TabIndex = 0
        '
        'BalanceosTableAdapter
        '
        Me.BalanceosTableAdapter.ClearBeforeFill = True
        '
        'btnBuscarCategorias
        '
        Me.btnBuscarCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscarCategorias.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue
        Me.btnBuscarCategorias.FlatAppearance.BorderSize = 0
        Me.btnBuscarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCategorias.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCategorias.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnBuscarCategorias.Image = Global.Textilera.My.Resources.Resources.Search_icon
        Me.btnBuscarCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarCategorias.Location = New System.Drawing.Point(357, 52)
        Me.btnBuscarCategorias.Name = "btnBuscarCategorias"
        Me.btnBuscarCategorias.Padding = New System.Windows.Forms.Padding(75, 0, 75, 0)
        Me.btnBuscarCategorias.Size = New System.Drawing.Size(365, 50)
        Me.btnBuscarCategorias.TabIndex = 111
        Me.btnBuscarCategorias.Text = "Buscar"
        Me.btnBuscarCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCategorias.UseVisualStyleBackColor = False
        '
        'txtEstiloId
        '
        Me.txtEstiloId.AccessibleName = "estilo"
        Me.txtEstiloId.Enabled = False
        Me.txtEstiloId.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstiloId.Location = New System.Drawing.Point(67, 65)
        Me.txtEstiloId.MaxLength = 15
        Me.txtEstiloId.Name = "txtEstiloId"
        Me.txtEstiloId.Size = New System.Drawing.Size(284, 25)
        Me.txtEstiloId.TabIndex = 110
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.ForeColor = System.Drawing.Color.Black
        Me.lbCodigo.Location = New System.Drawing.Point(63, 42)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(189, 20)
        Me.lbCodigo.TabIndex = 109
        Me.lbCodigo.Text = "Seleccione un balanceo"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(778, 52)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(75, 0, 75, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(363, 50)
        Me.btnGuardar.TabIndex = 112
        Me.btnGuardar.Text = "Generar reporte"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.Textilera.My.Resources.Resources.Delete_icon
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.Location = New System.Drawing.Point(12, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btnCerrar.Size = New System.Drawing.Size(45, 42)
        Me.btnCerrar.TabIndex = 113
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmReporteBalanceo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1222, 694)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBuscarCategorias)
        Me.Controls.Add(Me.txtEstiloId)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReporteBalanceo"
        Me.Text = "frmReporteBalanceo"
        CType(Me.BalanceosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BalanceosBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents BalanceosTableAdapter As DataSet1TableAdapters.BalanceosTableAdapter
    Friend WithEvents btnBuscarCategorias As Button
    Friend WithEvents txtEstiloId As TextBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCerrar As Button
End Class
