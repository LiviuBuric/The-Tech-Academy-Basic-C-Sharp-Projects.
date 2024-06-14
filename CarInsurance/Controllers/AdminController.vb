Public Class AdminController
    Inherits Controller

    Private db As InsuranceEntities = New InsuranceEntities()

    ' ... Other actions ...

    Public Function Quotes() As ActionResult
        Dim quotesList As List(Of Insuree) = db.Insurees.ToList()
        Return View(quotesList)
    End Function

    ' ... Other actions ...
End Class