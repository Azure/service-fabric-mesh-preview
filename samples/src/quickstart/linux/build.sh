#!/bin/bash
docker build . -f ./VotingWeb/Dockerfile -t votingweb:1.0-linux
docker build . -f ./VotingData/Dockerfile -t votingdata:1.0-linux
docker rmi -f $(docker images -f "dangling=true" -q)