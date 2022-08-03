Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblVtype.Text = frmVehicleCrge.VehicleType
        lblVnum.Text = frmVehicleCrge.VehicleNo
        lblFtype.Text = frmVehicleCrge.FuelType
        lblStatDt.Text = frmVehicleCrge.StartingDate
        lblNoOfDys.Text = frmVehicleCrge.NumberofDays + " Day(s)"
        lblMrStart.Text = frmVehicleCrge.MeterStart + " km"
        lblMrEnd.Text = frmVehicleCrge.MeterEnd + " km"
        lblTotal.Text = "Rs. " + frmVehicleCrge.TotalCost

    End Sub


End Class