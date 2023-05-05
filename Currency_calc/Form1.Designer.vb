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
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.txtUSCurrency = New System.Windows.Forms.TextBox()
        Me.lblUSCurrency = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblConversionResults = New System.Windows.Forms.Label()
        Me.picFlags = New System.Windows.Forms.PictureBox()
        Me.lblCurrencyChoice = New System.Windows.Forms.Label()
        Me.lblInstruct = New System.Windows.Forms.Label()
        CType(Me.picFlags, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCountry
        '
        Me.cboCountry.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Items.AddRange(New Object() {"Paraguay", "Bolivia", "Argentina"})
        Me.cboCountry.Location = New System.Drawing.Point(460, 130)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(167, 24)
        Me.cboCountry.TabIndex = 0
        Me.cboCountry.Text = "Choose the country:"
        '
        'txtUSCurrency
        '
        Me.txtUSCurrency.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSCurrency.Location = New System.Drawing.Point(542, 230)
        Me.txtUSCurrency.Name = "txtUSCurrency"
        Me.txtUSCurrency.Size = New System.Drawing.Size(100, 23)
        Me.txtUSCurrency.TabIndex = 1
        Me.txtUSCurrency.Visible = False
        '
        'lblUSCurrency
        '
        Me.lblUSCurrency.AutoSize = True
        Me.lblUSCurrency.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSCurrency.Location = New System.Drawing.Point(278, 234)
        Me.lblUSCurrency.Name = "lblUSCurrency"
        Me.lblUSCurrency.Size = New System.Drawing.Size(247, 19)
        Me.lblUSCurrency.TabIndex = 2
        Me.lblUSCurrency.Text = "Enter the U.S. dollar amount:"
        Me.lblUSCurrency.Visible = False
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(344, 342)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(100, 30)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        Me.btnConvert.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(542, 342)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'lblConversionResults
        '
        Me.lblConversionResults.AutoSize = True
        Me.lblConversionResults.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversionResults.Location = New System.Drawing.Point(349, 415)
        Me.lblConversionResults.Name = "lblConversionResults"
        Me.lblConversionResults.Size = New System.Drawing.Size(63, 19)
        Me.lblConversionResults.TabIndex = 5
        Me.lblConversionResults.Text = "Label1"
        Me.lblConversionResults.Visible = False
        '
        'picFlags
        '
        Me.picFlags.BackgroundImage = Global.Currency_calc.My.Resources.Resources.Untitled_1
        Me.picFlags.Location = New System.Drawing.Point(7, 7)
        Me.picFlags.Name = "picFlags"
        Me.picFlags.Size = New System.Drawing.Size(248, 500)
        Me.picFlags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlags.TabIndex = 6
        Me.picFlags.TabStop = False
        '
        'lblCurrencyChoice
        '
        Me.lblCurrencyChoice.AutoSize = True
        Me.lblCurrencyChoice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrencyChoice.Location = New System.Drawing.Point(408, 197)
        Me.lblCurrencyChoice.Name = "lblCurrencyChoice"
        Me.lblCurrencyChoice.Size = New System.Drawing.Size(63, 19)
        Me.lblCurrencyChoice.TabIndex = 7
        Me.lblCurrencyChoice.Text = "Label1"
        Me.lblCurrencyChoice.Visible = False
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(407, 85)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(281, 19)
        Me.lblInstruct.TabIndex = 8
        Me.lblInstruct.Text = "Select the country of your choice:"
        Me.lblInstruct.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(791, 519)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.lblCurrencyChoice)
        Me.Controls.Add(Me.picFlags)
        Me.Controls.Add(Me.lblConversionResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblUSCurrency)
        Me.Controls.Add(Me.txtUSCurrency)
        Me.Controls.Add(Me.cboCountry)
        Me.Name = "Form1"
        Me.Text = "South America Currency Calculator"
        CType(Me.picFlags, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCountry As ComboBox
    Friend WithEvents txtUSCurrency As TextBox
    Friend WithEvents lblUSCurrency As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblConversionResults As Label
    Friend WithEvents picFlags As PictureBox
    Friend WithEvents lblCurrencyChoice As Label
    Friend WithEvents lblInstruct As Label
End Class
