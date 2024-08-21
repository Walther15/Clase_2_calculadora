Imports System.Security.Cryptography.Xml

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim n1, n2, Result As Integer
        Dim op As String
        n1 = CInt(Num1.Text)
        n2 = CInt(Num2.Text)
        op = Operacion.Text
        If op = "Suma" Then
            Result = n1 + n2
        End If
        If op = "Resta" Then
            Result = n1 + n2
        End If
        If op = "Multiplicar" Then
            Result = n1 * n2
        End If
        If op = "Dividir" Then
            Result = n1 / n2
        End If
        MsgBox("Resultado es " & Result)
    End Sub

    Private Sub Num1_TextChanged(sender As Object, e As EventArgs) Handles Num1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
