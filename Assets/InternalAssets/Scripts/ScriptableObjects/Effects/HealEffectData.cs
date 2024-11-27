using UnityEngine;

[CreateAssetMenu(fileName = "HealEffectData", menuName = "Effects/HealEffectData")]
public class HealEffectData : SpaceshipEffectData
{
    [SerializeField]
    private float _value;
    [SerializeField]
    private bool _isPercentage;

    public float Value => _value;
    public bool IsPercentage => _isPercentage;

    private void OnEnable()
    {
        type = EffectType.Heal;
    }
}