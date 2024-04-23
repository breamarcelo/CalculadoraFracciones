Public Class Fraccion
    Private numerador, denominador As Double
    Public Sub setNumerador(ByVal num As Double)
        numerador = num
    End Sub
    Public Sub setDenominador(ByVal denom As Double)
        denominador = denom
    End Sub
    Public Function getNumerador() As Double
        Return numerador
    End Function
    Public Function getDenominador() As Double
        Return denominador
    End Function
End Class
