Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SumaControl1.Hide()
        DiferenciaControl1.Hide()
        ProductoControl1.Hide()
        DivisionControl1.Hide()
        ArrayControl1.Hide()
    End Sub

    Private Sub SumaBtn_Click(sender As Object, e As EventArgs) Handles SumaBtn.Click
        SumaControl1.Show()
        DiferenciaControl1.Hide()
        ProductoControl1.Hide()
        DivisionControl1.Hide()
        ArrayControl1.Hide()
        SumaBtn.BackColor = Color.IndianRed
        DiferenciaBtn.BackColor = Color.DarkSlateGray
        ProductoBtn.BackColor = Color.DarkSlateGray
        DivisionBtn.BackColor = Color.DarkSlateGray
        ArrayBtn.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub DiferenciaBtn_Click(sender As Object, e As EventArgs) Handles DiferenciaBtn.Click
        SumaControl1.Hide()
        DiferenciaControl1.Show()
        ProductoControl1.Hide()
        DivisionControl1.Hide()
        ArrayControl1.Hide()
        SumaBtn.BackColor = Color.DarkSlateGray
        DiferenciaBtn.BackColor = Color.IndianRed
        ProductoBtn.BackColor = Color.DarkSlateGray
        DivisionBtn.BackColor = Color.DarkSlateGray
        ArrayBtn.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub ProductoBtn_Click(sender As Object, e As EventArgs) Handles ProductoBtn.Click
        SumaControl1.Hide()
        DiferenciaControl1.Hide()
        ProductoControl1.Show()
        DivisionControl1.Hide()
        ArrayControl1.Hide()
        SumaBtn.BackColor = Color.DarkSlateGray
        DiferenciaBtn.BackColor = Color.DarkSlateGray
        ProductoBtn.BackColor = Color.IndianRed
        DivisionBtn.BackColor = Color.DarkSlateGray
        ArrayBtn.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub DivisionBtn_Click(sender As Object, e As EventArgs) Handles DivisionBtn.Click
        SumaControl1.Hide()
        DiferenciaControl1.Hide()
        ProductoControl1.Hide()
        DivisionControl1.Show()
        ArrayControl1.Hide()
        SumaBtn.BackColor = Color.DarkSlateGray
        DiferenciaBtn.BackColor = Color.DarkSlateGray
        ProductoBtn.BackColor = Color.DarkSlateGray
        DivisionBtn.BackColor = Color.IndianRed
        ArrayBtn.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub ArrayBtn_Click(sender As Object, e As EventArgs) Handles ArrayBtn.Click
        SumaControl1.Hide()
        DiferenciaControl1.Hide()
        ProductoControl1.Hide()
        DivisionControl1.Hide()
        ArrayControl1.Show()
        SumaBtn.BackColor = Color.DarkSlateGray
        DiferenciaBtn.BackColor = Color.DarkSlateGray
        ProductoBtn.BackColor = Color.DarkSlateGray
        DivisionBtn.BackColor = Color.DarkSlateGray
        ArrayBtn.BackColor = Color.IndianRed
    End Sub
End Class
