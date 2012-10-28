@echo off
ILMerge.exe /out:ComputerInfo.exe ComputerInfo.exe ^
Newtonsoft.Json.dll ^
da/ComputerInfo.resources.dll ^
en-GB/ComputerInfo.resources.dll
pause