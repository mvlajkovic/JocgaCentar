using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDBLibrary
{
    public class ScheduleTime
    {
        public ScheduleTime(int hout, string desc)
        {
            Hour = Hour;
            Description = desc;
        }
        public int Hour { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return Hour.ToString()+"H";
        }
    }
}
