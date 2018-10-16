cd product-catalog
dotnet publish -c Release -o ..\forawseb
cd ..\forawseb
Compress-Archive . -DestinationPath ..\forawseb.zip -Force
cd ..
Compress-Archive aws-windows-deployment-manifest.json, forawseb.zip -DestinationPath product-catalog-aws-eb.zip -Force
Remove-Item -Recurse -Force forawseb
Remove-Item -Force forawseb.zip




