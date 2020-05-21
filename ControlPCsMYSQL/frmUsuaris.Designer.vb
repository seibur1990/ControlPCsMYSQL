<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuaris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuaris))
        Me.txUsr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txPass = New System.Windows.Forms.TextBox()
        Me.btAlta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txCorreu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txPassRe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txNom = New System.Windows.Forms.TextBox()
        Me.chActiu = New System.Windows.Forms.CheckBox()
        Me.chNotifice = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txUsr
        '
        Me.txUsr.Location = New System.Drawing.Point(94, 96)
        Me.txUsr.MaxLength = 10
        Me.txUsr.Name = "txUsr"
        Me.txUsr.Size = New System.Drawing.Size(138, 20)
        Me.txUsr.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contrasenya"
        '
        'txPass
        '
        Me.txPass.Location = New System.Drawing.Point(94, 122)
        Me.txPass.MaxLength = 128
        Me.txPass.Name = "txPass"
        Me.txPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPass.Size = New System.Drawing.Size(138, 20)
        Me.txPass.TabIndex = 3
        '
        'btAlta
        '
        Me.btAlta.Location = New System.Drawing.Point(140, 243)
        Me.btAlta.Name = "btAlta"
        Me.btAlta.Size = New System.Drawing.Size(92, 33)
        Me.btAlta.TabIndex = 8
        Me.btAlta.Text = "Alta"
        Me.btAlta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Correu"
        '
        'txCorreu
        '
        Me.txCorreu.Location = New System.Drawing.Point(94, 174)
        Me.txCorreu.MaxLength = 256
        Me.txCorreu.Name = "txCorreu"
        Me.txCorreu.Size = New System.Drawing.Size(138, 20)
        Me.txCorreu.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Repetir-la"
        '
        'txPassRe
        '
        Me.txPassRe.Location = New System.Drawing.Point(94, 148)
        Me.txPassRe.MaxLength = 128
        Me.txPassRe.Name = "txPassRe"
        Me.txPassRe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPassRe.Size = New System.Drawing.Size(138, 20)
        Me.txPassRe.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nom"
        '
        'txNom
        '
        Me.txNom.Location = New System.Drawing.Point(94, 70)
        Me.txNom.MaxLength = 128
        Me.txNom.Name = "txNom"
        Me.txNom.Size = New System.Drawing.Size(138, 20)
        Me.txNom.TabIndex = 0
        '
        'chActiu
        '
        Me.chActiu.AutoSize = True
        Me.chActiu.Location = New System.Drawing.Point(56, 211)
        Me.chActiu.Name = "chActiu"
        Me.chActiu.Size = New System.Drawing.Size(50, 17)
        Me.chActiu.TabIndex = 6
        Me.chActiu.Text = "Actiu"
        Me.chActiu.UseVisualStyleBackColor = True
        '
        'chNotifice
        '
        Me.chNotifice.AutoSize = True
        Me.chNotifice.Location = New System.Drawing.Point(133, 211)
        Me.chNotifice.Name = "chNotifice"
        Me.chNotifice.Size = New System.Drawing.Size(87, 17)
        Me.chNotifice.TabIndex = 7
        Me.chNotifice.Text = "Notificacions"
        Me.chNotifice.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmUsuaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(283, 298)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chNotifice)
        Me.Controls.Add(Me.chActiu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txNom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txPassRe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txCorreu)
        Me.Controls.Add(Me.btAlta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txUsr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuaris"
        Me.Text = "Alta usuaris"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txUsr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txPass As TextBox
    Friend WithEvents btAlta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txCorreu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txPassRe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txNom As TextBox
    Friend WithEvents chActiu As CheckBox
    Friend WithEvents chNotifice As CheckBox
    Friend WithEvents Button1 As Button
End Class
