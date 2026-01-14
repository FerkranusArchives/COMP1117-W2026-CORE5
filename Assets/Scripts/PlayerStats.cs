using UnityEngine;

public class PlayerStats
{
    // Private fields
    private float moveSpeed;
    private int maxHealth;
    private int currentHealth;

    // Public properties
    public float MoveSpeed
    {
        get
        {
            return moveSpeed;
        }
        set
        {
            if (value > 20)
            {
                moveSpeed = 20;
            }
            else
            {
                moveSpeed = value;
            }
        }
    }
}
