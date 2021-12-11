md %windir%\test && (rd /s /q %windir%\test) || call:GET_ADMIN

C:\EmptyStandbyList.exe workingsets
C:\EmptyStandbyList.exe modifiedpagelist
C:\EmptyStandbyList.exe priority0standbylist
C:\EmptyStandbyList.exe standbylist
wmic process where name="lsass.exe" call setpriority 64
wmic process where name="winlogon.exe" call setpriority 64
rd %temp% /s /q
md %temp%
rd C:\Windows\Temp /s /q
md C:\Windows\Temp
exit /b

:GET_ADMIN
echo Set UAC = CreateObject^("Shell.Application"^) > "%temp%\getadmin.vbs"
set params= %*
echo UAC.ShellExecute "cmd.exe", "/c ""%~s0"" %params:"=""%", "", "runas", 1 >> "%temp%\getadmin.vbs"
"%temp%\getadmin.vbs"
del "%temp%\getadmin.vbs"
exit /b