Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports SPH3_TDS

Namespace Controllers
    Public Class TurnoController
        Inherits System.Web.Mvc.Controller

        Private db As New bdsenaitdsEntities

        ' GET: Turno
        Function Index() As ActionResult
            Return View(db.Turno.ToList())
        End Function

        ' GET: Turno/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim turno As Turno = db.Turno.Find(id)
            If IsNothing(turno) Then
                Return HttpNotFound()
            End If
            Return View(turno)
        End Function

        ' GET: Turno/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Turno/Create
        'Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        'obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="TURID,TURDESCRICAO")> ByVal turno As Turno) As ActionResult
            If ModelState.IsValid Then
                db.Turno.Add(turno)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(turno)
        End Function

        ' GET: Turno/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim turno As Turno = db.Turno.Find(id)
            If IsNothing(turno) Then
                Return HttpNotFound()
            End If
            Return View(turno)
        End Function

        ' POST: Turno/Edit/5
        'Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        'obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="TURID,TURDESCRICAO")> ByVal turno As Turno) As ActionResult
            If ModelState.IsValid Then
                db.Entry(turno).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(turno)
        End Function

        ' GET: Turno/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim turno As Turno = db.Turno.Find(id)
            If IsNothing(turno) Then
                Return HttpNotFound()
            End If
            Return View(turno)
        End Function

        ' POST: Turno/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim turno As Turno = db.Turno.Find(id)
            db.Turno.Remove(turno)
            db.SaveChanges()
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
