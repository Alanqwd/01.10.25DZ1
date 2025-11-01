using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._10._25Dz
{
    public class ToDo
    {

        public string CaseName { get; set; }
        public DateTime? TimeOfCompleating { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }


        public ToDo(string caseName, DateTime? timeOfCompleating, string description)
        {
            CaseName = caseName;
            TimeOfCompleating = timeOfCompleating;
            Description = description;
        }





    }
}