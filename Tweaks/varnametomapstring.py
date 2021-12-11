import subprocess, os, sys

#Test if required files are present
if not os.path.isfile("amifldrv64.sys"):
    print("[Error]amifldrv64.sys is missing.")
    sys.exit()
if not os.path.isfile("SCEWIN_64.exe"):
    print("[Error]SCEWIN_64.exe is missing.")
    sys.exit()

#If system inputs are incorrect
if len(sys.argv) < 3:
    print("[Error]Invalid user arguments: varnametomapstring.py <contains:only> <varname>")
    sys.exit()

#Define user arguments
method = sys.argv[1].lower()
varname = sys.argv[2]

#Import BIOS Settings using AMISCE to BIOSSettings.txt
importSettings = subprocess.getoutput("SCEWIN_64.exe /O /lang /S BIOSSettings.txt")

#If the key-word successfully is not here, there is a problem
#while importing BIOS Settings
if not "successfully" in importSettings:
    print("[Error]An error happened while exporting your BIOS Settings")
    sys.exit()

#Test if BIOSSettings.txt is present
if not os.path.isfile("BIOSSettings.txt"):
    print("[Error]BIOSSettings.txt is missing.")
    sys.exit()

instance = open("BIOSSettings.txt", "r")

#If third last line starts with HIICrc32= 
#it means that the BIOS is not compatible
if "HIICrc32=" in instance.readlines()[sum(1 for line in instance)-2]:
    print("[Error]Your BIOS is not compatible.")
    sys.exit()

#Read each line
#If a line correspond to the varname and we have a = meaning that it is a setup question:
#   If method is contains just add it to the list
#   If method is only test if length of varname and lineName are the same if yes add it to the array
mapStrings = []
with open("BIOSSettings.txt", "r") as f:
    for line in f:
        if "Setup" in line and varname in line:
            mapString = next(f).split("=")[1].replace(" ", "").replace("\n", "")
            if mapString in mapStrings:
                continue
            else:
                if method == "contains":
                    if varname.replace(" ", "") in line.split("=")[1].replace(" ", "").replace("\n", ""):
                        mapStrings.append(line.split("=")[1].replace(" ", "").replace("\n", "") + ":" + mapString)
                if method == "only":
                    if line.split("=")[1].replace(" ", "").replace("\n", "") == varname.replace(" ", ""):
                        mapStrings.append(line.split("=")[1].replace(" ", "").replace("\n", "") + ":" + mapString)
#Print all the values found
if len(mapStrings) > 0:
    print("[Success]" + ",".join(mapStrings))
else:
    print("[Error]This varname does not exist.")