using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public string Name;

        // add a constructor
        public Ninja(string name) {
            Name = name;
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        // add a public "getter" property called "IsFull"
        public bool IsFull(){
            if (this.calorieIntake >= 1200) {
                return true;
            } else {
                return false;
            }
        }

        // build out the Eat method
        public void Eat(Food item)
        {
            if(this.IsFull() == false) {
                this.calorieIntake += item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine($"Food Name: {item.Name} Is Spicy? {item.IsSpicy} Is Sweet? {item.IsSweet}");
            } else {
                System.Console.WriteLine($"{this.Name} is too full to eat right now.");
            }
        }
    }
}