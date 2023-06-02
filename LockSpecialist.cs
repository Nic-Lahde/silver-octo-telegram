using System;
namespace heist
{
    class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= this.SkillLevel;
            Console.WriteLine($"{this.Name} is cracking the vault. Decreased secuirity by {this.SkillLevel}");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{this.Name} has opened the vault. Repeat: Vault is open.");
            }
        }
    }
}