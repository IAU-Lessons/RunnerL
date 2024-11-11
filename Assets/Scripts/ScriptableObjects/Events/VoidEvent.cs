using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/VoidEvent", fileName = "NewVoidEvent")]
public class VoidEvent : ScriptableObject
{
    private Action action;

    public void AddListener(Action action)
    {
        this.action += action;
    }

    public void RemoveListener(Action action)
    {
        this.action -= action;
    }

    public void Raise()
    {
        this.action?.Invoke();
    }
}
