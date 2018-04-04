﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace AzureFilesVolumeTestApp
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Reflection;

    class Program
    {
        private const string DataFileName = "data.txt";
        private const string DataFolderName = "Data";
        private const int PauseBetweenUpdatesMillisec = 30000;

        static void Main(string[] args)
        {
            var codeFolderFullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var volumeTestFolderFullPath = Path.GetDirectoryName(codeFolderFullPath);
            var dataFileFullPath = Path.Combine(volumeTestFolderFullPath, DataFolderName, DataFileName);

            var sequenceNumber = File.Exists(dataFileFullPath) ? Int32.Parse(File.ReadAllText(dataFileFullPath)) : 0;
            for(;;)
            {
                sequenceNumber++;
                File.WriteAllText(dataFileFullPath, sequenceNumber.ToString());
                Thread.Sleep(PauseBetweenUpdatesMillisec);
            }
        }
    }
}
