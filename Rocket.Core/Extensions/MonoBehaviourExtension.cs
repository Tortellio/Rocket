using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

namespace Rocket.Core.Extensions
{
    public static class MonoBehaviourExtension
    {
        public static void Invoke(this MonoBehaviour behaviour, string method, object options, float delay)
        {
            behaviour.StartCoroutine(Invoke(behaviour, method, delay, options));
        }

        private static IEnumerator Invoke(this MonoBehaviour behaviour, string method, float delay, object options)
        {
            if (delay > 0f)
            {
                yield return new WaitForSeconds(delay);
            }

            Type instance = behaviour.GetType();
            MethodInfo mthd = instance.GetMethod(method);
            mthd.Invoke(behaviour, new object[] { options });

            yield return null;
        }

    }

}
