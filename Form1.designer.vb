<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.EmployeeIDLabel = New System.Windows.Forms.Label()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.EmployeeInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.PayRateTextBox = New System.Windows.Forms.TextBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PayRateLabel = New System.Windows.Forms.Label()
        Me.HoursWorkedLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.Label()
        Me.BenefitsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DentalCheckBox = New System.Windows.Forms.CheckBox()
        Me.LifeCheckBox = New System.Windows.Forms.CheckBox()
        Me.MedicalCheckBox = New System.Windows.Forms.CheckBox()
        Me.Retirement401ARadioButton = New System.Windows.Forms.RadioButton()
        Me.RetirementStandardRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoneRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NetPayTextBox = New System.Windows.Forms.TextBox()
        Me.BenefitsTextBox = New System.Windows.Forms.TextBox()
        Me.FederalTaxTextBox = New System.Windows.Forms.TextBox()
        Me.GrossPayTextBox = New System.Windows.Forms.TextBox()
        Me.FederalTaxLabel = New System.Windows.Forms.Label()
        Me.BenefitsLabel = New System.Windows.Forms.Label()
        Me.NetPayLabel = New System.Windows.Forms.Label()
        Me.GrossPayLabel = New System.Windows.Forms.Label()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalSalaryInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComputeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetFormToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeInformationGroupBox.SuspendLayout()
        Me.BenefitsGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeIDLabel
        '
        Me.EmployeeIDLabel.AutoSize = True
        Me.EmployeeIDLabel.Location = New System.Drawing.Point(6, 77)
        Me.EmployeeIDLabel.Name = "EmployeeIDLabel"
        Me.EmployeeIDLabel.Size = New System.Drawing.Size(88, 16)
        Me.EmployeeIDLabel.TabIndex = 0
        Me.EmployeeIDLabel.Text = "Employee ID:"
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.AutoSize = True
        Me.DepartmentLabel.Location = New System.Drawing.Point(6, 105)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(80, 16)
        Me.DepartmentLabel.TabIndex = 1
        Me.DepartmentLabel.Text = "Department:"
        '
        'EmployeeInformationGroupBox
        '
        Me.EmployeeInformationGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EmployeeInformationGroupBox.Controls.Add(Me.PayRateTextBox)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.HoursTextBox)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.DepartmentTextBox)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.EmployeeIDMaskedTextBox)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.NameTextBox1)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.PayRateLabel)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.HoursWorkedLabel)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.EmployeeIDLabel)
        Me.EmployeeInformationGroupBox.Controls.Add(Me.DepartmentLabel)
        Me.EmployeeInformationGroupBox.Location = New System.Drawing.Point(12, 47)
        Me.EmployeeInformationGroupBox.Name = "EmployeeInformationGroupBox"
        Me.EmployeeInformationGroupBox.Size = New System.Drawing.Size(674, 159)
        Me.EmployeeInformationGroupBox.TabIndex = 2
        Me.EmployeeInformationGroupBox.TabStop = False
        Me.EmployeeInformationGroupBox.Text = "Employee Information"
        '
        'PayRateTextBox
        '
        Me.PayRateTextBox.Location = New System.Drawing.Point(512, 111)
        Me.PayRateTextBox.Name = "PayRateTextBox"
        Me.PayRateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PayRateTextBox.TabIndex = 3
        Me.PayRateTextBox.Text = "$25.55  "
        Me.PayRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Location = New System.Drawing.Point(512, 84)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(100, 22)
        Me.HoursTextBox.TabIndex = 3
        Me.HoursTextBox.Text = "41.5  "
        Me.HoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(100, 105)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(184, 22)
        Me.DepartmentTextBox.TabIndex = 3
        Me.DepartmentTextBox.Text = "CMIS"
        '
        'EmployeeIDMaskedTextBox
        '
        Me.EmployeeIDMaskedTextBox.Location = New System.Drawing.Point(100, 74)
        Me.EmployeeIDMaskedTextBox.Name = "EmployeeIDMaskedTextBox"
        Me.EmployeeIDMaskedTextBox.Size = New System.Drawing.Size(139, 22)
        Me.EmployeeIDMaskedTextBox.TabIndex = 7
        Me.EmployeeIDMaskedTextBox.Text = "999-99-9999"
        '
        'NameTextBox1
        '
        Me.NameTextBox1.Location = New System.Drawing.Point(100, 41)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(320, 22)
        Me.NameTextBox1.TabIndex = 6
        Me.NameTextBox1.Text = " Douglas Bock"
        '
        'PayRateLabel
        '
        Me.PayRateLabel.AutoSize = True
        Me.PayRateLabel.Location = New System.Drawing.Point(409, 117)
        Me.PayRateLabel.Name = "PayRateLabel"
        Me.PayRateLabel.Size = New System.Drawing.Size(66, 16)
        Me.PayRateLabel.TabIndex = 3
        Me.PayRateLabel.Text = "Pay Rate:"
        '
        'HoursWorkedLabel
        '
        Me.HoursWorkedLabel.AutoSize = True
        Me.HoursWorkedLabel.Location = New System.Drawing.Point(409, 84)
        Me.HoursWorkedLabel.Name = "HoursWorkedLabel"
        Me.HoursWorkedLabel.Size = New System.Drawing.Size(97, 16)
        Me.HoursWorkedLabel.TabIndex = 4
        Me.HoursWorkedLabel.Text = "Hours Worked:"
        '
        'NameTextBox
        '
        Me.NameTextBox.AutoSize = True
        Me.NameTextBox.Location = New System.Drawing.Point(6, 41)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(47, 16)
        Me.NameTextBox.TabIndex = 5
        Me.NameTextBox.Text = "Name:"
        '
        'BenefitsGroupBox
        '
        Me.BenefitsGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BenefitsGroupBox.Controls.Add(Me.DentalCheckBox)
        Me.BenefitsGroupBox.Controls.Add(Me.LifeCheckBox)
        Me.BenefitsGroupBox.Controls.Add(Me.MedicalCheckBox)
        Me.BenefitsGroupBox.Controls.Add(Me.Retirement401ARadioButton)
        Me.BenefitsGroupBox.Controls.Add(Me.RetirementStandardRadioButton)
        Me.BenefitsGroupBox.Controls.Add(Me.NoneRadioButton)
        Me.BenefitsGroupBox.Location = New System.Drawing.Point(12, 212)
        Me.BenefitsGroupBox.Name = "BenefitsGroupBox"
        Me.BenefitsGroupBox.Size = New System.Drawing.Size(259, 270)
        Me.BenefitsGroupBox.TabIndex = 3
        Me.BenefitsGroupBox.TabStop = False
        Me.BenefitsGroupBox.Text = "Benefits"
        '
        'DentalCheckBox
        '
        Me.DentalCheckBox.AutoSize = True
        Me.DentalCheckBox.Location = New System.Drawing.Point(9, 218)
        Me.DentalCheckBox.Name = "DentalCheckBox"
        Me.DentalCheckBox.Size = New System.Drawing.Size(129, 20)
        Me.DentalCheckBox.TabIndex = 4
        Me.DentalCheckBox.Text = "Dental Insurance"
        Me.DentalCheckBox.UseVisualStyleBackColor = True
        '
        'LifeCheckBox
        '
        Me.LifeCheckBox.AutoSize = True
        Me.LifeCheckBox.Location = New System.Drawing.Point(9, 192)
        Me.LifeCheckBox.Name = "LifeCheckBox"
        Me.LifeCheckBox.Size = New System.Drawing.Size(111, 20)
        Me.LifeCheckBox.TabIndex = 4
        Me.LifeCheckBox.Text = "Life Insurance"
        Me.LifeCheckBox.UseVisualStyleBackColor = True
        '
        'MedicalCheckBox
        '
        Me.MedicalCheckBox.AutoSize = True
        Me.MedicalCheckBox.Location = New System.Drawing.Point(9, 166)
        Me.MedicalCheckBox.Name = "MedicalCheckBox"
        Me.MedicalCheckBox.Size = New System.Drawing.Size(138, 20)
        Me.MedicalCheckBox.TabIndex = 4
        Me.MedicalCheckBox.Text = "Medical Insurance"
        Me.MedicalCheckBox.UseVisualStyleBackColor = True
        '
        'Retirement401ARadioButton
        '
        Me.Retirement401ARadioButton.AutoSize = True
        Me.Retirement401ARadioButton.Location = New System.Drawing.Point(9, 103)
        Me.Retirement401ARadioButton.Name = "Retirement401ARadioButton"
        Me.Retirement401ARadioButton.Size = New System.Drawing.Size(133, 20)
        Me.Retirement401ARadioButton.TabIndex = 4
        Me.Retirement401ARadioButton.TabStop = True
        Me.Retirement401ARadioButton.Text = "Retirement - 401A"
        Me.Retirement401ARadioButton.UseVisualStyleBackColor = True
        '
        'RetirementStandardRadioButton
        '
        Me.RetirementStandardRadioButton.AutoSize = True
        Me.RetirementStandardRadioButton.Location = New System.Drawing.Point(9, 67)
        Me.RetirementStandardRadioButton.Name = "RetirementStandardRadioButton"
        Me.RetirementStandardRadioButton.Size = New System.Drawing.Size(158, 20)
        Me.RetirementStandardRadioButton.TabIndex = 4
        Me.RetirementStandardRadioButton.TabStop = True
        Me.RetirementStandardRadioButton.Text = "Retirement - Standard"
        Me.RetirementStandardRadioButton.UseVisualStyleBackColor = True
        '
        'NoneRadioButton
        '
        Me.NoneRadioButton.AutoSize = True
        Me.NoneRadioButton.Location = New System.Drawing.Point(9, 41)
        Me.NoneRadioButton.Name = "NoneRadioButton"
        Me.NoneRadioButton.Size = New System.Drawing.Size(144, 20)
        Me.NoneRadioButton.TabIndex = 4
        Me.NoneRadioButton.TabStop = True
        Me.NoneRadioButton.Text = "No Retirement Plan"
        Me.NoneRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.NetPayTextBox)
        Me.GroupBox1.Controls.Add(Me.BenefitsTextBox)
        Me.GroupBox1.Controls.Add(Me.FederalTaxTextBox)
        Me.GroupBox1.Controls.Add(Me.GrossPayTextBox)
        Me.GroupBox1.Controls.Add(Me.FederalTaxLabel)
        Me.GroupBox1.Controls.Add(Me.BenefitsLabel)
        Me.GroupBox1.Controls.Add(Me.NetPayLabel)
        Me.GroupBox1.Controls.Add(Me.GrossPayLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 175)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payroll Information"
        '
        'NetPayTextBox
        '
        Me.NetPayTextBox.Location = New System.Drawing.Point(153, 135)
        Me.NetPayTextBox.Name = "NetPayTextBox"
        Me.NetPayTextBox.ReadOnly = True
        Me.NetPayTextBox.Size = New System.Drawing.Size(164, 22)
        Me.NetPayTextBox.TabIndex = 7
        Me.NetPayTextBox.TabStop = False
        Me.NetPayTextBox.Text = "$773.11  "
        Me.NetPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BenefitsTextBox
        '
        Me.BenefitsTextBox.Location = New System.Drawing.Point(153, 101)
        Me.BenefitsTextBox.Name = "BenefitsTextBox"
        Me.BenefitsTextBox.ReadOnly = True
        Me.BenefitsTextBox.Size = New System.Drawing.Size(164, 22)
        Me.BenefitsTextBox.TabIndex = 6
        Me.BenefitsTextBox.TabStop = False
        Me.BenefitsTextBox.Text = "112.07  "
        Me.BenefitsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FederalTaxTextBox
        '
        Me.FederalTaxTextBox.Location = New System.Drawing.Point(153, 69)
        Me.FederalTaxTextBox.Name = "FederalTaxTextBox"
        Me.FederalTaxTextBox.ReadOnly = True
        Me.FederalTaxTextBox.Size = New System.Drawing.Size(164, 22)
        Me.FederalTaxTextBox.TabIndex = 5
        Me.FederalTaxTextBox.TabStop = False
        Me.FederalTaxTextBox.Text = "194.31  "
        Me.FederalTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrossPayTextBox
        '
        Me.GrossPayTextBox.Location = New System.Drawing.Point(153, 30)
        Me.GrossPayTextBox.Name = "GrossPayTextBox"
        Me.GrossPayTextBox.ReadOnly = True
        Me.GrossPayTextBox.Size = New System.Drawing.Size(164, 22)
        Me.GrossPayTextBox.TabIndex = 4
        Me.GrossPayTextBox.TabStop = False
        Me.GrossPayTextBox.Text = "$1.079.49  "
        Me.GrossPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FederalTaxLabel
        '
        Me.FederalTaxLabel.AutoSize = True
        Me.FederalTaxLabel.Location = New System.Drawing.Point(21, 72)
        Me.FederalTaxLabel.Name = "FederalTaxLabel"
        Me.FederalTaxLabel.Size = New System.Drawing.Size(83, 16)
        Me.FederalTaxLabel.TabIndex = 3
        Me.FederalTaxLabel.Text = "Federal Tax:"
        '
        'BenefitsLabel
        '
        Me.BenefitsLabel.AutoSize = True
        Me.BenefitsLabel.Location = New System.Drawing.Point(21, 107)
        Me.BenefitsLabel.Name = "BenefitsLabel"
        Me.BenefitsLabel.Size = New System.Drawing.Size(58, 16)
        Me.BenefitsLabel.TabIndex = 2
        Me.BenefitsLabel.Text = "Benefits:"
        '
        'NetPayLabel
        '
        Me.NetPayLabel.AutoSize = True
        Me.NetPayLabel.Location = New System.Drawing.Point(21, 141)
        Me.NetPayLabel.Name = "NetPayLabel"
        Me.NetPayLabel.Size = New System.Drawing.Size(58, 16)
        Me.NetPayLabel.TabIndex = 1
        Me.NetPayLabel.Text = "Net Pay:"
        '
        'GrossPayLabel
        '
        Me.GrossPayLabel.AutoSize = True
        Me.GrossPayLabel.Location = New System.Drawing.Point(21, 43)
        Me.GrossPayLabel.Name = "GrossPayLabel"
        Me.GrossPayLabel.Size = New System.Drawing.Size(73, 16)
        Me.GrossPayLabel.TabIndex = 0
        Me.GrossPayLabel.Text = "Gross Pay:"
        '
        'ComputeButton
        '
        Me.ComputeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComputeButton.Location = New System.Drawing.Point(307, 430)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(104, 41)
        Me.ComputeButton.TabIndex = 5
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExitButton.Location = New System.Drawing.Point(561, 432)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(93, 41)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ResetButton.Location = New System.Drawing.Point(443, 432)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(94, 39)
        Me.ResetButton.TabIndex = 7
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 31)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.FontToolStripMenuItem1, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(52, 27)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(187, 28)
        Me.FontToolStripMenuItem1.Text = "&Font"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(62, 27)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(144, 28)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputeToolStripMenuItem, Me.ResetFormToolStripMenuItem, Me.TotalSalaryInformationToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(83, 27)
        Me.ActionsToolStripMenuItem.Text = "&Actions"
        '
        'ComputeToolStripMenuItem
        '
        Me.ComputeToolStripMenuItem.Name = "ComputeToolStripMenuItem"
        Me.ComputeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ComputeToolStripMenuItem.Size = New System.Drawing.Size(351, 28)
        Me.ComputeToolStripMenuItem.Text = "&Compute"
        '
        'ResetFormToolStripMenuItem
        '
        Me.ResetFormToolStripMenuItem.Name = "ResetFormToolStripMenuItem"
        Me.ResetFormToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetFormToolStripMenuItem.Size = New System.Drawing.Size(351, 28)
        Me.ResetFormToolStripMenuItem.Text = "&Reset Form"
        '
        'TotalSalaryInformationToolStripMenuItem
        '
        Me.TotalSalaryInformationToolStripMenuItem.Name = "TotalSalaryInformationToolStripMenuItem"
        Me.TotalSalaryInformationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TotalSalaryInformationToolStripMenuItem.Size = New System.Drawing.Size(351, 28)
        Me.TotalSalaryInformationToolStripMenuItem.Text = "&Total Salary Information"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ContextMenuStrip1.DropShadowEnabled = False
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputeToolStripMenuItem1, Me.ResetFormToolStripMenuItem1, Me.ToolStripSeparator2, Me.ColorToolStripMenuItem1, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 112)
        Me.ContextMenuStrip1.Text = "ContextMenuStrip1"
        '
        'ComputeToolStripMenuItem1
        '
        Me.ComputeToolStripMenuItem1.Name = "ComputeToolStripMenuItem1"
        Me.ComputeToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.ComputeToolStripMenuItem1.Text = "&Compute"
        '
        'ResetFormToolStripMenuItem1
        '
        Me.ResetFormToolStripMenuItem1.Name = "ResetFormToolStripMenuItem1"
        Me.ResetFormToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.ResetFormToolStripMenuItem1.Text = "&Reset Form"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ColorToolStripMenuItem1
        '
        Me.ColorToolStripMenuItem1.Name = "ColorToolStripMenuItem1"
        Me.ColorToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.ColorToolStripMenuItem1.Text = "&Color"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(713, 494)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BenefitsGroupBox)
        Me.Controls.Add(Me.EmployeeInformationGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Payroll"
        Me.Text = "a"
        Me.EmployeeInformationGroupBox.ResumeLayout(False)
        Me.EmployeeInformationGroupBox.PerformLayout()
        Me.BenefitsGroupBox.ResumeLayout(False)
        Me.BenefitsGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeIDLabel As Label
    Friend WithEvents DepartmentLabel As Label
    Friend WithEvents EmployeeInformationGroupBox As GroupBox
    Friend WithEvents PayRateLabel As Label
    Friend WithEvents HoursWorkedLabel As Label
    Friend WithEvents NameTextBox As Label
    Friend WithEvents NameTextBox1 As TextBox
    Friend WithEvents EmployeeIDMaskedTextBox As MaskedTextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents PayRateTextBox As TextBox
    Friend WithEvents HoursTextBox As TextBox
    Friend WithEvents BenefitsGroupBox As GroupBox
    Friend WithEvents NoneRadioButton As RadioButton
    Friend WithEvents RetirementStandardRadioButton As RadioButton
    Friend WithEvents Retirement401ARadioButton As RadioButton
    Friend WithEvents DentalCheckBox As CheckBox
    Friend WithEvents LifeCheckBox As CheckBox
    Friend WithEvents MedicalCheckBox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FederalTaxLabel As Label
    Friend WithEvents BenefitsLabel As Label
    Friend WithEvents NetPayLabel As Label
    Friend WithEvents GrossPayLabel As Label
    Friend WithEvents NetPayTextBox As TextBox
    Friend WithEvents BenefitsTextBox As TextBox
    Friend WithEvents FederalTaxTextBox As TextBox
    Friend WithEvents GrossPayTextBox As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComputeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalSalaryInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ComputeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ResetFormToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ColorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
