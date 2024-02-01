<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Location = New Point(4, 119)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 150)
        Panel1.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(TextBox1)
        FlowLayoutPanel1.Controls.Add(TextBox2)
        FlowLayoutPanel1.Controls.Add(TextBox3)
        FlowLayoutPanel1.Controls.Add(TextBox4)
        FlowLayoutPanel1.Controls.Add(TextBox5)
        FlowLayoutPanel1.Location = New Point(325, 52)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(300, 150)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TextBox9, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBox10, 1, 0)
        TableLayoutPanel1.Controls.Add(TextBox11, 0, 1)
        TableLayoutPanel1.Controls.Add(TextBox12, 1, 1)
        TableLayoutPanel1.Location = New Point(352, 208)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(284, 61)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(3, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(3, 40)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(3, 77)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(3, 114)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(150, 31)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(3, 151)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(150, 31)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(0, 0)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(150, 31)
        TextBox6.TabIndex = 0
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(96, 67)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(150, 31)
        TextBox7.TabIndex = 1
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(59, 100)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(150, 31)
        TextBox8.TabIndex = 2
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(3, 3)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(136, 31)
        TextBox9.TabIndex = 0
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(145, 3)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(136, 31)
        TextBox10.TabIndex = 1
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(3, 33)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(136, 31)
        TextBox11.TabIndex = 2
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(145, 33)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(91, 31)
        TextBox12.TabIndex = 3
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
End Class
