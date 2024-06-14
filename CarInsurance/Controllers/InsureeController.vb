Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CarInsurance

Namespace Controllers
    Public Class InsureeController
        Inherits System.Web.Mvc.Controller

        Private db As New InsuranceEntities

        ' GET: Insuree
        Function Index() As ActionResult
            Return View(db.Insurees.ToList())
        End Function

        ' GET: Insuree/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim insuree As Insuree = db.Insurees.Find(id)
            If IsNothing(insuree) Then
                Return HttpNotFound()
            End If
            Return View(insuree)
        End Function

        ' GET: Insuree/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Insuree/Create
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")> ByVal insuree As Insuree) As ActionResult
            If ModelState.IsValid Then
                insuree.Quote = CalculateQuote(insuree)
                db.Insurees.Add(insuree)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(insuree)
        End Function

        ' GET: Insuree/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim insuree As Insuree = db.Insurees.Find(id)
            If IsNothing(insuree) Then
                Return HttpNotFound()
            End If
            Return View(insuree)
        End Function

        ' POST: Insuree/Edit/5
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")> ByVal insuree As Insuree) As ActionResult
            If ModelState.IsValid Then
                insuree.Quote = CalculateQuote(insuree)
                db.Entry(insuree).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(insuree)
        End Function

        ' GET: Insuree/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim insuree As Insuree = db.Insurees.Find(id)
            If IsNothing(insuree) Then
                Return HttpNotFound()
            End If
            Return View(insuree)
        End Function

        ' POST: Insuree/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim insuree As Insuree = db.Insurees.Find(id)
            db.Insurees.Remove(insuree)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function CalculateQuote(insuree As Insuree) As Decimal
            Dim baseQuote As Decimal = 50

            ' Age-based adjustments
            Dim age = DateTime.Now.Year - insuree.DateOfBirth.Year
            If insuree.DateOfBirth.Date > DateTime.Now.AddYears(-age) Then age -= 1

            If age <= 18 Then
                baseQuote += 100
            ElseIf age >= 19 AndAlso age <= 25 Then
                baseQuote += 50
            Else
                baseQuote += 25
            End If

            ' Car year-based adjustments
            If insuree.CarYear < 2000 Then
                baseQuote += 25
            ElseIf insuree.CarYear > 2015 Then
                baseQuote += 25
            End If

            ' Car make and model-based adjustments
            If insuree.CarMake.ToLower() = "porsche" Then
                baseQuote += 25
                If insuree.CarModel.ToLower() = "911 carrera" Then
                    baseQuote += 25
                End If
            End If

            ' Speeding tickets-based adjustments
            baseQuote += insuree.SpeedingTickets * 10

            ' DUI-based adjustments
            If insuree.DUI Then
                baseQuote *= 1.25D
            End If

            ' Coverage type-based adjustments
            If insuree.CoverageType Then
                baseQuote *= 1.5D
            End If

            Return baseQuote

        End Function

        'Get :        Insuree/AdminView()
        Function AdminView() As ActionResult
            Return View()
        End Function

    End Class
End Namespace