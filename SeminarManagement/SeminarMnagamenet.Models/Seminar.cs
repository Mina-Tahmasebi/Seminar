using System;
using System.Collections.Generic;

namespace SeminarMnagamenet.Models
{
    public class Seminar
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime Time { get; set; }

        public int LengthOfTIME{ get; set; }

        public virtual IList<Lectur> Lecturs { get; set; }

        public virtual ConfrenceRome ConfrenceRome { get; set; }
    }
}
