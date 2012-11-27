@echo off
ILMerge.exe /out:ComputerInfo.exe ComputerInfoUnmerged.exe ^
Newtonsoft.Json.dll ^
da/ComputerInfoUnmerged.resources.dll ^
en-GB/ComputerInfoUnmerged.resources.dll
pause