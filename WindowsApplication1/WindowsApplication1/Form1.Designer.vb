﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form123
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
        Me.gantiButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gantiButton
        '
        Me.gantiButton.Location = New System.Drawing.Point(193, 180)
        Me.gantiButton.Name = "gantiButton"
        Me.gantiButton.Size = New System.Drawing.Size(75, 23)
        Me.gantiButton.TabIndex = 0
        Me.gantiButton.Text = "Ganti"
        Me.gantiButton.UseVisualStyleBackColor = True
        '
        'Form123
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.gantiButton)
        Me.Name = "Form123"
        Me.Text = "Form Reski"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gantiButton As System.Windows.Forms.Button

End Class
