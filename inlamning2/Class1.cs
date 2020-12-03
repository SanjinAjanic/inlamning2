using System;
using System.Collections.Generic;
using System.Text;

namespace inlamning2
{
    class Members 
    {
        //Fält
        private string name;
        private string hobby;
        private string favFood;
        private string favColor;
        private string motivation;
        private string homTown;
        private string birthPlace;
        private int age;
        private int length;
        private int siblings;



        /*
        //Property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Hobby
        {
            get
            {
                return hobby;
            }
            set
            {
                hobby = value;
            }

        }
        */

        
        
   
        //Konstruktor
        public Members(string name, string hobby, string favFood, string favColor, string motivation, string homTown, string birthPlace, int age, int length, int siblings)
        {
            this.name = name;
            this.hobby = hobby;
            this.favFood = favFood;
            this.favColor = favColor;
            this.motivation = motivation;
            this.homTown = homTown;
            this.birthPlace = birthPlace;
            this.age = age;
            this.length = length;
            this.siblings = siblings;


        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Hobby
        {
            get
            {
                return hobby;
            }
        }

    }
}


