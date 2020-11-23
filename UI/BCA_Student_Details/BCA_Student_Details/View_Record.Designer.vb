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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentinfoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_infoDataSet1 = New BCA_Student_Details.student_infoDataSet1()
        Me.Student_info = New BCA_Student_Details.student_info()
        Me.StudentinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_infoTableAdapter = New BCA_Student_Details.student_infoTableAdapters.student_infoTableAdapter()
        Me.Student_infoDataSet = New BCA_Student_Details.student_infoDataSet()
        Me.StudentinfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_infoTableAdapter1 = New BCA_Student_Details.student_infoDataSetTableAdapters.student_infoTableAdapter()
        Me.Student_infoTableAdapter2 = New BCA_Student_Details.student_infoDataSet1TableAdapters.student_infoTableAdapter()
        Me.Student_infoDataSet2 = New BCA_Student_Details.student_infoDataSet2()
        Me.StudentinfoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_infoTableAdapter3 = New BCA_Student_Details.student_infoDataSet2TableAdapters.student_infoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_infoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_infoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_infoDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentinfoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(472, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(311, 62)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(151, 62)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 3
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
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RollnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentinfoBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(53, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(590, 360)
        Me.DataGridView1.TabIndex = 6
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "roll_no"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "roll_no"
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        Me.RollnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "Section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        Me.SectionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.ReadOnly = True
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
        'Student_infoDataSet2
        '
        Me.Student_infoDataSet2.DataSetName = "student_infoDataSet2"
        Me.Student_infoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentinfoBindingSource3
        '
        Me.StudentinfoBindingSource3.DataMember = "student_info"
        Me.StudentinfoBindingSource3.DataSource = Me.Student_infoDataSet2
        '
        'Student_infoTableAdapter3
        '
        Me.Student_infoTableAdapter3.ClearBeforeFill = True
        '
        'View_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 509)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "View_Record"
        Me.Text = "View_Record"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_infoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_infoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_infoDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentinfoBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Student_info As BCA_Student_Details.student_info
    Friend WithEvents StudentinfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter As BCA_Student_Details.student_infoTableAdapters.student_infoTableAdapter
    Friend WithEvents RollnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Student_infoDataSet As BCA_Student_Details.student_infoDataSet
    Friend WithEvents StudentinfoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter1 As BCA_Student_Details.student_infoDataSetTableAdapters.student_infoTableAdapter
    Friend WithEvents Student_infoDataSet1 As BCA_Student_Details.student_infoDataSet1
    Friend WithEvents StudentinfoBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter2 As BCA_Student_Details.student_infoDataSet1TableAdapters.student_infoTableAdapter
    Friend WithEvents Student_infoDataSet2 As BCA_Student_Details.student_infoDataSet2
    Friend WithEvents StudentinfoBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_infoTableAdapter3 As BCA_Student_Details.student_infoDataSet2TableAdapters.student_infoTableAdapter
End Class
