using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Video
{
    public string _title = "";
    public string _author = "";
    public double _length;
    public List<Video> _videos = new List<Video>();
    public List<Comment> _comments = new List<Comment>();
    //public List<Comment> _commentsVid2 = new List<Comment>();
    //public List<Comment> _commentsVid3 = new List<Comment>();
    //public List<Comment> _commentsVid4 = new List<Comment>();



    public int ReturnNumberOfComments()
    {
        return _comments.Count;

    }
    //public int ReturnNumberOfComments2()
    //{
    //    return _commentsVid2.Count;

    //}

    //public int ReturnNumberOfComments3()
    //{
    //    return _commentsVid3.Count;

    //}
    //public int ReturnNumberOfComments4()
    //{
    //    return _commentsVid4.Count;

    //}


    public void DisplayVideo()
    {
        foreach (Video video in _videos)
        {   
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} second(s)");
            Console.WriteLine();
            Console.WriteLine($"Comments: {ReturnNumberOfComments()}");
            Console.WriteLine();
            foreach (Comment comment in _comments)
            {
                comment.DisplayComment();
            }
            //foreach (Comment comment in _commentsVid2)
            //{
            //    comment.DisplayComment();
            //}
            //foreach (Comment comment in _commentsVid3)
            //{
            //    comment.DisplayComment();
            //}
            //foreach (Comment comment in _commentsVid4)
            //{
            //    comment.DisplayComment();
            //}
        }
    }
}