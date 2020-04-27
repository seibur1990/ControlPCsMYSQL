<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class peticioServei
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbResponsable2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPrioritat2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txProblema2 = New System.Windows.Forms.TextBox()
        Me.btNovaInci = New System.Windows.Forms.Button()
        Me.cmbDept2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Petició servei"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Aquamarine
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Responsable que informa de la petició"
        '
        'cmbResponsable2
        '
        Me.cmbResponsable2.FormattingEnabled = True
        Me.cmbResponsable2.Location = New System.Drawing.Point(273, 156)
        Me.cmbResponsable2.Name = "cmbResponsable2"
        Me.cmbResponsable2.Size = New System.Drawing.Size(155, 21)
        Me.cmbResponsable2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Cyan
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Prioritat"
        '
        'cmbPrioritat2
        '
        Me.cmbPrioritat2.FormattingEnabled = True
        Me.cmbPrioritat2.Location = New System.Drawing.Point(273, 187)
        Me.cmbPrioritat2.Name = "cmbPrioritat2"
        Me.cmbPrioritat2.Size = New System.Drawing.Size(155, 21)
        Me.cmbPrioritat2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Problema"
        '
        'txProblema2
        '
        Me.txProblema2.Location = New System.Drawing.Point(12, 307)
        Me.txProblema2.Multiline = True
        Me.txProblema2.Name = "txProblema2"
        Me.txProblema2.Size = New System.Drawing.Size(238, 87)
        Me.txProblema2.TabIndex = 10
        '
        'btNovaInci
        '
        Me.btNovaInci.Location = New System.Drawing.Point(338, 363)
        Me.btNovaInci.Name = "btNovaInci"
        Me.btNovaInci.Size = New System.Drawing.Size(99, 31)
        Me.btNovaInci.TabIndex = 11
        Me.btNovaInci.Text = "Alta"
        Me.btNovaInci.UseVisualStyleBackColor = True
        '
        'cmbDept2
        '
        Me.cmbDept2.FormattingEnabled = True
        Me.cmbDept2.Location = New System.Drawing.Point(273, 214)
        Me.cmbDept2.Name = "cmbDept2"
        Me.cmbDept2.Size = New System.Drawing.Size(155, 21)
        Me.cmbDept2.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Aquamarine
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tipus petició"
        '
        'peticioServei
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CatMANAGER.My.Resources.Resources.logoresolution400
        Me.ClientSize = New System.Drawing.Size(449, 406)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbDept2)
        Me.Controls.Add(Me.btNovaInci)
        Me.Controls.Add(Me.txProblema2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbPrioritat2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbResponsable2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "peticioServei"
        Me.Text = "Petició Servei"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbResponsable2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPrioritat2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txProblema2 As TextBox
    Friend WithEvents btNovaInci As Button
    Friend WithEvents cmbDept2 As ComboBox
    Friend WithEvents Label6 As Label
End Class
