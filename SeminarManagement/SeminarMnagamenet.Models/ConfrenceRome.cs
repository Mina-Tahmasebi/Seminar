using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarMnagamenet.Models
{
    public class ConfrenceRome
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual IList<Seminar> Seminars { get; set; }
    }
}
