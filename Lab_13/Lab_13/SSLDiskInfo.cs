using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Reflection;
namespace Lab_13
{
    class SSLDiskInfo
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        public void InfoOfDrivers()
        {
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Название: {0}", drive.Name);
                Console.WriteLine("Тип: {0}", drive.DriveType);
                if (drive.IsReady)
                {
                    Console.WriteLine("Объем диска: {0}", drive.TotalSize);
                    Console.WriteLine("Свободное пространство: {0}", drive.TotalFreeSpace);
                    Console.WriteLine("Метка: {0}", drive.VolumeLabel);
                }
                Console.WriteLine();
            }
        }
    }
}
