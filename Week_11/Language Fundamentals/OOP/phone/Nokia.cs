using System;
namespace phone
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) :base ( versionNumber,  batteryPercentage,  carrier,  ringTone){}

        public string Ring(){
            return $"...{ringTone}...";
        }

        public string Unlock(){
            return $"Nokia {versionNumber} unlocked with fingerprint scanner";
        }

        public override void DisplayInfo(){
            System.Console.WriteLine($"#########################{Environment.NewLine}Nokia {versionNumber}{Environment.NewLine}Battery Percentage: {batteryPercentage}{Environment.NewLine}Carrier: {carrier}{Environment.NewLine}Ring Tone: {ringTone}{Environment.NewLine}#########################");
        }
    }
}