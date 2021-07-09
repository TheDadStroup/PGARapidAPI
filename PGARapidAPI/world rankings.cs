using System;
using System.Collections.Generic;

namespace PGARapidAPI
{
    public class world_rankings
    {

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Fields
        {
            public string last_updated { get; set; }
        }

        public class Meta
        {
            public string title { get; set; }
            public string description { get; set; }
            public Fields fields { get; set; }
        }

        public class Ranking
        {
            public int position { get; set; }
            public int movement { get; set; }
            public int player_id { get; set; }
            public string player_name { get; set; }
            public int num_events { get; set; }
            public string avg_points { get; set; }
            public string total_points { get; set; }
            public string points_lost { get; set; }
            public string points_gained { get; set; }
        }

        public class Results
        {
            public DateTime last_updated { get; set; }
            public List<Ranking> rankings { get; set; }
        }

        public class Root
        {
            public Meta meta { get; set; }
            public Results results { get; set; }
        }


    }
}
