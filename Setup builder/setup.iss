; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "DofusBot"
#define MyAppVersion "2.66.10.1"
#define MyAppExeName "AmaknaProxy.Sniffer.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{0293C53E-06CE-4AB5-8943-B8CD6768DE3F}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputBaseFilename=Setup_DofusBot_2.66.10.1
SetupIconFile=D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\Ressources\logoBot.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\Build\Json\idToLibellePOI.json"; DestDir: "{app}\Json"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\Build\Json\listeCorrespondances.json"; DestDir: "{app}\Json"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\Build\Json\listeHint.json"; DestDir: "{app}\Json"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\Build\Json\MapPositions.json"; DestDir: "{app}\Json"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\AmaknaProxy.Hooks.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\AmaknaProxy.Hooks.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\AmaknaProxy.Sniffer.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\AmaknaProxy.Sniffer.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\AmaknaProxy.Sniffer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\EasyHook.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\EasyHook.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\EasyHook32.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\EasyHook32Svc.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\EasyHook64.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\EasyHook64Svc.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\EasyLoad32.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\EasyLoad64.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\Microsoft.Bcl.AsyncInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\Microsoft.Bcl.AsyncInterfaces.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Buffers.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Numerics.Vectors.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Runtime.CompilerServices.Unsafe.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Text.Encodings.Web.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Text.Encodings.Web.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Text.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Text.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.Threading.Tasks.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.ValueTuple.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\System.ValueTuple.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Documents\batch\ProjetsC#\BotMITM\VersionDofusDB\AmaknaCoreSniffer\AmaknaCore-Sniffer-master\AmaknaProxy.Sniffer\bin\Release\WeifenLuo.WinFormsUI.Docking.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

