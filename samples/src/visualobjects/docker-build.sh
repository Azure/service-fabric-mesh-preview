docker build . -f web/Dockerfile -t azure-mesh-visualobjects-web:dev
docker build . -f worker/Dockerfile -t azure-mesh-visualobjects-worker:dev
docker build . -f worker/rotate.Dockerfile -t azure-mesh-visualobjects-worker-rotate:dev
