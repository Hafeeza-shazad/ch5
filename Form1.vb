Public Class Payroll
    'Module level variable/constant declarations

    'Declare retirement benefit constants 
    Const RETIREMENT_STANDARD_DECIMAL As Decimal = 0.05D
    Const RETIREMENT_401A_DECIMAL As Decimal = 0.08D
    Private RetirementRateDecimal As Decimal
    Private Sub ComputeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeButton.Click, ComputeToolStripMenuItem.Click, ComputeToolStripMenuItem1.Click
        Try
            'Declare variables and constants
            Dim HoursDecimal, PayRateDecimal, GrossPayDecimal, FederalTaxDecimal, BenefitsCostDecimal, NetPayDecimal As Decimal

            'Declare constant used in this sub procedure
            'Tax rate constants
            Const TAX_RATE_08_DECIMAL As Decimal = 0.08D
            Const TAX_RATE_18_DECIMAL As Decimal = 0.18D
            Const TAX_RATE_28_DECIMAL As Decimal = 0.28D
            Const TAX_LEVEL_08_DECIMAL As Decimal = 985D
            Const TAX_LEVEL_18_DECIMAL As Decimal = 2450D
            'Benefit constants
            Const MEDICAL_RATE_DECIMAL As Decimal = 35.75D
            Const LIFE_RATE_DECIMAL As Decimal = 18.35D
            Const DENTAL_RATE_DECIMAL As Decimal = 4D
            'Enforce data validation rules
            If NameTextBox.Text.Trim = String.Empty Then
                'Required employee name is missing
                MessageBox.Show("Name is required", "Name Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NameTextBox.Focus()
                NameTextBox1.SelectAll()
            ElseIf EmployeeIDMaskedTextBox.Text.Trim.Length <> 11 OrElse EmployeeIDMaskedTextBox.Text.IndexOf(" ", 0, EmployeeIDMaskedTextBox.Text.Length) <> -1 Then
                'Required employee ID is not long enough or is not complete
                MessageBox.Show("Employee ID is not complete", "Employee ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmployeeIDMaskedTextBox.Focus()
                EmployeeIDMaskedTextBox.SelectAll()
            ElseIf DepartmentTextBox.Text.Trim = String.Empty Then
                'Required department is missing
                MessageBox.Show("Department is required", "Department Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DepartmentTextBox.Focus()
                DepartmentTextBox.SelectAll()
            ElseIf IsNumeric(HoursTextBox.Text) = False OrElse (Decimal.Parse(HoursTextBox.Text, Globalization.NumberStyles.Number) <= 0D Or Decimal.Parse(HoursTextBox.Text, Globalization.NumberStyles.Number) > 60D) Then
                'Hours must be numeric and within allowable range
                MessageBox.Show("Hours worked must be a number between 0 and 60", "Hours Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                HoursTextBox.Focus()
                HoursTextBox.SelectAll()
            ElseIf IsNumeric(PayRateTextBox.Text) = False OrElse Decimal.Parse(PayRateTextBox.Text, Globalization.NumberStyles.Currency) <= 0D Then
                'Pay rate must be numeric and greater than zero
                MessageBox.Show("Pay rate worked must be a number and greater than zero.", "Pay Rate Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PayRateTextBox.Focus()
                PayRateTextBox.SelectAll()
            Else
                'Data rules are all valid -- Use IPO model to process data
                'Parse textbox values to memory variables
                HoursDecimal = Decimal.Parse(HoursTextBox.Text, Globalization.NumberStyles.Number)
                PayRateDecimal = Decimal.Parse(PayRateTextBox.Text, Globalization.NumberStyles.Currency)

                'Compute gross pay
                If HoursDecimal <= 40D Then  'pay only regular time
                    GrossPayDecimal = Decimal.Round(HoursDecimal * PayRateDecimal, 2)
                Else  'pay regular + overtime
                    GrossPayDecimal = Decimal.Round((40D * PayRateDecimal) _
                        + ((HoursDecimal - 40D) * PayRateDecimal * 1.5D), 2)
                End If

                'Compute federal tax
                Select Case GrossPayDecimal
                    Case Is <= TAX_LEVEL_08_DECIMAL  '8% tax bracket
                        FederalTaxDecimal = Decimal.Round(TAX_RATE_08_DECIMAL * GrossPayDecimal, 2)
                    Case Is <= TAX_LEVEL_18_DECIMAL  '18% tax bracket
                        FederalTaxDecimal = Decimal.Round(TAX_RATE_18_DECIMAL * GrossPayDecimal, 2)
                    Case Else  '28% tax bracket
                        FederalTaxDecimal = Decimal.Round(TAX_RATE_28_DECIMAL * GrossPayDecimal, 2)
                End Select

                'Compute insurance benefits deduction
                If MedicalCheckBox.Checked Then
                    BenefitsCostDecimal += MEDICAL_RATE_DECIMAL  'selected medical insurance
                End If
                If LifeCheckBox.Checked Then
                    BenefitsCostDecimal += LIFE_RATE_DECIMAL 'selected life insurance
                End If
                If DentalCheckBox.Checked Then
                    BenefitsCostDecimal += DENTAL_RATE_DECIMAL  'selected dental insurance
                End If

                ''Remark out this part to test use of the CheckedChanged event to
                ''set the retirement rate
                ''Compute retirement benefits deduction
                'If Retirement401ARadioButton.Checked Then
                '    BenefitsCostDecimal += Decimal.Round(RETIREMENT_401A_DECIMAL * GrossPayDecimal, 2)
                'ElseIf RetirementStandardRadioButton.Checked Then
                '    BenefitsCostDecimal += Decimal.Round(RETIREMENT_STANDARD_DECIMAL * GrossPayDecimal, 2)
                'Else
                '    'No charge for not taking retirement benefit
                'End If

                'Use the retirement rate set in the CheckedChanged event
                'for the retirement radio button controls
                BenefitsCostDecimal += Decimal.Round(GrossPayDecimal * RetirementRateDecimal, 2)

                'Compute the net pay – no need to round because 
                'all values are already rounded
                NetPayDecimal = GrossPayDecimal - FederalTaxDecimal - BenefitsCostDecimal

                'Display output – this shows all four outputed values
                GrossPayTextBox.Text = GrossPayDecimal.ToString("C")
                FederalTaxTextBox.Text = FederalTaxDecimal.ToString("N")
                BenefitsTextBox.Text = BenefitsCostDecimal.ToString("N")
                NetPayTextBox.Text = NetPayDecimal.ToString("C")
            End If  'matches If statement for validating data
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Compute Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Close the form if the system user responds Yes
        Dim MessageString As String = "Do you want to close the form?"
        Dim ButtonDialogResult As DialogResult = MessageBox.Show(MessageString, "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ButtonDialogResult = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click, ResetFormToolStripMenuItem.Click, ResetFormToolStripMenuItem1.Click
        'Clear all textbox controls
        NameTextBox1.Clear()
        EmployeeIDMaskedTextBox.Clear()
        DepartmentTextBox.Clear()
        HoursTextBox.Clear()
        PayRateTextBox.Clear()
        GrossPayTextBox.Clear()
        FederalTaxTextBox.Clear()
        BenefitsTextBox.Clear()
        NetPayTextBox.Clear()

        'Reset retirement benefits status to none
        NoneRadioButton.Checked = True

        'Uncheck benefits checkboxes
        MedicalCheckBox.Checked = False
        LifeCheckBox.Checked = False
        DentalCheckBox.Checked = False

        'Set focus to name textbox
        NameTextBox.Focus()
    End Sub

    Private Sub NoneRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneRadioButton.CheckedChanged, Retirement401ARadioButton.CheckedChanged, RetirementStandardRadioButton.CheckedChanged
        'Create a radio button in memory and store the values of sender to it
        Dim CheckedRadioButton As RadioButton = CType(sender, RadioButton)

        'Use Select Case to evaluate the name of the radio button 
        'to decide which controls to enable/disable
        Select Case CheckedRadioButton.Name
            Case "NoneRadioButton"  'Cost is zero
                RetirementRateDecimal = 0D
            Case "RetirementStandardRadioButton"  'Standard rate
                RetirementRateDecimal = RETIREMENT_STANDARD_DECIMAL
            Case "Retirement401ARadioButton"  '401A rate
                RetirementRateDecimal = RETIREMENT_401A_DECIMAL
        End Select
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Display about message box
        Dim MessageString As String = "Programmed by Dr. Douglas Bock" & ControlChars.NewLine & "Today's Date/Time: " & Date.Now.ToString
        Dim TitleString As String = "About the Payroll Application"
        'Display output message
        MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        'Call Exit Button Click event
        ExitButton.PerformClick()

    End Sub



    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        'Change the form's back color property.
        'Stores current form color to the control's Color property.
        'Display the Color Component, and save the new color
        'to the form's BackColor property.
        ColorDialog1.Color = Me.BackColor
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
        MenuStrip1.BackColor = ColorDialog1.Color


    End Sub


    Private Sub FontToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem1.Click
        'Change the font used for the entire form.
        'Store current font to the control's Font property.
        'Display the Font Component, and save the new font
        'to the form's controls.
        FontDialog1.Font = Me.Font
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font

    End Sub
    Private Sub ColorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem1.Click
        'Change color of object  
        'Send color to dialog box
        ColorDialog1.Color = ContextMenuStrip1.SourceControl.ForeColor
        ColorDialog1.ShowDialog()        'Display new color
        ContextMenuStrip1.SourceControl.ForeColor = ColorDialog1.Color
    End Sub


End Class
