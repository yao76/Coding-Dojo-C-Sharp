namespace iron_ninja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (IsFull == false)
            {
                if (item.IsSweet == true)
                {
                    calorieIntake += 10;
                }
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
            }
        }

        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1500)
                {
                    return true;
                }
                return false;
            }
        }

    }
}