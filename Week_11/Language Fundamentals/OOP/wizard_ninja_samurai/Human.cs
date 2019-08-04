namespace wizard_ninja_samurai
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;

        // add a public "getter" property to access health
        public int getHealth
        {
            get { return health; }
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;

        }

        // Add a constructor to assign custom values to all fields
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            target.health -= 5 * this.Strength;
            return target.health;
        }

        public override string ToString()
        {
            return
                $"Name: {Name}, Health: {health}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}";
        }
    }
}