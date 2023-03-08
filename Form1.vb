Public Class Form1


    'DataGridView1.Rows.Add(txtNombre.Text, TextBox2.Text, TextBox3.Text, dtpFechaNacimiento.Value)

    ' txtNombre.Text = ""
    'txtNombre.Focus()

    'dtpFechaNacimiento.Value = ""
    'dtpFechaNacimiento.Focus()

    'TextBox2.Text = ""
    'TextBox2.Focus()

    'TextBox3.Text = ""
    'TextBox3.Focus()

    Dim Nombre(5) As String  '//En este declaramos las variables 
    Dim Correo(5) As String  '//En este declaramos las variables 
    Dim Telefono(5) As String  '//En este declaramos las variables 
    Dim FechadeNacimiento(5) As DateTime? '//En este declaramos la FECHA DE NACIMIENTO con un DateTime?, y el signo de interrogacion es para mostrar que no hay uno especificado aqui y que tendremos que agregarlo mediante la depuracion en el DateTimePicker

    Dim i As Integer = 0 '// Aqui declaramos una variable para poder utilizarlo como un arreglo

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click  '//En este boton se mostrara todo lo que escribamos dentro de el 

        '// Este es todo lo que se hara en el primer boton

        Nombre(i) = txtNombre.Text  '//Estas son las variables y sus respectivos textbox
        Telefono(i) = TextBox2.Text  '//Estas son las variables y sus respectivos textbox
        Correo(i) = TextBox3.Text  '//Estas son las variables y sus respectivos textbox
        FechadeNacimiento(i) = dtpFechaNacimiento.Value '//Estas son las variables y sus respectivos textbox

        MsgBox("Arreglo" & (i) & "Registrado") '//Este es el mensaje que se mostrara una vez que allamos agregado 

        If i = 5 Then   '//En este if mostrara el mensaje si se llena
            MsgBox("Esta lleno")  '//En este if mostrara el mensaje si se llena
        Else
            i = i + 1  '//En esta forma se incrementa en 1 hasta llegar al limite escrito (Expresado)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '//Este es el boton 2 al que le oprimiremos para mostrar todo lo que este dentro de este

        '// Este es todo lo que se hara en el primer boton


        'Dim z As Integer = 0  //Este es una forma de hacer una linea extra, Es decir una vez que agregemos el primer texto y lo guardamos el segundo tendra una repeticion extra y el tercero tendra otra 


        'While (z <= (i - 1))  //Este es una forma de hacer una linea extra, Es decir una vez que agregemos el primer texto y lo guardamos el segundo tendra una repeticion extra y el tercero tendra otra 

        DataGridView1.Rows.Add(txtNombre.Text, TextBox2.Text, TextBox3.Text, dtpFechaNacimiento.Value) '//Sirve para ordenas cada texto que escribamos en una sola linea y en las columnas que vayan.
        'Si haces varios hacia abajo y luego a cada uno le agregas el texto estos seran de forma vertical 

        txtNombre.Text = "" '//Este sirve para que limpie lo que escribimos en pantalla una vez que lo allamos agregado
        TextBox2.Text = "" '//Este sirve para que limpie lo que escribimos en pantalla una vez  que lo allamos agregado
        TextBox3.Text = "" '//Este sirve para que limpie lo que escribimos en pantalla una vez  que lo allamos agregado
        'dtpFechaNacimiento.Value = ""  '//Este no lo utilices ya que si lo haces te marcara un error , pero te funcionara bien 

        ' z += 1 //Este es una forma de hacer una linea extra, Es decir una vez que agregemos el primer texto y lo guardamos el segundo tendra una repeticion extra y el tercero tendra otra 
        'End While //Este es una forma de hacer una linea extra, Es decir una vez que agregemos el primer texto y lo guardamos el segundo tendra una repeticion extra y el tercero tendra otra 



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click  '//En este boton cerramos la depuracion (lo que esta mostrando en pantalla para escribir)
        End '//En este finaliza todo cerrando la depuracion(la ejecucion)
    End Sub
End Class