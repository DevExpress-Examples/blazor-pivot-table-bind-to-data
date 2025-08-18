Imports System
Imports System.ComponentModel.DataAnnotations

Namespace PivotTableBindToData.Northwind

    Public Partial Class Invoice

        Public Property ShipName As String

        Public Property ShipAddress As String

        Public Property ShipCity As String

        Public Property ShipRegion As String

        Public Property ShipPostalCode As String

        Public Property ShipCountry As String

        Public Property CustomerId As String

        Public Property CustomerName As String

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String

        Public Property Salesperson As String

        Public Property OrderId As Integer

        <Required>
        <Range(GetType(DateTime), "1/1/1996", "1/1/1999", ErrorMessage:="Order Date must be between {1:d} and {2:d}")>
        Public Property OrderDate As DateTime?

        Public Property RequiredDate As DateTime?

        Public Property ShippedDate As DateTime?

        Public Property ShipperName As String

        Public Property ProductId As Integer

        <Required>
        Public Property ProductName As String

        Public Property UnitPrice As Decimal

        Public Property Quantity As Short

        Public Property Discount As Single

        Public Property ExtendedPrice As Decimal?

        Public Property Freight As Decimal?
    End Class
End Namespace
