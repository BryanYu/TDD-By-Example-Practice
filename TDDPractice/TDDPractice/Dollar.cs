namespace TDDPractice
{
    public class Dollar
    {
        public int Amount;
        
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public void Times(int multiplier)
        {
            Amount *= multiplier;
        }
    }
}