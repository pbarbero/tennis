using System;
using System.Collections.Generic;

namespace tennis
{
    public class Match
    {
        private Player player1{get;set;}
        private Player player2{get;set;}
        int numberSets{get;set;}

        public Match(string name1, string name2, int numberSets)
        {
            this.player1 = new Player(){name = name1};
            this.player2 = new Player(){name = name2};
            this.numberSets = numberSets;

            //Init Players
            player1.gamesWon = new List<int>();
            player2.gamesWon = new List<int>();
            for(int i = 0; i < numberSets; i++)
            {
                player1.gamesWon.Add(0);
                player2.gamesWon.Add(0);
            }
        }

        public void PlayMatch()
        {
            //start player
            Player starterPlayer = RandomPlayer();

            string messageStarterPlayer = "\n{0} iniciará el partido sacando.";
            Console.WriteLine(string.Format(messageStarterPlayer, starterPlayer.name));

            //For Number of sets
            int countGames;
            for(int i = 0; i < numberSets; i++)
            {
                player1.games = 0;
                player2.games = 0;
                countGames = 1;

                while(!IsSetFinished())
                {
                    Console.WriteLine(string.Format("** Juego {0} - Set {1}", countGames, i+1));
                    PlayGame(i);
                    countGames++;
                }


                if(player1.games > player2.games)
                {
                    player1.sets++;
                    Console.WriteLine(string.Format("{0} gana el set.", player1.name));
                }
                else if(player1.games < player2.games)
                {
                    player2.sets++;
                    Console.WriteLine(string.Format("{0} gana el set.",  player2.name));
                }
            }


            //Final message
            if(player1.sets > player2.sets)
            {
                Console.WriteLine(string.Format("!!{0} gana el partido!!", player1.name).ToUpper());
            }
            else if(player1.sets < player2.sets)
            {
                Console.WriteLine(string.Format("!!{0} gana el partido!!", player2.name).ToUpper());
            }
        }

        bool IsSetFinished()
        {
            if(player1.games < 6 && player2.games < 6)
            {
                return false;
            }
            else if(player1.games == 7 || player2.games == 7)
            {
                return true;
            }
            else
            {
                if(Math.Abs(player1.games - player2.games) < 2)
                {
                    return false;
                }   
                else
                {
                    return true;
                }
            }

        }

        void PlayGame(int numberSet)
        {
            while(!IsGameFinished())
            {
                //Play point
                Player winner = RandomPlayer();
                winner.points++;
                
                Console.WriteLine(MessageEndPoint(winner));
            }

            string messageWinnerGame = "{0} gana el juego \t\t ({1})";
            if(player1.points > player2.points)
            {
                player1.games++;   
                player1.gamesWon[numberSet]++;             
                Console.WriteLine(string.Format(messageWinnerGame, player1.name, GetMessagePuntuations()));
            }
            else if(player1.points < player2.points)
            {
                player2.games++;
                player2.gamesWon[numberSet]++;    
                Console.WriteLine(string.Format(messageWinnerGame, player2.name, GetMessagePuntuations()));
            }

            //Reboot points
            player1.points = 0;
            player2.points = 0;
        }

        bool IsGameFinished()
        {
            if(player1.points < 4 && player2.points < 4)
            {
                return false;
            }
            else
            {
                if(Math.Abs(player1.points - player2.points) < 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        Player RandomPlayer()
        {                
            Random random = new Random();
            int index = random.Next(0, 2);
            if(index == 0)
            {
                return this.player1;
            }
            else
            {
                return this.player2;
            }
        }

        #region Messages 

        string MessageEndPoint(Player winner)
        {
            string message = "Punto de {0} {1}-{2} \t\t ({3})";

            return string.Format(message, winner.name
                                        , GetScore(player1.points)
                                        , GetScore(player2.points)
                                        , GetMessagePuntuations()
                                        );
        }

        string GetMessagePuntuations()
        {
            List<string> puntuations = new List<string>();
            for(int i = 0; i < player1.gamesWon.Count; i++)
            {
                puntuations.Add(string.Format("{0}-{1}", player1.gamesWon[i], player2.gamesWon[i]));
            }

            return string.Join(",", puntuations);
        }


        string GetScore(int points)
        {
            if(points == 0)
            {
                return "0";
            }
            else if(points == 1)
            {
                return "15";
            }
            else if(points == 2)
            {
                return "30";

            }
            else if(points == 3)
            {
                return "40";
            }
            else
            {
                return "Ad";
            }
        }
        #endregion
    }
}