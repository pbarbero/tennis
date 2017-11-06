using System;
using System.Collections.Generic;

namespace tennis
{
    public class Player
    {
        public string name {get;set;}
        public int points{get;set;}
        public int games{get;set;}
        public int sets{get;set;}
        public List<int> gamesWon {get;set;}
    }
}