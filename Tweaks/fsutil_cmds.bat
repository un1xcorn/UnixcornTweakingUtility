@echo off
C:\Windows\System32\fsutil.exe behavior set disableencryption 1
C:\Windows\System32\fsutil.exe behavior set encryptpagingfile 0
C:\Windows\System32\fsutil.exe behavior set quotanotify 7200