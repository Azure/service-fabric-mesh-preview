# Container Volume Sample
This sample illustrates the use of volumes in SeaBreeze containers.

The container requests a volume, that is backed by a specific [Azure Files](https://docs.microsoft.com/azure/storage/files/storage-files-introduction) file share, to be mounted to a specific location within the container. The application that runs inside the container writes a text file to this location.

## Running the sample
### Step 1: Build the application and Docker container image
The application can be built by running the _build.Windows.cmd_ script on Windows and the _build.Linux.sh_ script on Linux. Running these scripts results in the creation of the _pkg\Windows_ and _pkg\Linux_ folders which contain the application binaries for Windows and Linux respectively. They also contain the _dockerfile_ that can be used to build the Docker container image for the application. After building the application, build the Docker container image and push it to a Docker repository.

### Step 2: Create the Azure Files file share
Follow the instructions in the [Azure Files documentation](https://docs.microsoft.com/en-us/azure/storage/files/storage-how-to-create-file-share) to create a file share for the application to use.

### Step 3: Update the application resource description
Update _VolumeTestApp.Windows.json_ or _VolumeTestApp.Linux.json_ (depending on the OS - Windows or Linux) with the following information:

- **Container image information:** update the following fields

        "image": "",

- **Azure Files file share information:** update the following fields

        "azureFile": {
          "shareName": "",
          "storageAccountName": "",
          "storageAccountKey": ""
        }

### Step 4: Deploy the Container Group Set (CGS) that contains the application
Follow the instructions on the [CGS quickstart page](./../../docs/conceptual-docs/container-group-set-quickstart.md) to deploy the CGS. Use _VolumeTestApp.Windows.json_ for deploying the Windows container and _VolumeTestApp.Linux.json_ for Linux.

### Step 5: Verify that the application is able to use the volume
The presence of the file _data.txt_ in the file share created in Step 1 above indicates that the application was able to use the volume.