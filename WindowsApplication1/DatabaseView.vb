
Imports System.Windows
Public Class DatabaseView

    Private Sub DatabaseView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Your_DatabaseDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Your_DatabaseDataSet.Student)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If StudentIDTextBox.Text = "" Then

            MessageBox.Show("Enter  correct student number")


        Else
            StudentBindingSource.EndEdit()
        End If

    End Sub  'update current data being worked on excluding fields which are restricted


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If StudentIDTextBox.Text = "" Then

            MessageBox.Show("Enter  correct student number")


        Else

            StudentBindingSource.RemoveCurrent()
        End If
    End Sub  'remove current data being worked on

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        StudentBindingSource.AddNew()


    End Sub  'add new data option

   



    'when all parameters are met for the search function all the items below will appear contaning the searched data
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        StudentIDTextBox.Visible = True
        TitleComboBox.Visible = True
        LastNameTextBox.Visible = True
        YourNameTextBox.Visible = True
        Module1TextBox.Visible = True
        Module2TextBox.Visible = True
        Module3TextBox.Visible = True
        StudentIDTextBox.Visible = True
        AddressTextBox.Visible = True
        GenderComboBox.Visible = True
        DOBDateTimePicker.Visible = True
        CourseTextBox.Visible = True
        SemesterTextBox.Visible = True
        DataGridView1.Visible = True
        DataGridView1.DataSource = Me.Your_DatabaseDataSet.Student.Select("StudentID='" & TextBox1.Text & "'")
    End Sub



    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


End Class