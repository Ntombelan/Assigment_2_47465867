
Imports WindowsApplication1.Form1

Module StudentID

    
    Public studentnumber, con As String
    Public count As Integer
    Public newstudent As String
    Public cyear As String = DateTime.Now.ToString("yy")
    Dim studentTotal As Integer = 13


 


    Public Function studentid(ByRef studentnumber As String) As String

        'if statment to generate new student number for each registration'
        If (Form1.Button3.Enabled = True) Then
            newstudent = cyear & studentTotal.ToString("D4")


            studentTotal = studentTotal + 1
            studentnumber = newstudent.ToString
            Form1.TextBox9.Text = studentnumber
            Form1.TextBox9.Enabled = False

        End If

        Return (studentnumber)









    End Function

End Module
