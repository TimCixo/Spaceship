using UnityEngine;

[RequireComponent(typeof(SpaceshipEffectsView))]
public class SpaceshipEffectsManager : MonoBehaviour
{
    private SpaceshipEffectsModel _model;
    private SpaceshipEffectsView _view;
    private SpaceshipEffectsPresenter _presenter;

    public SpaceshipEffectsPresenter Presenter => _presenter;

    void Awake()
    {
        _model = new SpaceshipEffectsModel();
        _view = GetComponent<SpaceshipEffectsView>();
        _presenter = new SpaceshipEffectsPresenter(_model, _view);
    }
}