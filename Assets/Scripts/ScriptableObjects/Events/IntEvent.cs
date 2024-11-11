using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Events/IntEvent", fileName = "NewIntEvent")]
public class IntEvent : ScriptableObject
{
    private Action<int> action;

    public void AddListener(Action<int> action)
    {
        this.action += action;
    }

    public void RemoveListener(Action<int> action)
    {
        this.action -= action;
    }

    public void Raise(int val)
    {
        this.action?.Invoke(val);
    }
}
