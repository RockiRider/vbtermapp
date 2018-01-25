Public Class CustomerClass
    Private Forename As String
    Private Surname As String
    Private Street As String
    Private City As String
    Private Postcode As String
    Private Number As Integer
    Private Returning As Boolean
    Public Sub setForename(ByVal value As String)
        Forename = value
    End Sub
    Public Function getForename()
        Return Forename
    End Function
    Public Sub setSurname(ByVal value As String)
        Surname = value
    End Sub
    Public Function getSurname()
        Return Surname
    End Function
    Public Sub setStreet(ByVal value As String)
        Street = value
    End Sub
    Public Function getStreet()
        Return Street
    End Function
    Public Sub setCity(ByVal value As String)
        City = value
    End Sub
    Public Function getCity()
        Return City
    End Function
    Public Sub setPostcode(ByVal value As String)
        Postcode = value
    End Sub
    Public Function getPostcode()
        Return Postcode
    End Function
    Public Sub setNumber(ByVal value As Integer)
        Number = value
    End Sub
    Public Function getNumber()
        Return Number
    End Function
    Public Sub setReturning(ByVal value As Boolean)
        Returning = value
    End Sub
    Public Function getReturning()
        Return Returning
    End Function
End Class

Public Class FlightClass
    Private Airline As String
    Private Departurefrom As String
    Private Arrivalat As String
    Private DD As Date
    Private TD As Date
    Private DA As Date
    Private TA As Date
    Private CostF As Decimal

    Public Sub setAirline(ByVal value As String)
        Airline = value
    End Sub
    Public Function getAirline()
        Return Airline
    End Function
    Public Sub setDeparturefrom(ByVal value As String)
        Departurefrom = value
    End Sub
    Public Function getDeparturefrom()
        Return Departurefrom
    End Function
    Public Sub setArrivalat(ByVal value As String)
        Arrivalat = value
    End Sub
    Public Function getArrivalat()
        Return Arrivalat
    End Function
    Public Sub setDD(ByVal value As Date)
        DD = value
    End Sub
    Public Function getDD()
        Return DD
    End Function
    Public Sub setTD(ByVal value As Date)
        TD = value
    End Sub
    Public Function getTD()
        Return TD
    End Function

    Public Sub setDA(ByVal value As Date)
        DA = value
    End Sub
    Public Function getDA()
        Return DA
    End Function

    Public Sub setTA(ByVal value As Date)
        TA = value
    End Sub

    Public Function getTA()
        Return TA
    End Function

    Public Sub setCostF(ByVal value As Decimal)
        CostF = value
    End Sub

    Public Function getCostF()
        Return CostF
    End Function

End Class
Public Class placeClass
    Private Country As String
    Private Destination As String
    Private Hotel As String
    Private Cost As String

    Public Sub setCountry(ByVal value As String)
        Country = value
    End Sub
    Public Function getCountry()
        Return Country
    End Function

    Public Sub setDestination(ByVal value As String)
        Destination = value
    End Sub
    Public Function getDestination()
        Return Destination
    End Function
    Public Sub setHotel(ByVal value As String)
        Hotel = value
    End Sub
    Public Function getHotel()
        Return Hotel
    End Function
    Public Sub setCost(ByVal value As String)
        Cost = value
    End Sub
    Public Function getCost()
        Return Cost
    End Function
End Class
Public Class HolidayClass
    Public objCustomer As New CustomerClass
    Public objPlace As New placeClass
    Public objFlight As New FlightClass

    Public Overridable Function calcTotal() As Double
        Return (objPlace.getCost + objFlight.getCostF) * objCustomer.getNumber
    End Function
End Class
Public Class WinterClass
    Inherits HolidayClass
    Private SkiHire As Integer
    Private SkiPass As Integer
    Private SkiTutor As Integer
    Public Sub setSkiTutor(ByVal value As Integer)
        SkiTutor = value
    End Sub
    Public Function getSkiTutor()
        Return SkiTutor
    End Function
    Public Sub setSkiHire(ByVal value As Integer)
        SkiHire = value
    End Sub
    Public Function getSkiHire()
        Return SkiHire
    End Function
    Public Sub setSkiPass(ByVal value As Integer)
        SkiPass = value
    End Sub
    Public Function getSkiPass()
        Return SkiPass
    End Function
    Overrides Function calcTotal() As Double
        Return (getSkiHire() + getSkiPass() + getSkiTutor() + objPlace.getCost + objFlight.getCostF) * objCustomer.getNumber
    End Function
End Class
Public Class SummerClass
    Inherits HolidayClass
    Private ClimbingGear As Integer
    Private ClimbingGuide As Integer
    Public Sub setClimbingGear(ByVal value As Integer)
        ClimbingGear = value
    End Sub
    Public Function getClimbingGear()
        Return ClimbingGear
    End Function
    Public Sub setClimbingGuide(ByVal value As Integer)
        ClimbingGuide = value
    End Sub
    Public Function getClimbingGuide()
        Return ClimbingGuide
    End Function
    Public Overrides Function calcTotal() As Double
        Return (getClimbingGear() + getClimbingGuide() + objPlace.getCost + objFlight.getCostF) * objCustomer.getNumber

    End Function
End Class