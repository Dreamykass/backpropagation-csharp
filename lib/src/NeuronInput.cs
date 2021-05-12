using System;
using System.Collections.Generic;

namespace lib
{
    public class NeuronInput : INeuron
    {
        public NeuronInput(int id, int idInLayer, Layer<NeuronInput> layer)
        {
            Id = id;
            IdInLayer = idInLayer;
            Layer = layer;
            IdOfLayer = Layer.Id;
        }

        public Layer<NeuronInput> Layer { get; }

        public int Id { get; }
        public int IdInLayer { get; }
        public int IdOfLayer { get; }
        public List<Connection> ConnectionsPrev { get; } = new();
        public List<Connection> ConnectionsNext { get; } = new();
        public double ValueCurrent { get; private set; } = -99;
        public double ErrorCurrent { get; } = -99;
        public double ErrorPrevious { get; } = -99;

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
            throw new NotImplementedException();
        }

        public void PassInputInside(double input)
        {
            ValueCurrent = input;
        }
    }
}