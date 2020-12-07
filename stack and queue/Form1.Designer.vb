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
        Me.psh_box = New System.Windows.Forms.TextBox()
        Me.pop_box = New System.Windows.Forms.TextBox()
        Me.txtStack4 = New System.Windows.Forms.TextBox()
        Me.txtStack3 = New System.Windows.Forms.TextBox()
        Me.txtStack2 = New System.Windows.Forms.TextBox()
        Me.txtStack1 = New System.Windows.Forms.TextBox()
        Me.txtStack0 = New System.Windows.Forms.TextBox()
        Me.psh = New System.Windows.Forms.Button()
        Me.pop = New System.Windows.Forms.Button()
        Me.txtStack6 = New System.Windows.Forms.TextBox()
        Me.txtStack5 = New System.Windows.Forms.TextBox()
        Me.stk = New System.Windows.Forms.RadioButton()
        Me.que = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.clr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'psh_box
        '
        Me.psh_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psh_box.Location = New System.Drawing.Point(200, 185)
        Me.psh_box.Name = "psh_box"
        Me.psh_box.Size = New System.Drawing.Size(181, 30)
        Me.psh_box.TabIndex = 0
        '
        'pop_box
        '
        Me.pop_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pop_box.Location = New System.Drawing.Point(200, 282)
        Me.pop_box.Name = "pop_box"
        Me.pop_box.Size = New System.Drawing.Size(181, 30)
        Me.pop_box.TabIndex = 1
        '
        'txtStack4
        '
        Me.txtStack4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStack4.Location = New System.Drawing.Point(646, 190)
        Me.txtStack4.Name = "txtStack4"
        Me.txtStack4.Size = New System.Drawing.Size(181, 30)
        Me.txtStack4.TabIndex = 2
        '
        'txtStack3
        '
        Me.txtStack3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStack3.Location = New System.Drawing.Point(646, 226)
        Me.txtStack3.Name = "txtStack3"
        Me.txtStack3.Size = New System.Drawing.Size(181, 30)
        Me.txtStack3.TabIndex = 3
        '
        'txtStack2
        '
        Me.txtStack2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStack2.Location = New System.Drawing.Point(646, 262)
        Me.txtStack2.Name = "txtStack2"
        Me.txtStack2.Size = New System.Drawing.Size(181, 30)
        Me.txtStack2.TabIndex = 4
        '
        'txtStack1
        '
        Me.txtStack1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStack1.Location = New System.Drawing.Point(646, 298)
        Me.txtStack1.Name = "txtStack1"
        Me.txtStack1.Size = New System.Drawing.Size(181, 30)
        Me.txtStack1.TabIndex = 5
        '
        'txtStack0
        '
        Me.txtStack0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStack0.Location = New System.Drawing.Point(646, 334)
        Me.txtStack0.Name = "txtStack0"
        Me.txtStack0.Size = New System.Drawing.Size(181, 30)
        Me.txtStack0.TabIndex = 6
        '
        'psh
        '
        Me.psh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psh.Location = New System.Drawing.Point(432, 175)
        Me.psh.Name = "psh"
        Me.psh.Size = New System.Drawing.Size(156, 50)
        Me.psh.TabIndex = 7
        Me.psh.Text = "Push"
        Me.psh.UseVisualStyleBackColor = True
        '
        'pop
        '
        Me.pop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pop.Location = New System.Drawing.Point(432, 272)
        Me.pop.Name = "pop"
        Me.pop.Size = New System.Drawing.Size(156, 50)
        Me.pop.TabIndex = 8
        Me.pop.Text = "Pop"
        Me.pop.UseVisualStyleBackColor = True
        '
        'txtStack6
        '
        Me.txtStack6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStack6.Location = New System.Drawing.Point(646, 118)
        Me.txtStack6.Name = "txtStack6"
        Me.txtStack6.Size = New System.Drawing.Size(181, 30)
        Me.txtStack6.TabIndex = 10
        '
        'txtStack5
        '
        Me.txtStack5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStack5.Location = New System.Drawing.Point(646, 154)
        Me.txtStack5.Name = "txtStack5"
        Me.txtStack5.Size = New System.Drawing.Size(181, 30)
        Me.txtStack5.TabIndex = 11
        '
        'stk
        '
        Me.stk.AutoSize = True
        Me.stk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stk.Location = New System.Drawing.Point(271, 46)
        Me.stk.Name = "stk"
        Me.stk.Size = New System.Drawing.Size(110, 40)
        Me.stk.TabIndex = 12
        Me.stk.TabStop = True
        Me.stk.Text = "Stack"
        Me.stk.UseVisualStyleBackColor = True
        '
        'que
        '
        Me.que.AutoSize = True
        Me.que.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.que.Location = New System.Drawing.Point(427, 46)
        Me.que.Name = "que"
        Me.que.Size = New System.Drawing.Size(124, 40)
        Me.que.TabIndex = 13
        Me.que.TabStop = True
        Me.que.Text = "Queue"
        Me.que.UseVisualStyleBackColor = True
        '
        'clr
        '
        Me.clr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr.Location = New System.Drawing.Point(646, 28)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(126, 43)
        Me.clr.TabIndex = 14
        Me.clr.Text = "Refresh"
        Me.clr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(994, 450)
        Me.Controls.Add(Me.clr)
        Me.Controls.Add(Me.que)
        Me.Controls.Add(Me.stk)
        Me.Controls.Add(Me.txtStack5)
        Me.Controls.Add(Me.txtStack6)
        Me.Controls.Add(Me.pop)
        Me.Controls.Add(Me.psh)
        Me.Controls.Add(Me.txtStack0)
        Me.Controls.Add(Me.txtStack1)
        Me.Controls.Add(Me.txtStack2)
        Me.Controls.Add(Me.txtStack3)
        Me.Controls.Add(Me.txtStack4)
        Me.Controls.Add(Me.pop_box)
        Me.Controls.Add(Me.psh_box)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents psh_box As TextBox
    Friend WithEvents pop_box As TextBox
    Friend WithEvents txtStack4 As TextBox
    Friend WithEvents txtStack3 As TextBox
    Friend WithEvents txtStack2 As TextBox
    Friend WithEvents txtStack1 As TextBox
    Friend WithEvents txtStack0 As TextBox
    Friend WithEvents psh As Button
    Friend WithEvents pop As Button
    Friend WithEvents txtStack6 As TextBox
    Friend WithEvents txtStack5 As TextBox
    Friend WithEvents stk As RadioButton
    Friend WithEvents que As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents clr As Button
End Class
