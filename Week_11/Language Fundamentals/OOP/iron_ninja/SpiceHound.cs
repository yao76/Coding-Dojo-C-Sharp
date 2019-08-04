namespace iron_ninja
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull {
            get {
                if(calorieIntake >= 1200) {
                    return true;
                }
                return false;
            }
        }

        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if(item.IsSpicy) {
                calorieIntake -= 5;
            }
            calorieIntake += item.Calories;
            ConsumptionHistory.Add(item);
            item.GetInfo();

        }
    }
}