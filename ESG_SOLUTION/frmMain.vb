Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load forms into tab pages
        Dim frmElec As New frmElectricity()
        frmElec.TopLevel = False
        frmElec.FormBorderStyle = FormBorderStyle.None
        frmElec.Dock = DockStyle.Fill
        TabPageElectricity.Controls.Add(frmElec)
        frmElec.Show()

        Dim frmOwnElec As New frmOwnElectricity()
        frmOwnElec.TopLevel = False
        frmOwnElec.FormBorderStyle = FormBorderStyle.None
        frmOwnElec.Dock = DockStyle.Fill
        TabPageOwnElectricity.Controls.Add(frmOwnElec)
        frmOwnElec.Show()

        Dim frmGas As New frmGas()
        frmGas.TopLevel = False
        frmGas.FormBorderStyle = FormBorderStyle.None
        frmGas.Dock = DockStyle.Fill
        TabPageGas.Controls.Add(frmGas)
        frmGas.Show()

        Dim frmWater As New frmWater()
        frmWater.TopLevel = False
        frmWater.FormBorderStyle = FormBorderStyle.None
        frmWater.Dock = DockStyle.Fill
        TabPageWater.Controls.Add(frmWater)
        frmWater.Show()

        Dim frmPlastic As New frmPlastic()
        frmPlastic.TopLevel = False
        frmPlastic.FormBorderStyle = FormBorderStyle.None
        frmPlastic.Dock = DockStyle.Fill
        TabPagePlastic.Controls.Add(frmPlastic)
        frmPlastic.Show()

        Dim frmPaper As New frmPaper()
        frmPaper.TopLevel = False
        frmPaper.FormBorderStyle = FormBorderStyle.None
        frmPaper.Dock = DockStyle.Fill
        TabPagePaper.Controls.Add(frmPaper)
        frmPaper.Show()

        Dim frmProduct As New frmProductManagement()
        frmProduct.TopLevel = False
        frmProduct.FormBorderStyle = FormBorderStyle.None
        frmProduct.Dock = DockStyle.Fill
        TabPageProduct.Controls.Add(frmProduct)
        frmProduct.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub TabPageOwnElectricity_Click(sender As Object, e As EventArgs) Handles TabPageOwnElectricity.Click

    End Sub
End Class