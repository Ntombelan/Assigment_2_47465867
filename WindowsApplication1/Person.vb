Public Class Person
    Private stud_id As String
    Private stud_firstname As String
    Private stud_lastname As String
    Private stud_address As String
    Private stud_tel As String
    Private stud_gender As String
    Private stud_regyear As Date
    Dim converter As Integer

   



    Public Property StudentFname As String
        Get
            Return stud_firstname
        End Get
        Set(ByVal value As String)
            stud_firstname = value
        End Set
    End Property



    Public Property StudentLname As String
        Get
            Return stud_lastname
        End Get
        Set(ByVal value As String)
            stud_lastname = value
        End Set
    End Property



    Public Property StudentGender As String
        Get
            Return stud_gender
        End Get
        Set(ByVal value As String)
            stud_gender = value
        End Set
    End Property



    Public Property StudentAddress As String
        Get
            Return stud_address
        End Get
        Set(ByVal value As String)
            stud_address = value
        End Set
    End Property



    Public Property StudentRegYear As Date
        Get
            Return stud_regyear
        End Get
        Set(ByVal value As Date)


            stud_regyear = value
        End Set
    End Property



    Public Property StudentId As String
        Get
            Return stud_id
        End Get
        Set(ByVal value As String)


            stud_id = value
        End Set
    End Property



    Public Property StudentTel As String

        Get
            Return stud_tel
        End Get
        Set(ByVal value As String)

            stud_tel = value
        End Set
    End Property
End Class
