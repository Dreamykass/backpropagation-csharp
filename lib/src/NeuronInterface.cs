using System.Collections.Generic;

namespace lib
{
    public interface INeuron
    {
        public int Id { get; }
        public int IdInLayer { get; }
        public int IdOfLayer { get; }

        public List<Connection> ConnectionsPrev { get; }
        public List<Connection> ConnectionsNext { get; }

        public double ValueCurrent { get; }
        public double ErrorCurrent { get; }
        public double ErrorPrevious { get; }

        public void AddConnectionToPrev(Connection connection);
        public void AddConnectionToNext(Connection connection);

        public void CalculateValueFromPrevious();
    }
}