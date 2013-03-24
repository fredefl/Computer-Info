@echo off
ILMerge.exe /out:ComputerInfo.exe ComputerInfoUnmerged.exe ^
Newtonsoft.Json.dll ^
da-DK/ComputerInfoUnmerged.resources.dll ^
MetroFramework.dll
pause