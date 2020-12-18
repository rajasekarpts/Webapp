Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace WebApplication2
    Public Class LanguagesController
        Inherits System.Web.Mvc.Controller

        Private db As New inventoryEntities

        ' GET: Languages
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.Languages.ToListAsync())
        End Function

        ' GET: Languages/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim language As Language = Await db.Languages.FindAsync(id)
            If IsNothing(language) Then
                Return HttpNotFound()
            End If
            Return View(language)
        End Function

        ' GET: Languages/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Languages/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="Id,Name,Description")> ByVal language As Language) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Languages.Add(language)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(language)
        End Function

        ' GET: Languages/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim language As Language = Await db.Languages.FindAsync(id)
            If IsNothing(language) Then
                Return HttpNotFound()
            End If
            Return View(language)
        End Function

        ' POST: Languages/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="Id,Name,Description")> ByVal language As Language) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(language).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(language)
        End Function

        ' GET: Languages/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim language As Language = Await db.Languages.FindAsync(id)
            If IsNothing(language) Then
                Return HttpNotFound()
            End If
            Return View(language)
        End Function

        ' POST: Languages/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim language As Language = Await db.Languages.FindAsync(id)
            db.Languages.Remove(language)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
