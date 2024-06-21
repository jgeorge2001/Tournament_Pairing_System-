using System;
using System.Linq;
namespace Tournament
{
	public  class Tournament

	{

		
		class TeamNames
		{
			// Object Class Created for the Teams specifics
            class TeamList
            {
                public string TeamName { get; set; }
                public int TeamWins { get; set; }
            }

            public static void Main(string[] args)
			{


            // User input asked for the team's names and # of wins
            Console.WriteLine("Enter number of teams:(number must be even): ");

				string input = Console.ReadLine();

				int i = System.Convert.ToInt32(input);

				TeamList[] teamArray = new TeamList[i];

				int repeat = i;
				int n = 1;

				while (n <= repeat)
				{

					Console.WriteLine("Enter team name: ");

					   string name = Console.ReadLine();

					Console.WriteLine("Enter team's number of wins: ");

					   int wins = Convert.ToInt32(Console.ReadLine());

					//Added to array of objects
					TeamList obj = new TeamList() { TeamName = name, TeamWins = wins };

					teamArray[n-1] = obj;

                    n++;
				}

				//Array of objects printed which are teams entered in the list
				Console.WriteLine(" ");
				Console.WriteLine("Teams in the Tournament");
				Console.WriteLine("----------------------");

				foreach(TeamList teamList in teamArray)
				{
				Console.WriteLine("Team: {0}, # of Wins: {1}", teamList.TeamName, teamList.TeamWins);
				}

				Console.WriteLine(" ");
				Console.WriteLine("Tournament Game Pairings");
				int s = repeat;
				int v = 1;
				//Tournament games are created with the lowest 

					int minval = Array.IndexOf(teamArray, teamArray.OrderBy(x => x.TeamWins).FirstOrDefault());
					int maxval = Array.IndexOf(teamArray, teamArray.OrderByDescending(x => x.TeamWins).FirstOrDefault());

                    while (teamArray.Length > 0)
                    {
                        Console.WriteLine("Game " + v + ": " + teamArray[maxval].TeamName + " vs. " + teamArray[minval].TeamName);

					v++;

					List<TeamList> list = teamArray.ToList();

					list.RemoveAt(minval);

					if(minval < maxval)
					{
						maxval--;
					}
					list.RemoveAt(maxval);

					if(minval > maxval)
					   {
						 minval--;
					   }
					teamArray = list.ToArray();

					    if (teamArray.Length > 0)
					    {
                        minval = Array.IndexOf(teamArray, teamArray.OrderBy(x => x.TeamWins).FirstOrDefault());
                        maxval = Array.IndexOf(teamArray, teamArray.OrderByDescending(x => x.TeamWins).FirstOrDefault());

                        }

						

                    }
            }
		}
	}
}

