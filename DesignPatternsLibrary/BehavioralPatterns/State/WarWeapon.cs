namespace DesignPatterns.BehavioralPatterns.State
{
    public class WarWeapon
    {
        private IWeapon _weapon { get; set; }

        public WarWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Shoot()
        {
            _weapon.Shoot();
        }

        public void GetNewWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }
    }
}