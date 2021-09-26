<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Combox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ProcesosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Combox1
        '
        Me.Combox1.FormattingEnabled = True
        Me.Combox1.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.Combox1.Location = New System.Drawing.Point(234, 252)
        Me.Combox1.Name = "Combox1"
        Me.Combox1.Size = New System.Drawing.Size(177, 24)
        Me.Combox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RENTA AUTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese Nit"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(234, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Placa Automovil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Marca"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(234, 191)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 22)
        Me.TextBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 410)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Efectivo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(473, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tarjeta"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(234, 410)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(177, 22)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(597, 410)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(177, 22)
        Me.TextBox4.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 484)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(234, 487)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(177, 22)
        Me.TextBox5.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarEntradaToolStripMenuItem, Me.LimpiarVectorToolStripMenuItem, Me.SalirToolStripMenuItem, Me.ProcesosToolStripMenuItem1})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.ProcesosToolStripMenuItem.Text = "Menú"
        '
        'LimpiarEntradaToolStripMenuItem
        '
        Me.LimpiarEntradaToolStripMenuItem.Name = "LimpiarEntradaToolStripMenuItem"
        Me.LimpiarEntradaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LimpiarEntradaToolStripMenuItem.Text = "Limpiar Entrada"
        '
        'LimpiarVectorToolStripMenuItem
        '
        Me.LimpiarVectorToolStripMenuItem.Name = "LimpiarVectorToolStripMenuItem"
        Me.LimpiarVectorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LimpiarVectorToolStripMenuItem.Text = "Limpiar Vector"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(504, 76)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(270, 228)
        Me.ListBox1.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Dias de Alquiler"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(234, 334)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(177, 22)
        Me.TextBox6.TabIndex = 16
        '
        'ProcesosToolStripMenuItem1
        '
        Me.ProcesosToolStripMenuItem1.Name = "ProcesosToolStripMenuItem1"
        Me.ProcesosToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ProcesosToolStripMenuItem1.Text = "Procesos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(446, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Pago Parcial"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(597, 334)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(177, 22)
        Me.TextBox7.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 645)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Combox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Combox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProcesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ProcesosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
End Class
