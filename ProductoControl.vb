Imports CalculadoraFracciones.Fraccion
Public Class ProductoControl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, denom1, denom2, numFinal, denomFinal As Double
        Dim fraccion1 As New Fraccion()
        Dim fraccion2 As New Fraccion()

        fraccion1.setNumerador(TextBox1.Text)
        fraccion1.setDenominador(TextBox2.Text)
        fraccion2.setNumerador(TextBox3.Text)
        fraccion2.setDenominador(TextBox4.Text)

        num1 = fraccion1.getNumerador()
        denom1 = fraccion1.getDenominador()
        num2 = fraccion2.getNumerador()
        denom2 = fraccion2.getDenominador()

        numFinal = num1 * num2
        denomFinal = denom1 * denom2

        Label6.Text = numFinal
        Label7.Text = denomFinal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Label6.Text = ""
        Label7.Text = ""
    End Sub
End Class
