using System;
using System.Threading;
using System.Collections.Generic;

namespace tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get names
            Console.Write("Nombre jugador 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Nombre jugador 2: ");
            string name2 = Console.ReadLine();

            //Get number of sets
            Console.Write("Partido a 3 ó 5 sets?: ");
            int numberSets = 0;
            while(numberSets != 3 && numberSets != 5)
            {
                bool result = Int32.TryParse(Console.ReadLine(), out numberSets);
                if(!result)
                {
                    Console.WriteLine("Por favor introduzca un número.");
                    continue;
                }
            }

            Match match = new Match(name1, name2, numberSets);

            // //start player
            // int starterPlayer = RandomPlayer(players);

            // string messageStarterPlayer = "\n{0} iniciará el partido sacando.";
            // Console.WriteLine(string.Format(messageStarterPlayer, players[starterPlayer].name));

            // //For Number of sets
            // int countGames;
            // for(int i = 0; i < numberSets; i++)
            // {
            //     players[0].games = 0;
            //     players[1].games = 0;
            //     countGames = 1;

            //     while(!IsSetFinished(players))
            //     {
            //         Console.WriteLine(string.Format("** Juego {0} - Set {1}", countGames, i+1));
            //         PlayGame(players, i);
            //         countGames++;
            //     }


            //     if(players[0].games > players[1].games)
            //     {
            //         players[0].sets++;
            //         Console.WriteLine(string.Format("{0} gana el set.", players[0].name));
            //     }
            //     else if(players[0].games < players[1].games)
            //     {
            //         players[1].sets++;
            //         Console.WriteLine(string.Format("{0} gana el set.",  players[1].name));
            //     }
            // }


            // //Final message
            // if(players[0].sets > players[1].sets)
            // {
            //     Console.WriteLine(string.Format("!!{0} gana el partido!!", players[0].name).ToUpper());
            // }
            // else if(players[0].sets < players[1].sets)
            // {
            //     Console.WriteLine(string.Format("!!{0} gana el partido!!", players[1].name).ToUpper());
            // }
            match.PlayMatch();
        }

        // static bool IsSetFinished(List<Player> players)
        // {
        //     if(players[0].games < 6 && players[1].games < 6)
        //     {
        //         return false;
        //     }
        //     else if(players[0].games == 7 || players[1].games == 7)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         if(Math.Abs(players[0].games - players[1].games) < 2)
        //         {
        //             return false;
        //         }   
        //         else
        //         {
        //             return true;
        //         }
        //     }

        // }

        // static void PlayGame(List<Player> players, int numberSet)
        // {
        //     while(!IsGameFinished(players))
        //     {
        //         //Play point
        //         int indexWinner = RandomPlayer(players);
        //         players[indexWinner].points++;
                
        //         Console.WriteLine(MessageEndPoint(players, indexWinner));
        //     }

        //     string messageWinnerGame = "{0} gana el juego \t\t ({1})";
        //     if(players[0].points > players[1].points)
        //     {
        //         players[0].games++;   
        //         players[0].gamesWon[numberSet]++;             
        //         Console.WriteLine(string.Format(messageWinnerGame, players[0].name, GetMessagePuntuations(players)));
        //     }
        //     else if(players[0].points < players[1].points)
        //     {
        //         players[1].games++;
        //         players[1].gamesWon[numberSet]++;    
        //         Console.WriteLine(string.Format(messageWinnerGame, players[1].name, GetMessagePuntuations(players)));
        //     }

        //     //Reboot points
        //     players[0].points = 0;
        //     players[1].points = 0;
        // }

        // static bool IsGameFinished(List<Player> players)
        // {
        //     if(players[0].points < 4 && players[1].points < 4)
        //     {
        //         return false;
        //     }
        //     else
        //     {
        //         if(Math.Abs(players[0].points - players[1].points) < 2)
        //         {
        //             return false;
        //         }
        //         else
        //         {
        //             return true;
        //         }
        //     }
        // }

        // static int RandomPlayer(List<Player> players)
        // {                
        //     Random random = new Random();
        //     return random.Next(0, players.Count);
        // }

        // static string MessageEndPoint(List<Player> players, int indexWinner)
        // {
        //     string message = "Punto de {0} {1}-{2} \t\t ({3})";

        //     return string.Format(message, players[indexWinner].name
        //                                 , GetScore(players[0].points)
        //                                 , GetScore(players[1].points)
        //                                 , GetMessagePuntuations(players)
        //                                 );
        // }

        // static string GetMessagePuntuations(List<Player> players)
        // {
        //     List<string> puntuations = new List<string>();
        //     for(int i = 0; i < players[0].gamesWon.Count; i++)
        //     {
        //         puntuations.Add(string.Format("{0}-{1}", players[0].gamesWon[i], players[1].gamesWon[i]));
        //     }

        //     return string.Join(",", puntuations);
        // }


        // static string GetScore(int points)
        // {
        //     if(points == 0)
        //     {
        //         return "0";
        //     }
        //     else if(points == 1)
        //     {
        //         return "15";
        //     }
        //     else if(points == 2)
        //     {
        //         return "30";

        //     }
        //     else if(points == 3)
        //     {
        //         return "40";
        //     }
        //     else
        //     {
        //         return "Ad";
        //     }
        // }
    }
}
