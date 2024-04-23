<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ArrayBtn = New System.Windows.Forms.Button()
        Me.DivisionBtn = New System.Windows.Forms.Button()
        Me.ProductoBtn = New System.Windows.Forms.Button()
        Me.DiferenciaBtn = New System.Windows.Forms.Button()
        Me.SumaBtn = New System.Windows.Forms.Button()
        Me.DivisionControl1 = New CalculadoraFracciones.DivisionControl()
        Me.ProductoControl1 = New CalculadoraFracciones.ProductoControl()
        Me.DiferenciaControl1 = New CalculadoraFracciones.DiferenciaControl()
        Me.SumaControl1 = New CalculadoraFracciones.SumaControl()
        Me.ArrayControl1 = New CalculadoraFracciones.ArrayControl()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.ArrayBtn)
        Me.Panel1.Controls.Add(Me.DivisionBtn)
        Me.Panel1.Controls.Add(Me.ProductoBtn)
        Me.Panel1.Controls.Add(Me.DiferenciaBtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 561)
        Me.Panel1.TabIndex = 0
        '
        'ArrayBtn
        '
        Me.ArrayBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ArrayBtn.FlatAppearance.BorderSize = 0
        Me.ArrayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.ArrayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArrayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrayBtn.ForeColor = System.Drawing.Color.White
        Me.ArrayBtn.Location = New System.Drawing.Point(0, 352)
        Me.ArrayBtn.Name = "ArrayBtn"
        Me.ArrayBtn.Size = New System.Drawing.Size(200, 57)
        Me.ArrayBtn.TabIndex = 5
        Me.ArrayBtn.Text = "ARRAY"
        Me.ArrayBtn.UseVisualStyleBackColor = False
        '
        'DivisionBtn
        '
        Me.DivisionBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.DivisionBtn.FlatAppearance.BorderSize = 0
        Me.DivisionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.DivisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DivisionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivisionBtn.ForeColor = System.Drawing.Color.White
        Me.DivisionBtn.Location = New System.Drawing.Point(0, 289)
        Me.DivisionBtn.Name = "DivisionBtn"
        Me.DivisionBtn.Size = New System.Drawing.Size(200, 57)
        Me.DivisionBtn.TabIndex = 4
        Me.DivisionBtn.Text = "DIVISION"
        Me.DivisionBtn.UseVisualStyleBackColor = False
        '
        'ProductoBtn
        '
        Me.ProductoBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ProductoBtn.FlatAppearance.BorderSize = 0
        Me.ProductoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.ProductoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoBtn.ForeColor = System.Drawing.Color.White
        Me.ProductoBtn.Location = New System.Drawing.Point(0, 226)
        Me.ProductoBtn.Name = "ProductoBtn"
        Me.ProductoBtn.Size = New System.Drawing.Size(200, 57)
        Me.ProductoBtn.TabIndex = 3
        Me.ProductoBtn.Text = "PRODUCTO"
        Me.ProductoBtn.UseVisualStyleBackColor = False
        '
        'DiferenciaBtn
        '
        Me.DiferenciaBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.DiferenciaBtn.FlatAppearance.BorderSize = 0
        Me.DiferenciaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.DiferenciaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DiferenciaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiferenciaBtn.ForeColor = System.Drawing.Color.White
        Me.DiferenciaBtn.Location = New System.Drawing.Point(0, 163)
        Me.DiferenciaBtn.Name = "DiferenciaBtn"
        Me.DiferenciaBtn.Size = New System.Drawing.Size(200, 57)
        Me.DiferenciaBtn.TabIndex = 2
        Me.DiferenciaBtn.Text = "DIFERENCIA"
        Me.DiferenciaBtn.UseVisualStyleBackColor = False
        '
        'SumaBtn
        '
        Me.SumaBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.SumaBtn.FlatAppearance.BorderSize = 0
        Me.SumaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.SumaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SumaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumaBtn.ForeColor = System.Drawing.Color.White
        Me.SumaBtn.Location = New System.Drawing.Point(0, 100)
        Me.SumaBtn.Name = "SumaBtn"
        Me.SumaBtn.Size = New System.Drawing.Size(200, 57)
        Me.SumaBtn.TabIndex = 1
        Me.SumaBtn.Text = "SUMA"
        Me.SumaBtn.UseVisualStyleBackColor = False
        '
        'DivisionControl1
        '
        Me.DivisionControl1.BackColor = System.Drawing.Color.White
        Me.DivisionControl1.Location = New System.Drawing.Point(200, 0)
        Me.DivisionControl1.Name = "DivisionControl1"
        Me.DivisionControl1.Size = New System.Drawing.Size(684, 561)
        Me.DivisionControl1.TabIndex = 5
        '
        'ProductoControl1
        '
        Me.ProductoControl1.BackColor = System.Drawing.Color.White
        Me.ProductoControl1.Location = New System.Drawing.Point(200, 0)
        Me.ProductoControl1.Name = "ProductoControl1"
        Me.ProductoControl1.Size = New System.Drawing.Size(684, 561)
        Me.ProductoControl1.TabIndex = 4
        '
        'DiferenciaControl1
        '
        Me.DiferenciaControl1.BackColor = System.Drawing.Color.White
        Me.DiferenciaControl1.Location = New System.Drawing.Point(200, 0)
        Me.DiferenciaControl1.Name = "DiferenciaControl1"
        Me.DiferenciaControl1.Size = New System.Drawing.Size(684, 561)
        Me.DiferenciaControl1.TabIndex = 3
        '
        'SumaControl1
        '
        Me.SumaControl1.BackColor = System.Drawing.Color.White
        Me.SumaControl1.Location = New System.Drawing.Point(200, 0)
        Me.SumaControl1.Name = "SumaControl1"
        Me.SumaControl1.Size = New System.Drawing.Size(684, 561)
        Me.SumaControl1.TabIndex = 2
        '
        'ArrayControl1
        '
        Me.ArrayControl1.BackColor = System.Drawing.Color.White
        Me.ArrayControl1.Location = New System.Drawing.Point(200, 0)
        Me.ArrayControl1.Name = "ArrayControl1"
        Me.ArrayControl1.Size = New System.Drawing.Size(684, 561)
        Me.ArrayControl1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.ArrayControl1)
        Me.Controls.Add(Me.DivisionControl1)
        Me.Controls.Add(Me.ProductoControl1)
        Me.Controls.Add(Me.DiferenciaControl1)
        Me.Controls.Add(Me.SumaControl1)
        Me.Controls.Add(Me.SumaBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SumaBtn As Button
    Friend WithEvents ArrayBtn As Button
    Friend WithEvents DivisionBtn As Button
    Friend WithEvents ProductoBtn As Button
    Friend WithEvents DiferenciaBtn As Button
    Friend WithEvents SumaControl1 As SumaControl
    Friend WithEvents DiferenciaControl1 As DiferenciaControl
    Friend WithEvents ProductoControl1 As ProductoControl
    Friend WithEvents DivisionControl1 As DivisionControl
    Friend WithEvents ArrayControl1 As ArrayControl
End Class
