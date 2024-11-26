public struct Modifier
{
    public float MovementSpeed;
    public float RotationSpeed;
    public float MaxHealth;
    public float Damage;
    public float AttackSpeed;

    public static Modifier operator +(Modifier left, Modifier right)
    {
        return new Modifier
        {
            MovementSpeed = left.MovementSpeed + right.MovementSpeed,
            RotationSpeed = left.RotationSpeed + right.RotationSpeed,
            MaxHealth = left.MaxHealth + right.MaxHealth,
            Damage = left.Damage + right.Damage,
            AttackSpeed = left.AttackSpeed + right.AttackSpeed,
        };

    }
}