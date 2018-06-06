#!/bin/bash
registry=$1

docker login $registry

docker tag votingweb:1.0-linux $registry/votingweb:1.0-linux
docker tag votingdata:1.0-linux $registry/votingdata:1.0-linux

docker push $registry/votingweb:1.0-linux
docker push $registry/votingdata:1.0-linux