using System;

namespace SeminarMnagamenet.Models
{
    public class Lectur
    {
        public Guid Id { get; set; }

        public string Topic { get; set; }

        public string Lecturer { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public virtual Seminar Seminar { get; set; }
    }
}