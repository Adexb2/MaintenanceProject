﻿Imports System.Data.OleDb
Public Class Application

    Dim StuFName As String
        Dim StuLName As String

        Dim ConnInfo As New DBConnectionInfo
        Dim ConnString As String = ConnInfo.GetConnString()
        Dim con As New OleDbConnection()
        Dim AppID = Integer.Parse(Main.getSelectedApplicant())
        Dim Username = Integer.Parse(Login.getUsername())


    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim commandGetFName As New OleDbCommand("SELECT First_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetLName As New OleDbCommand("SELECT Last_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        con.ConnectionString = ConnString
        con.Open()

        Try
            StuFName = commandGetFName.ExecuteScalar
            StuLName = commandGetLName.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
        lblStuName.Text = StuLName & ", " & StuFName
    End Sub
    Private Sub InsertNewRecord()


        If ComboBox_suggesteddecision.SelectedIndex > -1 Then
            con.ConnectionString = ConnString

            Dim sqlComm As New OleDbCommand

            sqlComm.Connection = con

            sqlComm.CommandText = "addApplicationComment"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("AppID", Integer.Parse(AppID))
            sqlComm.Parameters.AddWithValue("userID", Integer.Parse(Username))
            sqlComm.Parameters.AddWithValue("comment", tbComment.Text)
            sqlComm.Parameters.AddWithValue("recommmendations", ComboBox_suggesteddecision.Text)

            con.Open()

            sqlComm.ExecuteNonQuery()
            con.Close()
        Else
            MessageBox.Show("Recommendation required")
        End If


    End Sub

    Private Sub btnAddComment_Click(sender As Object, e As EventArgs) Handles btnAddComment.Click
        Try
            InsertNewRecord()
            MessageBox.Show("Data Successfully Added!")
            Me.Close()
        Catch
            MessageBox.Show("Data was not added.")
        End Try
    End Sub


End Class
