namespace Tuple
{
    public class OwnTuple<T1, T2>
    {
        public OwnTuple(T1 first, T2 second)
        {
            this.FirstValue = first;
            this.SecondValue = second;
        }
       
        public T1 FirstValue { get; }
        public T2 SecondValue { get; }
    }
}
