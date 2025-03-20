using System;
using UnityEngine;

namespace Spaceship.Effects
{
    public class SpaceshipEffectsView : MonoBehaviour
    {
        public event Action OnUpdate;

        private void Update()
        {
            OnUpdate?.Invoke();
        }
    }
}