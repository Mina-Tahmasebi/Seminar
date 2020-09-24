using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarMnagamenet.Models
{
    class SeminarItem
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Topic topic { get; set; }
        public  List<visitor> visitors { get; set; }
    }
}
