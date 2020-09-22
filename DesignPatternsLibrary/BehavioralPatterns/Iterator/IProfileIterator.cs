namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public interface IProfileIterator
    {
        public Profile GetNext();

        public bool HasMore();
    }
}