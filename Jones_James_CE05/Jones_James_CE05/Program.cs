using System;
using System.Collections.Generic;

namespace Jones_James_CE05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* James M. Jones
             * 03/19/2021
             * DEV2000-O 02: Introduction to Development II
             * 2.4 Code Exercise: Advanced Dictionaries
             */

            //First, I want to create a Dictionary that will use a string of
            //the album name as the key and a List to hold at least (4) songs from each album.
            Dictionary<string, List<string>> favoriteAlbums = new Dictionary<string, List<string>>()
            {
                {"The Fame Monster", new List<string>() },
                {"Sail Out", new List<string>() },
                {"Passion, Pain & Demon Slayin'", new List<string>()},
                {"Isolation", new List<string>()}
            };

            //Next, I want to add songs from each album to lists.
            //The following 4 lines of code add (4) songs from The Fame Monster album.
            favoriteAlbums["The Fame Monster"].Add("Bad Romance");
            favoriteAlbums["The Fame Monster"].Add("Alejandro");
            favoriteAlbums["The Fame Monster"].Add("Monster");
            favoriteAlbums["The Fame Monster"].Add("Speechless");
            favoriteAlbums["The Fame Monster"].Add("Dance In The Dark");
            favoriteAlbums["The Fame Monster"].Add("Telephone");
            favoriteAlbums["The Fame Monster"].Add("So Happy I Could Die");
            favoriteAlbums["The Fame Monster"].Add("Teeth");

            //The following 4 lines of code add at least (4) songs from the Sail Out album.
            favoriteAlbums["Sail Out"].Add("The Vapors");
            favoriteAlbums["Sail Out"].Add("Bed Peace");
            favoriteAlbums["Sail Out"].Add("Stay Ready");
            favoriteAlbums["Sail Out"].Add("WTH");
            favoriteAlbums["Sail Out"].Add("The Worst");
            favoriteAlbums["Sail Out"].Add("3:16 AM");
            favoriteAlbums["Sail Out"].Add("Comfort Inn Ending");

            //The following 4 lines of code add at least (4) songs from the Passion, Pain & Demon Slayin' album.
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Frequency");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Swin In The Light");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Releaser");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("By Design");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("All In");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Illusions");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Rose Golden");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Baptized In Fire");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Flight At First Sight/Advanced");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Does It");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Dance 4 Eternity");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Distant Fantasies");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Wounds");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Mature Nature");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Kitchen");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Cosmic Warrior");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("The Guide");
            favoriteAlbums["Passion, Pain & Demon Slayin'"].Add("Surfin'");

            //The following 4 lines of code add at least (4) songs from the Isolation album.
            favoriteAlbums["Isolation"].Add("Body Language(Intro)");
            favoriteAlbums["Isolation"].Add("Miami");
            favoriteAlbums["Isolation"].Add("Just A Stranger");
            favoriteAlbums["Isolation"].Add("Flight 22");
            favoriteAlbums["Isolation"].Add("Your Teeth In My Neck");
            favoriteAlbums["Isolation"].Add("Tyrant");
            favoriteAlbums["Isolation"].Add("Dead To Me");
            favoriteAlbums["Isolation"].Add("Nuestro Planeta");
            favoriteAlbums["Isolation"].Add("In My Dreams");
            favoriteAlbums["Isolation"].Add("Gotta Get Up(Interlude)");
            favoriteAlbums["Isolation"].Add("Tomorrow");
            favoriteAlbums["Isolation"].Add("Coming Home(Interlude)");
            favoriteAlbums["Isolation"].Add("Feel Like A Fool");
            favoriteAlbums["Isolation"].Add("Killer");

            //Greet the user
            Console.WriteLine("\r\nHello and welcome to the Jukebox Hero!");
            Console.WriteLine("\r\nChoose an album and I will tell you all of the songs on the album.\r\n");

            foreach (KeyValuePair<string, List<string>> album in favoriteAlbums)
            {
                Console.WriteLine(album.Key);
            }

            //Tell the user to choose an album.
            Console.WriteLine("\r\nPlease choose an album from the above list:\r\n");
            //Prompt the user for the album they would like to listen to.
            string albumChoice = Console.ReadLine();

            //We want to validate that the user's album selection is on the avaiable
            while (!favoriteAlbums.ContainsKey(albumChoice) || string.IsNullOrWhiteSpace(albumChoice) || albumChoice == albumChoice.ToLower())
            {
                //Tell user the error
                Console.WriteLine("\r\nPlease only choose from the album list above.");

                //Re-ask the question
                Console.WriteLine("\r\nPlease choose an album from the available list:\r\n");

                //Re-catch the user's response in the same variable
                albumChoice = Console.ReadLine();
            }

            Console.WriteLine("\r\nThe album {0} has the following songs:\r\n", albumChoice);

            foreach (string songs in favoriteAlbums[albumChoice])
            {
                Console.WriteLine("\r\n" + songs);
            }

        }
    }
}
