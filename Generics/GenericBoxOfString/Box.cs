namespace GenericBoxOfString
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }
        public T Value { get; }
        public override string ToString()
        {
            var result = $"{this.Value.GetType()}: {this.Value}";

            return result;
        }
    }
}
