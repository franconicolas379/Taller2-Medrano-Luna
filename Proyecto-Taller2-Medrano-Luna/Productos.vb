'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Productos
    Public Property id_producto As Integer
    Public Property id_categoria As Integer
    Public Property descripcion As String
    Public Property precio_costo As Integer
    Public Property precio_venta As Integer
    Public Property stock As Integer
    Public Property stock_min As Integer
    Public Property eliminado As Boolean

    Public Overridable Property Categorias As Categorias
    Public Overridable Property Ventas__detalle As ICollection(Of Ventas__detalle) = New HashSet(Of Ventas__detalle)

End Class