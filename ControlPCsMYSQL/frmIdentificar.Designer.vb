<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdentificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIdentificar))
        Me.lbNom = New System.Windows.Forms.Label()
        Me.txNom = New System.Windows.Forms.TextBox()
        Me.btOk = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.lbCorreu = New System.Windows.Forms.Label()
        Me.txCorreu = New System.Windows.Forms.TextBox()
        Me.lbPassRe = New System.Windows.Forms.Label()
        Me.txPassRe = New System.Windows.Forms.TextBox()
        Me.btRecordar = New System.Windows.Forms.Button()
        Me.btNou = New System.Windows.Forms.Button()
        Me.btIdentificar = New System.Windows.Forms.Button()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txPass = New System.Windows.Forms.TextBox()
        Me.txUsr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbNom
        '
        Me.lbNom.AutoSize = True
        Me.lbNom.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lbNom.Location = New System.Drawing.Point(43, 142)
        Me.lbNom.Name = "lbNom"
        Me.lbNom.Size = New System.Drawing.Size(29, 13)
        Me.lbNom.TabIndex = 27
        Me.lbNom.Text = "Nom"
        Me.lbNom.Visible = False
        '
        'txNom
        '
        Me.txNom.Location = New System.Drawing.Point(115, 135)
        Me.txNom.MaxLength = 128
        Me.txNom.Name = "txNom"
        Me.txNom.Size = New System.Drawing.Size(206, 20)
        Me.txNom.TabIndex = 13
        Me.txNom.Visible = False
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(331, 264)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(86, 35)
        Me.btOk.TabIndex = 23
        Me.btOk.Text = "Ok"
        Me.btOk.UseVisualStyleBackColor = True
        Me.btOk.Visible = False
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(331, 305)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(86, 35)
        Me.btCancelar.TabIndex = 25
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        Me.btCancelar.Visible = False
        '
        'lbCorreu
        '
        Me.lbCorreu.AutoSize = True
        Me.lbCorreu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbCorreu.Location = New System.Drawing.Point(43, 255)
        Me.lbCorreu.Name = "lbCorreu"
        Me.lbCorreu.Size = New System.Drawing.Size(38, 13)
        Me.lbCorreu.TabIndex = 26
        Me.lbCorreu.Text = "Correu"
        Me.lbCorreu.Visible = False
        '
        'txCorreu
        '
        Me.txCorreu.Location = New System.Drawing.Point(115, 252)
        Me.txCorreu.MaxLength = 128
        Me.txCorreu.Name = "txCorreu"
        Me.txCorreu.Size = New System.Drawing.Size(206, 20)
        Me.txCorreu.TabIndex = 19
        Me.txCorreu.Visible = False
        '
        'lbPassRe
        '
        Me.lbPassRe.AutoSize = True
        Me.lbPassRe.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lbPassRe.Location = New System.Drawing.Point(43, 225)
        Me.lbPassRe.Name = "lbPassRe"
        Me.lbPassRe.Size = New System.Drawing.Size(60, 13)
        Me.lbPassRe.TabIndex = 24
        Me.lbPassRe.Text = "Repeteix-la"
        Me.lbPassRe.Visible = False
        '
        'txPassRe
        '
        Me.txPassRe.Location = New System.Drawing.Point(115, 222)
        Me.txPassRe.MaxLength = 128
        Me.txPassRe.Name = "txPassRe"
        Me.txPassRe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPassRe.Size = New System.Drawing.Size(206, 20)
        Me.txPassRe.TabIndex = 17
        Me.txPassRe.Visible = False
        '
        'btRecordar
        '
        Me.btRecordar.Location = New System.Drawing.Point(129, 305)
        Me.btRecordar.Name = "btRecordar"
        Me.btRecordar.Size = New System.Drawing.Size(95, 34)
        Me.btRecordar.TabIndex = 22
        Me.btRecordar.Text = "Restablir contrasenya"
        Me.btRecordar.UseVisualStyleBackColor = True
        '
        'btNou
        '
        Me.btNou.Location = New System.Drawing.Point(28, 305)
        Me.btNou.Name = "btNou"
        Me.btNou.Size = New System.Drawing.Size(95, 34)
        Me.btNou.TabIndex = 21
        Me.btNou.Text = "Nova alta"
        Me.btNou.UseVisualStyleBackColor = True
        '
        'btIdentificar
        '
        Me.btIdentificar.Location = New System.Drawing.Point(230, 305)
        Me.btIdentificar.Name = "btIdentificar"
        Me.btIdentificar.Size = New System.Drawing.Size(95, 34)
        Me.btIdentificar.TabIndex = 20
        Me.btIdentificar.Text = "Identificar-te"
        Me.btIdentificar.UseVisualStyleBackColor = True
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.BackColor = System.Drawing.Color.Turquoise
        Me.lbPass.Location = New System.Drawing.Point(43, 199)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(66, 13)
        Me.lbPass.TabIndex = 18
        Me.lbPass.Text = "Contrasenya"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label1.Location = New System.Drawing.Point(43, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Usuari"
        '
        'txPass
        '
        Me.txPass.Location = New System.Drawing.Point(115, 196)
        Me.txPass.MaxLength = 128
        Me.txPass.Name = "txPass"
        Me.txPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPass.Size = New System.Drawing.Size(206, 20)
        Me.txPass.TabIndex = 16
        '
        'txUsr
        '
        Me.txUsr.Location = New System.Drawing.Point(115, 161)
        Me.txUsr.MaxLength = 10
        Me.txUsr.Name = "txUsr"
        Me.txUsr.Size = New System.Drawing.Size(206, 20)
        Me.txUsr.TabIndex = 14
        '
        'frmIdentificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CatMANAGER.My.Resources.Resources.logoresolution400
        Me.ClientSize = New System.Drawing.Size(451, 350)
        Me.Controls.Add(Me.lbNom)
        Me.Controls.Add(Me.txNom)
        Me.Controls.Add(Me.btOk)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.lbCorreu)
        Me.Controls.Add(Me.txCorreu)
        Me.Controls.Add(Me.lbPassRe)
        Me.Controls.Add(Me.txPassRe)
        Me.Controls.Add(Me.btRecordar)
        Me.Controls.Add(Me.btNou)
        Me.Controls.Add(Me.btIdentificar)
        Me.Controls.Add(Me.lbPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txPass)
        Me.Controls.Add(Me.txUsr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIdentificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IT Resolution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNom As Label
    Friend WithEvents txNom As TextBox
    Friend WithEvents btOk As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents lbCorreu As Label
    Friend WithEvents txCorreu As TextBox
    Friend WithEvents lbPassRe As Label
    Friend WithEvents txPassRe As TextBox
    Friend WithEvents btRecordar As Button
    Friend WithEvents btNou As Button
    Friend WithEvents btIdentificar As Button
    Friend WithEvents lbPass As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txPass As TextBox
    Friend WithEvents txUsr As TextBox
End Class
