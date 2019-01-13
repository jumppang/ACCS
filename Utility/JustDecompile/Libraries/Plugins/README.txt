Guidelines for loading/unloading plugins into JustDecompile.

 - Loading plugins: JustDecompile will load on startup all of the plugins it finds in the “Plugins” sub-folder of the installation root folder(that's the folder where JustDecompile.exe resides). Each plugin needs to be placed in its own sub-folder of the "Plugins" folder. This will prevent file name collisions. 
 - Unloading Plugins: To disable a particular plugin it just needs to be removed from the “Plugins” sub-folder of the installation root folder.
 - Checking Current Status: There is a Plugin Manager in JustDecompile now (Tools -> Plugins…) that lists all of the currently loaded plugins.
