using System;
using NuGet.Configuration;

namespace console3
{
    class Program
    {
        static void Main(string[] args)
        {
            var machineWideSettingsOnly = Settings.LoadDefaultSettings(
                    root: null,
                    configFileName: null,
                    machineWideSettings: new XPlatMachineWideSetting());

            var result = SettingsUtility.GetGlobalPackagesFolder(machineWideSettingsOnly);

            Console.WriteLine(result);
        }
    }
}
