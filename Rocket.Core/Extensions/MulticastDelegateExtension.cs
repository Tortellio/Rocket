using Rocket.Core.Logging;
using System;

namespace Rocket.Core.Extensions
{
    public static class MulticastDelegateExtension
    {
        public static void TryInvoke(this MulticastDelegate theDelegate, params object[] args)
        {
            if (theDelegate == null) return;
            foreach (Delegate handler in theDelegate.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    Logger.LogError("Error in MulticastDelegate " + handler.GetType().Name + ": " + ex.ToString());
                }
            }
        }
    }
}
