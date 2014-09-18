<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModApply
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModApply))
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim YourNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim Module1Label As System.Windows.Forms.Label
        Dim Module2Label As System.Windows.Forms.Label
        Dim Module3Label As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Your_DatabaseDataSet = New WindowsApplication1.Your_DatabaseDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New WindowsApplication1.Your_DatabaseDataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Your_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.YourNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.Module1TextBox = New System.Windows.Forms.TextBox()
        Me.Module2TextBox = New System.Windows.Forms.TextBox()
        Me.Module3TextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        YourNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        Module1Label = New System.Windows.Forms.Label()
        Module2Label = New System.Windows.Forms.Label()
        Module3Label = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Your_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(552, 24)
        Me.MenuStrip1.TabIndex = 67
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Your_DatabaseDataSet
        '
        Me.Your_DatabaseDataSet.DataSetName = "Your_DatabaseDataSet"
        Me.Your_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Your_DatabaseDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Your_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(364, 140)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 93
        StudentIDLabel.Text = "Student ID:"
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Enabled = False
        Me.StudentIDTextBox.Location = New System.Drawing.Point(431, 137)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentIDTextBox.TabIndex = 94
        '
        'YourNameLabel
        '
        YourNameLabel.AutoSize = True
        YourNameLabel.Location = New System.Drawing.Point(35, 167)
        YourNameLabel.Name = "YourNameLabel"
        YourNameLabel.Size = New System.Drawing.Size(63, 13)
        YourNameLabel.TabIndex = 94
        YourNameLabel.Text = "Your Name:"
        '
        'YourNameTextBox
        '
        Me.YourNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "YourName", True))
        Me.YourNameTextBox.Enabled = False
        Me.YourNameTextBox.Location = New System.Drawing.Point(104, 164)
        Me.YourNameTextBox.Name = "YourNameTextBox"
        Me.YourNameTextBox.Size = New System.Drawing.Size(203, 20)
        Me.YourNameTextBox.TabIndex = 95
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(37, 192)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 95
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "LastName", True))
        Me.LastNameTextBox.Enabled = False
        Me.LastNameTextBox.Location = New System.Drawing.Point(104, 189)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(203, 20)
        Me.LastNameTextBox.TabIndex = 96
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(53, 252)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 96
        GenderLabel.Text = "Gender:"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Gender", True))
        Me.GenderTextBox.Enabled = False
        Me.GenderTextBox.Location = New System.Drawing.Point(104, 249)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(203, 20)
        Me.GenderTextBox.TabIndex = 97
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(65, 222)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 97
        DOBLabel.Text = "DOB:"
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "DOB", True))
        Me.DOBTextBox.Enabled = False
        Me.DOBTextBox.Location = New System.Drawing.Point(104, 219)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(203, 20)
        Me.DOBTextBox.TabIndex = 98
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(50, 278)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 98
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Address", True))
        Me.AddressTextBox.Enabled = False
        Me.AddressTextBox.Location = New System.Drawing.Point(104, 275)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(203, 20)
        Me.AddressTextBox.TabIndex = 99
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(17, 309)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 99
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Enabled = False
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(104, 306)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(203, 20)
        Me.PhoneNumberTextBox.TabIndex = 100
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Location = New System.Drawing.Point(44, 410)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(54, 13)
        SemesterLabel.TabIndex = 101
        SemesterLabel.Text = "Semester:"
        '
        'SemesterTextBox
        '
        Me.SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Semester", True))
        Me.SemesterTextBox.Enabled = False
        Me.SemesterTextBox.Location = New System.Drawing.Point(104, 407)
        Me.SemesterTextBox.Name = "SemesterTextBox"
        Me.SemesterTextBox.Size = New System.Drawing.Size(203, 20)
        Me.SemesterTextBox.TabIndex = 102
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(55, 439)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(43, 13)
        CourseLabel.TabIndex = 102
        CourseLabel.Text = "Course:"
        '
        'CourseTextBox
        '
        Me.CourseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Course", True))
        Me.CourseTextBox.Enabled = False
        Me.CourseTextBox.Location = New System.Drawing.Point(104, 436)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(203, 20)
        Me.CourseTextBox.TabIndex = 103
        '
        'Module1Label
        '
        Module1Label.AutoSize = True
        Module1Label.Location = New System.Drawing.Point(47, 465)
        Module1Label.Name = "Module1Label"
        Module1Label.Size = New System.Drawing.Size(51, 13)
        Module1Label.TabIndex = 103
        Module1Label.Text = "Module1:"
        '
        'Module1TextBox
        '
        Me.Module1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Module1", True))
        Me.Module1TextBox.Enabled = False
        Me.Module1TextBox.Location = New System.Drawing.Point(104, 462)
        Me.Module1TextBox.Name = "Module1TextBox"
        Me.Module1TextBox.Size = New System.Drawing.Size(203, 20)
        Me.Module1TextBox.TabIndex = 104
        '
        'Module2Label
        '
        Module2Label.AutoSize = True
        Module2Label.Location = New System.Drawing.Point(47, 491)
        Module2Label.Name = "Module2Label"
        Module2Label.Size = New System.Drawing.Size(51, 13)
        Module2Label.TabIndex = 104
        Module2Label.Text = "Module2:"
        '
        'Module2TextBox
        '
        Me.Module2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Module2", True))
        Me.Module2TextBox.Enabled = False
        Me.Module2TextBox.Location = New System.Drawing.Point(104, 488)
        Me.Module2TextBox.Name = "Module2TextBox"
        Me.Module2TextBox.Size = New System.Drawing.Size(203, 20)
        Me.Module2TextBox.TabIndex = 105
        '
        'Module3Label
        '
        Module3Label.AutoSize = True
        Module3Label.Location = New System.Drawing.Point(47, 517)
        Module3Label.Name = "Module3Label"
        Module3Label.Size = New System.Drawing.Size(51, 13)
        Module3Label.TabIndex = 105
        Module3Label.Text = "Module3:"
        '
        'Module3TextBox
        '
        Me.Module3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Module3", True))
        Me.Module3TextBox.Enabled = False
        Me.Module3TextBox.Location = New System.Drawing.Point(104, 514)
        Me.Module3TextBox.Name = "Module3TextBox"
        Me.Module3TextBox.Size = New System.Drawing.Size(203, 20)
        Me.Module3TextBox.TabIndex = 106
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(68, 143)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 106
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Title", True))
        Me.TitleTextBox.Enabled = False
        Me.TitleTextBox.Location = New System.Drawing.Point(104, 140)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(203, 20)
        Me.TitleTextBox.TabIndex = 107
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(40, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(334, 42)
        Me.Label28.TabIndex = 92
        Me.Label28.Text = "Orange University"
        '
        'ModApply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(552, 587)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
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
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(YourNameLabel)
        Me.Controls.Add(Me.YourNameTextBox)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ModApply"
        Me.Text = "Orange University"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Your_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Your_DatabaseDataSet As WindowsApplication1.Your_DatabaseDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As WindowsApplication1.Your_DatabaseDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Your_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YourNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CourseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Module1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Module2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Module3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
