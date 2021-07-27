Module Mensajes
    Public Sub MsgRegistroExitoso()
        MessageBox.Show("Se ha guardado el registro exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MsgActualizacionExitosa()
        MessageBox.Show("Se ha actualizado el registro exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MsgCampoVacio(txt As String)
        MessageBox.Show("Ingrese el campo " & txt, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Module
