// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VisualObjects.Worker
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml;

    using VisualObjects.Common;

    internal class FileStateStore : IStateStore
    {
        private const string StateFolderName = "Data";
        private const string SubFolderNameEnvVar = "Fabric_Id";
        private const string StateFileName = "visualobjects.data.xml";

        private DataContractSerializer serializer;
        private string stateFilePath;
        private string stateFolderPath;

        public FileStateStore()
            : this(GetDefaultFolderPath())
        {
        }

        public FileStateStore(string folderPath)
        {
            this.stateFolderPath = folderPath;
            this.stateFilePath = Path.Combine(folderPath, StateFileName);
            this.serializer = new DataContractSerializer(
                typeof(VisualObject),
                new DataContractSerializerSettings()
                {
                    MaxItemsInObjectGraph = int.MaxValue
                });
        }

        public async Task<VisualObject> ReadAsync(CancellationToken cancellationToken)
        {
            if (!File.Exists(this.stateFilePath))
            {
                Console.WriteLine($"State file {this.stateFilePath} does not exist. Creating new object.");
                var obj = VisualObject.CreateRandom(Guid.NewGuid().ToString());
                await WriteAsync(obj, cancellationToken);
            }

            // file exists read it
            byte[] data = null;
            using (var stream = new FileStream(
                this.stateFilePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None,
                4096,
                true))
            {
                data = new byte[stream.Length];
                await stream.ReadAsync(data, 0, data.Length, cancellationToken);
            }

            // deserialize
            try
            {
                return this.Deserialize(data);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Read error. recreating the object. {e.ToString()}");
                return VisualObject.CreateRandom(Guid.NewGuid().ToString());
            }
        }

        public async Task WriteAsync(VisualObject state, CancellationToken cancellationToken)
        {
            if (!Directory.Exists(this.stateFolderPath))
            {
                Directory.CreateDirectory(this.stateFolderPath);
            }

            var data = this.Serialize(state);
            using (var stream = new FileStream(
                this.stateFilePath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None,
                4096,
                true))
            {
                await stream.WriteAsync(data, 0, data.Length, cancellationToken);
            }
        }

        private byte[] Serialize(VisualObject parameters)
        {
            using (var stream = new MemoryStream())
            {
                using (var writer = XmlDictionaryWriter.CreateTextWriter(stream))
                {
                    this.serializer.WriteObject(writer, parameters);
                    writer.Flush();
                    return stream.ToArray();
                }
            }
        }

        private VisualObject Deserialize(byte[] parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters", "argument should not be null");
            }

            using (var stream = new MemoryStream(parameters))
            {
                using (var reader = XmlDictionaryReader.CreateTextReader(stream, XmlDictionaryReaderQuotas.Max))
                {
                    return (VisualObject)this.serializer.ReadObject(reader);
                }
            }
        }

        private static string GetDefaultFolderPath()
        {
            var subFolderName = Environment.GetEnvironmentVariable(SubFolderNameEnvVar);
            if (null == subFolderName)
            {
                subFolderName = String.Empty;
            }

            var codeFolderFullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var baseFolderFullPath = Path.GetDirectoryName(codeFolderFullPath);
            var stateFolderPath = Path.Combine(baseFolderFullPath, StateFolderName, subFolderName);

            return stateFolderPath;
        }
    }
}
