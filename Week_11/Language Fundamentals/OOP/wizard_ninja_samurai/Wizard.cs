namespace wizard_ninja_samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) :base(name)
        {
            health = 50;
            Intelligence = 25;
        }

        public override int Attack(Human target){
            target.health -= 5 * this.Intelligence;
            this.health += 5 * this.Intelligence;
            System.Console.WriteLine($"Attacked {target.Name} for {5 * this.Intelligence} damage! Also healed yourself for {5 * this.Intelligence} health!");
            return target.health;
        }

        public void Heal(Human target) {
            System.Console.WriteLine($"Healing {target.Name} for {10*this.Intelligence} health...");
            target.health += 10*this.Intelligence;
        }
    }
}