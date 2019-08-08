Imports System
Imports Microsoft.VisualBasic

Imports Autodesk.Revit.UI
Imports Autodesk.Revit.DB

<Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.ReadOnly)> _
Public Class HelloWorld
Implements IExternalCommand
        Public Function Execute(ByVal revit As ExternalCommandData, ByRef message As String, _
                                ByVal elements As ElementSet) As Autodesk.Revit.UI.Result _
                                Implements IExternalCommand.Execute

                MsgBox("Hello World from VB.Net!!")
                TaskDialog.Show("Revit", "Hello World from VB.Net!!")
                Return Autodesk.Revit.UI.Result.Succeeded
        End Function
End Class