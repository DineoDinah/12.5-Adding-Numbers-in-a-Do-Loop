Imports System.Diagnostics.Metrics

Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim Counter As Integer
		Do While Counter <= 100
			Counter += 1

			ListBox1.Items.Add(Counter)


		Loop
	End Sub
End Class
