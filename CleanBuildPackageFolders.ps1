Get-ChildItem D:\src\GitHub\dotNetTips.Spargine.8\ -include bin,obj,packages,appbin,outputbin -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse -Verbose }
dotnet nuget locals all -c