$modulePath = 'C:\Users\sam\SkyDrive\dev\cs\Algorithms\Euler\Problems\'
$moduleManifest = 'triangle-module-manifest'

$module = "$($modulePath)$($moduleManifest).psd1"

Import-Module -Force $module

Write-M