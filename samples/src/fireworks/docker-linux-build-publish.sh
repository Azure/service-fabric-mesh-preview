docker build . -f web/linux.Dockerfile -t seabreeze/azure-mesh-fireworks-web:0.1-stretch
docker build . -f worker/linux.Dockerfile -t seabreeze/azure-mesh-fireworks-worker:0.1-v1-stretch
docker build . -f worker/linux.v2.Dockerfile -t seabreeze/azure-mesh-fireworks-worker:0.1-v2-stretch
docker push seabreeze/azure-mesh-fireworks-web:0.1-stretch
docker push seabreeze/azure-mesh-fireworks-worker:0.1-v1-stretch
docker push seabreeze/azure-mesh-fireworks-worker:0.1-v2-stretch
