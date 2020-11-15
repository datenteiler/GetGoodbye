# GetGoodbye

Ein Hallo Welt-Programm zum Erstellen von binären Cmdlets für die PowerShell in VB.NET.

Das Cmdlet kann in .NET Core kompliliert werden. Zum Erstellen des Cmdlets wird das Template PSModule verwendet:

```
dotnet new -i Microsoft.PowerShell.Standard.Module.Template
dotnet new psmodule --name Goodbye
cd Goodbye
```
Die neu erstellte Beispieldatei *TestSampleCmdletCommand.cs* wird gelöscht und durch *Goodbye.vb* ersetzt und bei der Datei *Goodbye.csproj* die Endung durch *Goodbye.vbproj*. Anschließend wird das Cmdlet erstellt und kann in die PowerShell importiert werden:

```
dotnet build
Import-Module bin\Debug\netstandard2.0\Goodbye.dll
```

Und es kann ausgeführt werden:

```
Get-Goodbye -Name Welt
Write-Output "Welt" | Get-Goodbye | Select-String -Pattern "Tschüss"
```
