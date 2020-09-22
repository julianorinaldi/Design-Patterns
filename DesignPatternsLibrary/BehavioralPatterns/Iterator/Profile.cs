namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public class Profile
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public Profile(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}