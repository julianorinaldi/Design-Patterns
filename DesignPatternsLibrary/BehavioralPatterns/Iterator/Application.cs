namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public class Application
    {
        private ISocialNetwork _socialNetwork;

        public Application()
        {
            _socialNetwork = new Facebook();
        }

        public void SendMessageAllFriends(Profile profile, string message)
        {
            IProfileIterator iterator = _socialNetwork.ViewFriendsIterator(profile);
            var profileFriend = iterator.GetNext();

            while (profileFriend != null)
            {
                GerenciadorSaida.SaidaConsole.EscreverTexto($"Id: {profileFriend.Id}\tNome Friend: {profileFriend.Name}\tMensagem: {message}");
                profileFriend = iterator.GetNext();
            }
        }
    }
}