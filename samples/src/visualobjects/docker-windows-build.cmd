docker build . -f web\Dockerfile 
docker build . -f worker\Dockerfile 
docker build . -f worker\rotate.Dockerfile
