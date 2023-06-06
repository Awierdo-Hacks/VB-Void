Public Structure Computer

    Public Shared totaal As Decimal

    Private mcpu As String
    Public Property cpu() As String
        Get
            Return mcpu
        End Get
        Set(ByVal value As String)
            mcpu = value
        End Set
    End Property
    Private mcpuprijs As String
    Public Property cpuprijs() As String
        Get
            Return mcpuprijs
        End Get
        Set(ByVal value As String)
            mcpuprijs = value
        End Set
    End Property

    Private mssd As String
    Public Property ssd() As String
        Get
            Return mssd
        End Get
        Set(ByVal value As String)
            mssd = value
        End Set
    End Property

    Private mssdprijs As String
    Public Property ssdprijs() As String
        Get
            Return mssdprijs
        End Get
        Set(ByVal value As String)
            mssdprijs = value
        End Set
    End Property

    Private mgeheugen As String
    Public Property geheugen() As String
        Get
            Return mgeheugen
        End Get
        Set(ByVal value As String)
            mgeheugen = value
        End Set
    End Property
    Private mgeheugenprijs As String
    Public Property geheugenprijs() As String
        Get
            Return mgeheugenprijs
        End Get
        Set(ByVal value As String)
            mgeheugenprijs = value
        End Set
    End Property

    Private mmoederbord As String
    Public Property moederbord() As String
        Get
            Return mmoederbord
        End Get
        Set(ByVal value As String)
            mmoederbord = value
        End Set
    End Property
    Private mmoederbordprijs As String
    Public Property moederbordprijs() As String
        Get
            Return mmoederbordprijs
        End Get
        Set(ByVal value As String)
            mmoederbordprijs = value
        End Set
    End Property

    Private mbehuizing As String
    Public Property behuizing() As String
        Get
            Return mbehuizing
        End Get
        Set(ByVal value As String)
            mbehuizing = value
        End Set
    End Property
    Private mbehuizingprijs As String
    Public Property behuizingprijs() As String
        Get
            Return mbehuizingprijs
        End Get
        Set(ByVal value As String)
            mbehuizingprijs = value
        End Set
    End Property

    Private mgrafisch As String
    Public Property grafisch() As String
        Get
            Return mgrafisch
        End Get
        Set(ByVal value As String)
            mgrafisch = value
        End Set
    End Property
    Private mgrafischprijs As String
    Public Property grafischprijs() As String
        Get
            Return mgrafischprijs
        End Get
        Set(ByVal value As String)
            mgrafischprijs = value
        End Set
    End Property

    Public Function totaalberekenen()
        totaal = CDec(mcpuprijs + mssdprijs + mgeheugenprijs + mmoederbordprijs + mbehuizingprijs + mgrafischprijs) / 100


        Return totaal

    End Function

End Structure
