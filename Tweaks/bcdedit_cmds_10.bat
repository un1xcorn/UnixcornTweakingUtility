@echo off
C:\Windows\System32\bcdedit.exe /set {current} description "Windows 10"
C:\Windows\System32\bcdedit.exe /set x2apicpolicy disable
C:\Windows\System32\bcdedit.exe /set debug No
C:\Windows\System32\bcdedit.exe /set ems No
C:\Windows\System32\bcdedit.exe /set bootems No
C:\Windows\System32\bcdedit.exe /set vm No
C:\Windows\System32\bcdedit.exe /set sos No
C:\Windows\System32\bcdedit.exe /set quietboot yes
C:\Windows\System32\bcdedit.exe /set integrityservices disable
C:\Windows\System32\bcdedit.exe /deletevalue useplatformclock
C:\Windows\System32\bcdedit.exe /set useplatformtick yes
C:\Windows\System32\bcdedit.exe /set bootux disabled
C:\Windows\System32\bcdedit.exe /set bootlog no
C:\Windows\System32\bcdedit.exe /set nx alwaysoff
C:\Windows\System32\bcdedit.exe /set tpmbootentropy ForceDisable
C:\Windows\System32\bcdedit.exe /set disableelamdrivers yes
C:\Windows\System32\bcdedit.exe /set tscsyncpolicy legacy
C:\Windows\System32\bcdedit.exe /set hypervisorlaunchtype off
C:\Windows\System32\bcdedit.exe /set isolatedcontext no
C:\Windows\System32\bcdedit.exe /set pae ForceDisable
C:\Windows\System32\bcdedit.exe /set vsmlaunchtype Off

C:\Windows\System32\bcdedit.exe /set {globalsettings} custom:16000067 true
C:\Windows\System32\bcdedit.exe /set {globalsettings} custom:16000069 true
C:\Windows\System32\bcdedit.exe /set {globalsettings} custom:16000068 true
