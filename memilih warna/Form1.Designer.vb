<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        lblwarnapilihan = New Label()
        lblketerangan = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(22, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(366, 284)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pilih warna"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Lime
        Label6.Location = New Point(231, 133)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 92)
        Label6.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Black
        Label5.Location = New Point(118, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 92)
        Label5.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Red
        Label4.Location = New Point(15, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 92)
        Label4.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Blue
        Label3.Location = New Point(231, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 91)
        Label3.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Yellow
        Label2.Location = New Point(118, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 91)
        Label2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Label1.Location = New Point(15, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 91)
        Label1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblwarnapilihan)
        GroupBox2.Location = New Point(418, 37)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(173, 272)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' lblwarnapilihan
        ' 
        lblwarnapilihan.Location = New Point(22, 32)
        lblwarnapilihan.Name = "lblwarnapilihan"
        lblwarnapilihan.Size = New Size(132, 219)
        lblwarnapilihan.TabIndex = 0
        ' 
        ' lblketerangan
        ' 
        lblketerangan.Location = New Point(22, 335)
        lblketerangan.Name = "lblketerangan"
        lblketerangan.Size = New Size(208, 25)
        lblketerangan.TabIndex = 2
        lblketerangan.Text = "warna yang di pilih"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblketerangan)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblwarnapilihan As Label
    Friend WithEvents lblketerangan As Label

End Class
