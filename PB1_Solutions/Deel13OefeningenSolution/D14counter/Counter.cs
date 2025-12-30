namespace D14counter
{
    internal class Counter
    {
        public int Value { get; set; }
        public int StepValue { get; set; }

        public Counter()
        {
            Value = 0;
            StepValue = 1;
        }

        public void Advance()
        {
            Value += StepValue;
        }
    }
}
