Public Class Form1
    Dim Activo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles resultado.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles suma.Click
        Dim Numero1 As Double = Double.Parse(Me.TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(Me.TextBox2.Text)
        Dim Resultado As Double = Numero1 + Numero2
        Me.resultado.Text = Resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles multiplica.Click
        Dim Numero1 As Double = Double.Parse(Me.TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(Me.TextBox2.Text)
        Dim Resultado As Double = Numero1 * Numero2
        Me.resultado.Text = Resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles resta.Click
        Dim Numero1 As Double = Double.Parse(Me.TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(Me.TextBox2.Text)
        Dim Resultado As Double = Numero1 - Numero2
        Me.resultado.Text = Resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles divide.Click

        Dim result

        Dim Numero1 As Double = Double.Parse(Me.TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(Me.TextBox2.Text)

        If Numero2 > 0 Then
            result = Numero1 / Numero2
        Else
            result = "No se puede"
        End If

        resultado.Text = result.ToString()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Activo.Text = Activo.Text & "4"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Activo.Text = Activo.Text & "0"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Activo.Text = Activo.Text & "1"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Activo.Text = Activo.Text & "2"
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Activo.Text = Activo.Text & "3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Activo.Text = Activo.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Activo.Text = Activo.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Activo.Text = Activo.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Activo.Text = Activo.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Activo.Text = Activo.Text & "9"
    End Sub

    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click
        Activo.Text = "0"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        Activo.Text = Activo.Text & "."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Activo = TextBox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Activo = TextBox2
    End Sub
End Class
