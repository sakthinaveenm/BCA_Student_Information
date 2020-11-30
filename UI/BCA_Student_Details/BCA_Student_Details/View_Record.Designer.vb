<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Record
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
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Section = New System.Windows.Forms.ComboBox()
        Me.Department = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.register_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.graduate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloodgroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.father_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mother_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.guardian_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address_home = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.college_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pincode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentdetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDetailsALL = New BCA_Student_Details.StudentDetailsALL()
        Me.StudentinfoBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_Database_Final = New BCA_Student_Details.student_Database_Final()
        Me.StudentinfoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_infoDataSet2 = New BCA_Student_Details.student_infoDataSet2()
        Me.StudentinfoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_infoDataSet1 = New BCA_Student_Details.student_infoDataSet1()
        Me.Student_info = New BCA_Student_Details.student_info()
        Me.StudentinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_infoTableAdapter = New BCA_Student_Details.student_infoTableAdapters.student_infoTableAdapter()
        Me.Student_infoDataSet = New BCA_Student_Details.student_infoDataSet()
        Me.StudentinfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_infoTableAdapter1 = New BCA_Student_Details.student_infoDataSetTableAdapters.student_infoTableAdapter()
        Me.Student_infoTableAdapter2 = New BCA_Student_Details.student_infoDataSet1TableAdapters.student_infoTableAdapter()
        Me.Student_infoTableAdapter3 = New BCA_Student_Details.student_infoDataSet2TableAdapters.student_infoTableAdapter()
        Me.Student_infoTableAdapter4 = New BCA_Student_Details.student_Database_FinalTableAdapters.student_infoTableAdapter()
        Me.Student_infoDataSet3 = New BCA_Student_Details.student_infoDataSet3()
        Me.StudentdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_detailsTableAdapter = New BCA_Student_Details.student_infoDataSet3TableAdapters.student_detailsTableAdapter()
        Me.Student_detailsTableAdapter1 = New BCA_Student_Details.StudentDetailsALLTableAdapters.student_detailsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDetailsALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_Database_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_infoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_infoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_infoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_infoDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Year
        '
        Me.Year.FormattingEnabled = True
        Me.Year.Location = New System.Drawing.Point(472, 62)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(121, 21)
        Me.Year.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Year"
        '
        'Section
        '
        Me.Section.FormattingEnabled = True
        Me.Section.Location = New System.Drawing.Point(311, 62)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(121, 21)
        Me.Section.TabIndex = 2
        '
        'Department
        '
        Me.Department.FormattingEnabled = True
        Me.Department.Location = New System.Drawing.Point(151, 62)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(121, 21)
        Me.Department.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Department"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentDataGridViewTextBoxColumn, Me.register_no, Me.student_name, Me.Dob, Me.age, Me.graduate, Me.gender, Me.year_, Me.bloodgroup, Me.father_name, Me.mother_name, Me.guardian_name, Me.address_home, Me.personal_email, Me.college_email, Me.pincode, Me.SectionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentdetailsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(1, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1271, 487)
        Me.DataGridView1.TabIndex = 6
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'register_no
        '
        Me.register_no.DataPropertyName = "register_no"
        Me.register_no.HeaderText = "register_no"
        Me.register_no.Name = "register_no"
        Me.register_no.ReadOnly = True
        '
        'student_name
        '
        Me.student_name.DataPropertyName = "student_name"
        Me.student_name.HeaderText = "student_name"
        Me.student_name.Name = "student_name"
        Me.student_name.ReadOnly = True
        '
        'Dob
        '
        Me.Dob.DataPropertyName = "Dob"
        Me.Dob.HeaderText = "Dob"
        Me.Dob.Name = "Dob"
        Me.Dob.ReadOnly = True
        '
        'age
        '
        Me.age.DataPropertyName = "age"
        Me.age.HeaderText = "age"
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        '
        'graduate
        '
        Me.graduate.DataPropertyName = "graduate"
        Me.graduate.HeaderText = "graduate"
        Me.graduate.Name = "graduate"
        Me.graduate.ReadOnly = True
        '
        'gender
        '
        Me.gender.DataPropertyName = "gender"
        Me.gender.HeaderText = "gender"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'year_
        '
        Me.year_.DataPropertyName = "year_"
        Me.year_.HeaderText = "year_"
        Me.year_.Name = "year_"
        Me.year_.ReadOnly = True
        '
        'bloodgroup
        '
        Me.bloodgroup.DataPropertyName = "bloodgroup"
        Me.bloodgroup.HeaderText = "bloodgroup"
        Me.bloodgroup.Name = "bloodgroup"
        Me.bloodgroup.ReadOnly = True
        '
        'father_name
        '
        Me.father_name.DataPropertyName = "father_name"
        Me.father_name.HeaderText = "father_name"
        Me.father_name.Name = "father_name"
        Me.father_name.ReadOnly = True
        '
        'mother_name
        '
        Me.mother_name.DataPropertyName = "mother_name"
        Me.mother_name.HeaderText = "mother_name"
        Me.mother_name.Name = "mother_name"
        Me.mother_name.ReadOnly = True
        '
        'guardian_name
        '
        Me.guardian_name.DataPropertyName = "guardian_name"
        Me.guardian_name.HeaderText = "guardian_name"
        Me.guardian_name.Name = "guardian_name"
        Me.guardian_name.ReadOnly = True
        '
        'address_home
        '
        Me.address_home.DataPropertyName = "address_home"
        Me.address_home.HeaderText = "address_home"
        Me.address_home.Name = "address_home"
        Me.address_home.ReadOnly = True
        '
        'personal_email
        '
        Me.personal_email.DataPropertyName = "personal_email"
        Me.personal_email.HeaderText = "personal_email"
        Me.personal_email.Name = "personal_email"
        Me.personal_email.ReadOnly = True
        '
        'college_email
        '
        Me.college_email.DataPropertyName = "college_email"
        Me.college_email.HeaderText = "college_email"
        Me.college_email.Name = "college_email"
        Me.college_email.ReadOnly = True
        '
        'pincode
        '
        Me.pincode.DataPropertyName = "pincode"
        Me.pincode.HeaderText = "pincode"
        Me.pincode.Name = "pincode"
        Me.pincode.ReadOnly = True
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "Section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        Me.SectionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentdetailsBindingSource1
        '
        Me.StudentdetailsBindingSource1.DataMember = "student_details"
        Me.StudentdetailsBindingSource1.DataSource = Me.StudentDetailsALL
        '
        'StudentDetailsALL
        '
        Me.StudentDetailsALL.DataSetName = "StudentDetailsALL"
        Me.StudentDetailsALL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentinfoBindingSource4
        '
        Me.StudentinfoBindingSource4.DataMember = "student_info"
        Me.StudentinfoBindingSource4.DataSource = Me.Student_Database_Final
        '
        'Student_Database_Final
        '
        Me.Student_Database_Final.DataSetName = "student_Database_Final"
        Me.Student_Database_Final.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentinfoBindingSource3
        '
        Me.StudentinfoBindingSource3.DataMember = "student_info"
        Me.StudentinfoBindingSource3.DataSource = Me.Student_infoDataSet2
        '
        'Student_infoDataSet2
        '
        Me.Student_infoDataSet2.DataSetName = "student_infoDataSet2"
        Me.Student_infoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentinfoBindingSource2
        '
        Me.StudentinfoBindingSource2.DataMember = "student_info"
        Me.StudentinfoBindingSource2.DataSource = Me.Student_infoDataSet1
        '
        'Student_infoDataSet1
        '
        Me.Student_infoDataSet1.DataSetName = "student_infoDataSet1"
        Me.Student_infoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_info
        '
        Me.Student_info.DataSetName = "student_info"
        Me.Student_info.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentinfoBindingSource
        '
        Me.StudentinfoBindingSource.DataMember = "student_info"
        Me.StudentinfoBindingSource.DataSource = Me.Student_info
        '
        'Student_infoTableAdapter
        '
        Me.Student_infoTableAdapter.ClearBeforeFill = True
        '
        'Student_infoDataSet
        '
        Me.Student_infoDataSet.DataSetName = "student_infoDataSet"
        Me.Student_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentinfoBindingSource1
        '
        Me.StudentinfoBindingSource1.DataMember = "student_info"
        Me.StudentinfoBindingSource1.DataSource = Me.Student_infoDataSet
        '
        'Student_infoTableAdapter1
        '
        Me.Student_infoTableAdapter1.ClearBeforeFill = True
        '
        'Student_infoTableAdapter2
        '
        Me.Student_infoTableAdapter2.ClearBeforeFill = True
        '
        'Student_infoTableAdapter3
        '
        Me.Student_infoTableAdapter3.ClearBeforeFill = True
        '
        'Student_infoTableAdapter4
        '
        Me.Student_infoTableAdapter4.ClearBeforeFill = True
        '
        'Student_infoDataSet3
        '
        Me.Student_infoDataSet3.DataSetName = "student_infoDataSet3"
        Me.Student_infoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentdetailsBindingSource
        '
        Me.StudentdetailsBindingSource.DataMember = "student_details"
        Me.StudentdetailsBindingSource.DataSource = Me.Student_infoDataSet3
        '
        'Student_detailsTableAdapter
        '
        Me.Student_detailsTableAdapter.ClearBeforeFill = True
        '
        'Student_detailsTableAdapter1
        '
        Me.Student_detailsTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "<= Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'View_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 625)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.Section)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Year)
        Me.Name = "View_Record"
        Me.Text = "View_Record"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDetailsALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_Database_Final, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_infoDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_infoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_infoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_infoDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Section As System.Windows.Forms.ComboBox
    Friend WithEvents Department As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Student_info As BCA_Student_Details.student_info
    Friend WithEvents StudentinfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter As BCA_Student_Details.student_infoTableAdapters.student_infoTableAdapter
    Friend WithEvents Student_infoDataSet As BCA_Student_Details.student_infoDataSet
    Friend WithEvents StudentinfoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter1 As BCA_Student_Details.student_infoDataSetTableAdapters.student_infoTableAdapter
    Friend WithEvents Student_infoDataSet1 As BCA_Student_Details.student_infoDataSet1
    Friend WithEvents StudentinfoBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter2 As BCA_Student_Details.student_infoDataSet1TableAdapters.student_infoTableAdapter
    Friend WithEvents Student_infoDataSet2 As BCA_Student_Details.student_infoDataSet2
    Friend WithEvents StudentinfoBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter3 As BCA_Student_Details.student_infoDataSet2TableAdapters.student_infoTableAdapter
    Friend WithEvents Student_Database_Final As BCA_Student_Details.student_Database_Final
    Friend WithEvents StudentinfoBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter4 As BCA_Student_Details.student_Database_FinalTableAdapters.student_infoTableAdapter
    Friend WithEvents Student_infoDataSet3 As BCA_Student_Details.student_infoDataSet3
    Friend WithEvents StudentdetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_detailsTableAdapter As BCA_Student_Details.student_infoDataSet3TableAdapters.student_detailsTableAdapter
    Friend WithEvents StudentDetailsALL As BCA_Student_Details.StudentDetailsALL
    Friend WithEvents StudentdetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_detailsTableAdapter1 As BCA_Student_Details.StudentDetailsALLTableAdapters.student_detailsTableAdapter
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents register_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents student_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents graduate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents year_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bloodgroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents father_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mother_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents guardian_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address_home As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personal_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents college_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pincode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Year As System.Windows.Forms.ComboBox
End Class
