﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HashtagNoDoom.Resources
{
    static class StaticURIs
    {
        public static Uri GameIcon = new Uri(Directory.GetCurrentDirectory() + "\\data\\icon.png", UriKind.Absolute);
        public static List<string> TitleQuotes = new List<string>();
        static StaticURIs()
        {
            TitleQuotes.Add(": This ain't no doom copy!");
            TitleQuotes.Add(": IGN 10/10");
            TitleQuotes.Add(": Most immersive game ever");
            TitleQuotes.Add(": Tanárnő, ugye 60/60?");
        }

        public static Uri MenuTitle = new Uri(Directory.GetCurrentDirectory() + "\\data\\title.png", UriKind.Absolute);
        public static Uri MenuVideo = new Uri(Directory.GetCurrentDirectory() + "\\data\\menubck.mp4", UriKind.Absolute);
        public static Uri MenuMusic = new Uri(Directory.GetCurrentDirectory() + "\\data\\menu.mp3", UriKind.Absolute);
        public static Uri MenuNewGame = new Uri(Directory.GetCurrentDirectory() + "\\data\\New_game.png", UriKind.Absolute);
        public static Uri MenuScore = new Uri(Directory.GetCurrentDirectory() + "\\data\\Score.png", UriKind.Absolute);
        public static Uri MenuExit = new Uri(Directory.GetCurrentDirectory() + "\\data\\Exit.png", UriKind.Absolute);


        public static Uri Cogwheel = new Uri(Directory.GetCurrentDirectory() + "\\data\\cogwheel.png", UriKind.Absolute);
        public static Uri Help = new Uri(Directory.GetCurrentDirectory() + "\\data\\help.png", UriKind.Absolute);

        public static Uri FirstMap = new Uri(Directory.GetCurrentDirectory() + "\\data\\FirstMap.png", UriKind.Absolute);

        public static BitmapImage[] PlayerOne_BitMaps = 
        {
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\d1.PNG")), //0-4 //StandBy = 0
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\d2.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\d3.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\d4.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\d5.PNG")),

            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\u1.png")), //5-9 //StandBy = 5
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\u2.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\u3.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\u4.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\u5.png")),
            
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\l1.png")),//10-14 //StandBy = 10
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\l2.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\l3.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\l4.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\l5.png")),

            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\r1.png")),//15-19 // StandBy = 15
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\r2.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\r3.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\r4.png")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\p_one\\r5.png"))
        };

        public static BitmapImage[] Imp_BitMaps =
        {
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\d1.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\d2.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\d3.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\d4.PNG")),

            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\u1.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\u2.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\u3.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\u4.PNG")),

            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\l1.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\l2.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\l3.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\l4.PNG")),

            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\r1.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\r2.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\r3.PNG")),
            new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\data\\minions\\imp\\r4.PNG")),
        };

    }
}
