﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email_Landing
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
        PictureBox11 = New PictureBox()
        Button12 = New Button()
        Button11 = New Button()
        Button10 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = image_4__1_
        PictureBox11.Location = New Point(36, 62)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(62, 53)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 19
        PictureBox11.TabStop = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.Black
        Button12.Cursor = Cursors.Hand
        Button12.FlatAppearance.BorderSize = 0
        Button12.FlatStyle = FlatStyle.Flat
        Button12.Font = New Font("Bodoni MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = Color.White
        Button12.Location = New Point(831, 62)
        Button12.Margin = New Padding(0)
        Button12.Name = "Button12"
        Button12.Size = New Size(169, 53)
        Button12.TabIndex = 18
        Button12.Text = "SENT MAILS"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Black
        Button11.Cursor = Cursors.Hand
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Font = New Font("Bodoni MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = Color.White
        Button11.Location = New Point(505, 62)
        Button11.Margin = New Padding(0)
        Button11.Name = "Button11"
        Button11.Size = New Size(145, 53)
        Button11.TabIndex = 17
        Button11.Text = "INBOX"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Black
        Button10.Cursor = Cursors.Hand
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Bodoni MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.White
        Button10.Location = New Point(136, 62)
        Button10.Margin = New Padding(0)
        Button10.Name = "Button10"
        Button10.Size = New Size(145, 53)
        Button10.TabIndex = 16
        Button10.Text = "COMPOSE"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(144, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 34)
        Label3.TabIndex = 15
        Label3.Text = "Inbox"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(104, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 34)
        Label2.TabIndex = 14
        Label2.Text = ">"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bodoni MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 34)
        Label1.TabIndex = 13
        Label1.Text = "Email"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Location = New Point(0, 121)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 639)
        Panel1.TabIndex = 20
        ' 
        ' Email_Landing
        ' 
        AutoScaleDimensions = New SizeF(12F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1107, 760)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(PictureBox11)
        Controls.Add(Button12)
        Controls.Add(Button11)
        Controls.Add(Button10)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Email_Landing"
        Text = "Email_Landing"
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
