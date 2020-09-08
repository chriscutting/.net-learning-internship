using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232Unit10AssignmentCutting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes and inheritence.");
            Console.WriteLine(" ");
            Console.WriteLine("Base classes after adding");
            Console.WriteLine(" ");
            //Start class scoreKeeper/construct
            scoreKeeper gameOne = new scoreKeeper("Canasta");
            gameOne.addName("Larry");
            gameOne.addName("Moe");
            gameOne.addName("Curly");
            //add scores
            gameOne.addScores("Larry", 20);
            gameOne.addScores("Moe", 35);
            gameOne.addScores("Curly", 45);

            gameOne.listAllScores();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Derived class results from baseball");
            Console.WriteLine(" ");

            baseBall gameTwo = new baseBall("Cubs", "Braves");
            //The following will create a new scenario for the game
            gameTwo.addScores("Cubs", 2);
            gameTwo.advOuts();
            gameTwo.advOuts();
            gameTwo.advOuts();
            gameTwo.addScores("Braves", 3);
            gameTwo.advOuts();
            gameTwo.advStrikes();
            gameTwo.advFouls();
            gameTwo.advFouls();
            gameTwo.advFouls();
            gameTwo.advBalls();

            //Print current results
            gameTwo.listAllScores();
            Console.WriteLine(" ");
            Console.WriteLine("The current inning is " + gameTwo.getInning());
            Console.WriteLine("Outs:" + gameTwo.getOuts());
            Console.WriteLine("Balls:" + gameTwo.getBalls());
            Console.WriteLine("Fouls" + gameTwo.getFouls());
            Console.WriteLine("Strikes:" + gameTwo.getStrike());



        }
    }
    //Now to make things in the code exist. First off the base class of scoreKeeper
    class scoreKeeper
    {
        private string gamePlayed;
        private Dictionary<string, int> players = new Dictionary<string, int>();

        //Class methods

        public void setGame(string name)
        {
            gamePlayed = name;
        }
        public string getGame()
        {
            return gamePlayed;
        }
        public void addName(string name)
        {
            players.Add(name, 0);
        }
        public string getPlayerName(int playerNum)
        {
            return players.Keys.ElementAt(playerNum - 1);

        }
        public int addScores(string player, int points)
        {
            players[player] = players[player] + points;
                return players[player];
        }
        public int subScore(string player, int points)
        {
            players[player] = players[player] - points;
            return players[player];
        }
        public int getScore(string name)
        {
            return players[name];
        }
        public void listAllScores()
        {
            string name;
            Console.WriteLine("The scores for " + gamePlayed + ":");

            //loop through players
            for (int i = 0; i < players.Count; i++)
            {
                name = getPlayerName(i + 1);
                Console.WriteLine(name + " score is " + getScore(name));
            }
        }
        //Default construction
        public scoreKeeper()
        {

        }

        public scoreKeeper(string game)
        {
            setGame(game);
        }



        class baseBall : scoreKeeper
        {
            //Inherit class baseball into the game
            //all class properties

            private double inning = 1;
            private int outs = 0;
            private int strikes = 0;
            private int fouls = 0;
            private int balls = 0;

            //all class methods

            public void advOuts()
            {
                outs++;
                if (outs >= 3)
                {
                    inning = inning + .5;
                    outs = 0;
                    fouls = 0;
                    balls = 0;
                    strikes = 0;

                }
            }

            public void advStrikes()
            {
                strikes++;
                if (strikes >= 3)
                {
                    advOuts();
                }
          
            }

            public void advFouls()
            {
                fouls++;
                if (strikes < 2)
                {
                    strikes++;
                }
                
            }

            public void advBalls()
            {
                balls++;
                if (balls >= 4)
                {
                    strikes = 0;
                    fouls = 0;
                    balls = 0;

                }
            }

            //The following methods return text fields
            public double getInning()
            { return inning; }

            public int getOuts()
            { return outs;  }

            public int getStrikes()
            { return strikes; }

            public int getFouls()
            { return fouls; }

            public int getBalls()
            { return balls; }

            //Default Constructs
            public baseBall()
            { 
            }

            public baseBall(string team1, string team2)
            {
                setGame(team1 + " vs. " + team2);
                addName(team1);
                addName(team2);
            }

        }


    }
  

}
