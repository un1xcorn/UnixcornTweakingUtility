# UnixcornTweakingUtility
Source code of UnixcornTweakingUtility.

## Database
UnixcornTweakingUtility uses [this](https://github.com/littleunixcorn/UnixcornTweakingUtility-Licenses/blob/main/licenses.txt) as a database.

All licenses are encrypted with MD5 algorithm and a salt (1337) at the end of each license (hardware id).

The feature for checking updates works as described below:
- Get current version from [this](https://github.com/littleunixcorn/UnixcornTweakingUtility-Licenses/blob/main/version.txt)
- Compare it with the current version written into the Program.cs file (`Program.version`)
- If the two values are not the same, the executable file of the user is not up to date.

The feature for logging users in a discord channel for security purposes works as described below:
- Get webhook link from [this](https://github.com/littleunixcorn/UnixcornTweakingUtility-Licenses/blob/main/webhook.txt) (the string is encrypted with AES-256 and the following key `/k5j}L.|N?mt5>6fCp(oCr<(G|PJZ(ah` is used)
- Decrypt the string and use it to post logging details following the sample below:
```
License key: <key>
IP Address: <ip>
```
(IP Address is obtained by fetching `https://api.ipify.org`)

## To implement
- Bare drivers/services for Windows 8 and 10
- Debloat Windows 10

## Requirements
- Windows 7 64 bits
- .NET Framework 4.7.2
