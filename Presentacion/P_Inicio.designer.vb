<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Inicio
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
        Me.components = New System.ComponentModel.Container()
        Me.Tb1_Nom = New System.Windows.Forms.TextBox()
        Me.Tb1_Pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bt1_Ingresa = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pb1_1 = New System.Windows.Forms.PictureBox()
        Me.Pb1_2 = New System.Windows.Forms.PictureBox()
        CType(Me.Pb1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb1_Nom
        '
        Me.Tb1_Nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tb1_Nom.Location = New System.Drawing.Point(221, 20)
        Me.Tb1_Nom.Margin = New System.Windows.Forms.Padding(2)
        Me.Tb1_Nom.Name = "Tb1_Nom"
        Me.Tb1_Nom.Size = New System.Drawing.Size(96, 20)
        Me.Tb1_Nom.TabIndex = 1
        '
        'Tb1_Pass
        '
        Me.Tb1_Pass.Location = New System.Drawing.Point(221, 55)
        Me.Tb1_Pass.Margin = New System.Windows.Forms.Padding(2)
        Me.Tb1_Pass.Name = "Tb1_Pass"
        Me.Tb1_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb1_Pass.Size = New System.Drawing.Size(96, 20)
        Me.Tb1_Pass.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(141, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(141, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Bt1_Ingresa
        '
        Me.Bt1_Ingresa.AutoSize = True
        Me.Bt1_Ingresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bt1_Ingresa.Location = New System.Drawing.Point(233, 90)
        Me.Bt1_Ingresa.Margin = New System.Windows.Forms.Padding(2)
        Me.Bt1_Ingresa.Name = "Bt1_Ingresa"
        Me.Bt1_Ingresa.Size = New System.Drawing.Size(75, 28)
        Me.Bt1_Ingresa.TabIndex = 3
        Me.Bt1_Ingresa.Text = "Ingresar"
        Me.Bt1_Ingresa.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Pb1_1
        '
        Me.Pb1_1.BackColor = System.Drawing.Color.Transparent
        Me.Pb1_1.Image = Global.Presentacion.My.Resources.Resources.SEGROJO
        Me.Pb1_1.Location = New System.Drawing.Point(26, 0)
        Me.Pb1_1.Margin = New System.Windows.Forms.Padding(2)
        Me.Pb1_1.Name = "Pb1_1"
        Me.Pb1_1.Size = New System.Drawing.Size(104, 118)
        Me.Pb1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pb1_1.TabIndex = 0
        Me.Pb1_1.TabStop = False
        '
        'Pb1_2
        '
        Me.Pb1_2.BackColor = System.Drawing.Color.Transparent
        Me.Pb1_2.Image = Global.Presentacion.My.Resources.Resources.SegVerde
        Me.Pb1_2.Location = New System.Drawing.Point(26, 0)
        Me.Pb1_2.Margin = New System.Windows.Forms.Padding(2)
        Me.Pb1_2.Name = "Pb1_2"
        Me.Pb1_2.Size = New System.Drawing.Size(104, 118)
        Me.Pb1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pb1_2.TabIndex = 0
        Me.Pb1_2.TabStop = False
        Me.Pb1_2.Visible = False
        '
        'P_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(339, 136)
        Me.Controls.Add(Me.Bt1_Ingresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb1_Pass)
        Me.Controls.Add(Me.Tb1_Nom)
        Me.Controls.Add(Me.Pb1_1)
        Me.Controls.Add(Me.Pb1_2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "P_Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE ACCESO"
        CType(Me.Pb1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb1_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pb1_1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tb1_Nom As System.Windows.Forms.TextBox
    Friend WithEvents Tb1_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bt1_Ingresa As System.Windows.Forms.Button
    Friend WithEvents Pb1_2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
