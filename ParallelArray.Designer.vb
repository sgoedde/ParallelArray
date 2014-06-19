<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParallelArray
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtBxName = New System.Windows.Forms.TextBox()
        Me.txtBxSalary = New System.Windows.Forms.TextBox()
        Me.txtBxOutput = New System.Windows.Forms.RichTextBox()
        Me.txtBxNewOutput = New System.Windows.Forms.RichTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.txtBxPercent = New System.Windows.Forms.TextBox()
        Me.btnNewReport = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusSpring = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblNumRecords = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtBxHighLow = New System.Windows.Forms.RichTextBox()
        Me.txtBxNewHighLow = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(11, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Na&me:"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(90, 35)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(44, 15)
        Me.lblSalary.TabIndex = 2
        Me.lblSalary.Text = "&Salary:"
        '
        'txtBxName
        '
        Me.txtBxName.Location = New System.Drawing.Point(61, 6)
        Me.txtBxName.Name = "txtBxName"
        Me.txtBxName.Size = New System.Drawing.Size(180, 20)
        Me.txtBxName.TabIndex = 1
        '
        'txtBxSalary
        '
        Me.txtBxSalary.Location = New System.Drawing.Point(140, 32)
        Me.txtBxSalary.Name = "txtBxSalary"
        Me.txtBxSalary.Size = New System.Drawing.Size(101, 20)
        Me.txtBxSalary.TabIndex = 3
        '
        'txtBxOutput
        '
        Me.txtBxOutput.Font = New System.Drawing.Font("Courier New", 7.92!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxOutput.Location = New System.Drawing.Point(12, 165)
        Me.txtBxOutput.Name = "txtBxOutput"
        Me.txtBxOutput.ReadOnly = True
        Me.txtBxOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtBxOutput.Size = New System.Drawing.Size(483, 137)
        Me.txtBxOutput.TabIndex = 12
        Me.txtBxOutput.Text = ""
        Me.txtBxOutput.WordWrap = False
        '
        'txtBxNewOutput
        '
        Me.txtBxNewOutput.Font = New System.Drawing.Font("Courier New", 7.92!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNewOutput.Location = New System.Drawing.Point(12, 376)
        Me.txtBxNewOutput.Name = "txtBxNewOutput"
        Me.txtBxNewOutput.ReadOnly = True
        Me.txtBxNewOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtBxNewOutput.Size = New System.Drawing.Size(483, 137)
        Me.txtBxNewOutput.TabIndex = 14
        Me.txtBxNewOutput.Text = ""
        Me.txtBxNewOutput.WordWrap = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(268, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(378, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Enabled = False
        Me.btnCreate.Location = New System.Drawing.Point(268, 32)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(104, 23)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "&Create Report"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(378, 32)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Enabled = False
        Me.lblPercent.Location = New System.Drawing.Point(5, 60)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(129, 15)
        Me.lblPercent.TabIndex = 4
        Me.lblPercent.Text = "Salary &Increase (in %):"
        '
        'txtBxPercent
        '
        Me.txtBxPercent.Enabled = False
        Me.txtBxPercent.Location = New System.Drawing.Point(140, 57)
        Me.txtBxPercent.Name = "txtBxPercent"
        Me.txtBxPercent.Size = New System.Drawing.Size(101, 20)
        Me.txtBxPercent.TabIndex = 5
        '
        'btnNewReport
        '
        Me.btnNewReport.Enabled = False
        Me.btnNewReport.Location = New System.Drawing.Point(305, 61)
        Me.btnNewReport.Name = "btnNewReport"
        Me.btnNewReport.Size = New System.Drawing.Size(135, 24)
        Me.btnNewReport.TabIndex = 10
        Me.btnNewReport.Text = "Create &New Report"
        Me.btnNewReport.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblStatusSpring, Me.lblNumRecords})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 517)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(509, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'lblStatusSpring
        '
        Me.lblStatusSpring.AutoSize = False
        Me.lblStatusSpring.Name = "lblStatusSpring"
        Me.lblStatusSpring.Size = New System.Drawing.Size(494, 17)
        Me.lblStatusSpring.Spring = True
        '
        'lblNumRecords
        '
        Me.lblNumRecords.Name = "lblNumRecords"
        Me.lblNumRecords.Size = New System.Drawing.Size(0, 17)
        '
        'txtBxHighLow
        '
        Me.txtBxHighLow.Font = New System.Drawing.Font("Courier New", 7.92!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxHighLow.Location = New System.Drawing.Point(12, 97)
        Me.txtBxHighLow.Name = "txtBxHighLow"
        Me.txtBxHighLow.ReadOnly = True
        Me.txtBxHighLow.Size = New System.Drawing.Size(256, 62)
        Me.txtBxHighLow.TabIndex = 11
        Me.txtBxHighLow.Text = ""
        Me.txtBxHighLow.WordWrap = False
        '
        'txtBxNewHighLow
        '
        Me.txtBxNewHighLow.Font = New System.Drawing.Font("Courier New", 7.92!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNewHighLow.Location = New System.Drawing.Point(12, 308)
        Me.txtBxNewHighLow.Name = "txtBxNewHighLow"
        Me.txtBxNewHighLow.ReadOnly = True
        Me.txtBxNewHighLow.Size = New System.Drawing.Size(256, 62)
        Me.txtBxNewHighLow.TabIndex = 13
        Me.txtBxNewHighLow.Text = ""
        Me.txtBxNewHighLow.WordWrap = False
        '
        'frmParallelArray
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(509, 539)
        Me.Controls.Add(Me.txtBxNewHighLow)
        Me.Controls.Add(Me.txtBxHighLow)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnNewReport)
        Me.Controls.Add(Me.txtBxPercent)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBxNewOutput)
        Me.Controls.Add(Me.txtBxOutput)
        Me.Controls.Add(Me.txtBxSalary)
        Me.Controls.Add(Me.txtBxName)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmParallelArray"
        Me.Text = "Parallel Array Sort"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents txtBxName As System.Windows.Forms.TextBox
    Friend WithEvents txtBxSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtBxOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents txtBxNewOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents txtBxPercent As System.Windows.Forms.TextBox
    Friend WithEvents btnNewReport As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblNumRecords As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusSpring As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtBxHighLow As System.Windows.Forms.RichTextBox
    Friend WithEvents txtBxNewHighLow As System.Windows.Forms.RichTextBox

End Class
