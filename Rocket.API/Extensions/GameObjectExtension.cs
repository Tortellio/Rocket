using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rocket.API.Extensions
{
    public static class GameObjectExtension
    {
        public static object TryAddComponent(this UnityEngine.GameObject gameobject, Type T)
        {
            return P_TryAddComponent(gameobject, T);
        }

        public static T TryAddComponent<T>(this UnityEngine.GameObject gameobject) where T : UnityEngine.Component
        {
            return (T)P_TryAddComponent(gameobject, typeof(T));
        }

        private static object P_TryAddComponent(UnityEngine.GameObject gameobject, Type T)
        {
            try
            {
                return gameobject.AddComponent(T);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("An error occured while adding component {0}", T.Name), ex);
            }
        }

        public static void TryRemoveComponent(this UnityEngine.GameObject gameobject,Type T)
        {
            P_TryRemoveComponent(gameobject, T);
        }

        public static void TryRemoveComponent<T>(this UnityEngine.GameObject gameobject) where T : UnityEngine.Component
        {
            TryRemoveComponent(gameobject,typeof(T));
        }

        private static void P_TryRemoveComponent(UnityEngine.GameObject gameobject, Type T)
        {
            try
            {
                UnityEngine.Object.Destroy(gameobject.GetComponent(T));
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("An error occured while removing component {0}", T.Name), ex);
            }
        }


    }
}
