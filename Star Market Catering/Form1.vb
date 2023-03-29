Option Strict On
Option Explicit On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decTotal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints = ""
        Dim intPoints As Integer

        If IsNumeric(txtPoints.Text) Then
            intPoints = Convert.ToInt32(txtPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."
            If intPoints >= 0 Then
                If radCheese.Checked Then
                    decCost = 49.99D
                    strOrder = "Gourmet Cheese"
                ElseIf radPinwheel.Checked Then
                    decCost = 59.99D
                    strOrder = "Pinwheel Wraps"
                ElseIf radVeggie.Checked Then
                    decCost = 29.99D
                    strOrder = "Veggie"
                ElseIf radSausage.Checked Then
                    decCost = 49.99D
                    strOrder = "Sausage and Cheese"
                ElseIf radFruit.Checked Then
                    decCost = 29.99D
                    strOrder = "Fruit"
                End If

                If radPre.Checked Then
                    strPay = " using Pre-Pay"
                ElseIf radPickup.Checked Then
                    strPay = " with Pay upon Pickup"
                End If

                intPoints = Convert.ToInt32(intPoints \ 10I)

                decPoints = (intPoints * cdecDiscount) / 100

                If decPoints > 1 Then
                    decPoints = 1
                End If

                decTotal = decCost * (1 - decPoints)

                lblTotal.Text = "Your order of " & strOrder & " platter costs " & decTotal.ToString("C") & strPay & strPoints
            Else
                MsgBox("Please enter a valid number of points.", , "Input Error")
                Me.btnClear.PerformClick()
            End If
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPoints.Clear()
        txtPoints.Focus()
        lblTotal.Text = ""
        radCheese.Checked = True
        radPinwheel.Checked = False
        radVeggie.Checked = False
        radSausage.Checked = False
        radFruit.Checked = False
        radPre.Checked = True
        radPickup.Checked = False
    End Sub
End Class
