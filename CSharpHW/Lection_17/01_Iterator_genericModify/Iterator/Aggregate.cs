namespace Iterator
{
    abstract class Aggregate<T> where T: class
    {
        public abstract Iterator<T> CreateIterator();
    }
}