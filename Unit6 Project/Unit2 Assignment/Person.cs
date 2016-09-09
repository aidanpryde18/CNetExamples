using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit6_Project
{
    class Person
    {
        //fields
        private string _name;       //The persons name
        private string _food;       //The persons favorite food
        private byte _age;          //The persons current age
       
        //Constructor
        public Person()
        {
            _name = "";
            _food = "";
            _age = 0;
        }

        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Food property
        public string Food
        {
            get { return _food; }
            set { _food = value; }
        }

        //Age property
        public byte Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //Set Greeting method returns the string below to whichever method called it. It uses the current property values of Name and Food.
        public string SetGreeting()
        {
            return "Hi " + _name + ", my favorite food is " + _food + " too!";
        }
        
        public string SetPrediction()
        {
            int future;     //variable to hold the random number for a number of years in the future

            int futureAge;  //variable to hold the sum of current age and future for the prediction string.

            Random rand = new Random();     //Creates a random number variable

            future = rand.Next(31) + 10;    //Sets future to a random integer between 10 and 40

            futureAge = _age + future;      //Sets the futureAge variable as the sum of users current age and the randomly generated number

            //Returns the string below to the calling method
            return "In " + future + " years, you will be " + futureAge + " years old and still like " + _food + " the most.";
        }

    }
}
