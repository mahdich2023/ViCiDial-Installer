# ViCiDial Launcher / Installer
Here we have a launcher for ViCiDial designed for deployment on agent desktops! Some of the features of this launcher include;

- Runs ViCiDial in full-screen mode to prevent agents from closing the dialer down during operation. This can decrease the amount of drop calls you experience on your campaign.
- Additionally, agents cannot close easily close ViCiDial with common methods like Alt+F4 further decreasing the likelihood of dropped calls.
- Running the launcher can increase data integrity and keep data sane.
- Running the launcher can decrease the chances of LAGGED issues as the process runs in isolation and is not marred by Edge's Throttling mechanisms.

This launcher is built for and will run on 32-bit and 64-bit Microsoft Windows machines. This installer and launcher was built using Visual C# and the awesome, InstallForge. ViCiDial is a dialler system maintained by the ViCiDial Group.

# How to Use This
1) Download one of the installers;

- ViCiDial Launcher x86 Installer.exe (Windows 32-bit Installer).
- ViCiDial Launcher x64 Installer.exe (Windows 64-bit Installer).

2) Run the installer on the agent's computer. There is no need for administrator privileges.

3) A shortcut can be placed on the agent's desktop and/or in their Start Menu (Under ViCiDial Launcher). The application files will be placed in a folder on the agent's desktop called "ViCiDial Launcher".

4) You must configure the application to point to your ViCiDial installation. Open %USERPROFILE%\Desktop\ViCiDial Launcher and edit vicidial_server_address.txt and place the URL of your cluster on the first line.

5) Launch the ViCiDial Launcher shortcut and enjoy.

6) To terminate the application, open the task manager, right-click on ViCiDial Launcher.exe and click "End Task". Alternatively, logout or restart your computer.

# Screenshots
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Installer%20Splash%20Screen.png" height="425" width="600">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Installer%20Setup%20Wizard%20Part%201.png" height="425" width="600">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Installer%20Setup%20Wizard%20Part%202.png" height="425" width="600">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Installer%20Setup%20Wizard%20Part%203.png" height="425" width="600">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Installer%20Setup%20Wizard%20Part%204.png" height="425" width="600">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Installer%20Setup%20Wizard%20Part%205.png" height="425" width="600">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Installer%20Start%20Menu%20Items.png" height="425" width="750">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Kiosk%20Mode%20%231.png" height="425" width="1000">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Kiosk%20Mode%20%232.png" height="425" width="1000">
<img src="https://github.com/TheBlode/ViCiDial-Installer/blob/main/screenshots/ViCiDial%20Kiosk%20Mode%20%233.png" height="425" width="1000">

# Known bugs
- No known at this time. If you find bugs, please report them on;

https://github.com/TheBlode/ViCiDial-Installer/issues

# Upcoming changes
- Linx installer. You may have success with wine or Bottles but I will try to deploy an AppImage.
- Allow the process to be terminated when the agent logs out of ViCiDial.

# Links
Official ViCiDial forum post -> http://www.vicidial.org/VICIDIALforum/viewtopic.php?f=5&t=41813

mDial page -> https://github.com/TheBlode/mDial

Project page -> https://github.com/TheBlode/ViCiDial-Installer