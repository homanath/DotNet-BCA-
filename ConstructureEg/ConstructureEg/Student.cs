using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructureEg_
{
    public class Student
    {
        private string name=null!;
        private int roll;
        private int age;
        public Student()
        {
            roll = 1;
            name = "Unknown";
            age = 18;
        }
        public void setName(string n)
        {
            this.name=n;
        }
        public string getName()
        {
            return name;
        }

        public void setRoll(int roll)
        {
            if(roll>0 && roll<100)
             this.roll = roll;
            else
                Console.WriteLine("Invalid Roll No");
        }
        public int getRoll()
        {
            return roll;
        }
    }
}
