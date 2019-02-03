﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    class Game
    {
        public string _name;
        public int _numberOfPlayers;
        public float _rating;
        public string _originCountry;

        public Game()
        {

        }

        public Game(string name, float rating = 5.5f)
        {
            _name = name;
            _rating = rating;
        }

        public Game(string name, int numberOfPlayers, float rating, string originCountry)
        {
            _name = name;
            _numberOfPlayers = numberOfPlayers;
            _originCountry = originCountry;
            _rating = rating;
        }

        public Game(string name, string originCountry)
        {
            _name = name;
            _originCountry = originCountry;
        }

        public int TellMeHowManyPlayers()
        {
            return _numberOfPlayers;
        }

        public override string ToString()
        {
            return $"Game Name : {_name} Number of players : {_numberOfPlayers} Rating : {_rating} Origin country : {_originCountry}";
        }
    }

}