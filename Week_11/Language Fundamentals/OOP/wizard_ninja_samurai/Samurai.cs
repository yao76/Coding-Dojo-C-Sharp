namespace wizard_ninja_samurai
{
    public class Samurai : Human
    {
        public Samurai(string name) :base(name) {
            health =  200;
        }

        public override int Attack(Human target) {
            if(target.health < 50) {
                target.health = 0;
                System.Console.WriteLine($"You killed {target.Name}!");
            } else {
                System.Console.WriteLine("Your attack was ineffective");
            }
            return target.health;
        }

        public void Meditate() {
            this.health = 200;
            System.Console.WriteLine($"{this.Name} used full restore, back to full health!");
        }
    }
}