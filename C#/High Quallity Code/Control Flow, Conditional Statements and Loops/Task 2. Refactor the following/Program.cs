using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Refactor the following if statements
namespace Refactor_the_following
{
    class Program
    {
        public static Potato Cook(Potato potato)
        {
            return potato;
        }
        public class Potato
        {
            private bool isPeeled = false;
            private bool isRotten = false;

            public Potato(bool isRotten)
            {
                this.isRotten = isRotten;
            }   

            public bool IsPeeled
            {
                get { return isPeeled; }
                set { isPeeled = value; }
            }

            public bool IsRotten
            {
                get { return isRotten; }
                set { isRotten = value; }
            }

            public void Peel()
            {
                this.isPeeled = true;
            }

            public void Rot()
            {
                this.isRotten = true;
            }
        }

        static void Main(string[] args)
        {
            Potato potato = new Potato(false);
            //... 
            if (potato == null)
            {
                //Do smth / throw an exception
            }
            if (potato.IsPeeled && !potato.IsRotten)
            {
                Program.Cook(potato);
            }
                
                    
        }
    }
}
