using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOnThingsLearned
{
    class Worker
    {
        private bool Energy { get; set; }
        private void GetARest(){
            Console.WriteLine("Out of energy.");
            Console.WriteLine("Getting some rest...");
            Energy = true;
            Console.WriteLine("Energy is full!!");
        }
        public void work()
        {
            if(Energy == false)
                GetARest();
            Console.WriteLine("Working...");
            Energy = false;
            Console.WriteLine("Finished work!");
        }
    }
}
