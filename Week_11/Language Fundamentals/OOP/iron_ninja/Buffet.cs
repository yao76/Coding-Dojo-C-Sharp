using System.Collections.Generic;
using System;


namespace iron_ninja

{
    public class Buffet
    {
        public List<IConsumable> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
        {
            new Food("Roast Duck", 1000, false, false),
            new Food("Roast Fish", 600, true, false),
            new Food("Mapo Tofu", 200, true, false),
            new Food("Red Bean Buns", 150, false, true),
            new Food("Sweet and Spicy Chicken", 500, true, true),
            new Food("Spicy Rabbit", 500, true, false),
            new Food("Sichuan Hotpot", 1100, true, false),
            new Drink("Rootbeer Float", 700, false),
            new Drink("Coke Zero", 0, false),
            new Drink("Jalapeño Margarita", 150, true)
        };
        }

        public IConsumable Serve()
        {
            Random randFood = new Random();
            int index = randFood.Next(Menu.Count);
            return Menu[index];
        }
    }
}