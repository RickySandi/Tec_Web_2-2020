using System;
namespace Assignment_1.general_classes
{
    public class Runner : Athlete
    {
        public int trainingHours { get; set; }

        public override string Skill()
        {
            return "I run";
        }

    }
}
