namespace Rocket.Core.Steam
{
    public static class Steam
    {
        public static bool IsValidCSteamID(string CSteamID)
        {
            if (ulong.TryParse(CSteamID, out ulong id) && id > 76561197960265728)
            {
                return true;
            }
            return false;
        }
    }
}
