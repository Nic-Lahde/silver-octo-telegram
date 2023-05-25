using System;

namespace heist
{
    class Program
    {
        static void Main()
        {
            TheCrew theCrew = new TheCrew();
            int bankDifficulty = 100;
            int totalSkillLevel = 0;
            Random random = new Random();
            Console.WriteLine("Plan Your Heist!");
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
                    Console.WriteLine("Success!");
                    bankDifficulty = 100;
                }
                else
                {
                    Console.WriteLine("Failure!");
                    bankDifficulty = 100;
                }

            }
        }
    }

}
