using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHp = 3;

    private int currentHp;

    private void Start()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;

        Debug.Log("åªç›ÇÃHPÅF" + currentHp);

        if (currentHp <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}