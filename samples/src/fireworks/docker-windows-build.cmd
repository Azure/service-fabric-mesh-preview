docker build . -f web\Dockerfile -t azure-mesh-fireworks-web:dev
docker build . -f worker\Dockerfile -t azure-mesh-fireworks-worker:dev-v1
docker build . -f worker\v2.Dockerfile -t azure-mesh-fireworks-worker:dev-v2