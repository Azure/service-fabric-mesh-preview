pushd win
xcopy ..\AzureFilesVerifier.py . || goto :error
docker build -t azurefilesverifier:win -f Dockerfile . || goto :error
del AzureFilesVerifier.py || goto :error
popd
echo "Image successfully created : name : azurefilesverifier:win"

goto :EOF

:error
echo Failed with error #%errorlevel%.
exit /b %errorlevel%