namespace Iterator
{
    abstract class Iterator<T> where T: class
    {
        public abstract T First();
        
        public abstract T Next();
        
        public abstract bool IsDone();
        
        public abstract T CurrentItem();
    }
}