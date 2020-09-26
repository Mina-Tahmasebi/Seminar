using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarMnagamenet.Models
{
    public class SeminarItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Topic Topic { get; set; }
        public List<Visitor> Visitors { get; set; }
    }
}
