Public Structure Auto

    Private mreeks As String
    Public Property reeks() As String
        Get
            Return mreeks
        End Get
        Set(ByVal value As String)
            mreeks = value
        End Set
    End Property

    Private mairco As Boolean
    Public Property airco() As Boolean
        Get
            Return mairco
        End Get
        Set(ByVal value As Boolean)
            mairco = value
        End Set
    End Property

    Private mleder As Boolean
    Public Property leder() As Boolean
        Get
            Return mleder
        End Get
        Set(ByVal value As Boolean)
            mleder = value
        End Set
    End Property

    Private mled As Boolean
    Public Property led() As Boolean
        Get
            Return mled
        End Get
        Set(ByVal value As Boolean)
            mled = value
        End Set
    End Property

    Private mtraktie As Boolean
    Public Property traktie() As Boolean
        Get
            Return mtraktie
        End Get
        Set(ByVal value As Boolean)
            mtraktie = value
        End Set
    End Property

    Private mtitanium As Boolean
    Public Property titanium() As Boolean
        Get
            Return mtitanium
        End Get
        Set(ByVal value As Boolean)
            mtitanium = value
        End Set
    End Property

    Private mvoet As Boolean
    Public Property voet() As Boolean
        Get
            Return mvoet
        End Get
        Set(ByVal value As Boolean)
            mvoet = value
        End Set

    End Property



    Function totaalprijsberekenen(ByVal mreeks As String, ByVal mairco As Boolean, ByVal mleder As Boolean, ByVal mled As Boolean, ByVal mairco As Boolean, ) As Integer

        Return 0
    End Function
















End Structure
