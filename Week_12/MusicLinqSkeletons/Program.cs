using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var artist = Artists.Where(
                a=>a.Hometown=="Mount Vernon")
                .Select(myArtist => new Artist{RealName = myArtist.RealName, Age = myArtist.Age});
            foreach(var art in artist)
            {
                System.Console.WriteLine($"Artists from Mount Vernon: Artist Name: {art.ArtistName} Real Name: {art.RealName} Age:{art.Age}");
            }

            

            //Who is the youngest artist in our collection of artists?
            var youngest = Artists.OrderByDescending(x=>x.Age).Last();
            
            System.Console.WriteLine($"Youngest artist: Artist Name: {youngest.ArtistName} Real Name: {youngest.RealName} Age: {youngest.Age}");

            //Display all artists with 'William' somewhere in their real name
            var williams = Artists.Where(will => will.RealName.Contains("William"));
            foreach(var will in williams)
            {
                System.Console.WriteLine(will.RealName);
            }

            //Display the 3 oldest artist from Atlanta
            var threeoldest = Artists.Where(a=>a.Hometown=="Atlanta").OrderByDescending(x=>x.Age).Take(3);
            foreach(var old in threeoldest)
            {
                System.Console.WriteLine($"Artist Name: {old.ArtistName} Real Name: {old.RealName} Age: {old.Age}");
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'

	       
        }
    }
}
