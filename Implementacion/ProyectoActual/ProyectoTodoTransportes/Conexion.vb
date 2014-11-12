﻿Imports MySql.Data.MySqlClient


Public Class Conexion

    Dim cs As String = "Database=ttpt;Data Source=localhost;" _
     & "User Id=testUser;Password=12Test34@"
    Dim conn As New MySqlConnection(cs)
    Dim adaptador As MySqlDataAdapter
    Dim lector As MySqlDataReader
    Dim comando As MySqlCommand


#Region "DESARROLLO"

    Sub iSesion()
        'INICIA SESIÓN SIN PEDIR USER/PASS
        Using comando As New MySqlCommand()
            With comando
                .CommandType = CommandType.Text
                .Connection = conn

            End With
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub

#End Region

#Region "HERRAMIENTAS"

    Function count(ByVal NombreTabla As String) As String

        'Retorna el numero de registros en 'NombreTabla'

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM " & NombreTabla
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cant
    End Function

    Function last(ByVal columna As String, ByVal tabla As String) As String

        'Funcion que retorna el último 'columna' de la tabla 'tabla'

        Using comando As New MySqlCommand()

            comando.CommandText = "SELECT max(" & columna & ") AS " & columna & " FROM " & tabla
            comando.CommandType = CommandType.Text
            comando.Connection = conn

            Try
                comando.ExecuteNonQuery()

                Dim res As String = Convert.ToString(comando.ExecuteScalar)
                Return res

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
    End Function

    Function toArray(ByVal n As Integer, ByVal NombreCampo As String, ByVal NombreTabla As String) As String()

        'Retorna un arreglo con los datos 'NombreCampo' de la tabla 'NombreTabla'

        Dim arreglo(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT " & NombreCampo & " FROM " & NombreTabla
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        arreglo(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return arreglo
    End Function

    Function selectWhereQuery(ByVal columna As String, ByVal tabla As String, ByVal condicion As String) As String

        'DEVUELVE UN DATO EN ESPECIFICO EN LA BD

        Dim res As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT " & columna & " FROM " & tabla & " WHERE " & condicion
                .CommandType = CommandType.Text
                .Connection = conn
            End With
            Try
                comando.ExecuteNonQuery()
                res = comando.ExecuteScalar
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return res
    End Function

    Function iniciarSesion(ByVal usuario As String, ByVal contra As String) As Boolean

        'Verifica USUARIO/CONTRASEÑA y permite el ingreso al sistema
        'Abre la conexión

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Contraseña FROM USUARIO WHERE Nombre = '" & usuario & "'"
                .CommandType = CommandType.Text
                .Connection = conn

            End With
            Try
                conn.Open()
                comando.ExecuteNonQuery()
                Dim pass As String = Convert.ToString(comando.ExecuteScalar)

                If pass.Equals(contra) Then Return True Else Return False

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
        Return False

    End Function

    Sub Close()

        'CIERRA LA BD

        Using comando As New MySqlCommand()
            comando.Connection = conn
        End Using
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

#End Region

#Region "INSERTS"

    Sub regFuncionario(ByVal Nombre As String, ByVal Tipo As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO FUNCIONARIO (Nombre, Tipo) VALUES(@Nombre, @Tipo)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@Tipo", Tipo)

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regUsuario(ByVal Nombre As String, ByVal Contra As String, ByVal Tipo As String, ByVal Funcionario As String)
        Dim idFuncionario As String = Me.selectWhereQuery("idFUNCIONARIO", "FUNCIONARIO", "Nombre = '" & Funcionario & "'")
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO USUARIO (Nombre, Contraseña, Tipo, Funcionario) VALUES(@Nombre, @Contraseña, @Tipo, @Funcionario)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@Contraseña", Contra)
                .Parameters.AddWithValue("@Tipo", Tipo)
                .Parameters.AddWithValue("@Funcionario", CInt(idFuncionario))
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regAtencion(ByVal usuario As String, ByVal idcliente As Integer, ByVal fecha As String, ByVal metodo As String)

        'Realiza el registro en la tabla ATENCION_CLIENTE

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Atencion_cliente_potencial (Usuario, Cliente_Potencial, Fecha, Metodo) VALUES(@Usuario,@Cliente,@Fecha,@Metodo)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Usuario", usuario)
                .Parameters.AddWithValue("@Cliente", idcliente)
                .Parameters.AddWithValue("@Fecha", fecha)
                .Parameters.AddWithValue("@Metodo", metodo) 'momentaneo'

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regClientePotencial(ByVal Nombre As String, ByVal Telefono As Integer, ByVal Producto As String, ByVal Extra As String, ByVal USER As String)

        'Realiza el registro en la tabla CLIENTE

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Cliente_potencial (Nombre, Telefono, Producto, Extra) VALUES(@Nombre, @Telefono, @Producto, @Extra)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@Telefono", Telefono)
                .Parameters.AddWithValue("@Producto", Producto)
                .Parameters.AddWithValue("@Extra", Extra)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

#End Region

#Region "OTROS"


    Function funcionariosToArray(ByVal n As Integer) As String()

        'Retorna un Array con los cursos impartidos por la empresa

        Dim cursos(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT idFUNCIONARIO FROM funcionario"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        cursos(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cursos
    End Function

    Function registrosEnTIPOUSUARIO() As String

        'Retorna el numero de cursos
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM TIPO_USUARIO"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cant
    End Function

    Function tipoUsuariosToArray(ByVal n As Integer) As String()

        'Retorna un Array con los cursos impartidos por la empresa

        Dim tipos(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Tipo FROM tipo_usuario"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        tipos(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return tipos
    End Function

    'AQUI EMPIEZAN LOS METODOS DEL CASO DE USO REGISTRAR CLIENTE
    'Horarios estudiante practico caso de uso registar estudiante

    Function registrosPractico() As String

        'Retorna el numero de clases practica
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM PRACTICA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cant
    End Function

    Function practicoToArray(ByVal n As Integer) As String()

        'Retorna un Array con los practicos impartidos por la empresa

        Dim pract(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Horario FROM PRACTICA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        pract(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return pract
    End Function
    'Horarios estudiante teorico caso de uso registar estudiante'

    Function registrosTeorico() As String

        'Retorna el numero de clases practica
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM TEORIA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cant
    End Function

    Function teoricoToArray(ByVal n As Integer) As String()

        'Retorna un Array con los practicoss impartidos por la empresa

        Dim teo(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Horario FROM TEORIA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        teo(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return teo
    End Function

    Function registrosMedio() As String

        'Retorna el numero de clases practica
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM MEDIO_PAGO"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cant
    End Function

    Function MedioToArray(ByVal n As Integer) As String()

        'Retorna un Array con los practicoss impartidos por la empresa

        Dim medio(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT medio FROM MEDIO_PAGO"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer
                i = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        medio(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return medio
    End Function

    Function buscarPago(ByVal edad As Integer, ByVal Codigo As String) As Integer
        Dim pago As Integer
        Using comando As New MySqlCommand()
            With comando
                If edad > 17 Then
                    .CommandText = "SELECT PrecioAdulto FROM CURSO WHERE Codigo = '" & Codigo & "'"
                    .CommandType = CommandType.Text
                    .Connection = conn
                ElseIf edad <= 17 Then
                    .CommandText = "SELECT PrecioEstudiante FROM CURSO WHERE Codigo = '" & Codigo & "'"
                    .CommandType = CommandType.Text
                    .Connection = conn
                End If
            End With
            Try
                comando.ExecuteNonQuery()
                pago = Convert.ToDecimal(comando.ExecuteScalar)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
        Return pago
    End Function

    Sub RegistrarPago(ByVal Codigo As Integer, ByVal Monto As Integer, ByVal Medio As String)
        'Registra Pago'
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO PAGO (Codigo, Monto, Medio) VALUES(@Codigo, @Monto, @Medio)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Monto", Monto)
                .Parameters.AddWithValue("@Medio", Medio)

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub RegistrarMatricula(ByVal Codigo As String, ByVal Nombre As String, ByVal RUT As String, ByVal Edad As Integer, ByVal Fecha As String, ByVal Telefono As Integer, ByVal CodigoPago As Integer, ByVal Curso As String, ByVal HoraTeorica As String, ByVal HoraPractica As String)
        'Registra Matricula'

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO MATRICULA (Codigo, Nombre, RUT, Edad, Fecha, Telefono, CodigoPago, Curso, HoraTeoria, HoraPractica) VALUES(@Codigo, @Nombre, @RUT, @Edad, @Fecha, @Telefono, @CodigoPago, @Curso, @HoraTeorica, @HoraPractica)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@RUT", RUT)
                .Parameters.AddWithValue("@Edad", Edad)
                .Parameters.AddWithValue("@Fecha", Fecha)
                .Parameters.AddWithValue("@Telefono", Telefono)
                .Parameters.AddWithValue("@CodigoPago", CodigoPago)
                .Parameters.AddWithValue("@Curso", Curso)
                .Parameters.AddWithValue("@HoraTeorica", HoraTeorica)
                .Parameters.AddWithValue("@HoraPractica", HoraPractica)

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub

    Sub RegistrarEstudiante(ByVal Matricula As String, ByVal FotosCarnet As Integer, ByVal CertEstudios As Boolean, ByVal CertAlumnRegular As Boolean, ByVal AutNotarial As Boolean)
        'Registra Estudiante'
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO ESTUDIANTE (Matricula, FotosCarnet, CertEstudios, CertAlumnRegular, AutNotarial) VALUES(@Matricula, @FotosCarnet, @CertEstudios, @CertAlumnRegular, @AutNotarial)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Matricula", Matricula)
                .Parameters.AddWithValue("@FotosCarnet", FotosCarnet)
                .Parameters.AddWithValue("@CertEstudios", CertEstudios)
                .Parameters.AddWithValue("@CertAlumnRegular", CertAlumnRegular)
                .Parameters.AddWithValue("@AutNotarial", AutNotarial)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub

    'Caso de uso 03: examen visual: se necesitan estas clases debido a que no se han llenado ninguna'

    Function registrosMatricula() As String

        'Retorna el numero de estudiantes
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM MATRICULA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cant
    End Function

    Function estudiantesToArray(ByVal n As Integer) As String()

        'Retorna un Array con los nombres de los estudiantes registrados por la empresa

        Dim est(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Nombre FROM MATRICULA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer
                i = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        est(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return est
    End Function

    Function rutToArray(ByVal n As Integer) As String()

        'Retorna un Array con los rut de los estudiantes registrados por la empresa

        Dim r(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Rut FROM MATRICULA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer
                i = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        r(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return r
    End Function

    'Crear clase'
    Sub RegistrarClase(ByVal Codigo As String, ByVal Curso As String, ByVal FechaInicio As String, ByVal FechaTermino As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO CLASE (Codigo, Curso, FechaInicio, FechaTermino) VALUES(@Codigo, @Curso, @FechaInicio, @FechaTermino)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Curso", Curso)
                .Parameters.AddWithValue("@FechaInicio", FechaInicio)
                .Parameters.AddWithValue("@FechaTermino", FechaTermino)

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub
    'Crear clase-estudiante'
    Sub RegistrarClaseEstudiante(ByVal Clase As String, ByVal Estudiante As String, ByVal ExamenVisual As Integer, ByVal Psicotecnico As Integer, ByVal ClaseCambioRueda As Integer)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO CLASE_ESTUDIANTE (Clase, Estudiante, ExamenVisual, Psicotecnico, ClaseCambioRueda) VALUES(@Clase, @Estudiante, @ExamenVisual, @Psicotecnico, @ClaseCambioRueda)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Clase", Clase)
                .Parameters.AddWithValue("@Estudiante", Estudiante)
                .Parameters.AddWithValue("@ExamenVisual", ExamenVisual)
                .Parameters.AddWithValue("@Psicotecnico", Psicotecnico)
                .Parameters.AddWithValue("@ClaseCambioRueda", ClaseCambioRueda)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub
    'Crear examen visual'
    Sub RegistrarExamenVisual(ByVal Examinador As String, ByVal Estado As String, ByVal Certificado As Boolean, ByVal Fecha As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO EXAMEN_VISUAL (Examinador, Estado, Certificado, Fecha) VALUES(@Examinador, @Estado, @Certificado, @Fecha)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Examinador", Examinador)
                .Parameters.AddWithValue("@Estado", Estado)
                .Parameters.AddWithValue("@Certificado", Certificado)
                .Parameters.AddWithValue("@Fecha", Fecha)

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub
    'Crear examen psicotecnico'
    Sub RegistrarExamenPsico(ByVal Fecha As String, ByVal Examinador As String, ByVal Estado As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO EXAMEN_PSICOTECNICO (Fecha, Examinador, Estado) VALUES(@Fecha, @Examinador, @Estado)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Fecha", Fecha)
                .Parameters.AddWithValue("@Examinador", Examinador)
                .Parameters.AddWithValue("@Estado", Estado)

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub

#End Region

End Class
