# Define the source and destination directories
$sourceDir = "C:\dotNetTips.com"
$destinationDir = "D:\src\GitHub\dotNetTips.Spargine.8\docs\Library Information"

# Get all files starting with "DotNetTips.Spargine" and having the extension ".md"
$files = Get-ChildItem -Path $sourceDir -Filter "DotNetTips.Spargine*.md"

# Move each file to the destination directory
foreach ($file in $files) {
    $destinationPath = Join-Path -Path $destinationDir -ChildPath $file.Name
    Move-Item -Path $file.FullName -Destination $destinationPath -Force
}

Write-Output "Files moved successfully."
