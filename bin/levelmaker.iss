[Setup]
AppName=PvZ U Level Editor
AppVersion=1.1.0
DefaultDirName={autopf}\PvZ U Level Editor
DefaultGroupName=PvZ U Level Editor
OutputDir=.\InstallerOutput
OutputBaseFilename=PvZULevelEditorInstaller
Compression=lzma
SolidCompression=yes

[Files]
Source: "Release\net8.0-windows\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\PvZ U Level Editor"; Filename: "{app}\PvZU_Level_Maker.exe"
Name: "{group}\Uninstall PvZ U Level Editor"; Filename: "{uninstallexe}"
