'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Book
    Public Property Id As Integer
    Public Property Title As String
    Public Property Author As String
    Public Property Description As String
    Public Property Category As String
    Public Property TotalPages As Integer
    Public Property CreatedOn As Nullable(Of Date)
    Public Property UpdatedOn As Nullable(Of Date)
    Public Property LanguageId As Integer
    Public Property CoverImageUrl As String
    Public Property BookPdfUrl As String

    Public Overridable Property BookGalleries As ICollection(Of BookGallery) = New HashSet(Of BookGallery)
    Public Overridable Property Language As Language

End Class
