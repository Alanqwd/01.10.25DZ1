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
        public DateTime? TimeCompleating { get; set; }
        public string DateDescription { get; set; }
        public string Description { get; set; }


        public ToDo(string caseName, DateTime? timeCompleating, string description, string Datedescription)
        {
            Description = description;
            CaseName = caseName;
            TimeCompleating = timeCompleating;
            DateDescription = Datedescription;
        }

    }





}
