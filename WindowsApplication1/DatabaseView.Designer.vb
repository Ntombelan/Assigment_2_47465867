<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim YourNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim Module1Label As System.Windows.Forms.Label
        Dim Module2Label As System.Windows.Forms.Label
        Dim Module3Label As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Me.StudentTableAdapter = New WindowsApplication1.Your_DatabaseDataSetTableAdapters.StudentTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Your_DatabaseDataSet = New WindowsApplication1.Your_DatabaseDataSet()
        Me.TableAdapterManager = New WindowsApplication1.Your_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.YourNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.Module1TextBox = New System.Windows.Forms.TextBox()
        Me.Module2TextBox = New System.Windows.Forms.TextBox()
        Me.Module3TextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TitleComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YourNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudyYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Module1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Module2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Module3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        YourNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        Module1Label = New System.Windows.Forms.Label()
        Module2Label = New System.Windows.Forms.Label()
        Module3Label = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Your_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(355, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(274, 476)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 476)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Add New"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(248, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "GO"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Your_DatabaseDataSet
        '
        'Your_DatabaseDataSet
        '
        Me.Your_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Your_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'YourNameLabel
        '
        YourNameLabel.AutoSize = True
        YourNameLabel.Location = New System.Drawing.Point(26, 113)
        YourNameLabel.Name = "YourNameLabel"
        YourNameLabel.Size = New System.Drawing.Size(63, 13)
        YourNameLabel.TabIndex = 37
        YourNameLabel.Text = "Your Name:"
        YourNameLabel.Visible = False
        '
        'YourNameTextBox
        '
        Me.YourNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "YourName", True))
        Me.YourNameTextBox.Location = New System.Drawing.Point(95, 110)
        Me.YourNameTextBox.Name = "YourNameTextBox"
        Me.YourNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YourNameTextBox.TabIndex = 38
        Me.YourNameTextBox.Visible = False
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(28, 141)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 38
        LastNameLabel.Text = "Last Name:"
        LastNameLabel.Visible = False
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(95, 138)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 39
        Me.LastNameTextBox.Visible = False
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(41, 195)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 40
        AddressLabel.Text = "Address:"
        AddressLabel.Visible = False
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(95, 192)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 41
        Me.AddressTextBox.Visible = False
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Location = New System.Drawing.Point(35, 254)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(54, 13)
        SemesterLabel.TabIndex = 42
        SemesterLabel.Text = "Semester:"
        SemesterLabel.Visible = False
        '
        'SemesterTextBox
        '
        Me.SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Semester", True))
        Me.SemesterTextBox.Enabled = False
        Me.SemesterTextBox.Location = New System.Drawing.Point(95, 251)
        Me.SemesterTextBox.Name = "SemesterTextBox"
        Me.SemesterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SemesterTextBox.TabIndex = 43
        Me.SemesterTextBox.Visible = False
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(46, 289)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(43, 13)
        CourseLabel.TabIndex = 44
        CourseLabel.Text = "Course:"
        CourseLabel.Visible = False
        '
        'CourseTextBox
        '
        Me.CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Course", True))
        Me.CourseTextBox.Enabled = False
        Me.CourseTextBox.Location = New System.Drawing.Point(95, 286)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CourseTextBox.TabIndex = 45
        Me.CourseTextBox.Visible = False
        '
        'Module1Label
        '
        Module1Label.AutoSize = True
        Module1Label.Enabled = False
        Module1Label.Location = New System.Drawing.Point(201, 293)
        Module1Label.Name = "Module1Label"
        Module1Label.Size = New System.Drawing.Size(51, 13)
        Module1Label.TabIndex = 46
        Module1Label.Text = "Module1:"
        Module1Label.Visible = False
        '
        'Module1TextBox
        '
        Me.Module1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Module1", True))
        Me.Module1TextBox.Enabled = False
        Me.Module1TextBox.Location = New System.Drawing.Point(258, 290)
        Me.Module1TextBox.Name = "Module1TextBox"
        Me.Module1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Module1TextBox.TabIndex = 47
        Me.Module1TextBox.Visible = False
        '
        'Module2Label
        '
        Module2Label.AutoSize = True
        Module2Label.Enabled = False
        Module2Label.Location = New System.Drawing.Point(201, 324)
        Module2Label.Name = "Module2Label"
        Module2Label.Size = New System.Drawing.Size(51, 13)
        Module2Label.TabIndex = 47
        Module2Label.Text = "Module2:"
        Module2Label.Visible = False
        '
        'Module2TextBox
        '
        Me.Module2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Module2", True))
        Me.Module2TextBox.Enabled = False
        Me.Module2TextBox.Location = New System.Drawing.Point(258, 321)
        Me.Module2TextBox.Name = "Module2TextBox"
        Me.Module2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Module2TextBox.TabIndex = 48
        Me.Module2TextBox.Visible = False
        '
        'Module3Label
        '
        Module3Label.AutoSize = True
        Module3Label.Enabled = False
        Module3Label.Location = New System.Drawing.Point(201, 351)
        Module3Label.Name = "Module3Label"
        Module3Label.Size = New System.Drawing.Size(51, 13)
        Module3Label.TabIndex = 48
        Module3Label.Text = "Module3:"
        Module3Label.Visible = False
        '
        'Module3TextBox
        '
        Me.Module3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Module3", True))
        Me.Module3TextBox.Enabled = False
        Me.Module3TextBox.Location = New System.Drawing.Point(258, 348)
        Me.Module3TextBox.Name = "Module3TextBox"
        Me.Module3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Module3TextBox.TabIndex = 49
        Me.Module3TextBox.Visible = False
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Enabled = False
        StudentIDLabel.Location = New System.Drawing.Point(519, 16)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 49
        StudentIDLabel.Text = "Student ID:"
        StudentIDLabel.Visible = False
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Enabled = False
        Me.StudentIDTextBox.Location = New System.Drawing.Point(586, 13)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentIDTextBox.TabIndex = 50
        Me.StudentIDTextBox.Visible = False
        Me.StudentIDTextBox.WordWrap = False
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(8, 224)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 50
        PhoneNumberLabel.Text = "Phone Number:"
        PhoneNumberLabel.Visible = False
        '
        'PhoneNumberMaskedTextBox
        '
        Me.PhoneNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "PhoneNumber", True))
        Me.PhoneNumberMaskedTextBox.Location = New System.Drawing.Point(95, 221)
        Me.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox"
        Me.PhoneNumberMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberMaskedTextBox.TabIndex = 51
        Me.PhoneNumberMaskedTextBox.Visible = False
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(59, 83)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 51
        TitleLabel.Text = "Title:"
        TitleLabel.Visible = False
        '
        'TitleComboBox
        '
        Me.TitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Title", True))
        Me.TitleComboBox.FormattingEnabled = True
        Me.TitleComboBox.Items.AddRange(New Object() {"Mr", "Miss", "Mrs", "Dr", "Prof"})
        Me.TitleComboBox.Location = New System.Drawing.Point(95, 80)
        Me.TitleComboBox.Name = "TitleComboBox"
        Me.TitleComboBox.Size = New System.Drawing.Size(100, 21)
        Me.TitleComboBox.TabIndex = 52
        Me.TitleComboBox.Visible = False
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(44, 168)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 52
        GenderLabel.Text = "Gender:"
        GenderLabel.Visible = False
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(95, 165)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(100, 21)
        Me.GenderComboBox.TabIndex = 53
        Me.GenderComboBox.Visible = False
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(209, 172)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 53
        DOBLabel.Text = "DOB:"
        DOBLabel.Visible = False
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(248, 168)
        Me.DOBDateTimePicker.MaxDate = New Date(2001, 12, 31, 0, 0, 0, 0)
        Me.DOBDateTimePicker.MinDate = New Date(1945, 12, 31, 0, 0, 0, 0)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(91, 20)
        Me.DOBDateTimePicker.TabIndex = 54
        Me.DOBDateTimePicker.Value = New Date(1945, 12, 31, 0, 0, 0, 0)
        Me.DOBDateTimePicker.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.YourNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.StudyYearDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.Module1DataGridViewTextBoxColumn, Me.Module2DataGridViewTextBoxColumn, Me.Module3DataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 561)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(939, 150)
        Me.DataGridView1.TabIndex = 55
        Me.DataGridView1.Visible = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YourNameDataGridViewTextBoxColumn
        '
        Me.YourNameDataGridViewTextBoxColumn.DataPropertyName = "YourName"
        Me.YourNameDataGridViewTextBoxColumn.HeaderText = "YourName"
        Me.YourNameDataGridViewTextBoxColumn.Name = "YourNameDataGridViewTextBoxColumn"
        Me.YourNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudyYearDataGridViewTextBoxColumn
        '
        Me.StudyYearDataGridViewTextBoxColumn.DataPropertyName = "StudyYear"
        Me.StudyYearDataGridViewTextBoxColumn.HeaderText = "StudyYear"
        Me.StudyYearDataGridViewTextBoxColumn.Name = "StudyYearDataGridViewTextBoxColumn"
        Me.StudyYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        Me.SemesterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Module1DataGridViewTextBoxColumn
        '
        Me.Module1DataGridViewTextBoxColumn.DataPropertyName = "Module1"
        Me.Module1DataGridViewTextBoxColumn.HeaderText = "Module1"
        Me.Module1DataGridViewTextBoxColumn.Name = "Module1DataGridViewTextBoxColumn"
        Me.Module1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Module2DataGridViewTextBoxColumn
        '
        Me.Module2DataGridViewTextBoxColumn.DataPropertyName = "Module2"
        Me.Module2DataGridViewTextBoxColumn.HeaderText = "Module2"
        Me.Module2DataGridViewTextBoxColumn.Name = "Module2DataGridViewTextBoxColumn"
        Me.Module2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Module3DataGridViewTextBoxColumn
        '
        Me.Module3DataGridViewTextBoxColumn.DataPropertyName = "Module3"
        Me.Module3DataGridViewTextBoxColumn.HeaderText = "Module3"
        Me.Module3DataGridViewTextBoxColumn.Name = "Module3DataGridViewTextBoxColumn"
        Me.Module3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatabaseView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 740)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleComboBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberMaskedTextBox)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(Module3Label)
        Me.Controls.Add(Me.Module3TextBox)
        Me.Controls.Add(Module2Label)
        Me.Controls.Add(Me.Module2TextBox)
        Me.Controls.Add(Module1Label)
        Me.Controls.Add(Me.Module1TextBox)
        Me.Controls.Add(CourseLabel)
        Me.Controls.Add(Me.CourseTextBox)
        Me.Controls.Add(SemesterLabel)
        Me.Controls.Add(Me.SemesterTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(YourNameLabel)
        Me.Controls.Add(Me.YourNameTextBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "DatabaseView"
        Me.Text = "DatabaseView"
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Your_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Your_DatabaseDataSet As WindowsApplication1.Your_DatabaseDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As WindowsApplication1.Your_DatabaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As WindowsApplication1.Your_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents YourNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CourseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Module1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Module2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Module3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YourNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudyYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Module1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Module2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Module3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
