Public Class component


    Public Sub New()
        mprijs = 0
        mbenaming = ""


    End Sub

    Public Sub New(ByVal benaming As String, ByVal prijs As Decimal)
        mprijs = 0
        mbenaming = ""


    End Sub

    Private mbenaming As String
    Public Property benaming() As String
        Get
            Return mbenaming
        End Get
        Set(ByVal value As String)
            mbenaming = value
        End Set
    End Property

    Private mprijs As Decimal
    Public Property prijs() As Decimal
        Get
            Return mprijs
        End Get
        Set(ByVal value As Decimal)
            mprijs = value
        End Set
    End Property
    'zal gevraagd worden op examen !!!!
    Public Overrides Function ToString() As String
        Return mbenaming.PadRight(30, ".") & "€" & CStr(Me.prijs).PadLeft(8, " ")
    End Function



End Class
