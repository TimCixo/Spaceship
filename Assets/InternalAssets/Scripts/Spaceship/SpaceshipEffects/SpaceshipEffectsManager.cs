using UnityEngine;

[RequireComponent(typeof(SpaceshipEffectsView), typeof(SpaceshipStatsManager))]
public class SpaceshipEffectsManager : MonoBehaviour
{
    private SpaceshipEffectsModel _model;
    private SpaceshipEffectsView _view;
    private SpaceshipEffectsPresenter _presenter;

    public SpaceshipEffectsPresenter Presenter => _presenter;

    void Awake()
    {
        _model = new SpaceshipEffectsModel(GetComponent<SpaceshipStatsManager>());
        _view = GetComponent<SpaceshipEffectsView>();
        _presenter = new SpaceshipEffectsPresenter(_model, _view);
    }
}