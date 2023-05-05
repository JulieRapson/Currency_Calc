'Author: Julie Rapson
'Date: 5/04/2023
'Program Description: This is a south american currency calculator and will convert U.S. dollars into 
'3 other countries currencies: Paraguay, Bolivia, Argentina.  It will return the result and you can then exit
'the program or try with a different country.
Option Strict On
Option Explicit On
Public Class Form1
    'variables for the currency conversions. These numbers were based on a google search
    'to know how to convert. They also seem to fluctuate. I have had to update them :) 
    Private _decParaguay As Decimal = 7204.36D
    Private _decBolivia As Decimal = 6.91D
    Private _decArgentina As Decimal = 220.88D
    Private Sub cboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountry.SelectedIndexChanged
        'below is checking to see which Index was selected, then return the correct text corresponding to the selection
        'it will start showing some labels and buttons.
        If cboCountry.SelectedIndex = 0 Then
            lblCurrencyChoice.Text = "U.S. Dollars to PYG (Paraguay Guarani)"
            lblCurrencyChoice.Visible = True
            lblUSCurrency.Visible = True
            txtUSCurrency.Visible = True
            btnClear.Visible = True
            btnConvert.Visible = True
            txtUSCurrency.Focus()
        End If
        If cboCountry.SelectedIndex = 1 Then
            lblCurrencyChoice.Text = "U.S. Dollars to BOB (Bolivian Boliviano)"
            lblCurrencyChoice.Visible = True
            lblUSCurrency.Visible = True
            txtUSCurrency.Visible = True
            btnClear.Visible = True
            btnConvert.Visible = True
            txtUSCurrency.Focus()
        End If
        If cboCountry.SelectedIndex = 2 Then
            lblCurrencyChoice.Text = "U.S. Dollars to ARS (Argentine Peso)"
            lblCurrencyChoice.Visible = True
            lblUSCurrency.Visible = True
            txtUSCurrency.Visible = True
            btnClear.Visible = True
            btnConvert.Visible = True
            txtUSCurrency.Focus()
        End If

    End Sub
    Private Sub ClearScreen()
        'Clearing out all previous selections/entries and resetting focus
        txtUSCurrency.Clear()
        lblConversionResults.Visible = False
        lblCurrencyChoice.Visible = False
        btnClear.Visible = False
        btnConvert.Visible = False
        'just mentioning here the clear button will also set index to -1 and populate instructions.
        cboCountry.SelectedIndex = -1
        cboCountry.Text = "Choose a country:"
        lblInstruct.Visible = True
        lblUSCurrency.Visible = False
        txtUSCurrency.Visible = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This just calls the clear screen function above.
        ClearScreen()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is to set the timer on the splash screen to keep it up a little longer 
        'and set the instructions to visible.
        Threading.Thread.Sleep(4000)
        lblInstruct.Visible = True
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'When clicking the convert button, this will go into a check for the number being valid,
        'if it is, it will continue and see which index was selected and then send the value to the 
        'appropriate function to have the currency calculated. 
        Dim blnIsValid As Boolean = False
        Dim intValidNum As Decimal
        Dim decCurrencyConverted As Decimal
        blnIsValid = ValidateInput()

        If blnIsValid = True Then
            intValidNum = Convert.ToDecimal(txtUSCurrency.Text)
            If cboCountry.SelectedIndex = 0 Then
                decCurrencyConverted = CalculateCurrencyP(intValidNum)
            ElseIf cboCountry.SelectedIndex = 1 Then
                decCurrencyConverted = CalculateCurrencyB(intValidNum)
            Else
                decCurrencyConverted = CalculateCurrencyA(intValidNum)
            End If
            lblConversionResults.Visible = True
            lblConversionResults.Text = "The conversion is " & decCurrencyConverted.ToString("C")
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        'This function validates the input is usable by checking if the number is
        'greater that zero and sets the variable to True and returns that back to the caller. 
        Dim intIsNum As Decimal
        Dim blnIsValid As Boolean = False
        'try catch implemented here to catch format, overflow and system exceptions.  Has proper
        'error messages that will be displayed as well. 
        Try
            intIsNum = Convert.ToDecimal(txtUSCurrency.Text)
            If intIsNum > 0D Then
                blnIsValid = True
                Return blnIsValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid number", , "Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a smaller number")
        Catch Exception As SystemException
            MsgBox("This is an invalid entry. Please enter a valid number.", , "Error")
        End Try
        txtUSCurrency.Focus()
        txtUSCurrency.Text = ""
        Return blnIsValid
    End Function
    'Function for Paraguay calculation
    Private Function CalculateCurrencyP(ByVal intPAmount As Decimal) As Decimal
        Dim decPAmount As Decimal
        decPAmount = intPAmount * _decParaguay
        Return decPAmount
    End Function

    'Function for Bolivia calculation
    Private Function CalculateCurrencyB(ByVal intBAmount As Decimal) As Decimal
        Dim decBAmount As Decimal
        decBAmount = intBAmount * _decBolivia
        Return decBAmount
    End Function

    'Function for Argentina calculation
    Private Function CalculateCurrencyA(ByVal intAAmount As Decimal) As Decimal
        Dim decAAmount As Decimal
        decAAmount = intAAmount * _decArgentina
        Return decAAmount
    End Function

End Class
