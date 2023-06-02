using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main()
        {
            TheCrew theCrew = new TheCrew();
            List<IRobber> rolodex = new List<IRobber>{
                new Hacker
                {
                    Name = "Alex Bishop",
                    SkillLevel = 70,
                    PercentageCut = 20
                },
                new Hacker
                {
                    Name = "Josh Barton",
                    SkillLevel = 95,
                    PercentageCut = 30
                },
                new Muscle
                {
                    Name = "Courtney Gulledge",
                    SkillLevel = 80,
                    PercentageCut = 15
                },
                new Muscle
                {
                    Name = "Lincoln Keesecker",
                    SkillLevel = 60,
                    PercentageCut = 5
                },
                new LockSpecialist
                {
                    Name = "Nic Lahde",
                    SkillLevel = 75,
                    PercentageCut = 15
                },
                new LockSpecialist
                {
                    Name = "Laura Furnivall",
                    SkillLevel = 50,
                    PercentageCut = 5
                }
            };
            int totalSkillLevel = 0;
            Random random = new Random();
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("What is the bank's secuirity level? (enter a number)");
            string setBankDifficulty = Console.ReadLine();
            int bankDifficulty = int.Parse(setBankDifficulty);
            int successfulRuns = 0;
            int failedRuns = 0;

            void PlanHeist()
            {
                while (theCrew.teamMembers.Count < 11)
                {
                    string name;
                    int skillLevel;
                    float courageFactor;

                    Console.Write("Enter team member's name: ");
                    name = Console.ReadLine();
                    if (name == "")
                    {
                        break;
                    }
                    Console.Write("Enter team member's skill level 1-100: ");
                    skillLevel = int.Parse(Console.ReadLine());

                    Console.Write("Enter team member's courage factor 0.0 to 2.0: ");
                    courageFactor = float.Parse(Console.ReadLine());

                    theCrew.teamMembers.Add(new TeamMember(name, skillLevel, courageFactor));

                }
            }
            PlanHeist();
            Console.WriteLine($"Ocean's {theCrew.teamMembers.Count}");
            foreach (TeamMember member in theCrew.teamMembers)
            {
                totalSkillLevel += member.SkillLevel;
                // Console.WriteLine($"Name: {member.Name}");
                // Console.WriteLine($"Skill Level: {member.SkillLevel}");
                // Console.WriteLine($"Courage factor: {member.CourageFactor}");

            }
            Console.WriteLine($"The Crew's combined skill level: {totalSkillLevel}");
            Console.WriteLine($"The bank's difficulty level: {bankDifficulty}");
            Console.WriteLine("How many simulations would you like to run?");
            string trialInput = Console.ReadLine();
            int trialRuns = int.Parse(trialInput);
            for (int i = 0; i < trialRuns; i++)
            {
                bankDifficulty += random.Next(-10, 11);
                if (totalSkillLevel > bankDifficulty)
                {
                    successfulRuns++;
                    Console.WriteLine("Success!");
                    bankDifficulty = int.Parse(setBankDifficulty);
                }
                else
                {
                    failedRuns++;
                    Console.WriteLine("Failure!");
                    bankDifficulty = int.Parse(setBankDifficulty);
                }

            }
            Console.WriteLine($"Out of {trialRuns} attempts, {successfulRuns} were successful and {failedRuns} failed.");
        }
    }

}
