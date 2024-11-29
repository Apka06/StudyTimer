using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTimer
{
    public class Work 
    {
        public double sessionTime = 0;
        public double totalTimeWorked { get; set; }
        public string Name { get; set; }
        public Work(string name, double totalTimeWorked)
        {
            this.Name = name;
            this.totalTimeWorked = totalTimeWorked;
        }
        public Work()
        {

        }

    }
}
