Imports System.Reflection.Emit
Imports CalculadoraFracciones.Fraccion
Public Class ArrayControl
    Dim counter As Integer = 0
    Dim numeradores = New Double() {}
    Dim denominadores = New Double() {}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numerador, denominador, cantidad As String
        Dim fraccion As New Fraccion

        cantidad = TextBox3.Text
        numerador = TextBox1.Text
        denominador = TextBox2.Text

        fraccion.setNumerador(numerador)
        fraccion.setDenominador(denominador)
        numeradores(cantidad) = fraccion.getNumerador()
        denominadores(cantidad) = fraccion.getDenominador()


        If counter < cantidad - 1 Then
            Label2.Text += numerador & "/" & denominador & " + "
        ElseIf counter = cantidad - 1 Then
            Label2.Text += numerador & "/" & denominador
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        counter += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2, denom1, denom2, numFinal, denomFinal As Double

        numFinal = numeradores(0)
        denomFinal = denominadores(0)
        For i = 1 To counter - 1
            num1 = numFinal
            denom1 = denomFinal
            num2 = numeradores(i)
            denom2 = denominadores(i)

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
        Next
        Label6.Text = numFinal
        Label7.Text = denomFinal
        counter = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label2.Text = ""
        Label6.Text = ""
        Label7.Text = ""
    End Sub
End Class
