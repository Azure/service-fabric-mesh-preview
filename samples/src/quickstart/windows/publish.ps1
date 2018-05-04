$registry =  ''

docker tag votingweb:1.0-nanoserver-1709 $registry/votingweb:1.0-nanoserver-1709
docker tag votingdata:1.0-nanoserver-1709 $registry/votingdata:1.0-nanoserver-1709

docker login $registry

docker push $registry/votingdata:1.0-nanoserver-1709
docker push $registry/votingweb:1.0-nanoserver-1709