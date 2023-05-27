using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Game
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public Referee Referee { get; set; }
    public List<Goal> Goals { get; set; }
    public string Result
    {
        get
        {
            int team1Goals = Goals.Count(goal => goal.Team == "Team1");
            int team2Goals = Goals.Count(goal => goal.Team == "Team2");
            if (team1Goals > team2Goals)
            {
                return "Team1";
            }
            else if (team1Goals == team2Goals)
            {
                return "Draw";
            }
            else
            {
                return "Team2";
            }
        }
    }
    public Team Winner
    {
        get
        {
            if (Result == "Team1")
            {
                return Team1;
            }
            else if (Result == "Team2")
            {
                return Team2;
            }
            else
            {
                return null;
            }
        }
    }
}

