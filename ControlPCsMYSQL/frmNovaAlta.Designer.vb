<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovaAlta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaAlta))
        Me.cmbResponsable = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbPCs = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPrioritat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txProblema = New System.Windows.Forms.TextBox()
        Me.btNovaInci = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbResponsable
        '
        Me.cmbResponsable.FormattingEnabled = True
        Me.cmbResponsable.Location = New System.Drawing.Point(291, 168)
        Me.cmbResponsable.Name = "cmbResponsable"
        Me.cmbResponsable.Size = New System.Drawing.Size(155, 21)
        Me.cmbResponsable.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nova incidència"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Turquoise
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Qui informa del problema: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nom ordinador afectat"
        '
        'cmbPCs
        '
        Me.cmbPCs.FormattingEnabled = True
        Me.cmbPCs.Location = New System.Drawing.Point(291, 195)
        Me.cmbPCs.Name = "cmbPCs"
        Me.cmbPCs.Size = New System.Drawing.Size(155, 21)
        Me.cmbPCs.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Turquoise
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prioritat"
        '
        'cmbPrioritat
        '
        Me.cmbPrioritat.FormattingEnabled = True
        Me.cmbPrioritat.Location = New System.Drawing.Point(291, 222)
        Me.cmbPrioritat.Name = "cmbPrioritat"
        Me.cmbPrioritat.Size = New System.Drawing.Size(155, 21)
        Me.cmbPrioritat.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Problema"
        '
        'txProblema
        '
        Me.txProblema.Location = New System.Drawing.Point(30, 320)
        Me.txProblema.Multiline = True
        Me.txProblema.Name = "txProblema"
        Me.txProblema.Size = New System.Drawing.Size(238, 87)
        Me.txProblema.TabIndex = 8
        '
        'btNovaInci
        '
        Me.btNovaInci.Location = New System.Drawing.Point(347, 386)
        Me.btNovaInci.Name = "btNovaInci"
        Me.btNovaInci.Size = New System.Drawing.Size(99, 31)
        Me.btNovaInci.TabIndex = 9
        Me.btNovaInci.Text = "Alta"
        Me.btNovaInci.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipus indicèndia"
        '
        'cmbDept
        '
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(291, 270)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(155, 21)
        Me.cmbDept.TabIndex = 11
        '
        'frmNovaAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(497, 442)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btNovaInci)
        Me.Controls.Add(Me.txProblema)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPrioritat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbPCs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbResponsable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNovaAlta"
        Me.Text = "Alta incidència"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbResponsable As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPCs As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPrioritat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txProblema As TextBox
    Friend WithEvents btNovaInci As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDept As ComboBox
End Class
