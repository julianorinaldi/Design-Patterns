namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public class FacebookIterator : IProfileIterator
    {
        private Facebook _facebook;
        private Profile[] Cache { get; set; }

        private int _currentPosition = 0;

        private Profile _sourceProfile;

        internal FacebookIterator(Facebook facebook, Profile sourceProfile)
        {
            _facebook = facebook;
            _sourceProfile = sourceProfile;
        }

        public Profile GetNext()
        {
            if (HasMore())
            {
                return Cache[_currentPosition++];
            }

            return null;
        }

        public bool HasMore()
        {
            LazyInit();
            return _currentPosition < Cache.Length;
        }

        private void LazyInit()
        {
            if (Cache == null)
                Cache = _facebook.GetAllProfilesFromSource(_sourceProfile);
        }
    }
}