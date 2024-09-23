<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnShowNumbers = New Button()
        lblNumbers = New Label()
        SuspendLayout()
        ' 
        ' btnShowNumbers
        ' 
        btnShowNumbers.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowNumbers.Location = New Point(129, 88)
        btnShowNumbers.Name = "btnShowNumbers"
        btnShowNumbers.Size = New Size(92, 43)
        btnShowNumbers.TabIndex = 0
        btnShowNumbers.Text = "Display"
        btnShowNumbers.UseVisualStyleBackColor = True
        ' 
        ' lblNumbers
        ' 
        lblNumbers.AutoSize = True
        lblNumbers.Location = New Point(146, 167)
        lblNumbers.Name = "lblNumbers"
        lblNumbers.Size = New Size(56, 15)
        lblNumbers.TabIndex = 1
        lblNumbers.Text = "Numbers"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(362, 312)
        Controls.Add(lblNumbers)
        Controls.Add(btnShowNumbers)
        Name = "Form1"
        Text = "For Loop"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnShowNumbers As Button
    Friend WithEvents lblNumbers As Label

End Class
