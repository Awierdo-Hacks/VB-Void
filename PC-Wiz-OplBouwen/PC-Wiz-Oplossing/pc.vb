Public Class pc

    Public Sub New()
        mCasing = New component
        mssd = New component
        mcpu = New component
        mmoederbord = New component
        mgrafischekaart = New component
        mgeheugen = New component

    End Sub


    Private mCasing As component
    Public Property casing() As component
        Get

            Return mCasing
        End Get
        Set(ByVal value As component)
            mCasing = value
        End Set
    End Property

    Private mssd As component
    Public Property ssd() As component
        Get
            'me.mssd.prijs komt hier dit is andere weg dan ssd.prijs
            Return mssd
        End Get
        Set(ByVal value As component)
            mssd = value
        End Set
    End Property

    Private mgrafischekaart As component
    Public Property grafischekaart() As component
        Get
            Return mgrafischekaart
        End Get
        Set(ByVal value As component)
            mgrafischekaart = value
        End Set
    End Property

    Private mgeheugen As component
    Public Property geheugen() As component
        Get
            Return mgeheugen
        End Get
        Set(ByVal value As component)
            mgeheugen = value
        End Set
    End Property

    Private mcpu As component
    Public Property cpu() As component
        Get
            Return mcpu
        End Get
        Set(ByVal value As component)
            mcpu = value
        End Set
    End Property

    Private mmoederbord As component
    Public Property moederbord() As component
        Get
            Return mmoederbord
        End Get
        Set(ByVal value As component)
            mmoederbord = value
        End Set
    End Property

    Public Function berekentotaalprijs() As Decimal
        Dim totaalprijs As Decimal
        totaalprijs += mCasing.prijs
        totaalprijs += mcpu.prijs
        totaalprijs += mgeheugen.prijs
        totaalprijs += Me.mgrafischekaart.prijs
        totaalprijs += Me.mmoederbord.prijs
        totaalprijs += Me.ssd.prijs
        Return 0
    End Function

End Class
