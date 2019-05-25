Public Class clsOrderDetail
    'This class has the properties for an item ordered
    'It stores, retrieves, and manages all information regarding the details of each type of item ordered
    'It also validates its own elements

    Private iLine As Integer        'Store the item line
    Private sItem As String         'Store item description info
    Private iQty As Integer         'store quantity
    Private dPrice As Double        'Store price
    Private sError As String        'store errors in this class

    Public Sub New()
        'Set default values
        sItem = ""
        iQty = 0
        dPrice = 0
        sError = ""
    End Sub

    '===================================================
    ' Object properties getters/setters
    '===================================================

    Public Property Item()
        'Set / Get item description
        Get
            Return sItem
        End Get
        Set(ByVal value)
            'Validate
            If isValidItem(value) Then
                sItem = value
            End If
        End Set
    End Property

    Public Property Qty()
        'Set / Get item quantity
        Get
            Return iQty
        End Get
        Set(ByVal value)
            'Validate
            If isValidQty(value) Then
                iQty = Convert.ToInt32(value)
            End If
        End Set
    End Property

    Public Property Price()
        'Set / Get item Price
        Get
            Return dPrice
        End Get
        Set(ByVal value)
            'Validate
            If isValidPrice(value) Then
                dPrice = Convert.ToDecimal(value)
            End If
        End Set
    End Property

    Public Property line()
        'Gets line number
        Get
            Return iLine
        End Get
        Set(ByVal value)
            iLine = Convert.ToInt32(value)
        End Set
    End Property

    '===================================================
    ' Helper functions
    '===================================================
    Public Function total() As Double
        'Calculate the total of this detail item
        Return Qty * Price
    End Function

    Public Function getError() As String
        'return all errors that happen in the class
        Return sError
    End Function

    Private Sub addError(ByVal s As String)
        'format our error message with line breaks
        If sError = "" Then
            sError = s
        Else
            sError += vbCrLf & s
        End If
    End Sub


    '===================================================
    ' Validation routines at the class level :)
    '===================================================

    Private Function isValidItem(ByVal s As String) As Boolean
        Dim bResult As Boolean
        'Validation of item description
        'you can add try/catch 
        If s <> "" Then
            bResult = True
        Else
            addError("Line:" & iLine & ":Item: Description cannot be blank")
            bResult = False
        End If
        Return bresult
    End Function

    Private Function isValidPrice(ByVal s As String) As Boolean
        Dim bResult As Boolean
        'Validation of Price
        'you can add a try / catch like the quantity validation
        If s <> "" Then
            bResult = True
        Else
            addError("Line:" & iLine & ":Price: Price cannot be blank")
            bResult = False
        End If
        Return bResult
    End Function
    Private Function isValidQty(ByVal s As String) As Boolean
        'Function that validates quantity
        Dim bResult As Boolean
        Try
            If (s = "") Then
                addError("Line:" & iLine & ":Qty: Quantity cannot be blank")
                bResult = False
            Else
                Dim aNum As Integer = 0

                If (Integer.TryParse(s, aNum)) Then
                    If (aNum <= 0) Then
                        addError("Qty: Cannot be 0 or less for line " & iLine)
                        bResult = False
                    Else
                        bResult = True
                    End If
                Else
                    addError("Qty:" & iLine & "Invalid format, must enter valid integers")
                    bResult = False
                End If

            End If
        Catch ex As Exception
            addError("Line:" & iLine & ":Qty: Invalid Qty")
            bResult = False
        End Try

        Return bResult
    End Function
End Class
