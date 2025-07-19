# 2>nul&cls&@echo off& powershell -Command "& {Invoke-Expression $([System.IO.File]::ReadAllText('%~0', [System.Text.Encoding]::UTF8))}" & goto :EOF
if(Test-Path "${env:USERPROFILE}\.nuget\packages\otapi.upcoming\") {
    $minVersion = [version]::new(3, 1, 20);
    $ver = [version]::new()
    foreach($version in (Get-ChildItem -Attributes Directory "${env:USERPROFILE}\.nuget\packages\otapi.upcoming\")) {
        if([version]::TryParse($version.Name, ([ref]$ver)) -and ($ver -ge $minVersion)) {
            Copy-Item 'OTAPI\OTAPI.xml' $version.FullName 
        }
    }
}