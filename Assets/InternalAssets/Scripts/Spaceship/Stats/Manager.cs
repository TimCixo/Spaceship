using UnityEngine;
using MvpCreator;

namespace Spaceship.Stats
{
    [RequireComponent(typeof(View))]
    public class Manager : MonoBehaviour, IBootstrapable
    {
        [SerializeField]
        private SpaceshipBaseStats _spaceshipBaseStats;

        private Model _model;
        private View _view;
        private Presenter _presenter;

        public Presenter Presenter => _presenter;

        public void BootstrapInit()
        {
            _model = new Model(_spaceshipBaseStats);
            _view = GetComponent<View>();
            _presenter = new Presenter(_model, _view);
        }
    }
}