using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.FSO;

namespace ConsoleApplicationTest_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Drive/Drivew

            Drive c = new Drive("C:/");
            Console.WriteLine("AvailableSpace : {0}", c.AvailableSpace);
            Console.WriteLine("DriveLetter : {0}", c.DriveLetter);
            Console.WriteLine("DriveType : {0}", c.Type.ToString());
            Console.WriteLine("FileSystem : {0}", c.FileSystem);
            Console.WriteLine("FreeSpace : {0}", c.FreeSpace);
            Console.WriteLine("IsReady : {0}", c.IsReady);
            Console.WriteLine("Name : {0}", c.Name);
            Console.WriteLine("Path : {0}", c.Path);
            //Console.WriteLine("RootFolder : {0}", c.RootFolder);
            Console.WriteLine("SerialNumber : {0}", c.SerialNumber);
            Console.WriteLine("ShareName : {0}", c.ShareName);
            Console.WriteLine("TotalSize : {0}", c.TotalSize);
            Console.WriteLine("VolumeName : {0}", c.VolumeName);
            Drives drs = new Drives();
            foreach (Drive i in drs.Drives)
            {
                Console.Write("{0} ", i.DriveLetter);
            }
            Console.WriteLine(); 
            Console.WriteLine();

            #endregion
            #region Folder/Folders

            Folders myFolders = new Folders(@"D:\PANOV.IN.UA\just start");
            Folder myFolder = myFolders.Folders[0];
            Console.WriteLine("Attributes : {0}", myFolder.Attributes);
            Console.WriteLine("DateCreated : {0}", myFolder.DateCreated);
            Console.WriteLine("DateLastAccessed : {0}", myFolder.DateLastAccessed);
            Console.WriteLine("DateLastModified : {0}", myFolder.DateLastModified);
            Console.WriteLine("Drive : {0}", myFolder.Drive);
            Console.WriteLine("IsRootFolder : {0}", myFolder.IsRootFolder);
            Console.WriteLine("Name : {0}", myFolder.Name);
            Console.WriteLine("ParentFolder : {0}", myFolder.ParentFolder);
            Console.WriteLine("Path : {0}", myFolder.Path);
            Console.WriteLine("ShortName : {0}", myFolder.ShortName);
            Console.WriteLine("ShortPath : {0}", myFolder.ShortPath);
            Console.WriteLine("Size : {0}", myFolder.Size);
            Console.WriteLine("Type : {0}", myFolder.Type);
            Console.WriteLine("Zero subfolder : {0}", myFolder.SubFolders.Folders[0].Path);
            Console.WriteLine();

            #endregion
            #region File/Files

            Files myfiles = new Files("D:/HTML");
            File myfile = myfiles.Files[1];//new File("D:/HTML/404.html");
            Console.WriteLine("Attributes : {0}", myfile.Attributes);
            Console.WriteLine("DateCreated : {0}", myfile.DateCreated);
            Console.WriteLine("DateLastAccessed : {0}", myfile.DateLastAccessed);
            Console.WriteLine("DateLastModified : {0}", myfile.DateLastModified);
            Console.WriteLine("Drive : {0}", myfile.Drive);
            Console.WriteLine("Name : {0}", myfile.Name);
            Console.WriteLine("ParentFolder : {0}", myfile.ParentFolder);
            Console.WriteLine("Path : {0}", myfile.Path);
            Console.WriteLine("ShortName : {0}", myfile.ShortName);
            Console.WriteLine("ShortPath : {0}", myfile.ShortPath);
            Console.WriteLine("Size : {0}", myfile.Size);
            Console.WriteLine("Type : {0}", myfile.Type);

            #endregion

            Console.ReadLine();
        }
    }
}
