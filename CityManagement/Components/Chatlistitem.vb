﻿Imports System.Drawing.Drawing2D

Public Class Chatlistitem
    Public Worker_id As Integer
    'Constructor
    Public Sub New(Optional ByVal ID As Integer = 1, Optional ByVal name As String = "Default Name", Optional ByVal lastmessage As String = "Sure What time works for you?", Optional ByVal unreadcount As Integer = 0)
        ' This call is required by the designer.
        InitializeComponent()
        ' Set the values to the controls
        Worker_id = ID
        Label1.Text = name

        ' Check if lastmessage is longer than 30 characters
        If lastmessage.Length > 30 Then
            Label2.Text = lastmessage.Substring(0, 30) & "..."
        Else
            Label2.Text = lastmessage
        End If

        ' Check if unreadcount is 0
        If unreadcount = 0 Then
            Label3.Hide()
        Else
            Label3.Text = unreadcount.ToString()
            Label3.Show()
        End If

        ' Make the PictureBox round
        MakePictureBoxRound(PictureBox1)
    End Sub

    Private Sub MakePictureBoxRound(pictureBox As PictureBox)
        ' Create a GraphicsPath to define a circle
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the PictureBox's region to the circle defined by the GraphicsPath
        pictureBox.Region = New Region(path)
    End Sub

    Private Sub CurvedLabel1_Click(sender As Object, e As EventArgs) Handles CurvedLabel1.Click, Label1.Click, Label2.Click, PictureBox1.Click, Label3.Click
        Globals.ChatIdAsCitizen = Worker_id
        Try
            ' Create a MySQL connection
            Using connection As New MySqlConnection(Globals.connectionstring)
                ' Open the connection
                connection.Open()

                ' Define the SQL query to update the Seen status
                Dim query As String = "UPDATE Chats " &
                              "SET Seen = 1 " &
                              "WHERE workerID = @ChatIdAsCitizen " &
                              "AND SentBy = 1 " &
                              "AND Seen = 0;"

                ' Create MySqlCommand
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@ChatIdAsCitizen", Globals.ChatIdAsCitizen)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error occurred while updating Seen status: " & ex.Message)
        Finally
            Globals.chatsForm.Label2.Text = Label1.Text
            Globals.Chatspage = Globals.chatsForm
            Globals.UrbanClapNavForm.ShowFormInPanel1(Globals.Chatspage)
        End Try
    End Sub

End Class