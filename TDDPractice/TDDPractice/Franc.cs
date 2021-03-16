namespace TDDPractice
{
    public class Franc
    {
        private int amount;
        
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            Franc franc = (Franc) obj;
            return amount == franc.amount;
        }
    }
}