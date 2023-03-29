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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLoyalty = New System.Windows.Forms.Label()
        Me.lblPlease = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpFood = New System.Windows.Forms.GroupBox()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radSausage = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radPinwheel = New System.Windows.Forms.RadioButton()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.grpPay = New System.Windows.Forms.GroupBox()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.radPre = New System.Windows.Forms.RadioButton()
        Me.picPlatter = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.grpFood.SuspendLayout()
        Me.grpPay.SuspendLayout()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(140, 28)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(119, 32)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Catering"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(140, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 23)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Star Market"
        '
        'lblLoyalty
        '
        Me.lblLoyalty.AutoSize = True
        Me.lblLoyalty.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLoyalty.Location = New System.Drawing.Point(438, 261)
        Me.lblLoyalty.Name = "lblLoyalty"
        Me.lblLoyalty.Size = New System.Drawing.Size(115, 18)
        Me.lblLoyalty.TabIndex = 2
        Me.lblLoyalty.Text = "Loyalty Points"
        '
        'lblPlease
        '
        Me.lblPlease.AutoSize = True
        Me.lblPlease.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPlease.Location = New System.Drawing.Point(94, 424)
        Me.lblPlease.Name = "lblPlease"
        Me.lblPlease.Size = New System.Drawing.Size(97, 23)
        Me.lblPlease.TabIndex = 3
        Me.lblPlease.Text = "Please Pay:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(213, 424)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(512, 52)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Your order of XXXXX platter costs $XX.XX using" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XXXXXXXX after discount of XX loy" &
    "alty points."
        '
        'grpFood
        '
        Me.grpFood.BackColor = System.Drawing.SystemColors.Info
        Me.grpFood.Controls.Add(Me.radFruit)
        Me.grpFood.Controls.Add(Me.radSausage)
        Me.grpFood.Controls.Add(Me.radVeggie)
        Me.grpFood.Controls.Add(Me.radPinwheel)
        Me.grpFood.Controls.Add(Me.radCheese)
        Me.grpFood.Location = New System.Drawing.Point(40, 102)
        Me.grpFood.Name = "grpFood"
        Me.grpFood.Size = New System.Drawing.Size(295, 200)
        Me.grpFood.TabIndex = 5
        Me.grpFood.TabStop = False
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radFruit.Location = New System.Drawing.Point(16, 146)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(137, 21)
        Me.radFruit.TabIndex = 4
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "Fruit $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radSausage
        '
        Me.radSausage.AutoSize = True
        Me.radSausage.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radSausage.Location = New System.Drawing.Point(16, 116)
        Me.radSausage.Name = "radSausage"
        Me.radSausage.Size = New System.Drawing.Size(254, 21)
        Me.radSausage.TabIndex = 3
        Me.radSausage.TabStop = True
        Me.radSausage.Text = "Sausage and Cheese $49.99"
        Me.radSausage.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radVeggie.Location = New System.Drawing.Point(16, 86)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(146, 21)
        Me.radVeggie.TabIndex = 2
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "Veggie $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radPinwheel
        '
        Me.radPinwheel.AutoSize = True
        Me.radPinwheel.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radPinwheel.Location = New System.Drawing.Point(16, 56)
        Me.radPinwheel.Name = "radPinwheel"
        Me.radPinwheel.Size = New System.Drawing.Size(218, 21)
        Me.radPinwheel.TabIndex = 1
        Me.radPinwheel.TabStop = True
        Me.radPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.radPinwheel.UseVisualStyleBackColor = True
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radCheese.Location = New System.Drawing.Point(16, 26)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(218, 21)
        Me.radCheese.TabIndex = 0
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "Gourmet Cheese $49.99"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'grpPay
        '
        Me.grpPay.BackColor = System.Drawing.SystemColors.Info
        Me.grpPay.Controls.Add(Me.radPickup)
        Me.grpPay.Controls.Add(Me.radPre)
        Me.grpPay.Location = New System.Drawing.Point(94, 308)
        Me.grpPay.Name = "grpPay"
        Me.grpPay.Size = New System.Drawing.Size(180, 100)
        Me.grpPay.TabIndex = 6
        Me.grpPay.TabStop = False
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radPickup.Location = New System.Drawing.Point(15, 56)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(164, 21)
        Me.radPickup.TabIndex = 1
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pay upon Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'radPre
        '
        Me.radPre.AutoSize = True
        Me.radPre.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radPre.Location = New System.Drawing.Point(15, 26)
        Me.radPre.Name = "radPre"
        Me.radPre.Size = New System.Drawing.Size(92, 21)
        Me.radPre.TabIndex = 0
        Me.radPre.TabStop = True
        Me.radPre.Text = "Pre-Pay"
        Me.radPre.UseVisualStyleBackColor = True
        '
        'picPlatter
        '
        Me.picPlatter.Image = CType(resources.GetObject("picPlatter.Image"), System.Drawing.Image)
        Me.picPlatter.Location = New System.Drawing.Point(381, 12)
        Me.picPlatter.Name = "picPlatter"
        Me.picPlatter.Size = New System.Drawing.Size(364, 230)
        Me.picPlatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlatter.TabIndex = 7
        Me.picPlatter.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(422, 345)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(109, 30)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(577, 345)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 30)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPoints.Location = New System.Drawing.Point(592, 257)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(43, 28)
        Me.txtPoints.TabIndex = 10
        Me.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(757, 499)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.picPlatter)
        Me.Controls.Add(Me.grpPay)
        Me.Controls.Add(Me.grpFood)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPlease)
        Me.Controls.Add(Me.lblLoyalty)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.Text = "Catering"
        Me.grpFood.ResumeLayout(False)
        Me.grpFood.PerformLayout()
        Me.grpPay.ResumeLayout(False)
        Me.grpPay.PerformLayout()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblLoyalty As Label
    Friend WithEvents lblPlease As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents grpFood As GroupBox
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radSausage As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radPinwheel As RadioButton
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents grpPay As GroupBox
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents radPre As RadioButton
    Friend WithEvents picPlatter As PictureBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtPoints As TextBox
End Class
