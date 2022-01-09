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
        Me.TLP1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'TLP1
        '
        Me.TLP1.ColumnCount = 5
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP1.Location = New System.Drawing.Point(12, 12)
        Me.TLP1.Name = "TLP1"
        Me.TLP1.RowCount = 6
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP1.Size = New System.Drawing.Size(278, 319)
        Me.TLP1.TabIndex = 30
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(297, 13)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(491, 542)
        Me.ListView1.TabIndex = 31
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 567)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TLP1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLP1 As TableLayoutPanel
    Friend WithEvents ListView1 As ListView
End Class
