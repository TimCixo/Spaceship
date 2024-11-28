using System;
using UnityEngine;

public class SpaceshipEffectsView : MonoBehaviour
{
    public event Action OnUpdate;

    private void Update()
    {
        OnUpdate?.Invoke();
    }
}