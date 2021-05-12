namespace lib
{
    public class Connection
    {
        public Connection(int id, INeuron prev, INeuron next)
        {
            Id = id;
            Prev = prev;
            Next = next;
            WeightCurrent = Randomness.R.NextDouble();

            prev.AddConnectionToNext(this);
            next.AddConnectionToPrev(this);
        }

        public int Id { get; }
        public INeuron Prev { get; }
        public INeuron Next { get; }

        public double WeightCurrent { get; private set; }
        public double WeightPrevious { get; private set; }

        public void AdjustWeight(double learningRate, double momentum, double globalError)
        {
            WeightPrevious = WeightCurrent;

            WeightCurrent = WeightCurrent + learningRate * Next.ErrorCurrent * Prev.ValueCurrent;
        }
    }
}