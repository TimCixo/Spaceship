using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Spaceship.Effects;

namespace Spaceship.Sprint
{
    [RequireComponent(typeof(Manager))]
    public class View : MonoBehaviour
    {
        [SerializeField]
        private InputActionReference _sprintAction;
        private Presenter _effectsPresenter;

        public Action OnSprintPerformed;
        public Action OnSprintCanceled;

        private void Awake()
        {
            _effectsPresenter = GetComponent<Manager>().Presenter;
        }

        private void OnEnable()
        {
            _sprintAction.action.Enable();
            _sprintAction.action.performed += HandleSprintPerformed;
            _sprintAction.action.canceled += HandleMoveCanceled;
        }

        private void OnDisable()
        {
            _sprintAction.action.Disable();
            _sprintAction.action.performed -= HandleSprintPerformed;
            _sprintAction.action.canceled -= HandleMoveCanceled;
        }

        private void HandleSprintPerformed(InputAction.CallbackContext context)
        {
            OnSprintPerformed?.Invoke();
        }

        private void HandleMoveCanceled(InputAction.CallbackContext context)
        {
            OnSprintCanceled?.Invoke();
        }
    }
}