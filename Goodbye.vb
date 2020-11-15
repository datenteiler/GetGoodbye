Imports System
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces

Namespace GetGoodbye
    <Cmdlet(VerbsCommon.Get, "Goodbye")> _
    Public Class GetGoodbyeCommand
        Inherits PSCmdlet

        Private _Name As String()
        <Parameter(Position:=0, Mandatory:=True, _ 
        ValueFromPipeline:=True, _
        ValueFromPipelineByPropertyName:=True), _
        ValidateNotNullOrEmpty()> _
        Public Property Name() As String() '
            Get
                Return _Name
            End Get
            Set(ByVal value As String())
                _Name = value
            End Set
        End Property

        Protected Overrides Sub ProcessRecord()
            Dim strName As String = String.Join(" ", _Name)
            WriteObject("Tschüss " + strName + "!")
        End Sub
    End Class
End Namespace