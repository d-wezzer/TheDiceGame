using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nfocus.dylanwesthead.dicegame
{
    internal class Dice
    {
        // The number of sides the dice will possess.
        int numOfSides = 6;
        public int diceNumber { get; set; }

        //Empty constructor, creates dice with the default properties above.
        public Dice()
        {
        }

        // Allows user to create dice with a specific number of sides on the dice.
        public Dice(int numOfSides) 
        {
            this.numOfSides = numOfSides;
        }


        // The method used to roll the dice. Generates a radnom number between 1 and the numOfSides value.
        public int throwDice()
        {
            Random rand = new Random();
            this.diceNumber = rand.Next(1, numOfSides + 1);

            return diceNumber;
        }

       // -------------------------------------------------
        public int getNumOfSides()
        {
            return numOfSides;
        }
        public void setNumOfSides(int numOfSides)
        {
            this.numOfSides = numOfSides;
        }
    }
}
