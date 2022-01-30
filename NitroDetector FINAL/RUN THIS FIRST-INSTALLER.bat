@echo off
title NitroDetector First-Time Setup Wizard
echo NitroDetector First-Time Setup Wizard
echo.
echo IF ACCESS DENIED, RUN THIS AGAIN AS ADMINISTRATOR - RIGHT CLICK BATCH AND RUN AS ADMINISTARTOR.
echo.
mkdir C:\Users\Public\Nitro_Detector
mkdir "C:\Program Files\Nitro_Detector"
copy "%~dp0\Config.txt" "C:\Users\Public\Nitro_Detector"
copy "%~dp0\NitroDetector.exe" "C:\Program Files\Nitro_Detector"

set SCRIPT="%TEMP%\%RANDOM%-%RANDOM%-%RANDOM%-%RANDOM%.vbs"

echo Set oWS = WScript.CreateObject("WScript.Shell") >> %SCRIPT%
echo sLinkFile = "%USERPROFILE%\Desktop\NitroDetector.lnk" >> %SCRIPT%
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> %SCRIPT%
echo oLink.TargetPath = "C:\Program Files\Nitro_Detector\NitroDetector.exe" >> %SCRIPT%
echo oLink.Save >> %SCRIPT%

cscript /nologo %SCRIPT%
del %SCRIPT%

pause >nul
