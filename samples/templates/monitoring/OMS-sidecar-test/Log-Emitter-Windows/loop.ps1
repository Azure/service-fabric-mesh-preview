$path = "\var\logs"
If(!(test-path $path)){
    New-Item -ItemType Directory -Force -Path $path
}

while ($true) { $A = Get-Date; Add-Content /var/logs/log.txt $A; Write-Host $A; Start-Sleep -s 1; }