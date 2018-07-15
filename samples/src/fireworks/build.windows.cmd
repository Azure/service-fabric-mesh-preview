@echo off
echo docker build src -f src\web\Dockerfile -t azure-mesh-fireworks-web:dev-nanoserver-1709
docker build src -f src\web\Dockerfile -t azure-mesh-fireworks-web:dev-nanoserver-1709

echo docker build src -f src\worker\Dockerfile -t azure-mesh-fireworks-worker-v1:dev-nanoserver-1709
docker build src -f src\worker\Dockerfile -t azure-mesh-fireworks-worker-v1:dev-nanoserver-1709

echo docker build src -f src\worker\v2.Dockerfile -t azure-mesh-fireworks-worker-v2:dev-nanoserver-1709
docker build src -f src\worker\v2.Dockerfile -t azure-mesh-fireworks-worker-v2:dev-nanoserver-1709