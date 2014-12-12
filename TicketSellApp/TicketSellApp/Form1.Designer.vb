<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.customerNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numberOfTicketTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalPriceButton = New System.Windows.Forms.Button()
        Me.deatailsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'customerNameTextbox
        '
        Me.customerNameTextbox.Location = New System.Drawing.Point(146, 54)
        Me.customerNameTextbox.Name = "customerNameTextbox"
        Me.customerNameTextbox.Size = New System.Drawing.Size(154, 20)
        Me.customerNameTextbox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number Of Ticket:"
        '
        'numberOfTicketTextbox
        '
        Me.numberOfTicketTextbox.Location = New System.Drawing.Point(146, 101)
        Me.numberOfTicketTextbox.Name = "numberOfTicketTextbox"
        Me.numberOfTicketTextbox.Size = New System.Drawing.Size(154, 20)
        Me.numberOfTicketTextbox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ticket price 10 Taka"
        '
        'totalPriceButton
        '
        Me.totalPriceButton.Location = New System.Drawing.Point(85, 237)
        Me.totalPriceButton.Name = "totalPriceButton"
        Me.totalPriceButton.Size = New System.Drawing.Size(75, 23)
        Me.totalPriceButton.TabIndex = 5
        Me.totalPriceButton.Text = "Total price"
        Me.totalPriceButton.UseVisualStyleBackColor = True
        '
        'deatailsButton
        '
        Me.deatailsButton.Location = New System.Drawing.Point(243, 237)
        Me.deatailsButton.Name = "deatailsButton"
        Me.deatailsButton.Size = New System.Drawing.Size(75, 23)
        Me.deatailsButton.TabIndex = 6
        Me.deatailsButton.Text = "Button1"
        Me.deatailsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 396)
        Me.Controls.Add(Me.deatailsButton)
        Me.Controls.Add(Me.totalPriceButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numberOfTicketTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.customerNameTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents customerNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numberOfTicketTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totalPriceButton As System.Windows.Forms.Button
    Friend WithEvents deatailsButton As System.Windows.Forms.Button

End Class
