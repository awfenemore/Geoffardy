using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoffardy
{
    class Player
    {

        //Player Name
        private String name;

        //Players Score
        private int score;




        //Constructor
        public Player (String newName)
        {
            name = newName;
            score = 0;
        }




        //Sets the name
        public void setName (String newName)
        {
            name = newName;
        }


        //Changes the score
        public void addScore (int points)
        {
            score += points;
        }

        //Returns the score
        public int getScore ()
        {
            return score;
        }

    }
}
