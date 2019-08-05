using System;
namespace phone
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) { }

        public string Ring()
        {
            return $"...{ringTone}...";
        }

        public string Unlock()
        {
            return $"Galaxy {versionNumber} unlocked with fingerprint scanner";
        }

        public override void DisplayInfo()
        {
            System.Console.WriteLine($"#########################{Environment.NewLine}Nokia {versionNumber}{Environment.NewLine}Battery Percentage: {batteryPercentage}{Environment.NewLine}Carrier: {carrier}{Environment.NewLine}Ring Tone: {ringTone}{Environment.NewLine}#########################");
        }
    }
}