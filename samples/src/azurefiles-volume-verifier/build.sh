#!/bin/bash
set -e
# Any subsequent(*) commands which fail will cause the shell script to exit immediately

pushd linux
docker build -t azurefilesverifier:linux -f Dockerfile .
popd
echo "Image successfully created : name : azurefilesverifier:linux"
