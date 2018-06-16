docker build . -f web\Dockerfile -t seabreeze/azure-mesh-visualobjects-web:1.1-nanoserver-1709
docker build . -f worker\Dockerfile -t seabreeze/azure-mesh-visualobjects-worker:1.1-nanoserver-1709
docker build . -f worker\rotate.Dockerfile -t seabreeze/azure-mesh-visualobjects-worker:1.1-rotate-nanoserver-1709
docker push seabreeze/azure-mesh-visualobjects-web:1.1-nanoserver-1709
docker push seabreeze/azure-mesh-visualobjects-worker:1.1-nanoserver-1709
docker push seabreeze/azure-mesh-visualobjects-worker:1.1-rotate-nanoserver-1709
