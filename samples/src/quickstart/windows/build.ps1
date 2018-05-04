docker build . -f ./VotingWeb/Dockerfile -t votingweb:1.0-windows
docker build . -f ./VotingData/Dockerfile -t votingdata:1.0-windows

docker rmi $(docker images -f "dangling=true" -q)