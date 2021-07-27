'Módulo con todas las validaciones generales usadas en los formularios
Module Validaciones
    'Función para validar si existen campos vacios en una lista de TextBoxes
    Public Function validarCamposVacios(lista As List(Of TextBox))
        Dim campoVacio As String = ""
        Dim estado As Boolean = True

        For Each textBox In lista
            If (textBox.Text = "") Then
                campoVacio = textBox.AccessibleName
                estado = False
                Exit For
            End If
        Next

        Dim res As New List(Of Object) From {estado, campoVacio}
        Return res
    End Function
End Module
