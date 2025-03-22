using UnityEngine;
using MvpCreator;
using Spaceship.Effects;

namespace Spaceship.Sprint
{
    [RequireComponent(typeof(View), typeof(Effects.Manager))]
    public class Manager : MonoBehaviour, IBootstrapable
    {
        private Model _model;
        private View _view;
        private Presenter _presenter;
        [SerializeField]
        private StatusEffectData _sprintEffect;

        public Presenter Presenter => _presenter;

        public void BootstrapInit()
        {
            _model = new Model(GetComponent<Effects.Manager>().Presenter, _sprintEffect);
            _view = GetComponent<View>();
            _presenter = new Presenter(_model, _view);
        }
    }
}