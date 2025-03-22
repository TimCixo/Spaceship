using System;
using UnityEngine;

namespace Spaceship.Effects
{
    public class View : MonoBehaviour
    {
        public event Action OnUpdate;

        private void Update()
        {
            OnUpdate?.Invoke();
        }
    }
}