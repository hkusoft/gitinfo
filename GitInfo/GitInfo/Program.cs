using System;
using System.Collections.Generic;
using LibGit2Sharp;
using System.Linq;

namespace GitInfo
{
    public class API
    {
		const string RepoPath = @"/Users/m1/Data/source/dch/mobility";

		//"path\to\repo.git"
		public static List<Tag> GetTags()
		{

			using (var repo = new Repository(RepoPath))
			{
				return repo.Tags.ToList<Tag>();
			}

		}
    }



    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var tags = API.GetTags();
            foreach (var tag in tags)
            {
                Console.WriteLine(tag.FriendlyName);
            }
        }
    }

	
}
