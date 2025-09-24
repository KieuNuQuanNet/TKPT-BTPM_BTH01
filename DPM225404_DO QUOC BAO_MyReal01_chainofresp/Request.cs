using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_MyReal01_chainofresp
{
    public class SupportRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }

        public SupportRequest(int id, string description, int level)
        {
            Id = id;
            Description = description;
            Level = level;
        }
    }
}
