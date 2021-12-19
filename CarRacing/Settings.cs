using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    class Settings
    {
        static public int TimerSpeed;
        static public int GameSpeed;
        static public int CarTurnSpeed;
        static public bool IsGameOver;
        public Settings()
        {
            TimerSpeed = 100;
            GameSpeed = 4;
            CarTurnSpeed = 10;
            IsGameOver = false;
        }
    }
}
