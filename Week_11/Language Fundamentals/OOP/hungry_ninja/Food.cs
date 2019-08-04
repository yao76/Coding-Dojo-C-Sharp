namespace hungry_ninja
{
    public class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

        public Food(string foodName, int foodCals, bool spicy, bool sweet) {
            Name = foodName;
            Calories = foodCals;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}