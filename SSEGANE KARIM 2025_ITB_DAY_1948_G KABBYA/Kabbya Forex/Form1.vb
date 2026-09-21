Public Class Form1
    Private Sub btnToYuan_Click(sender As Object, e As EventArgs) Handles btnToYuan.Click


        Dim ugx As Double
        Dim yuan As Double

        ugx = Val(txtUGXYuan.Text)

        yuan = ugx / 540

        txtYuan.Text = yuan.ToString()


    End Sub

    Private Sub btnYuanToUGX_Click(sender As Object, e As EventArgs) Handles btnYuanToUGX.Click


        Dim yuan As Double
        Dim ugx As Double

        yuan = Val(txtYuanUGX.Text)

        ugx = yuan * 540

        txtUGXFromYuan.Text = ugx.ToString()


    End Sub

    Private Sub btnToDirham_Click(sender As Object, e As EventArgs) Handles btnToDirham.Click


        Dim ugx As Double
        Dim dirham As Double

        ugx = Val(txtUGXDirham.Text)

        dirham = ugx / 110

        txtDirham.Text = dirham.ToString()


    End Sub

    Private Sub btnDirhamToUGX_Click(sender As Object, e As EventArgs) Handles btnDirhamToUGX.Click


        Dim dirham As Double
        Dim ugx As Double

        dirham = Val(txtDirhamUGX.Text)

        ugx = dirham * 110

        txtUGXFromDirham.Text = ugx.ToString()


    End Sub
End Class
