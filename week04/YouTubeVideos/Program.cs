using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Video List:");
        Console.WriteLine();

        Comment cm1 = new Comment();
        cm1._commenterName = "WDuke17";
        cm1._commentText = "He sure knows how to paddle!";
        Comment cm2 = new Comment();
        cm2._commenterName = "HipHop789";
        cm2._commentText = "I hope he doesn't make a mess while swimming!";
        Comment cm3 = new Comment();
        cm3._commenterName = "DevinBryan83";
        cm3._commentText = "Fido is sure working for his gold medal in the high dive!";
        Comment cm4 = new Comment();
        cm4._commenterName = "HilaryDuffFan02";
        cm4._commentText = "''I want to swim with my humans!''";
        Video vid1 = new Video();
        vid1._title = "Dog jumps in pool";
        vid1._author = "DailyDogVids";
        vid1._length = 120;
        vid1._comments.Add(cm1);
        vid1._comments.Add(cm2);
        vid1._comments.Add(cm3);
        vid1._comments.Add(cm4);
        vid1._videos.Add(vid1);
        vid1.DisplayVideo();

        Console.WriteLine();

        Comment cm5 = new Comment();
        cm5._commenterName = "Rebecca Hader";
        cm5._commentText = "That cat is probably thinking, ''Who are you?!''";
        Comment cm6 = new Comment();
        cm6._commenterName = "KuroNeko";
        cm6._commentText = "Awww! So cuuute!";
        Comment cm7 = new Comment();
        cm7._commenterName = "IndigoLeague97";
        cm7._commentText = "Has the cat ever thought of tapping on the mirror?";
        Comment cm8 = new Comment();
        cm8._commenterName = "DungeonMaster92";
        cm8._commentText = "He arguing with his inner conscience.";
        Video vid2 = new Video();
        vid2._title = "Cat meows itself in front of mirror";
        vid2._author = "CatasticVideos";
        vid2._length = 1000;
        vid2._comments.Add(cm5);
        vid2._comments.Add(cm6);
        vid2._comments.Add(cm7);
        vid2._comments.Add(cm8);
        vid2._videos.Add(vid2);
        vid2.DisplayVideo();

        Console.WriteLine();

        Comment cm9 = new Comment();
        cm9._commenterName = "JShon512";
        cm9._commentText = "This is why I do the drive-thru instead of dine-in!";
        Comment cm10 = new Comment();
        cm10._commenterName = "FrankWhelan";
        cm10._commentText = "It looks like she forgot the ketchup!";
        Comment cm11 = new Comment();
        cm11._commenterName = "MamaBear23";
        cm11._commentText = "I won't let nobody steal nuggets from my kids!";
        Comment cm12 = new Comment();
        cm12._commenterName = "KarenVids";
        cm12._commentText = "Where's the manager?!!";
        Video vid3 = new Video();
        vid3._title = "Crazy lady steals chicken nuggets";
        vid3._author = "TheDailyCraze";
        vid3._length = 880;
        vid3._comments.Add(cm9);
        vid3._comments.Add(cm10);
        vid3._comments.Add(cm11);
        vid3._comments.Add(cm12);
        vid3._videos.Add(vid3);
        vid3.DisplayVideo();

        Console.WriteLine();

        Comment cm13 = new Comment();
        cm13._commenterName = "RandyManor";
        cm13._commentText = "I remember guys twice this kid's size struggling to bench 300 back in high school!";
        Comment cm14 = new Comment();
        cm14._commenterName = "Barry FitzGerald";
        cm14._commentText = "Never, have I EVER seen such a skinny runt press THAT much in my entire life!";
        Comment cm15 = new Comment();
        cm15._commenterName = "SwolBros";
        cm15._commentText = "This bro puts all the pro lifters to shame!";
        Comment cm16 = new Comment();
        cm16._commenterName = "BicepsCurls5050";
        cm16._commentText = "I bet nobody will steal his lunch money after seeing this!";
        Video vid4 = new Video();
        vid4._title = "Skinny dude benches 400 lbs!";
        vid4._author = "SkinnyFeats";
        vid4._length = 1200;
        vid4._comments.Add(cm13);
        vid4._comments.Add(cm14);
        vid4._comments.Add(cm15);
        vid4._comments.Add(cm16);
        vid4._videos.Add(vid4);
        vid4.DisplayVideo();

        Console.WriteLine();

    }
}