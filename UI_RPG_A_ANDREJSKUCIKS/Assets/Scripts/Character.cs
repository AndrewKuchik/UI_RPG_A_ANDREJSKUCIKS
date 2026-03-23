using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health;
    public float speed;
    [SerializeField]
    private string charName;

    public string CharName
    {
        get { return charName; }
    }

    public abstract void Attack(Character toHit);
    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(charName + " takes " + damage + health);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
