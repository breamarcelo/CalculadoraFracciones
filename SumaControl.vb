Imports CalculadoraFracciones.Fraccion
Public Class SumaControl
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

        If denom1 = denom2 Then
            numFinal = num1 + num2
            denomFinal = denom1
        ElseIf denom1 Mod denom2 = 0 Then
            Dim denomDiv As Double = denom1 / denom2
            numFinal = ((num2 * denomDiv) + num1) / denom2
            denomFinal = denom1 / denom2
        Else
            numFinal = num1 * denom2 + num2 * denom1
            denomFinal = denom2
        End If

        Label7.Text = numFinal
        Label8.Text = denomFinal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Label7.Text = ""
        Label8.Text = ""
    End Sub
End Class
