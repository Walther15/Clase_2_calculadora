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
        Num1 = New TextBox()
        Num2 = New TextBox()
        Operacion = New ComboBox()
        Calcular = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Num1
        ' 
        Num1.Location = New Point(171, 76)
        Num1.Name = "Num1"
        Num1.Size = New Size(100, 23)
        Num1.TabIndex = 0
        ' 
        ' Num2
        ' 
        Num2.Location = New Point(171, 122)
        Num2.Name = "Num2"
        Num2.Size = New Size(100, 23)
        Num2.TabIndex = 1
        ' 
        ' Operacion
        ' 
        Operacion.FormattingEnabled = True
        Operacion.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicación", "División"})
        Operacion.Location = New Point(171, 170)
        Operacion.Name = "Operacion"
        Operacion.Size = New Size(121, 23)
        Operacion.TabIndex = 2
        ' 
        ' Calcular
        ' 
        Calcular.Location = New Point(171, 215)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(75, 23)
        Calcular.TabIndex = 3
        Calcular.Text = "Calcular"
        Calcular.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 15)
        Label1.TabIndex = 4
        Label1.Text = "Ingrese primer numero:" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 15)
        Label2.TabIndex = 5
        Label2.Text = "Ingrese segundo numero:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 352)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Calcular)
        Controls.Add(Operacion)
        Controls.Add(Num2)
        Controls.Add(Num1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents Operacion As ComboBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
