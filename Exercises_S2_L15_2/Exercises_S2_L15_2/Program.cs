using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S2_L15_2
{
    class Program
    {
        //exercise specification is to simply create a Post class & use it to up-vote/down-vote/get votes

        static void Main(string[] args)
        {
            var post = new Post("How to Foo the Bar", "Lorem Ipsum blah blah blah");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();

            Console.WriteLine("Vote value: " + post.Votes);
        }
    }
}
