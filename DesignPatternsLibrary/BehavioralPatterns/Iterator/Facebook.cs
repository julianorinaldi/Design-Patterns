using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Iterator
{
    internal class Facebook : ISocialNetwork
    {
        public IProfileIterator ViewFriendsIterator(Profile profile)
        {
            return new FacebookIterator(this, profile);
        }

        public Profile[] GetAllProfilesFromSource(Profile sourceProfile)
        {
            List<Profile> profileList = new List<Profile>();
            // Aqui poderia ir até banco de dados e extrair todos os perfis que são amigos do sourceProfile {sourceProfile}.
            // Vamos simular alguns.
            Random random = new Random();
            profileList.Add(new Profile(random.Next(), "João"));
            profileList.Add(new Profile(random.Next(), "José"));
            profileList.Add(new Profile(random.Next(), "Maria"));
            profileList.Add(new Profile(random.Next(), "Rodrigo"));
            profileList.Add(new Profile(random.Next(), "Juliano"));
            profileList.Add(new Profile(random.Next(), "Felipe"));
            profileList.Add(new Profile(random.Next(), "Marli"));
            profileList.Add(new Profile(random.Next(), "Fulano"));
            profileList.Add(new Profile(random.Next(), "Beltrano"));

            return profileList.ToArray();
        }
    }
}