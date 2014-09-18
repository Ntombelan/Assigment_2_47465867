Imports System.Diagnostics
Imports System.Drawing.Printing
Imports System.Xml

Public Class Form1

    Private _textBoxes() As TextBox
   





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "OrangeUniversity.com"


        ' text boxes are created and put in the array
        _textBoxes = {TextBox1, TextBox10, TextBox11, TextBox12, TextBox2, TextBox3, TextBox9}

        'TODO: This line of code loads data into the 'Your_DatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Your_DatabaseDataSet.Student)
        StudentBindingSource.AddNew()

        ' StudentBindingSource.MoveNext()




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StudentBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)   'addnew
        StudentBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click   'save

        For Each tb As TextBox In _textBoxes
            If tb.Text.Trim().Length = 0 Then


                Dim comp As String = Me.Your_DatabaseDataSet.Student.Select("StudentID='" & TextBox9.Text & "'").ToString

                If comp Then

                    StudentID.studentid(studentnumber)

                    MessageBox.Show("You must enter a value for all fields.")
                    Return

                End If
            Else


                On Error GoTo SaveErr
                StudentBindingSource.AddNew()
                StudentBindingSource.EndEdit()
                StudentTableAdapter.Update(Your_DatabaseDataSet.Student)
                MessageBox.Show("You have succesfully Registered")

SaveErr:
                Exit Sub




            End If
        Next


        Me.Refresh()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StudentBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub




    '----------------------------------Course selection

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged




        Select Case ComboBox3.SelectedIndex

            Case 0
                ListBox1.Items.Clear()

                If ComboBox2.SelectedIndex.ToString = "0" Then

                    ListBox1.Items.Add("Maths")
                    ListBox1.Items.Add("English")
                    ListBox1.Items.Add("Science")



                ElseIf ComboBox2.SelectedIndex.ToString = "1" Then

                    'Case 1

                    ListBox1.Items.Add("computers")
                    ListBox1.Items.Add("Drawing")
                    ListBox1.Items.Add("design")

                End If

                'End Select






            Case 1

                ListBox1.Items.Clear()

                If ComboBox2.SelectedText.ToString = "0" Then

                    ListBox1.Items.Add("Maths")
                    ListBox1.Items.Add("Law")
                    ListBox1.Items.Add("Tax")


                    ' Case 1


                ElseIf ComboBox2.SelectedIndex.ToString = "1" Then

                    ListBox1.Items.Add("Finance")
                    ListBox1.Items.Add("Management")
                    ListBox1.Items.Add("Pastel")

                End If





        End Select

        'End Select

    End Sub











    '---------------------------------------Adding to module Buttons

    Private Sub ButM1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButM1.Click
        Dim lst As New List(Of Object)
        For Each a As Object In ListBox1.SelectedItems

            TextBox12.Text = ListBox1.SelectedItem
            lst.Add(a)
            TextBox12.Enabled = False

        Next
        For Each a As Object In lst
            ListBox1.Items.Remove(a)
        Next

    End Sub

    Private Sub ButM2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButM2.Click
        Dim lst As New List(Of Object)
        For Each a As Object In ListBox1.SelectedItems

            TextBox11.Text = ListBox1.SelectedItem
            lst.Add(a)
            TextBox11.Enabled = False
        Next
        For Each a As Object In lst
            ListBox1.Items.Remove(a)
        Next
    End Sub

    Private Sub ButM3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButM3.Click
        Dim lst As New List(Of Object)
        For Each a As Object In ListBox1.SelectedItems

            TextBox10.Text = ListBox1.SelectedItem
            lst.Add(a)
            TextBox10.Enabled = False
        Next
        For Each a As Object In lst
            ListBox1.Items.Remove(a)
        Next
    End Sub



    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DatabaseView.Show()


    End Sub


    ' ----------------------------------------------------------File Tab



    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click

        DatabaseView.Show()
        Me.Hide()
    End Sub






    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        StudentID.studentid(studentnumber)
        TextBox9.Text = studentnumber
        MsgBox("your student number is :" & studentnumber)


    End Sub


    Private Sub PrintPreViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreViewToolStripMenuItem.Click


        ModApply.Show()
        Me.Hide()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click


    End Sub



    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Me.Close()
        DatabaseView.Close()
        ModApply.Close()
    End Sub

    Private Sub ViewDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDatabaseToolStripMenuItem.Click

    End Sub
End Class