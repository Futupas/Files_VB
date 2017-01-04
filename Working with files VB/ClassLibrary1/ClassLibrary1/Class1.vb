Namespace FSO
    Public Class Drive
        ''' <param name="objname">objname must be in format 'C:/'!</param>
        Public Sub New(objname As String)   ' constructor
            Me.Name = objname
            Me.Drive = CreateObject("Scripting.FileSystemObject").GetDrive(CreateObject("Scripting.FileSystemObject").GetDriveName(Name))
            Me.IsReady = Drive.IsReady
            If (Drive.IsReady) Then
                Me.AvailableSpace = Drive.AvailableSpace
                Me.DriveLetter = Drive.DriveLetter
                Select Case Drive.DriveType
                    Case 0 : Me.Type = DriveTypes.Unknown
                    Case 1 : Me.Type = DriveTypes.Removable
                    Case 2 : Me.Type = DriveTypes.Fixed
                    Case 3 : Me.Type = DriveTypes.Network
                    Case 4 : Me.Type = DriveTypes.CD_ROM
                    Case 5 : Me.Type = DriveTypes.RAM_Disk
                End Select
                Me.FileSystem = Drive.FileSystem
                Me.FreeSpace = Drive.FreeSpace
                Me.Path = Drive.Path
                'Me.RootFolder = Drive.RootFolder
                Me.SerialNumber = Drive.SerialNumber
                Me.ShareName = Drive.ShareName
                Me.TotalSize = Drive.TotalSize
                Me.VolumeName = Drive.VolumeName
            End If
        End Sub
        ''' <summary>
        ''' Gets name of Drive, than you gave when you created it
        ''' </summary>
        Public ReadOnly Name As String
        ''' <summary>
        ''' Com object with which you working ()
        ''' </summary>
        ''' 'todo HERE!
        Public ReadOnly Drive As Object
        ''' <summary>
        ''' Gets available space IN BYTES
        ''' </summary>
        Public ReadOnly AvailableSpace As ULong
        ''' <summary>
        ''' Gets Drive's Letter
        ''' </summary>
        Public ReadOnly DriveLetter As String
        ''' <summary>
        ''' Gets Drive's Type
        ''' </summary>
        Public ReadOnly Type As Drive.DriveTypes
        ''' <summary>
        ''' Gets Drive's file system
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly FileSystem As String
        ''' <summary>
        ''' Gets free space on Drive IN BYTES
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly FreeSpace As ULong
        ''' <summary>
        ''' Shows, Does Drive ready
        ''' </summary>
        Public ReadOnly IsReady As Boolean
        ''' <summary>
        ''' Gets Drive's path
        ''' </summary>
        Public ReadOnly Path As String
        'Public ReadOnly RootFolder As Object
        ''' <summary>
        ''' Gets Drive's serial number
        ''' </summary>
        Public ReadOnly SerialNumber As String
        ''' <summary>
        ''' Gets Drive's share name
        ''' </summary>
        Public ReadOnly ShareName As String
        ''' <summary>
        ''' Get Drive's total size IN BYTES
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly TotalSize As ULong
        ''' <summary>
        ''' Gets Drive's total size
        ''' </summary>
        Public ReadOnly VolumeName As String
        ''' <summary>
        ''' Types of drives
        ''' </summary>
        Public Enum DriveTypes
            Unknown = 0
            Removable = 1
            Fixed = 2
            Network = 3
            CD_ROM = 4
            RAM_Disk = 5
        End Enum
    End Class
    Public Class Drives
        ''' <summary>
        ''' Makes new collections of drives on your computer
        ''' </summary>
        Public Sub New()   ' constructor
            Me.Drives_ascoll = CreateObject("Scripting.FileSystemObject").Drives()
            Me.Count = Drives_ascoll.Count
            Array.Resize(Me.Drives, Me.Count)
            Dim i As Integer = 0
            For Each itm In Drives_ascoll
                Me.Drives(i) = New Drive(itm.DriveLetter + ":/")
                i = i + 1
            Next itm
        End Sub
        ''' <summary>
        ''' Drives as collection (VB) (not recommended)
        ''' </summary>
        Public ReadOnly Drives_ascoll As Object
        ''' <summary>
        ''' Drives as array
        ''' </summary>
        Public ReadOnly Drives(1) As Drive
        ''' <summary>
        ''' Gets count of dries in collection
        ''' </summary>
        Public ReadOnly Count As Integer
        ''' <param name="Name">Name must be in format 'C:/'!</param>
        Public Function Item(Name As String) As Drive
            Dim drv As Drive = New Drive(Drives_ascoll.Item(Name).DriveLetter + ":/")
            Return Drives_ascoll.Item(Name)
        End Function
    End Class

    Public Class Folder
        ''' <param name="FolderName">FolderName must be in format 'C:/MyFolder/' or 'C:\MyFolder\' or 'C:/MyFolder' or 'C:\MyFolder'!</param>
        Public Sub New(FolderName As String)
            Me.Folder = CreateObject("Scripting.FileSystemObject").GetFolder(FolderName)
            Me.Attributes = Me.Folder.Attributes
            Me.DateCreated = Me.Folder.DateCreated
            Me.DateLastAccessed = Me.Folder.DateLastAccessed
            Me.DateLastModified = Me.Folder.DateLastModified
            Me.Drive = Me.Folder.Drive.DriveLetter
            'Me.Files = Me.Folder.Files
            Me.IsRootFolder = Me.Folder.IsRootFolder
            Me.Name = Me.Folder.Name
            Me.ParentFolder = Me.Folder.ParentFolder.Path
            Me.Path = Me.Folder.Path
            Me.ShortName = Me.Folder.ShortName
            Me.ShortPath = Me.Folder.ShortPath
            Me.Size = Me.Folder.Size
            Me.SubFolders = New Folders(Me.Folder.Path)
            Me.Type = Me.Folder.Type
        End Sub
        ''' <summary>
        ''' Gets Folder's attributes
        ''' </summary>
        Public ReadOnly Attributes As Integer
        ''' <summary>
        ''' Gets date of Folder's created
        ''' </summary>
        Public ReadOnly DateCreated As System.DateTime
        ''' <summary>
        ''' Gets date of Folder's last accessed
        ''' </summary>
        Public ReadOnly DateLastAccessed As System.DateTime
        ''' <summary>
        ''' Gets date of Folder's last modified
        ''' </summary>
        Public ReadOnly DateLastModified As System.DateTime
        ''' <summary>
        ''' Drive's format is 'C'
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Drive As String
        'Public ReadOnly Files
        ''' <summary>
        ''' Gets 'true' if Folder is root. Else gets 'fasle'
        ''' </summary>
        Public ReadOnly IsRootFolder As Boolean
        ''' <summary>
        ''' Gets name of Folder, than you gave when you created it
        ''' </summary>
        Public ReadOnly Name As String
        ''' <summary>
        ''' Gets parent folders's path
        ''' </summary>
        Public ReadOnly ParentFolder As String
        ''' <summary>
        ''' Gets Folder's path
        ''' </summary>
        Public ReadOnly Path As String
        ''' <summary>
        ''' Gets Folder's short name
        ''' </summary>
        Public ReadOnly ShortName As String
        ''' <summary>
        ''' Gets Folder's short path
        ''' </summary>
        Public ReadOnly ShortPath As String
        ''' <summary>
        ''' Gets Folder's size IN BYTES
        ''' </summary>
        Public ReadOnly Size As ULong
        ''' <summary>
        ''' Gets sub folders
        ''' </summary>
        Public ReadOnly SubFolders As Folders
        ''' <summary>
        ''' Gets Folder's type
        ''' </summary>
        Public ReadOnly Type As String
        'ToDo here!
        ''' <summary>
        ''' Com object
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly Folder As Object
        Public Sub Copy(destination As String)
            Folder.Copy(destination)
        End Sub
        Public Sub Move(destination As String)
            Folder.Move(destination)
        End Sub
        Public Sub Delete()
            Folder.Delete()
        End Sub
        ''' <param name="filename">filename must be in format 'newfile.txt'! Format is '*.*'</param>
        Public Sub CreateTextFile(filename As String)
            Folder.CreateTextFile(filename)
        End Sub
    End Class
    Public Class Folders
        ''' <summary>
        ''' Makes new collections of folders on your computer
        ''' </summary>
        Public Sub New(FolderName As String)   ' constructor
            Me.Folders_ascoll = CreateObject("Scripting.FileSystemObject").GetFolder(FolderName).SubFolders()
            Me.Count = Folders_ascoll.Count
            Array.Resize(Me.Folders, Me.Count)
            Dim i As Integer = 0
            For Each itm In Folders_ascoll
                Me.Folders(i) = New Folder(itm.Path)
                i = i + 1
            Next itm
        End Sub
        ''' <summary>
        ''' Folders as collection (VB)
        ''' </summary>
        Public ReadOnly Folders_ascoll As Object
        ''' <summary>
        ''' Folders as array
        ''' </summary>
        Public ReadOnly Folders(1) As Folder
        Public ReadOnly Count As Integer
        ''' <param name="Name">Name must be in format  'C:/MyFolder/' or 'C:\MyFolder\' or 'C:/MyFolder' or 'C:\MyFolder'!</param>
        Public Function Item(Name As String) As Folder
            Dim drv As Folder = New Folder(Me.Folders_ascoll.Item(Name).Path)
            Return Me.Folders_ascoll.Item(Name)
        End Function
        Public Sub Add(foldername As String)
            Me.Folders_ascoll.Add(foldername)
        End Sub
    End Class

    Public Class File
        ''' <param name="FileName">FileName must be in format 'C:/Folder/file.txt' or 'C:\Folder\file.txt'. File Format is '*.*'</param>
        Public Sub New(FileName As String)
            Me.File = CreateObject("Scripting.FileSystemObject").GetFile(FileName)
            Me.Attributes = File.Attributes
            Me.DateCreated = File.DateCreated
            Me.DateLastAccessed = File.DateLastAccessed
            Me.DateLastModified = File.DateLastModified
            Me.Drive = File.Drive.DriveLetter
            Me.Name = File.Name
            Me.ParentFolder = File.ParentFolder.Path
            Me.Path = File.Path
            Me.ShortName = File.ShortName
            Me.ShortPath = File.ShortPath
            Me.Size = File.Size
            Me.Type = File.Type
        End Sub
        Public ReadOnly File As Object
        Public ReadOnly Attributes As Integer
        Public ReadOnly DateCreated As System.DateTime
        Public ReadOnly DateLastAccessed As System.DateTime
        Public ReadOnly DateLastModified As System.DateTime
        ''' <summary>
        ''' Drive is in format 'C'
        ''' </summary>
        Public ReadOnly Drive As String
        Public ReadOnly Name As String
        Public ReadOnly ParentFolder As String
        Public ReadOnly Path As String
        Public ReadOnly ShortName As String
        Public ReadOnly ShortPath As String
        Public ReadOnly Size As String
        Public ReadOnly Type As String
        Public Sub Move(destination As String)
            Me.File.Move(destination)
        End Sub
        Public Sub Copy(destination As String)
            Me.File.Copy(destination)
        End Sub
        Public Sub Delete()
            Me.File.Delete()
        End Sub
    End Class
    Public Class Files
        Public Sub New(FolderName As String)
            Me.Files_ascoll = CreateObject("Scripting.FileSystemObject").GetFolder(FolderName).Files()
            Me.Count = Files_ascoll.Count
            Array.Resize(Me.Files, Me.Count)
            Dim i As Integer = 0
            For Each itm In Files_ascoll
                Me.Files(i) = New File(itm.Path)
                i = i + 1
            Next itm
        End Sub
        Public ReadOnly Count As Integer
        ''' <summary>
        ''' Files as aray
        ''' </summary>
        Public ReadOnly Files(1) As File
        ''' <summary>
        ''' Files as collection (VB)
        ''' </summary>
        Public ReadOnly Files_ascoll As Object
    End Class
End Namespace