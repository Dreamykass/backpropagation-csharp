using System.Collections.Generic;

namespace lib
{
    public class NeuronHidden : INeuron
    {
        public NeuronHidden(int id, int idInLayer, Layer<NeuronHidden> layer)
        {
            Id = id;
            IdInLayer = idInLayer;
            Layer = layer;
            IdOfLayer = Layer.Id;
        }

        public Layer<NeuronHidden> Layer { get; }

        public int Id { get; }
        public int IdInLayer { get; }
        public int IdOfLayer { get; }
        public List<Connection> ConnectionsPrev { get; } = new();
        public List<Connection> ConnectionsNext { get; } = new();
        public double ValueCurrent { get; private set; }
        public double ErrorCurrent { get; private set; } = 1;
        public double ErrorPrevious { get; private set; } = 1;

        public void AddConnectionToPrev(Connection connection)
        {
            ConnectionsPrev.Add(connection);
        }

        public void AddConnectionToNext(Connection connection)
        {
            ConnectionsNext.Add(connection);
        }

        public void CalculateValueFromPrevious()
        {
            // page 70

            double value = 0;

            foreach (var connection in ConnectionsPrev)
                value += connection.Prev.ValueCurrent
                         * connection.WeightCurrent
                         + Layer.Bias;

            value = Sigmoid.Activator(value);
            ValueCurrent = value;
        }

        public void CalculateErrorFromNext()
        {
            ErrorPrevious = ErrorCurrent;

            var errorSum = 0.0;

            foreach (var connection in ConnectionsNext)
                errorSum += connection.Next.ErrorCurrent * connection.WeightCurrent * Sigmoid.Derivative(ValueCurrent);

            ErrorCurrent = errorSum;
        }
    }
}