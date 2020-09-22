namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public interface ISocialNetwork
    {
        public IProfileIterator ViewFriendsIterator(Profile profile);
    }
}