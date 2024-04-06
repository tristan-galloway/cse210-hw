using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Create List to hold videos
        List<Video> videos = new();

        Video v1 = new("Rick Astley - Never Gonna Give You Up (Official Music Video)", "Rick Astley", 212);
        v1.AddComment("cal3819", "When they put ads so you can't rickroll anymore");
        v1.AddComment("GuyontheInternet525", "People don't Rickroll me: \nMe: Fine, I'll do it myself");
        v1.AddComment("ailo8625", "I leave my comment here so that every time someone \"likes\" I get a notification and it reminds me that I have to come listen to this great song again");
        videos.Add(v1);

        Video v2 = new("Leeroy Jenkins HD (High Quality)", "DBlow2003", 170);
        v2.AddComment("84updown", "Who else has no idea what they're talking about and is only here for \nLEEROYYYYYYYY JENKIIINNNSS");
        v2.AddComment("theeshyguy", "The best part is that the other guys weren't even super angry, just disappointed lol");
        v2.AddComment("OfficialNinjaSkillz", "10 Years already we need to find all of these players and make a Leeroy Jenkins reunion");
        videos.Add(v2);

        Video v3 = new("HEYYEYAAEYAAAEYAEYAA", "ProtoOfSnagem", 126);
        v3.AddComment("Mrhellslayerz", "This video is like a black hole. No matter how hard you try, YT always finds a way to bring you back here.");
        v3.AddComment("jestercorn2775", "If this video is deleted will the internet die?");
        v3.AddComment("nia.r5988", "Imagined we all died and this was the only proof we were alive.");
        v3.AddComment("briancmusic6872", "This is the core of the entire internet.");
        videos.Add(v3);
        
        Console.Clear();

        foreach (Video v in videos)
        {
            v.GetVideo();
            Console.WriteLine("------------------------------------------");
        }
        
    }
}