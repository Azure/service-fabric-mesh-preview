#!/bin/bash
set -e
# Any subsequent(*) commands which fail will cause the shell script to exit immediately

pushd linux
cp ../AzureFilesVerifier.py .
docker build -t azurefilesverifier:linux -f Dockerfile .
rm AzureFilesVerifier.py
popd
echo "Image successfully created : name : azurefilesverifier:linux"
