using System.Collections;

namespace Iterator
{
    public class StationList : IEnumerable<RadioStation>
    {
        List<RadioStation> Stations = new List<RadioStation>();

        public RadioStation this[int index]
        {
            get { return Stations[index]; }
            set { Stations.Insert(index, value); }
        }

        public void Add(RadioStation station)
        {
            Stations.Add(station);
        }

        public void Remove(RadioStation station)
        {
            Stations.Remove(station);
        }

        public IEnumerator<RadioStation> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var x in Stations)
            {
                yield return x;
            }
        }
    }
}
