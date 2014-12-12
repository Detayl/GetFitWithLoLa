using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json.Linq;


namespace LeagueWorkoutProgram
{
    public partial class frmWorkoutProgram : Form
    {
        public int wrkout = 0;

        public frmWorkoutProgram()
        {
            InitializeComponent();
            radPushups.Select();//On form load selects Pushups and the initial workout.
            this.ActiveControl = txtUserName;
        }
        public static JObject token = new JObject();

        public static string TestAPIConnect(string info)//Returns userID string to calling method
        {

            WebClient client = new WebClient();//Opens WebClient, much tidier than using a full class to initiate a connection when all we are doing is getting data.
            Stream stream = client.OpenRead("https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/" + info + "?api_key=");//visits API and pulls data (Remains blank to maintain my API key integrity)
            StreamReader reader = new StreamReader(stream);//Reads Data
            token = JObject.Parse(reader.ReadLine());//Changes to a searchable token for userID
            string summonerID = (string)token.SelectToken(info + ".id");//Finds user ID.
            return summonerID;//returns the ID.

        }

        public static Tuple<string, string, string> PullTeamKDA (string info)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://na.api.pvp.net/api/lol/na/v1.3/game/by-summoner/" + info + "/recent?api_key="); //Pull info and Read it
            StreamReader reader = new StreamReader(stream);//Reads info into a "stream" or basically a string
            token = JObject.Parse(reader.ReadLine());//Sets a Token and Parses the json info
            string kills = (string)token.SelectToken("games[0].stats.championsKilled");//Selecting most recent game and then the kills from the game.
            string deaths = (string)token.SelectToken("games[0].stats.numDeaths");//Same as previous but with deaths.
            string assists = (string)token.SelectToken("games[0].stats.assists");//Assists.
            var tupleTeamKDA = new Tuple<string, string, string>(kills, deaths, assists);
            return tupleTeamKDA;
        }

        public static Tuple<string, string, string> ReturnMyKDA(string info, int selector)//Returns 3 strings to calling method, accepts a string and int ?? Can we do this without the int?
        {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://na.api.pvp.net/api/lol/na/v1.3/game/by-summoner/" + info + "/recent?api_key="); //Pull info and Read it
                StreamReader reader = new StreamReader(stream);//Reads info into a "stream" or basically a string
                token = JObject.Parse(reader.ReadLine());//Sets a Token and Parses the json info
                string kills = (string)token.SelectToken("games[0].stats.championsKilled");//Selecting most recent game and then the kills from the game.
                string deaths = (string)token.SelectToken("games[0].stats.numDeaths");//Same as previous but with deaths.
                string assists = (string)token.SelectToken("games[0].stats.assists");//Assists.
                var tupleKDA = new Tuple<string, string, string>(kills, deaths, assists);//Setting Variable to Tuple Data and Sending back to btn_Generate
                stream.Close();
                return tupleKDA;
            
        }

        public static int CalculateWorkout(int userKills, int userDeaths, int userAssists, int teamKillsHigh, int teamDeathsLow, int teamAssistsHigh, int workout)
    {
            int multiplier = 0;
            
            if (workout == 0)
            {
                multiplier = 5;
            }
            else {
                multiplier = 10;
            }

        int killDiff = teamKillsHigh - userKills;
        if (killDiff < 0)
            killDiff = 0;

        int deathDiff = userDeaths - teamDeathsLow;
        if (deathDiff < 0)
            deathDiff = 0;

        int assistDiff = teamAssistsHigh - userAssists;
        if (assistDiff < 0)
            assistDiff = 0;

        int total = (killDiff + deathDiff + assistDiff)* multiplier;

        return total;


    }
         public void SetLabels(string kills, string deaths, string assists, int labelSelector)
        {
            if (labelSelector == 0)
            {
                lblYourKills.Text = "Kills: " + kills;
                lblYourDeaths.Text = "Deaths: " + deaths;
                lblYourAssists.Text = "Assists: " + assists;
            }
            else if (labelSelector == 1)
            {
                lblTeamKillHigh.Text = "Kills: " + kills;
                lblTeamDeathLow.Text = "Deaths: " + deaths;
                lblTeamAssistHigh.Text = "Assists: " + assists;
            }
        }

