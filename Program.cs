using System;

namespace heist
{
    class Program
    {
        static void Main()
        {
            TheCrew theCrew = new TheCrew();
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
                Console.WriteLine($"Name: {member.Name}");
                Console.WriteLine($"Skill Level: {member.SkillLevel}");
                Console.WriteLine($"Courage factor: {member.CourageFactor}");
            }
        }
    }

}
