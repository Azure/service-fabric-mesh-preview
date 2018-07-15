#!/bin/sh 
DOCKER_REPO=$1
WEB_TAG=$2
WORKER_TAG=$3
echo docker tag azure-mesh-fireworks-web:dev-alpine $DOCKER_REPO/azure-mesh-fireworks-web:$WEB_TAG-alpine
docker tag azure-mesh-fireworks-web:dev-alpine $DOCKER_REPO/azure-mesh-fireworks-web:$WEB_TAG-alpine
echo docker push $DOCKER_REPO/azure-mesh-fireworks-web:$WEB_TAG-alpine
docker push $DOCKER_REPO/azure-mesh-fireworks-web:$WEB_TAG-alpine
echo docker tag azure-mesh-fireworks-worker-v1:dev-strech $DOCKER_REPO/azure-mesh-fireworks-worker-v1:$WORKER_TAG-strech
docker tag azure-mesh-fireworks-worker-v1:dev-strech $DOCKER_REPO/azure-mesh-fireworks-worker-v1:$WORKER_TAG-strech
echo docker push $DOCKER_REPO/azure-mesh-fireworks-worker-v1:$WORKER_TAG-strech
docker push $DOCKER_REPO/azure-mesh-fireworks-worker-v1:$WORKER_TAG-strech
echo docker tag azure-mesh-fireworks-worker-v2:dev-strech $DOCKER_REPO/azure-mesh-fireworks-worker-v2:$WORKER_TAG-strech
docker tag azure-mesh-fireworks-worker-v2:dev-strech $DOCKER_REPO/azure-mesh-fireworks-worker-v2:$WORKER_TAG-strech
echo docker push $DOCKER_REPO/azure-mesh-fireworks-worker-v2:$WORKER_TAG-strech
docker push $DOCKER_REPO/azure-mesh-fireworks-worker-v2:$WORKER_TAG-strech
