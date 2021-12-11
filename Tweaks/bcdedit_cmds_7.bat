@echo off
C:\Windows\System32\bcdedit.exe /set {current} description "Windows 7"
C:\Windows\System32\bcdedit.exe /set x2apicpolicy disable
C:\Windows\System32\bcdedit.exe /set debug No
C:\Windows\System32\bcdedit.exe /set ems No
C:\Windows\System32\bcdedit.exe /set bootems No
C:\Windows\System32\bcdedit.exe /set integrityservices disable
C:\Windows\System32\bcdedit.exe /deletevalue useplatformclock
C:\Windows\System32\bcdedit.exe /set bootux disabled
C:\Windows\System32\bcdedit.exe /set nx alwaysoff
C:\Windows\System32\bcdedit.exe /set tpmbootentropy ForceDisable
C:\Windows\System32\bcdedit.exe /set {globalsettings} custom:16000067 true
C:\Windows\System32\bcdedit.exe /set {globalsettings} custom:16000069 true
C:\Windows\System32\bcdedit.exe /set {globalsettings} custom:16000068 true