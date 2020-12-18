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
    Public Class BooksController
        Inherits System.Web.Mvc.Controller

        Private db As New inventoryEntities

        ' GET: Books
        Async Function Index() As Task(Of ActionResult)
            Dim books = db.Books.Include(Function(b) b.Language)
            Return View(Await books.ToListAsync())
        End Function

        ' GET: Books/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As Book = Await db.Books.FindAsync(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' GET: Books/Create
        Function Create() As ActionResult
            ViewBag.LanguageId = New SelectList(db.Languages, "Id", "Name")
            Return View()
        End Function

        ' POST: Books/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="Id,Title,Author,Description,Category,TotalPages,CreatedOn,UpdatedOn,LanguageId,CoverImageUrl,BookPdfUrl")> ByVal book As Book) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Books.Add(book)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            ViewBag.LanguageId = New SelectList(db.Languages, "Id", "Name", book.LanguageId)
            Return View(book)
        End Function

        ' GET: Books/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As Book = Await db.Books.FindAsync(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            ViewBag.LanguageId = New SelectList(db.Languages, "Id", "Name", book.LanguageId)
            Return View(book)
        End Function

        ' POST: Books/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="Id,Title,Author,Description,Category,TotalPages,CreatedOn,UpdatedOn,LanguageId,CoverImageUrl,BookPdfUrl")> ByVal book As Book) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(book).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            ViewBag.LanguageId = New SelectList(db.Languages, "Id", "Name", book.LanguageId)
            Return View(book)
        End Function

        ' GET: Books/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As Book = Await db.Books.FindAsync(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' POST: Books/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim book As Book = Await db.Books.FindAsync(id)
            db.Books.Remove(book)
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
