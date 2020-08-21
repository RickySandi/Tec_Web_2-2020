using System;
namespace Assignment_1.general_classes
{
    public class SoccerPlayer : Athlete
    {
        public int Salary { get; set; }

        public override string Skill()
        {
            return "I play soccer";
        }
    }
}
