Public Class EstimatedInteger
    Private value As Integer
    Private isEstimate As Boolean

    Public Sub New(ByVal value As Integer, ByVal isEstimate As Boolean)
        Me.value = value
        Me.isEstimate = isEstimate
    End Sub

    ' Properties
    Public Property IntegerValue() As Integer
        Get
            Return value
        End Get
        Set(ByVal newValue As Integer)
            value = newValue
        End Set
    End Property

    Public Property IsEstimateFlag() As Boolean
        Get
            Return isEstimate
        End Get
        Set(ByVal newFlag As Boolean)
            isEstimate = newFlag
        End Set
    End Property

    Public Overrides Function ToString() As String
        If isEstimate Then
            Return "Around " & value.ToString()
        Else
            Return value.ToString()
        End If
    End Function

    ' Addition
    Public Shared Operator +(ByVal a As EstimatedInteger, ByVal b As EstimatedInteger) As EstimatedInteger
        Dim resultValue = a.value + b.value
        Dim resultIsEstimate = a.isEstimate Or b.isEstimate
        Return New EstimatedInteger(resultValue, resultIsEstimate)
    End Operator

    ' Subtraction
    Public Shared Operator -(ByVal a As EstimatedInteger, ByVal b As EstimatedInteger) As EstimatedInteger
        Dim resultValue = a.value - b.value
        Dim resultIsEstimate = a.isEstimate Or b.isEstimate
        Return New EstimatedInteger(resultValue, resultIsEstimate)
    End Operator

    ' Multiplication
    Public Shared Operator *(ByVal a As EstimatedInteger, ByVal b As EstimatedInteger) As EstimatedInteger
        Dim resultValue = a.value * b.value
        Dim resultIsEstimate = a.isEstimate Or b.isEstimate
        Return New EstimatedInteger(resultValue, resultIsEstimate)
    End Operator

    ' Division
    Public Shared Operator /(ByVal a As EstimatedInteger, ByVal b As EstimatedInteger) As EstimatedInteger
        If b.value = 0 Then
            'bawal divide sa 0
            Throw New DivideByZeroException("Cannot divide by zero.")
        End If
        Dim resultValue = a.value \ b.value
        Dim resultIsEstimate = a.isEstimate Or b.isEstimate
        Return New EstimatedInteger(resultValue, resultIsEstimate)
    End Operator
End Class
