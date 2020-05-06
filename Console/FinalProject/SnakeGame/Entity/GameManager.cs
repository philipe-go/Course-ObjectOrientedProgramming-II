using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Entity
{
    class GameManager
    {
        #region SingletonPattern
        private static GameManager instance = null;
        private GameManager() { }
        public static GameManager GetInstance()
        {
            if (instance == null) { instance = new GameManager(); }
            return instance;
        }
        #endregion
    }
}
