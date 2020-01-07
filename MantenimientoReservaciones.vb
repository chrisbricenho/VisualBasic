Public Class MantenimientoReservaciones
    Private mId As Integer
    Private mDesde As DateTime
    Private mHasta As DateTime
    Private mId_Habitacion As Integer
    Private mEstado As EstadoReservaciones
    Private mNombreResponsable As String
    Private mFechaCreacion As Date
    Private mTipoHabitacion As TipoHabitaciones

    Property Id As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Property Desde As Date
        Get
            Return mDesde
        End Get
        Set(ByVal value As Date)
            mDesde = value
        End Set
    End Property

    Property Hasta As Date
        Get
            Return mHasta
        End Get
        Set(ByVal value As Date)
            mHasta = value
        End Set
    End Property

    Property Id_Habitacion As Integer
        Get
            Return mId_Habitacion
        End Get
        Set(ByVal value As Integer)
            mId_Habitacion = value
        End Set
    End Property

    Property Estado As EstadoReservaciones
        Get
            Return mEstado
        End Get
        Set(ByVal value As EstadoReservaciones)
            mEstado = value
        End Set
    End Property

    Property NombreResponsable As String
        Get
            Return mNombreResponsable
        End Get
        Set(ByVal value As String)
            mNombreResponsable = value
        End Set
    End Property

    Property FechaCreacion As Date
        Get
            Return mFechaCreacion
        End Get
        Set(ByVal value As Date)
            mFechaCreacion = value
        End Set
    End Property

    Property TipoHabitacion As TipoHabitaciones
        Get
            Return mTipoHabitacion
        End Get
        Set(ByVal value As TipoHabitaciones)
            mTipoHabitacion = value
        End Set
    End Property

End Class
