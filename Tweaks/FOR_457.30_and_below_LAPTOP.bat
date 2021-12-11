@Echo Off
Title Nvidia Tweaks & Color 1A
cd %systemroot%\system32
call :IsAdmin

for /f %%i in ('wmic path Win32_VideoController get PNPDeviceID^| findstr /L "PCI\VEN_"') do (
	for /f "tokens=3" %%a in ('reg query "HKLM\SYSTEM\CurrentControlSet\Enum\%%i" /v "Driver"') do set "GPUDRIVERKEY=%%a"
)
echo %GPUDRIVERKEY%
reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\%GPUDRIVERKEY%" /v "RMHdcpKeyglobZero" /t REG_DWORD /d "1" /f
reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\%GPUDRIVERKEY%" /v "RMDisableGpuASPMFlags" /t REG_DWORD /d "1" /f
reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\%GPUDRIVERKEY%" /v "RMEnableASPMAtLoad" /t REG_DWORD /d "0" /f
reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\%GPUDRIVERKEY%" /v "RMEnableASPMDT" /t REG_DWORD /d "0" /f
reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\%GPUDRIVERKEY%" /v "RmOverrideSupportChipsetAspm" /t REG_DWORD /d "0" /f
reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\%GPUDRIVERKEY%" /v "RMSbiosEnableASPMDT" /t REG_DWORD /d "0" /f
reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\%GPUDRIVERKEY%" /v "RMEnableASPMDT" /t REG_DWORD /d "0" /f
reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\Class\%GPUDRIVERKEY%" /v "DisableWriteCombining" /t REG_DWORD /d "1" /f

for /f %%i in ('reg query "HKLM\SYSTEM\CurrentControlSet\Control\GraphicsDrivers" /s /f "Scaling"^| findstr "HKEY"') do reg add "%%i" /v "Scaling" /t REG_DWORD /d "1" /f 

Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Control\GraphicsDrivers\Scheduler" /v "VsyncIdleTimeout" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\ControlSet001\Control\GraphicsDrivers" /v "PlatformSupportMiracast" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\ControlSet001\Control\GraphicsDrivers" /v "TdrLevel" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\Services\nvlddmkm\Global\NVTweak" /v "DisplayPowerSaving" /t REG_DWORD /d "0" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\nvlddmkm" /v "DisableWriteCombining" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\nvlddmkm" /v "DisableMshybridNvsrSwitch" /t REG_DWORD /d "1" /f
Reg.exe add "HKLM\SYSTEM\CurrentControlSet\services\nvlddmkm" /v "EnableHybridMode" /t REG_DWORD /d "0" /f

:IsAdmin
Reg.exe query "HKU\S-1-5-19\Environment"
If Not %ERRORLEVEL% EQU 0 (
 Cls & Echo You must have administrator rights to continue ... 
 Pause & Exit
)
Cls
goto:eof
