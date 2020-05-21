<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarisUPDATE
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txPassRe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txCorreu = New System.Windows.Forms.TextBox()
        Me.btActualitzar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbUsr = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chNotifice = New System.Windows.Forms.CheckBox()
        Me.chActiu = New System.Windows.Forms.CheckBox()
        Me.txNom = New System.Windows.Forms.TextBox()
        Me.chAdmin = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Repetir-la"
        '
        'txPassRe
        '
        Me.txPassRe.Enabled = False
        Me.txPassRe.Location = New System.Drawing.Point(84, 116)
        Me.txPassRe.MaxLength = 128
        Me.txPassRe.Name = "txPassRe"
        Me.txPassRe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPassRe.Size = New System.Drawing.Size(138, 20)
        Me.txPassRe.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Correu"
        '
        'txCorreu
        '
        Me.txCorreu.Enabled = False
        Me.txCorreu.Location = New System.Drawing.Point(84, 141)
        Me.txCorreu.MaxLength = 256
        Me.txCorreu.Name = "txCorreu"
        Me.txCorreu.Size = New System.Drawing.Size(138, 20)
        Me.txCorreu.TabIndex = 3
        '
        'btActualitzar
        '
        Me.btActualitzar.Location = New System.Drawing.Point(130, 222)
        Me.btActualitzar.Name = "btActualitzar"
        Me.btActualitzar.Size = New System.Drawing.Size(92, 33)
        Me.btActualitzar.TabIndex = 6
        Me.btActualitzar.Text = "Actualitzar"
        Me.btActualitzar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Contrasenya"
        '
        'txPass
        '
        Me.txPass.Enabled = False
        Me.txPass.Location = New System.Drawing.Point(84, 90)
        Me.txPass.MaxLength = 128
        Me.txPass.Name = "txPass"
        Me.txPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPass.Size = New System.Drawing.Size(138, 20)
        Me.txPass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuari"
        '
        'cmbUsr
        '
        Me.cmbUsr.FormattingEnabled = True
        Me.cmbUsr.Location = New System.Drawing.Point(85, 64)
        Me.cmbUsr.MaxLength = 10
        Me.cmbUsr.Name = "cmbUsr"
        Me.cmbUsr.Size = New System.Drawing.Size(137, 21)
        Me.cmbUsr.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Nom"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(32, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chNotifice
        '
        Me.chNotifice.AutoSize = True
        Me.chNotifice.Enabled = False
        Me.chNotifice.Location = New System.Drawing.Point(93, 186)
        Me.chNotifice.Name = "chNotifice"
        Me.chNotifice.Size = New System.Drawing.Size(87, 17)
        Me.chNotifice.TabIndex = 5
        Me.chNotifice.Text = "Notificacions"
        Me.chNotifice.UseVisualStyleBackColor = True
        '
        'chActiu
        '
        Me.chActiu.AutoSize = True
        Me.chActiu.Enabled = False
        Me.chActiu.Location = New System.Drawing.Point(16, 186)
        Me.chActiu.Name = "chActiu"
        Me.chActiu.Size = New System.Drawing.Size(50, 17)
        Me.chActiu.TabIndex = 4
        Me.chActiu.Text = "Actiu"
        Me.chActiu.UseVisualStyleBackColor = True
        '
        'txNom
        '
        Me.txNom.Enabled = False
        Me.txNom.Location = New System.Drawing.Point(85, 35)
        Me.txNom.MaxLength = 128
        Me.txNom.Name = "txNom"
        Me.txNom.Size = New System.Drawing.Size(138, 20)
        Me.txNom.TabIndex = 8
        '
        'chAdmin
        '
        Me.chAdmin.AutoSize = True
        Me.chAdmin.Enabled = False
        Me.chAdmin.Location = New System.Drawing.Point(186, 186)
        Me.chAdmin.Name = "chAdmin"
        Me.chAdmin.Size = New System.Drawing.Size(89, 17)
        Me.chAdmin.TabIndex = 20
        Me.chAdmin.Text = "Administrador"
        Me.chAdmin.UseVisualStyleBackColor = True
        '
        'frmUsuarisUPDATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 271)
        Me.Controls.Add(Me.chAdmin)
        Me.Controls.Add(Me.txNom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chNotifice)
        Me.Controls.Add(Me.chActiu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbUsr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txPassRe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txCorreu)
        Me.Controls.Add(Me.btActualitzar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txPass)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarisUPDATE"
        Me.Text = "Manteniment usuaris admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txPassRe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txCorreu As TextBox
    Friend WithEvents btActualitzar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbUsr As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chNotifice As CheckBox
    Friend WithEvents chActiu As CheckBox
    Friend WithEvents txNom As TextBox
    Friend WithEvents chAdmin As CheckBox
End Class
