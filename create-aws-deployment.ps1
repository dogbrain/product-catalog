cd product-catalog
npm install -D
dotnet publish -c Release -o ..\forawseb
cd ..\forawseb
Compress-Archive . -DestinationPath ..\forawseb.zip -Force
cd ..
Compress-Archive create-aws-deployment.ps1, forawseb.zip -DestinationPath product-catalog-aws-eb.zip -Force
Remove-Item -Recurse -Force forawseb
Remove-Item -Force forawseb.zip




