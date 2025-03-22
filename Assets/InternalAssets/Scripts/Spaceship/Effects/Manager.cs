using UnityEngine;
using MvpCreator;

namespace Spaceship.Effects
{
    [RequireComponent(typeof(View), typeof(Stats.Manager), typeof(Bootstrap))]
    public class Manager : MonoBehaviour, IBootstrapable
    {
        private Model _model;
        private View _view;
        private Presenter _presenter;

        public Presenter Presenter => _presenter;

        public void BootstrapInit()
        {
            _model = new Model(GetComponent<Stats.Manager>());
            _view = GetComponent<View>();
            _presenter = new Presenter(_model, _view);
        }
    }
}