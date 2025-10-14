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
        public DateTime? DateExecution { get; set; }
        public string DescriptionCase { get; set; }


        public ToDo(string casename, DateTime? dateexecution, string descriptioncase)
        {
            CaseName = casename;
            DateExecution = dateexecution;
            DescriptionCase = descriptioncase;

        }










    }





}
