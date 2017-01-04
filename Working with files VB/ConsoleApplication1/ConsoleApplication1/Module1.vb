Module Module1

    Sub Main()
        ' If you use anonimous you do not need declare these variables
        'Dim fso, f

        Dim str, scripttxt
        str = ""

        ' Simple
        'fso = CreateObject("Scripting.FileSystemObject")
        'f = fso.GetFile("C:\Users\Alex\Desktop\script.txt")
        'f = fso.GetFile(".\ConsoleApplication1.exe")
        'scripttxt = f.openasTextStream()

        ' Anonymous
        scripttxt = CreateObject("Scripting.FileSystemObject").GetFile("C:\Users\Alex\Desktop\script.txt").openasTextStream()

        str = str & "***** BEGIN *****" & vbNewLine
        Do While True
            str = str & scripttxt.ReadLine
            If scripttxt.AtEndOfStream <> True Then
                str = str & vbNewLine
            Else
                Exit Do
            End If
        Loop
        str = str & vbNewLine & "***** ENG *****"
        scripttxt.close()
        Console.WriteLine(str)
        Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine()

        Do While True
            Dim mydrive As Drive = New Drive("C:/")
            Console.WriteLine(mydrive.FreeSpace)
            Console.ReadKey()
        Loop
    End Sub

End Module

Class Drive
    ''' <summary>
    ''' objname must be in format 'C:/'!
    ''' </summary>
    ''' <param name="objname"></param>
    ''' <remarks></remarks>
    Public Sub New(objname As String)   ' constructor
        Name = objname
        Drive = CreateObject("Scripting.FileSystemObject").GetDrive(CreateObject("Scripting.FileSystemObject").GetDriveName(Name))
        AvailableSpace = Drive.AvailableSpace
        DriveLetter = Drive.DriveLetter
        DriveType = Drive.DriveType
        FileSystem = Drive.FileSystem
        FreeSpace = Drive.FreeSpace
        IsReady = Drive.IsReady
        Path = Drive.Path
        RootFolder = Drive.RootFolder
        SerialNumber = Drive.SerialNumber
        ShareName = Drive.ShareName
        TotalSize = Drive.TotalSize
        VolumeName = Drive.VolumeName
    End Sub
    Public ReadOnly Name As String
    Public ReadOnly Drive
    Public ReadOnly AvailableSpace
    Public ReadOnly DriveLetter
    Public ReadOnly DriveType
    Public ReadOnly FileSystem
    Public ReadOnly FreeSpace
    Public ReadOnly IsReady
    Public ReadOnly Path
    Public ReadOnly RootFolder
    Public ReadOnly SerialNumber
    Public ReadOnly ShareName
    Public ReadOnly TotalSize
    Public ReadOnly VolumeName
End Class
Class Drives
    ''' <summary>
    ''' Makes new collections of drives on your computer
    ''' </summary>
    Public Sub New()   ' constructor
        Drives = CreateObject("Scripting.FileSystemObject").Drives()
        Count = Drives.Count
    End Sub
    Public ReadOnly Drives
    Public ReadOnly Count
End Class
Class File

End Class
Class Files

End Class
Class Folder

End Class
Class Folders

End Class
Class TextStream

End Class


'Class Line
'    Public Sub New()   ' constructor
'        Console.WriteLine("Object is being created")
'    End Sub
'    Protected Overrides Sub Finalize()  ' destructor
'        Console.WriteLine("Object is being deleted")
'    End Sub
'End Class