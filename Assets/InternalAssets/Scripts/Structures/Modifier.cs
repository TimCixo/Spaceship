public struct Modifier
{
    public float MovementSpeed;
    public float RotationSpeed;
    public float MaxHealth;
    public float AttackDamage;
    public float AttackSpeed;

    public override string ToString()
    {
        return $"MS: {MovementSpeed}, RS: {RotationSpeed}, MH: {MaxHealth}, AD: {AttackDamage}, AS: {AttackSpeed}";
    }

    public static Modifier operator +(Modifier left, Modifier right)
    {
        return new Modifier
        {
            MovementSpeed = left.MovementSpeed + right.MovementSpeed,
            RotationSpeed = left.RotationSpeed + right.RotationSpeed,
            MaxHealth = left.MaxHealth + right.MaxHealth,
            AttackDamage = left.AttackDamage + right.AttackDamage,
            AttackSpeed = left.AttackSpeed + right.AttackSpeed
        };
    }

    public static Modifier operator -(Modifier left, Modifier right)
    {
        return new Modifier
        {
            MovementSpeed = left.MovementSpeed - right.MovementSpeed,
            RotationSpeed = left.RotationSpeed - right.RotationSpeed,
            MaxHealth = left.MaxHealth - right.MaxHealth,
            AttackDamage = left.AttackDamage - right.AttackDamage,
            AttackSpeed = left.AttackSpeed - right.AttackSpeed
        };
    }

    public static Modifier operator *(Modifier left, Modifier right)
    {
        return new Modifier
        {
            MovementSpeed = left.MovementSpeed * right.MovementSpeed,
            RotationSpeed = left.RotationSpeed * right.RotationSpeed,
            MaxHealth = left.MaxHealth * right.MaxHealth,
            AttackDamage = left.AttackDamage * right.AttackDamage,
            AttackSpeed = left.AttackSpeed * right.AttackSpeed
        };
    }

    public static Modifier operator /(Modifier left, Modifier right)
    {
        return new Modifier
        {
            MovementSpeed = left.MovementSpeed / right.MovementSpeed,
            RotationSpeed = left.RotationSpeed / right.RotationSpeed,
            MaxHealth = left.MaxHealth / right.MaxHealth,
            AttackDamage = left.AttackDamage / right.AttackDamage,
            AttackSpeed = left.AttackSpeed / right.AttackSpeed
        };
    }

    public static Modifier operator /(Modifier left, float right)
    {
        return new Modifier
        {
            MovementSpeed = left.MovementSpeed / right,
            RotationSpeed = left.RotationSpeed / right,
            MaxHealth = left.MaxHealth / right,
            AttackDamage = left.AttackDamage / right,
            AttackSpeed = left.AttackSpeed / right
        };
    }
}