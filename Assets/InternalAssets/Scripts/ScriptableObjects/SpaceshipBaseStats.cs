using UnityEngine;

[CreateAssetMenu(fileName = "SpaceshipBaseStats", menuName = "Stats/SpaceshipBaseStats")]
public class SpaceshipBaseStats : ScriptableObject
{
    [Header("Movement Settings")]
    [SerializeField, Tooltip("Base spaceship movement speed")]
    private float _baseMovementSpeed = 14f;
    [SerializeField, Tooltip("Base spaceship rotation speed")] 
    private float _baseRotationSpeed = 7f;

    [Header("Health Settings")]
    [SerializeField, Tooltip("Max spaceship health")]
    private float _maxHealth = 100f;

    [Header("Weapon Settings")]
    [SerializeField, Tooltip("Base spaceship damage")]
    private float _baseDamage = 20f;

    public float BaseMovementSpeed => _baseMovementSpeed;
    public float BaseRotationSpeed => _baseRotationSpeed;
    public float MaxHealth => _maxHealth;
    public float BaseDamage => _baseDamage;
}