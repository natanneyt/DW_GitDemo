namespace D16Figuren.Domein
{
    public abstract class Figuur
    {
        public Figuur() { }

        public virtual double BerekenOppervlakte()
        {
            return 0;
        }
    }
}
