﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.AccessibleName = "usuario"
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(71, 253)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.MaxLength = 15
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(362, 30)
        Me.txtUsuario.TabIndex = 27
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.ForeColor = System.Drawing.Color.Black
        Me.lbCodigo.Location = New System.Drawing.Point(68, 227)
        Me.lbCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(75, 22)
        Me.lbCodigo.TabIndex = 26
        Me.lbCodigo.Text = "Usuario"
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnIniciar.Location = New System.Drawing.Point(70, 453)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(363, 59)
        Me.btnIniciar.TabIndex = 29
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'txtContrasenia
        '
        Me.txtContrasenia.AccessibleName = "contraseña"
        Me.txtContrasenia.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(72, 357)
        Me.txtContrasenia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasenia.MaxLength = 15
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(361, 30)
        Me.txtContrasenia.TabIndex = 31
        Me.txtContrasenia.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(66, 331)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(93, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 159)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 552)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbCodigo)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lbCodigo As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class