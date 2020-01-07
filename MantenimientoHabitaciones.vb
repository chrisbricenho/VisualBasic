Public Class MantenimientoHabitaciones

    Private mId As Integer
    Private mEstado As EstadoHabitaciones
    Private mTipo As TipoHabitaciones
    Private mNumero As Integer

    Property Id As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Property Estado As EstadoHabitaciones
        Get
            Return mEstado
        End Get
        Set(ByVal value As EstadoHabitaciones)
            mEstado = value
        End Set
    End Property

    Property Tipo As TipoHabitaciones
        Get
            Return mTipo
        End Get
        Set(ByVal value As TipoHabitaciones)
            mTipo = value
        End Set
    End Property


    Property Numero As Integer
        Get
            Return mNumero
        End Get
        Set(ByVal value As Integer)
            mNumero = value
        End Set
    End Property
End Class