        public void SetTotalLabel(int total, int workout)
         {
            string wType = "";

            if (workout == 0)
                wType = "Pushups";
            else if (workout == 1)
                wType = "Situps";
            else
                wType = "Squats";

                    lblTotal.Text = "Total " + wType + ": " + total;                       
         }

        public static Tuple<string, string, string> PullTeammatesInfo(JObject userInfo)
        {
            int team = (int)userInfo.SelectToken("games[0].stats.team");
            int teamkill = 0;
            int teamdeath = 99;
            int teamassist = 0;
            int tempKill = 0;
            int tempDeath = 99;
            int tempAssist = 0;

                        foreach(JObject teammate in userInfo.SelectToken("games[0].fellowPlayers"))
                        {
                            if((int)teammate.SelectToken("teamId") == team)
                            {
                                var TeamKDA = PullTeamKDA((string)teammate.SelectToken("summonerId"));
                                tempKill = Convert.ToInt32(TeamKDA.Item1);
                                tempDeath = Convert.ToInt32(TeamKDA.Item2);
                                tempAssist = Convert.ToInt32(TeamKDA.Item3);

                                if (tempKill > teamkill)
                                    teamkill = tempKill;

                                if (tempDeath < teamdeath)
                                    teamdeath = tempDeath;

                                if (tempAssist > teamassist)
                                    teamassist = tempAssist;

                            }
                        }
            var bestKDA = new Tuple<string, string, string>(teamkill.ToString(), teamdeath.ToString(), teamassist.ToString());
            return bestKDA;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This workout program is based on the stats you have got from your last game. It should pull the information from your match history and then generate the workout." +
                "This is generated based on whatever the highest Kills and Assists were on the team, as well as lowest Deaths. Whatever your scores were are taken from the highs/lows and multiplied" + 
                "based on the workout.\n\nPushups are 5 times the difference, Situps and Squats are 10 times the difference.\n\nKeep in mind that this needs to be ran directly after the game has" +
                "ended in order to give accurate results based on your teammates scores, or else this will give their most recent game stats as well as yours. This is not synced based on gameID." +
                "\n\nCreated by: Detayl (Summoner, NA Server)\n\nPlease remember Get Fit With LoL(GFWL) isn't endorsed by Riot Games and doesn't reflect the views or opinions of Riot Games or " +
                "anyone officially involved in producing or managing League of Legends. League of Legends and Riot Games are trademarks or registered trademarks of Riot Games, Inc. League of" +
                "Legends © Riot Games, Inc.", "About - Get Fit With LoL(GFWL)");
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String userName =  txtUserName.Text.Replace(" ", "").Trim().ToLower(); //Take username from textbox, reformat for search
            if (userName == "" || userName == null)
            {
                MessageBox.Show("Error, no information input.", "Error");
            }
            else
            {
                string userID = TestAPIConnect(userName);
                var KDA = ReturnMyKDA(userID, 0);
                var KDATeam = PullTeammatesInfo(token);
                SetLabels(KDATeam.Item1, KDATeam.Item2, KDATeam.Item3, 1);
                SetLabels(KDA.Item1, KDA.Item2, KDA.Item3, 0);
                SetTotalLabel(CalculateWorkout(Convert.ToInt32(KDA.Item1), Convert.ToInt32(KDA.Item2), Convert.ToInt32(KDA.Item3), Convert.ToInt32(KDATeam.Item1), Convert.ToInt32(KDATeam.Item2), Convert.ToInt32(KDATeam.Item3), wrkout), wrkout);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radPushups_CheckedChanged(object sender, EventArgs e)
        {
            wrkout = 0;
        }

        private void radSitups_CheckedChanged(object sender, EventArgs e)
        {
            wrkout = 1;
        }

        private void radSquats_CheckedChanged(object sender, EventArgs e)
        {
            wrkout = 2;
        }
       
    }
}
