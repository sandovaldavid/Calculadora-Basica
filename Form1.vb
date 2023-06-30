Public Class Form1
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtResultado.Text = txtResultado.Text + "4"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub
    Private Sub txtResultadoNumero_KeyPress(ByVal sender As Object,
           ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResultado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtResultado.Text = txtResultado.Text + "8"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles btnIgual.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

    End Sub

    Private Sub btnDEL_Click(sender As Object, e As EventArgs) Handles btnDEL.Click

    End Sub

    Private Sub btnInversa_Click(sender As Object, e As EventArgs) Handles btnInversa.Click

    End Sub

    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click

    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click

    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click

    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtResultado.Text = txtResultado.Text + "7"
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtResultado.Text = txtResultado.Text + "9"
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click

    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtResultado.Text = txtResultado.Text + "5"
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtResultado.Text = txtResultado.Text + "6"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtResultado.Text = txtResultado.Text + "1"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtResultado.Text = txtResultado.Text + "2"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtResultado.Text = txtResultado.Text + "3"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

    End Sub

    Private Sub btnCambioSigno_Click(sender As Object, e As EventArgs) Handles btnCambioSigno.Click

    End Sub

    Private Sub btnout_Click(sender As Object, e As EventArgs) Handles btnout.Click
        txtResultado.Text = txtResultado.Text + "0"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click

    End Sub
End Class
