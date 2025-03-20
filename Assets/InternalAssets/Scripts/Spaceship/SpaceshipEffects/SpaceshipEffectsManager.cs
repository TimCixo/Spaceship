using UnityEngine;
using MvpCreator;

[RequireComponent(typeof(SpaceshipEffectsView), typeof(SpaceshipStatsManager))]
public class SpaceshipEffectsManager : MonoBehaviour, IBootstrapable
{
    private SpaceshipEffectsModel _model;
    private SpaceshipEffectsView _view;
    private SpaceshipEffectsPresenter _presenter;

    public SpaceshipEffectsPresenter Presenter => _presenter;

    public void BootstrapInit()
    {
        _model = new SpaceshipEffectsModel(GetComponent<SpaceshipStatsManager>());
        _view = GetComponent<SpaceshipEffectsView>();
        _presenter = new SpaceshipEffectsPresenter(_model, _view);
    }
}