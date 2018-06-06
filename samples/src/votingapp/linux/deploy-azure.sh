#!/bin/bash
rgName=$1
location=$2

#az login
#az account set --subscription {your subscriptionID}

az group create --name $rgname --location $location
az mesh deployment create --resource-group $rgname --template-file ./Deployment/quickstart-linux.json