<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WB
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TB
        '
        Me.TB.BackColor = System.Drawing.Color.LightGray
        Me.TB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB.Font = New System.Drawing.Font("Consolas", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB.ForeColor = System.Drawing.Color.Black
        Me.TB.Location = New System.Drawing.Point(0, 0)
        Me.TB.MaxLength = 1
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(48, 48)
        Me.TB.TabIndex = 1
        Me.TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TB)
        Me.Name = "WB"
        Me.Size = New System.Drawing.Size(48, 48)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB As TextBox
End Class
