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
        btnShowTable = New Button()
        txtMultiplicationTable = New TextBox()
        SuspendLayout()
        ' 
        ' btnShowTable
        ' 
        btnShowTable.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowTable.Location = New Point(113, 46)
        btnShowTable.Name = "btnShowTable"
        btnShowTable.Size = New Size(106, 47)
        btnShowTable.TabIndex = 0
        btnShowTable.Text = "Display"
        btnShowTable.UseVisualStyleBackColor = True
        ' 
        ' txtMultiplicationTable
        ' 
        txtMultiplicationTable.Location = New Point(88, 131)
        txtMultiplicationTable.Name = "txtMultiplicationTable"
        txtMultiplicationTable.Size = New Size(159, 23)
        txtMultiplicationTable.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 256)
        Controls.Add(txtMultiplicationTable)
        Controls.Add(btnShowTable)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnShowTable As Button
    Friend WithEvents txtMultiplicationTable As TextBox

End Class
