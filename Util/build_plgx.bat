set PluginRoot=..
set KeePassExe=%PluginRoot%\bin\Debug\KeePass.exe

xcopy /Y %PluginRoot%\Properties\AssemblyInfo.cs plgx\Properties\
xcopy /Y %PluginRoot%\HIBPOfflineCheck.csproj plgx\
xcopy /Y %PluginRoot%\HIBPOfflineCheck.sln plgx\
xcopy /Y %PluginRoot%\HIBPOfflineCheckExt.cs plgx\
xcopy /Y %PluginRoot%\HIBPOfflineCheckOptions.cs plgx\
xcopy /Y %PluginRoot%\HIBPOfflineCheckOptions.Designer.cs plgx\
xcopy /Y %PluginRoot%\HIBPOfflineCheckOptions.resx plgx\
xcopy /Y %PluginRoot%\Options.cs plgx\
xcopy /Y %PluginRoot%\Resources\Nuvola\B48x48_KOrganizer.png plgx\Resources\Nuvola\
xcopy /Y %PluginRoot%\Properties\Resources.Designer.cs plgx\Properties\
xcopy /Y %PluginRoot%\Properties\Resources.resx plgx\Properties\

%KeePassExe% --plgx-create %~dp0plgx

@ rem run the hole .bat from an existing command line, otherwise the file won't be moved
move /Y %~dp0plgx.plgx %PluginRoot%\HIBPOfflineCheck.plgx

rmdir /S /Q %~dp0plgx