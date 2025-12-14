using Bridge;

var linuxSystem = new LinuxSystem() { sysInterface = new ConsoleInterface() };
linuxSystem.DisplayMenu();

var windowsSystem = new WindowsSystem() { sysInterface = new GUIInterface() };
windowsSystem.DisplayMenu();