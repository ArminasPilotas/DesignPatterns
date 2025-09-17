namespace Strategy
{
    public class Sorter
    {
        private readonly ISortStrategy SortStrategy;

        public Sorter(ISortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
        }

        public List<int> Sort(List<int> unSortedList)
        {
            return SortStrategy.Sort(unSortedList);
        }
    }
}
