docker build . -f web\Dockerfile -t seabreeze/azure-mesh-fireworks-web:1.0-nanoserver-1709
docker build . -f worker\Dockerfile -t seabreeze/azure-mesh-fireworks-worker:1.0-v1-nanoserver-1709
docker build . -f worker\v2.Dockerfile -t seabreeze/azure-mesh-fireworks-worker:1.0-v2-nanoserver-1709
docker push seabreeze/azure-mesh-fireworks-web:1.0-nanoserver-1709
docker push seabreeze/azure-mesh-fireworks-worker:1.0-v1-nanoserver-1709
docker push seabreeze/azure-mesh-fireworks-worker:1.0-v2-nanoserver-1709
