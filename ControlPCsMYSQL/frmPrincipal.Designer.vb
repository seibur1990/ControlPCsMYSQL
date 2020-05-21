<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IncidènciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaIncidènciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstatIncidènciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeticióServeiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstatPeticionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimentUsuarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaNouUsuariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreLaplicacióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncidènciesToolStripMenuItem, Me.AdministracióToolStripMenuItem, Me.SobreLaplicacióToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1096, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IncidènciesToolStripMenuItem
        '
        Me.IncidènciesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaIncidènciaToolStripMenuItem, Me.EstatIncidènciesToolStripMenuItem, Me.PeticióServeiToolStripMenuItem, Me.EstatPeticionsToolStripMenuItem})
        Me.IncidènciesToolStripMenuItem.Name = "IncidènciesToolStripMenuItem"
        Me.IncidènciesToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.IncidènciesToolStripMenuItem.Text = "Incidències"
        '
        'NovaIncidènciaToolStripMenuItem
        '
        Me.NovaIncidènciaToolStripMenuItem.Name = "NovaIncidènciaToolStripMenuItem"
        Me.NovaIncidènciaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NovaIncidènciaToolStripMenuItem.Text = "Nova incidència"
        '
        'EstatIncidènciesToolStripMenuItem
        '
        Me.EstatIncidènciesToolStripMenuItem.Name = "EstatIncidènciesToolStripMenuItem"
        Me.EstatIncidènciesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EstatIncidènciesToolStripMenuItem.Text = "Estat incidències"
        '
        'PeticióServeiToolStripMenuItem
        '
        Me.PeticióServeiToolStripMenuItem.Name = "PeticióServeiToolStripMenuItem"
        Me.PeticióServeiToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PeticióServeiToolStripMenuItem.Text = "Petició servei"
        '
        'EstatPeticionsToolStripMenuItem
        '
        Me.EstatPeticionsToolStripMenuItem.Name = "EstatPeticionsToolStripMenuItem"
        Me.EstatPeticionsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EstatPeticionsToolStripMenuItem.Text = "Estat peticions"
        '
        'AdministracióToolStripMenuItem
        '
        Me.AdministracióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimentUsuarisToolStripMenuItem, Me.AltaNouUsuariToolStripMenuItem})
        Me.AdministracióToolStripMenuItem.Name = "AdministracióToolStripMenuItem"
        Me.AdministracióToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.AdministracióToolStripMenuItem.Text = "Administració"
        Me.AdministracióToolStripMenuItem.Visible = False
        '
        'MantenimentUsuarisToolStripMenuItem
        '
        Me.MantenimentUsuarisToolStripMenuItem.Name = "MantenimentUsuarisToolStripMenuItem"
        Me.MantenimentUsuarisToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MantenimentUsuarisToolStripMenuItem.Text = "Manteniment usuaris"
        '
        'AltaNouUsuariToolStripMenuItem
        '
        Me.AltaNouUsuariToolStripMenuItem.Name = "AltaNouUsuariToolStripMenuItem"
        Me.AltaNouUsuariToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AltaNouUsuariToolStripMenuItem.Text = "Alta nou usuari"
        '
        'SobreLaplicacióToolStripMenuItem
        '
        Me.SobreLaplicacióToolStripMenuItem.Name = "SobreLaplicacióToolStripMenuItem"
        Me.SobreLaplicacióToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.SobreLaplicacióToolStripMenuItem.Text = "Sobre l'aplicació"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1096, 608)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Menú principal Resolution"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IncidènciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaIncidènciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracióToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimentUsuarisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaNouUsuariToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstatIncidènciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreLaplicacióToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeticióServeiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstatPeticionsToolStripMenuItem As ToolStripMenuItem
End Class
