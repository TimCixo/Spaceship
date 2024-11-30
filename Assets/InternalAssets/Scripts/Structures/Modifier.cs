using Unity.VisualScripting;

public struct Modifier
{
    public float MovementSpeed;
    public float RotationSpeed;
    public float MaxHealth;
    public float AttackDamage;
    public float AttackSpeed;

    public static Modifier operator +(Modifier left, Modifier right)
    {
        return new Modifier
        {
            MovementSpeed = left.MovementSpeed + right.MovementSpeed,
            RotationSpeed = left.RotationSpeed + right.RotationSpeed,
            MaxHealth = left.MaxHealth + right.MaxHealth,
            AttackDamage = left.AttackDamage + right.AttackDamage,
            AttackSpeed = left.AttackSpeed + right.AttackSpeed,
        };
    }

    public static bool operator ==(Modifier left, Modifier right)
    {
        return left.MovementSpeed == right.MovementSpeed &&
               left.RotationSpeed == right.RotationSpeed &&
               left.MaxHealth == right.MaxHealth &&
               left.AttackDamage == right.AttackDamage &&
               left.AttackSpeed == right.AttackSpeed;
    }
    
    public static bool operator !=(Modifier left, Modifier right)
    {
        return left.MovementSpeed != right.MovementSpeed ||
               left.RotationSpeed != right.RotationSpeed ||
               left.MaxHealth != right.MaxHealth ||
               left.AttackDamage != right.AttackDamage ||
               left.AttackSpeed != right.AttackSpeed;
    }
}