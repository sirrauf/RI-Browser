﻿Public Class AboutApp
    Private Sub imgDonate_Click(sender As Object, e As EventArgs) Handles imgDonate.Click
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2M3R3VLR7BZ36")
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub About_Apps()
        Dim Url1, Url2
        Url1 = "https://www.instagram.com/anandarauf08"
        Url2 = "https://goo.gl/maps/KLbW5tU86kqERWMv5"
        lblUrl1.Text = Url1
        lblUrl2.Text = Url2
        lblCopyright.Text = "18 July 2019"
        lblVersion.Text = "Version" & Me.GetType.Assembly.GetName.Version.ToString

    End Sub

    Private Sub AboutApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        About_Apps()
    End Sub

    Private Sub lblUrl1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblUrl1.LinkClicked
        System.Diagnostics.Process.Start("https://www.instagram.com/anandarauf08")
    End Sub

    Private Sub lblUrl2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblUrl2.LinkClicked
        System.Diagnostics.Process.Start("https://goo.gl/maps/KLbW5tU86kqERWMv5")
    End Sub
End Class