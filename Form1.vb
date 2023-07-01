Public Class Form1
    Dim flagOperacion As Boolean
    Dim Resultado As Nullable(Of Double) = Nothing
    Dim aux As Nullable(Of Double) = Nothing
    Dim Operador As String
    Dim sqrt As Double
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        Conactenar()
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

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "8"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        TipoOperacion()
        Operador = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtOperacion.Text = ""
        txtResultado.Text = ""
        Operador = ""
        Resultado = Nothing
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        TipoOperacion()
        Operador = "/"
        txtOperacion.Text = +txtResultado.Text + Operador
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "7"
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "9"
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        TipoOperacion()
        Operador = "*"
        txtOperacion.Text = txtResultado.Text + Operador
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "5"
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "6"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        TipoOperacion()
        Operador = "-"
        txtOperacion.Text = +txtResultado.Text + Operador
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "1"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "2"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "3"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        TipoOperacion()
        Operador = "+"
        txtOperacion.Text = txtResultado.Text + Operador
    End Sub

    Private Sub btnout_Click(sender As Object, e As EventArgs) Handles btnout.Click
        Conactenar()
        txtResultado.Text = txtResultado.Text + "0"
    End Sub

    Public Sub TipoOperacion()
        flagOperacion = True
        aux = Val(txtResultado.Text)
        If Resultado IsNot Nothing Then
            Select Case Operador
                Case "+"
                    Resultado = Resultado + aux
                    txtOperacion.Text = txtOperacion.Text + aux.ToString
                Case "-"
                    Resultado = Resultado - aux
                    txtOperacion.Text = txtOperacion.Text + aux.ToString
                Case "*"
                    Resultado = Resultado * aux
                    txtOperacion.Text = txtOperacion.Text + aux.ToString
                Case "/"
                    Resultado = Resultado / aux
                    txtOperacion.Text = txtOperacion.Text + aux.ToString
            End Select
            txtResultado.Text = Resultado
        Else
            Resultado = aux
        End If
    End Sub
    Public Sub Conactenar()
        If (flagOperacion = True) Then
            txtResultado.Text = ""
            flagOperacion = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub

    Private Sub txtOperacion_TextChanged(sender As Object, e As EventArgs) Handles txtOperacion.TextChanged

    End Sub

    Private Sub btnPunto_Click_1(sender As Object, e As EventArgs) Handles btnPunto.Click
        Conactenar()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text = txtResultado.Text + "."
        End If
    End Sub
End Class




