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
        txtValue1 = New TextBox()
        txtValue2 = New TextBox()
        btnAdd = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        btnDivide = New Button()
        lblResult = New Label()
        chkEstimate1 = New CheckBox()
        chkEstimate2 = New CheckBox()
        SuspendLayout()
        ' 
        ' txtValue1
        ' 
        txtValue1.Location = New Point(467, 156)
        txtValue1.Margin = New Padding(7, 8, 7, 8)
        txtValue1.Name = "txtValue1"
        txtValue1.PlaceholderText = "Integer 1"
        txtValue1.Size = New Size(237, 47)
        txtValue1.TabIndex = 0
        ' 
        ' txtValue2
        ' 
        txtValue2.Location = New Point(781, 156)
        txtValue2.Margin = New Padding(7, 8, 7, 8)
        txtValue2.Name = "txtValue2"
        txtValue2.PlaceholderText = "Integer 2"
        txtValue2.Size = New Size(237, 47)
        txtValue2.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(467, 265)
        btnAdd.Margin = New Padding(7, 8, 7, 8)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(237, 75)
        btnAdd.TabIndex = 2
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(781, 265)
        btnSubtract.Margin = New Padding(7, 8, 7, 8)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(237, 75)
        btnSubtract.TabIndex = 3
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(467, 385)
        btnMultiply.Margin = New Padding(7, 8, 7, 8)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(237, 75)
        btnMultiply.TabIndex = 4
        btnMultiply.Text = "x"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(781, 385)
        btnDivide.Margin = New Padding(7, 8, 7, 8)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(237, 75)
        btnDivide.TabIndex = 5
        btnDivide.Text = "÷"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(692, 499)
        lblResult.Margin = New Padding(7, 0, 7, 0)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(98, 41)
        lblResult.TabIndex = 6
        lblResult.Text = "Result"
        ' 
        ' chkEstimate1
        ' 
        chkEstimate1.AutoSize = True
        chkEstimate1.Location = New Point(467, 95)
        chkEstimate1.Margin = New Padding(7, 8, 7, 8)
        chkEstimate1.Name = "chkEstimate1"
        chkEstimate1.Size = New Size(227, 45)
        chkEstimate1.TabIndex = 7
        chkEstimate1.Text = "Estimate Int1"
        chkEstimate1.UseVisualStyleBackColor = True
        ' 
        ' chkEstimate2
        ' 
        chkEstimate2.AutoSize = True
        chkEstimate2.Location = New Point(781, 95)
        chkEstimate2.Margin = New Padding(7, 8, 7, 8)
        chkEstimate2.Name = "chkEstimate2"
        chkEstimate2.Size = New Size(227, 45)
        chkEstimate2.TabIndex = 8
        chkEstimate2.Text = "Estimate Int2"
        chkEstimate2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1943, 1230)
        Controls.Add(chkEstimate2)
        Controls.Add(chkEstimate1)
        Controls.Add(lblResult)
        Controls.Add(btnDivide)
        Controls.Add(btnMultiply)
        Controls.Add(btnSubtract)
        Controls.Add(btnAdd)
        Controls.Add(txtValue2)
        Controls.Add(txtValue1)
        Margin = New Padding(7, 8, 7, 8)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtValue1 As TextBox
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents chkEstimate1 As CheckBox
    Friend WithEvents chkEstimate2 As CheckBox

End Class
