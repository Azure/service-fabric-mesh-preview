pushd win
docker build -t filesverifier:nano -f Dockerfile . || goto :error
popd
echo "Image successfully created : name : filesverifier:nano"

goto :EOF

:error
echo Failed with error #%errorlevel%.
exit /b %errorlevel%