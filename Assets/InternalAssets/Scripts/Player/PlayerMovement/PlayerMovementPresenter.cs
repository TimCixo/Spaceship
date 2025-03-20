using UnityEngine;

namespace Spaceship.Movement
{
    public class PlayerMovementPresenter
    {
        private PlayerMovementModel _model;
        private PlayerMovementView _view;

        public PlayerMovementPresenter(PlayerMovementModel model, PlayerMovementView view)
        {
            _model = model;
            _view = view;

            _view.OnFixedUpdate += OnFixedUpdate;
            _view.OnMovePerformed += OnMovePerformed;
            _view.OnMoveCanceled += OnMoveCanceled;
        }

        private void OnFixedUpdate()
        {
            Move();
            Rotate();
        }

        private void OnMovePerformed(Vector2 direction)
        {
            _model.Direction = direction;
        }

        private void OnMoveCanceled()
        {
            _model.Direction = Vector2.zero;
        }

        private void Move()
        {
            Vector2 force = _view.transform.up * _model.Direction.y * _model.StatsPresenter.MovementSpeed;

            _view.Rigidbody2D.AddForce(force, ForceMode2D.Force);
        }

        private void Rotate()
        {
            float force = -_model.Direction.x * _model.StatsPresenter.RotationSpeed;

            _view.Rigidbody2D.MoveRotation(_view.Rigidbody2D.rotation + force);
        }
    }
}