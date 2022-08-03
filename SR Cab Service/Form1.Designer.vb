<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVehicleCrge
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
        Me.txtVno = New System.Windows.Forms.TextBox()
        Me.lblVehicleNo = New System.Windows.Forms.Label()
        Me.lblTpc = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblNoOfDays = New System.Windows.Forms.Label()
        Me.txtNoOfDays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVehicleType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMetrReading = New System.Windows.Forms.Label()
        Me.lblStrt = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.txtMRStart = New System.Windows.Forms.TextBox()
        Me.txtMREnd = New System.Windows.Forms.TextBox()
        Me.cmdCalCost = New System.Windows.Forms.Button()
        Me.cmdTotCstPrint = New System.Windows.Forms.Button()
        Me.txtTotCost = New System.Windows.Forms.TextBox()
        Me.lblTotCst = New System.Windows.Forms.Label()
        Me.grpFuelType = New System.Windows.Forms.GroupBox()
        Me.rdioDiesel = New System.Windows.Forms.RadioButton()
        Me.rdioPetrol = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbVtype = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.grpFuelType.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVno
        '
        Me.txtVno.BackColor = System.Drawing.Color.DarkGray
        Me.txtVno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVno.ForeColor = System.Drawing.Color.Black
        Me.txtVno.Location = New System.Drawing.Point(312, 114)
        Me.txtVno.Name = "txtVno"
        Me.txtVno.Size = New System.Drawing.Size(181, 20)
        Me.txtVno.TabIndex = 1
        '
        'lblVehicleNo
        '
        Me.lblVehicleNo.AutoSize = True
        Me.lblVehicleNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleNo.ForeColor = System.Drawing.Color.White
        Me.lblVehicleNo.Location = New System.Drawing.Point(384, 88)
        Me.lblVehicleNo.Name = "lblVehicleNo"
        Me.lblVehicleNo.Size = New System.Drawing.Size(109, 15)
        Me.lblVehicleNo.TabIndex = 0
        Me.lblVehicleNo.Text = "Vehicle Number"
        '
        'lblTpc
        '
        Me.lblTpc.AutoSize = True
        Me.lblTpc.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTpc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTpc.Location = New System.Drawing.Point(24, 19)
        Me.lblTpc.Name = "lblTpc"
        Me.lblTpc.Size = New System.Drawing.Size(135, 49)
        Me.lblTpc.TabIndex = 0
        Me.lblTpc.Text = "SR Cab"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(462, 342)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "S e r v i c e s"
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.SystemColors.HighlightText
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 342
        Me.LineShape1.Y1 = 237
        Me.LineShape1.Y2 = 237
        '
        'lblNoOfDays
        '
        Me.lblNoOfDays.AutoSize = True
        Me.lblNoOfDays.ForeColor = System.Drawing.Color.White
        Me.lblNoOfDays.Location = New System.Drawing.Point(24, 203)
        Me.lblNoOfDays.Name = "lblNoOfDays"
        Me.lblNoOfDays.Size = New System.Drawing.Size(83, 13)
        Me.lblNoOfDays.TabIndex = 2
        Me.lblNoOfDays.Text = "Number of Days"
        '
        'txtNoOfDays
        '
        Me.txtNoOfDays.BackColor = System.Drawing.Color.DarkGray
        Me.txtNoOfDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoOfDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfDays.ForeColor = System.Drawing.Color.Black
        Me.txtNoOfDays.Location = New System.Drawing.Point(129, 199)
        Me.txtNoOfDays.Name = "txtNoOfDays"
        Me.txtNoOfDays.Size = New System.Drawing.Size(106, 20)
        Me.txtNoOfDays.TabIndex = 9
        Me.txtNoOfDays.Text = "1"
        Me.txtNoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Starting Date"
        '
        'txtVehicleType
        '
        Me.txtVehicleType.BackColor = System.Drawing.Color.DarkGray
        Me.txtVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVehicleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleType.ForeColor = System.Drawing.Color.Black
        Me.txtVehicleType.Location = New System.Drawing.Point(24, 87)
        Me.txtVehicleType.Name = "txtVehicleType"
        Me.txtVehicleType.Size = New System.Drawing.Size(211, 20)
        Me.txtVehicleType.TabIndex = 2
        Me.txtVehicleType.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vehicle Type"
        '
        'lblMetrReading
        '
        Me.lblMetrReading.AutoSize = True
        Me.lblMetrReading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetrReading.ForeColor = System.Drawing.Color.White
        Me.lblMetrReading.Location = New System.Drawing.Point(289, 134)
        Me.lblMetrReading.Name = "lblMetrReading"
        Me.lblMetrReading.Size = New System.Drawing.Size(104, 18)
        Me.lblMetrReading.TabIndex = 2
        Me.lblMetrReading.Text = "Meter Reading"
        '
        'lblStrt
        '
        Me.lblStrt.AutoSize = True
        Me.lblStrt.ForeColor = System.Drawing.Color.White
        Me.lblStrt.Location = New System.Drawing.Point(289, 166)
        Me.lblStrt.Name = "lblStrt"
        Me.lblStrt.Size = New System.Drawing.Size(29, 13)
        Me.lblStrt.TabIndex = 2
        Me.lblStrt.Text = "Start"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.ForeColor = System.Drawing.Color.White
        Me.lblEnd.Location = New System.Drawing.Point(289, 203)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(26, 13)
        Me.lblEnd.TabIndex = 2
        Me.lblEnd.Text = "End"
        '
        'txtMRStart
        '
        Me.txtMRStart.BackColor = System.Drawing.Color.DarkGray
        Me.txtMRStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMRStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRStart.ForeColor = System.Drawing.Color.Black
        Me.txtMRStart.Location = New System.Drawing.Point(340, 162)
        Me.txtMRStart.Name = "txtMRStart"
        Me.txtMRStart.Size = New System.Drawing.Size(100, 20)
        Me.txtMRStart.TabIndex = 10
        '
        'txtMREnd
        '
        Me.txtMREnd.BackColor = System.Drawing.Color.DarkGray
        Me.txtMREnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMREnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMREnd.ForeColor = System.Drawing.Color.Black
        Me.txtMREnd.Location = New System.Drawing.Point(340, 199)
        Me.txtMREnd.Name = "txtMREnd"
        Me.txtMREnd.Size = New System.Drawing.Size(100, 20)
        Me.txtMREnd.TabIndex = 11
        '
        'cmdCalCost
        '
        Me.cmdCalCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.cmdCalCost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCalCost.FlatAppearance.BorderSize = 0
        Me.cmdCalCost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.cmdCalCost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.cmdCalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCalCost.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalCost.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdCalCost.Location = New System.Drawing.Point(293, 250)
        Me.cmdCalCost.Name = "cmdCalCost"
        Me.cmdCalCost.Size = New System.Drawing.Size(147, 66)
        Me.cmdCalCost.TabIndex = 12
        Me.cmdCalCost.Text = "Calculate Cost"
        Me.cmdCalCost.UseVisualStyleBackColor = False
        '
        'cmdTotCstPrint
        '
        Me.cmdTotCstPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.cmdTotCstPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTotCstPrint.FlatAppearance.BorderSize = 0
        Me.cmdTotCstPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.cmdTotCstPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.cmdTotCstPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTotCstPrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTotCstPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdTotCstPrint.Location = New System.Drawing.Point(24, 294)
        Me.cmdTotCstPrint.Name = "cmdTotCstPrint"
        Me.cmdTotCstPrint.Size = New System.Drawing.Size(211, 22)
        Me.cmdTotCstPrint.TabIndex = 13
        Me.cmdTotCstPrint.Text = "Print"
        Me.cmdTotCstPrint.UseVisualStyleBackColor = False
        '
        'txtTotCost
        '
        Me.txtTotCost.BackColor = System.Drawing.Color.DarkGray
        Me.txtTotCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotCost.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTotCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotCost.ForeColor = System.Drawing.Color.Black
        Me.txtTotCost.Location = New System.Drawing.Point(129, 250)
        Me.txtTotCost.Name = "txtTotCost"
        Me.txtTotCost.ReadOnly = True
        Me.txtTotCost.Size = New System.Drawing.Size(106, 20)
        Me.txtTotCost.TabIndex = 0
        Me.txtTotCost.TabStop = False
        '
        'lblTotCst
        '
        Me.lblTotCst.AutoSize = True
        Me.lblTotCst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCst.ForeColor = System.Drawing.Color.White
        Me.lblTotCst.Location = New System.Drawing.Point(24, 254)
        Me.lblTotCst.Name = "lblTotCst"
        Me.lblTotCst.Size = New System.Drawing.Size(84, 13)
        Me.lblTotCst.TabIndex = 2
        Me.lblTotCst.Text = "TOTAL COST"
        '
        'grpFuelType
        '
        Me.grpFuelType.Controls.Add(Me.rdioPetrol)
        Me.grpFuelType.Controls.Add(Me.rdioDiesel)
        Me.grpFuelType.ForeColor = System.Drawing.Color.White
        Me.grpFuelType.Location = New System.Drawing.Point(287, 22)
        Me.grpFuelType.Name = "grpFuelType"
        Me.grpFuelType.Size = New System.Drawing.Size(153, 85)
        Me.grpFuelType.TabIndex = 2
        Me.grpFuelType.TabStop = False
        Me.grpFuelType.Text = "Fuel Type"
        '
        'rdioDiesel
        '
        Me.rdioDiesel.AutoSize = True
        Me.rdioDiesel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioDiesel.ForeColor = System.Drawing.Color.White
        Me.rdioDiesel.Location = New System.Drawing.Point(28, 53)
        Me.rdioDiesel.Name = "rdioDiesel"
        Me.rdioDiesel.Size = New System.Drawing.Size(54, 17)
        Me.rdioDiesel.TabIndex = 5
        Me.rdioDiesel.TabStop = True
        Me.rdioDiesel.Text = "Diesel"
        Me.rdioDiesel.UseVisualStyleBackColor = True
        '
        'rdioPetrol
        '
        Me.rdioPetrol.AutoSize = True
        Me.rdioPetrol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdioPetrol.ForeColor = System.Drawing.Color.White
        Me.rdioPetrol.Location = New System.Drawing.Point(28, 23)
        Me.rdioPetrol.Name = "rdioPetrol"
        Me.rdioPetrol.Size = New System.Drawing.Size(52, 17)
        Me.rdioPetrol.TabIndex = 4
        Me.rdioPetrol.TabStop = True
        Me.rdioPetrol.Text = "Petrol"
        Me.rdioPetrol.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 162)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'cmbVtype
        '
        Me.cmbVtype.BackColor = System.Drawing.Color.DarkGray
        Me.cmbVtype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbVtype.FormattingEnabled = True
        Me.cmbVtype.Items.AddRange(New Object() {"Car", "Van", "Bus", "Lorry", "Motor Bike", "Canter"})
        Me.cmbVtype.Location = New System.Drawing.Point(24, 47)
        Me.cmbVtype.Name = "cmbVtype"
        Me.cmbVtype.Size = New System.Drawing.Size(211, 21)
        Me.cmbVtype.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClr)
        Me.GroupBox1.Controls.Add(Me.cmbVtype)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.grpFuelType)
        Me.GroupBox1.Controls.Add(Me.lblTotCst)
        Me.GroupBox1.Controls.Add(Me.txtTotCost)
        Me.GroupBox1.Controls.Add(Me.cmdTotCstPrint)
        Me.GroupBox1.Controls.Add(Me.cmdCalCost)
        Me.GroupBox1.Controls.Add(Me.txtMREnd)
        Me.GroupBox1.Controls.Add(Me.txtMRStart)
        Me.GroupBox1.Controls.Add(Me.lblEnd)
        Me.GroupBox1.Controls.Add(Me.lblStrt)
        Me.GroupBox1.Controls.Add(Me.lblMetrReading)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtVehicleType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNoOfDays)
        Me.GroupBox1.Controls.Add(Me.lblNoOfDays)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(25, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 361)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnClr
        '
        Me.btnClr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnClr.FlatAppearance.BorderSize = 0
        Me.btnClr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnClr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.ForeColor = System.Drawing.Color.White
        Me.btnClr.Location = New System.Drawing.Point(391, 318)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(46, 23)
        Me.btnClr.TabIndex = 17
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'frmVehicleCrge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 536)
        Me.Controls.Add(Me.txtVno)
        Me.Controls.Add(Me.lblVehicleNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTpc)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmVehicleCrge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculate Vehicle Charge"
        Me.grpFuelType.ResumeLayout(False)
        Me.grpFuelType.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVno As System.Windows.Forms.TextBox
    Friend WithEvents lblVehicleNo As System.Windows.Forms.Label
    Friend WithEvents lblTpc As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents lblNoOfDays As Label
    Friend WithEvents txtNoOfDays As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVehicleType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMetrReading As Label
    Friend WithEvents lblStrt As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents txtMRStart As TextBox
    Friend WithEvents txtMREnd As TextBox
    Friend WithEvents cmdCalCost As Button
    Friend WithEvents cmdTotCstPrint As Button
    Friend WithEvents txtTotCost As TextBox
    Friend WithEvents lblTotCst As Label
    Friend WithEvents grpFuelType As GroupBox
    Friend WithEvents rdioPetrol As RadioButton
    Friend WithEvents rdioDiesel As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbVtype As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClr As Button
End Class
