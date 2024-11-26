using UnityEngine;

[CreateAssetMenu(fileName = "SpaceshipBaseStats", menuName = "Stats/SpaceshipBaseStats")]
public class SpaceshipBaseStats : ScriptableObject
{
    [Header("Movement Settings")]
    [SerializeField, Tooltip("Base spaceship movement speed")]
    private float _movementSpeed = 14f;
    [SerializeField, Tooltip("Base spaceship rotation speed")] 
    private float _rotationSpeed = 7f;

    [Header("Health Settings")]
    [SerializeField, Tooltip("Max spaceship health")]
    private float _maxHealth = 100f;

    [Header("Weapon Settings")]
    [SerializeField, Tooltip("Base spaceship attack damage")]
    private float _attackDamage = 20f;
    [SerializeField, Tooltip("Base spaceship attack speed")]
    private float _attackSpeed = 1f;

    public float MovementSpeed => _movementSpeed;
    public float RotationSpeed => _rotationSpeed;
    public float AttackDamage => _attackDamage;
    public float AttackSpeed => _attackSpeed;
    public float MaxHealth => _maxHealth;
}