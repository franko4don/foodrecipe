Imports System.Windows.Forms

Public Class CustomGroupBox
    Inherits GroupBox

    Public Sub New(ByVal name As String, ByVal description As String, ByVal image As String)
        Console.WriteLine(description)
        Me.SetBounds(7, 13, 639, 25)
        Me.BackColor = Color.Aquamarine
    End Sub
End Class
