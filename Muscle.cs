using System;
namespace heist
{
    class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= this.SkillLevel;
            Console.WriteLine($"{this.Name} is subduing the guards. Decreased security by {this.SkillLevel}");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{this.Name} has incapcitated the guards. Repeat: Security guards are incapacitated.");
            }
        }
    }
}