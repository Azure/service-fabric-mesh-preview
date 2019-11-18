// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace AzureFilesVolumeTestApp
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Text;
    using System.Reflection;

    class Program
    {
        private const string DataFileName = "data.txt";
        private const string DataFolderName = "Data";
        private const int PauseBetweenUpdatesMillisec = 30000;

        static void Main(string[] args)
        {
            var codeFolderFullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine($"Code dir path {codeFolderFullPath}");
            var volumeTestFolderFullPath = Path.GetDirectoryName(codeFolderFullPath);
            var dataFolderFullPath = Path.Combine(volumeTestFolderFullPath, DataFolderName);
            Console.WriteLine($"Data dir path {dataFolderFullPath}");
            Directory.CreateDirectory(dataFolderFullPath);

            var dataFileFullPath = Path.Combine(dataFolderFullPath, DataFileName);
            var sequenceNumber = 0;
            string fileContent = "";
            try
            {
                if (File.Exists(dataFileFullPath))
                {
                    // The content may be empty or non-number, catch the exception to avoid crash
                    fileContent = File.ReadAllText(dataFileFullPath);
                    sequenceNumber = Int32.Parse(fileContent);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception {e.ToString()}");
                Console.WriteLine($"Invalid file content {fileContent}");
            }

            for(;;)
            {
                sequenceNumber++;
                try
                {
                    using (var file = new FileStream(dataFileFullPath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        var bytes = Encoding.ASCII.GetBytes(sequenceNumber.ToString());
                        file.Write(bytes, 0, bytes.Length);
                        file.Flush();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception {e.ToString()}");
                }

                Thread.Sleep(PauseBetweenUpdatesMillisec);
            }
        }
    }
}
