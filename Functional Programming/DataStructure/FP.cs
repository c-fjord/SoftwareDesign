namespace DataStructure
{
    public abstract class List<TA>
    {
        public static List<TA> Init(params TA[] a)
        {
            if (a.Length == 0)
            {
                return new Nil<TA>();
            }
        }
    }
    public sealed class Nil<TA> : List<TA> { }

    public sealed class Cons<TA> : List<TA>
    {
        public readonly TA X;
        public readonly List<TA> Tail;
    }
}