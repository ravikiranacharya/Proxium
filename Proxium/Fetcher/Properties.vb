Module Properties
    Private _NumberOfLinks As Integer
    Public Property NumberOfLinks() As Integer
        Get
            Return _NumberOfLinks
        End Get
        Set(ByVal value As Integer)
            _NumberOfLinks = value
        End Set
    End Property

    Private _NumberOfThreads As Integer
    Public Property NumberOfThreads() As Integer
        Get
            Return _NumberOfThreads
        End Get
        Set(ByVal value As Integer)
            _NumberOfThreads = value
        End Set
    End Property

    Private _MaximumThreads As Integer
    Public Property MaximumThreads() As Integer
        Get
            Return _MaximumThreads
        End Get
        Set(ByVal value As Integer)
            _MaximumThreads = value
        End Set
    End Property

End Module