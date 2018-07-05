docker build . -f web\Dockerfile -t seabreeze/azure-mesh-fireworks-web:0.1-nanoserver-1709
docker build . -f worker\Dockerfile -t seabreeze/azure-mesh-fireworks-worker:0.1-v1-nanoserver-1709
docker build . -f worker\v2.Dockerfile -t seabreeze/azure-mesh-fireworks-worker:0.1-v2-nanoserver-1709
docker push seabreeze/azure-mesh-fireworks-web:0.1-nanoserver-1709
docker push seabreeze/azure-mesh-fireworks-worker:0.1-v1-nanoserver-1709
docker push seabreeze/azure-mesh-fireworks-worker:0.1-v2-nanoserver-1709
