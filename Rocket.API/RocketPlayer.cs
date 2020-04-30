namespace Rocket.API
{
    public class RocketPlayer : IRocketPlayer
    {
        public string Id { get; }
        public string DisplayName { get; }
        public bool IsAdmin { get; }

        public RocketPlayer(string Id, string DisplayName = null, bool IsAdmin = false)
        {
            this.Id = Id;
            if (DisplayName == null)
            {
                this.DisplayName = Id;
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            this.IsAdmin = IsAdmin;
        }

        public int CompareTo(object obj)
        {
            return Id.CompareTo(((IRocketPlayer)obj).Id);
        }
    }
}
