@echo off
ILMerge.exe /out:ComputerInfo.exe ComputerInfoUnmerged.exe ^
Newtonsoft.Json.dll ^
MetroFramework.dll
ILMerge.exe /target:winexe /copyattrs /allowdup /out:ComputerInfo.exe da-DK/ComputerInfoUnmerged.resources.dll
pause