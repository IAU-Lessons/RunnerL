using System;
using UnityEngine;


public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static volatile T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
             }

            return instance;
        }
    }

    protected virtual void Awake()
    {
        instance = this as T;
    }
}
