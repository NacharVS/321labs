using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    abstract class Unit
    {
        private string name;
        private int healthPoints;
        private int power;
        private int speed;
        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                this.name = value;
            }
        
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                this.power = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                this.speed = value;
            }
        }
    
    }
}
