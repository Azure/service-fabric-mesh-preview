docker build . -f web/linux.Dockerfile -t azure-mesh-fireworks-web:dev
docker build . -f worker/linux.Dockerfile -t azure-mesh-fireworks-worker:dev-v1
docker build . -f worker/linux.v2.Dockerfile -t azure-mesh-fireworks-worker:dev-v2
