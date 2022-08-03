Public Class frmVehicleCrge  '****** Developing one ******

    Public Shared VehicleType As String = ""
    Public Shared VehicleNo As String = ""
    Public Shared FuelType As String = ""
    Public Shared StartingDate As String = ""
    Public Shared NumberofDays As String = ""
    Public Shared MeterStart As String = ""
    Public Shared MeterEnd As String = ""
    Public Shared TotalCost As String = ""

    Private Sub frmVehicleCrge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtVno.Focus()
    End Sub

    Private Sub cmbVtype_Click(sender As Object, e As EventArgs) Handles cmbVtype.Click
        txtVehicleType.Text = cmbVtype.Text

        If cmbVtype.Text = "Bus" Or cmbVtype.Text = "Lorry" Or cmbVtype.Text = "Canter" Then
            rdioPetrol.Enabled = False
            rdioPetrol.Checked = False
        Else
            rdioPetrol.Enabled = True

        End If
        If cmbVtype.Text = "Motor Bike" Then
            rdioDiesel.Enabled = False
            rdioDiesel.Checked = False
        Else
            rdioDiesel.Enabled = True
        End If

    End Sub

    Private Sub cmdCalCost_Click(sender As Object, e As EventArgs) Handles cmdCalCost.Click
        Dim MRdifer As Decimal
        Dim DCount As Integer
        DCount = Val(txtNoOfDays.Text)


        If rdioDiesel.Checked = True Or rdioPetrol.Checked = True Then 'oder eka hadanna msg box wala
            If txtMRStart.Text = "" And txtMREnd.Text = "" Then
                MsgBox("Please Enter Start and End Meter Reading")
            ElseIf txtVehicleType.Text = "" Then
                MsgBox("Please Select Vehicle Type")
            Else


                MRdifer = Val(txtMREnd.Text) - (txtMRStart.Text)

                If rdioPetrol.Checked = True And cmbVtype.Text = "Car" Or rdioPetrol.Checked = True And cmbVtype.Text = "Van" Then
                    txtTotCost.Text = MRdifer * 20 * DCount

                ElseIf rdioDiesel.Checked = True And cmbVtype.Text = "Car" Or rdioDiesel.Checked = True And cmbVtype.Text = "Van" Then
                    txtTotCost.Text = MRdifer * 15 * DCount

                ElseIf rdioDiesel.Checked = True And cmbVtype.Text = "Bus" Or rdioDiesel.Checked = True And cmbVtype.Text = "Lorry" Then
                    txtTotCost.Text = MRdifer * 45 * DCount

                ElseIf rdioDiesel.Checked = True And cmbVtype.Text = "Canter" Then
                    txtTotCost.Text = MRdifer * 45 * DCount

                ElseIf rdioPetrol.Checked = True And cmbVtype.Text = "Motor Bike" Then
                    txtTotCost.Text = MRdifer * 10 * DCount

                End If
            End If

        Else
            MsgBox("Please Enter Fuel Type")
        End If

    End Sub

    Private Sub txtMREnd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMREnd.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            cmdCalCost.PerformClick()
        End If
    End Sub

    Private Sub cmbVtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVtype.SelectedIndexChanged
        txtVehicleType.Text = cmbVtype.Text

        If cmbVtype.Text = "Bus" Or cmbVtype.Text = "Lorry" Or cmbVtype.Text = "Canter" Then
            rdioPetrol.Enabled = False
            rdioPetrol.Checked = False
        Else
            rdioPetrol.Enabled = True

        End If
        If cmbVtype.Text = "Motor Bike" Then
            rdioDiesel.Enabled = False
            rdioDiesel.Checked = False
        Else
            rdioDiesel.Enabled = True
        End If
    End Sub

    Private Sub cmdTotCstPrint_Click(sender As Object, e As EventArgs) Handles cmdTotCstPrint.Click
        If txtTotCost.Text <> "" Then
            VehicleType = txtVehicleType.Text
            VehicleNo = txtVno.Text
            If rdioPetrol.Checked Then
                FuelType = "Petrol"
            ElseIf rdioDiesel.Checked Then
                FuelType = "Petrol"
            End If
            StartingDate = DateTimePicker1.Text
            NumberofDays = txtNoOfDays.Text
            MeterStart = txtMRStart.Text
            MeterEnd = txtMREnd.Text
            TotalCost = txtTotCost.Text

            Dim frm2 As Form2 = New Form2()
            frm2.Show()
        End If

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtVehicleType.Text = ""
        cmbVtype.Text = ""
        txtVno.Text = ""
        rdioPetrol.Checked = False
        rdioDiesel.Checked = False
        DateTimePicker1.Text = ""
        txtNoOfDays.Text = ""
        txtMRStart.Text = ""
        txtMREnd.Text = ""
        txtTotCost.Text = ""
    End Sub

End Class '****** Developing one ******

