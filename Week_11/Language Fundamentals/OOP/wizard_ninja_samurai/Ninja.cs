using System;
namespace wizard_ninja_samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) :base(name)
        {
            Dexterity = 175;
        }
        private bool IsCrit() {
            Random r = new Random();
            int num = r.Next(5);
            if(num == 4) {
                return true;
            }

            return false;
        }
        public override int Attack(Human target){
            target.health -= 5*this.Dexterity;
            bool crit = IsCrit();
            if(crit == true) {
                System.Console.WriteLine("Critical Strike! Dealt additional 10 damage!");
                target.health -= 10;
            }

            return target.health;
        }

        public void Steal(Human target) {
            System.Console.WriteLine($"{this.Name} is stealing 5 health from {target.Name}");
            target.health -= 5;
            this.health += 5;
        }
    }
}