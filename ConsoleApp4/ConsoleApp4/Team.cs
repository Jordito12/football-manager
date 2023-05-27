using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Team
{
    public string TeamName { get; set; }
    public Coach Coach { get; set; }
    public List<FootballPlayer> Players { get; set; }
    public double AverageAge
    {
        get
        {
            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }
            return totalAge / Players.Count;
        }
    }
}

