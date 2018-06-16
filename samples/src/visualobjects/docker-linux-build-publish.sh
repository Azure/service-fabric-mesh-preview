docker build . -f web/Dockerfile -t seabreeze/azure-mesh-visualobjects-web:1.1-stretch
docker build . -f worker/Dockerfile -t seabreeze/azure-mesh-visualobjects-worker:1.1-stretch
docker build . -f worker/rotate.Dockerfile -t seabreeze/azure-mesh-visualobjects-worker:1.1-rotate-stretch
docker push seabreeze/azure-mesh-visualobjects-web:1.1-stretch
docker push seabreeze/azure-mesh-visualobjects-worker:1.1-stretch
docker push seabreeze/azure-mesh-visualobjects-worker:1.1-rotate-stretch
