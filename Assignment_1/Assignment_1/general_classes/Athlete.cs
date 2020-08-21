using System;
namespace Assignment_1.general_classes
{
    public abstract class Athlete
    {
        public int Id { get; set; }
        public string AthleteName { get; set; }
        public int AthleteAge { get; set; }

        public virtual string Skill()
        {
            return string.Empty;
        }

    }
}
