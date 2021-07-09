using System;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace PGARapidAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new RestClient("https://golf-leaderboard-data.p.rapidapi.com/tour-rankings/2/2021");
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("x-rapidapi-key", "ad097d5c45mshbc13e25e0f79185p1231e3jsn175260ba160d");
            //request.AddHeader("x-rapidapi-host", "golf-leaderboard-data.p.rapidapi.com");
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            //var golfRankings = JsonConvert.DeserializeObject<Root>(response.Content);

            //var bestPlayer = new Ranking();
            //int mostWins = 0;
            //foreach (var ranking in golfRankings.results.rankings)
            //{


            //    if (ranking.num_wins > mostWins)
            //    {
            //        mostWins = ranking.num_wins;
            //        bestPlayer = ranking;
            //    }


            //}



            //var topTwentyFive = golfRankings.results.rankings.OrderByDescending(x => x.num_wins).Take(25);

            //foreach (var player in topTwentyFive)
            //{
            //    Console.WriteLine("..................");
            //    Console.WriteLine(player.player_name);
            //    Console.WriteLine(player.num_wins);
            //}


            //Console.WriteLine($"the player with the most wins is...");
            //Console.WriteLine(bestPlayer.player_name);
            //Console.WriteLine($"with a total win number of {bestPlayer.num_wins}");

            var client = new RestClient("https://golf-leaderboard-data.p.rapidapi.com/world-rankings");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "ad097d5c45mshbc13e25e0f79185p1231e3jsn175260ba160d");
            request.AddHeader("x-rapidapi-host", "golf-leaderboard-data.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var golfRankings = JsonConvert.DeserializeObject<Root>(response.Content);

            var topFifty = golfRankings.results.rankings.OrderByDescending(x => x.num_wins).Take(50);

            foreach (var player in topFifty)
            {
                Console.WriteLine("..................");
                Console.WriteLine($"{player.position} {player.player_name} ");

            }



        }



    }
}
