using System.Collections;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private float health;
    public float speed;
    [SerializeField]
    private string charName;
    public bool isFrozen;

    public string CharName
    {
        get { return charName; }
    }

    public abstract void Attack(Character toHit);
    public virtual void  TakeDamage(float damage)
    {
        Health -= damage;
        Debug.Log(charName + " takes " + damage + health);
    }

    public void TakeDamage(Weapon thrownWeapon)
    {
        float damage = thrownWeapon.GetDamage();
        Health -= damage;
        Debug.Log(charName + " takes " + damage + health);

        StartCoroutine(HitEffect());

    }

   IEnumerator HitEffect()
    {
        transform.localScale = Vector3.one*1.2f;
        transform.position += transform.right * 1.2f * Time.deltaTime;
        yield return new WaitForSeconds(0.05f);
        transform.localScale = Vector3.one;
        
    }
    public bool IsDead()
    {
        return Health <= 0;
    }

    public float Health
    {
        get {return health;}
        set {health = Mathf.Max(0,value);}
    }

    public void Freeze()
    {
        Debug.Log("Freezed");
        isFrozen = true;
    }

    public void Heal(float amount)
    {
        Health += amount;
        Debug.Log(charName + " heals " + amount);
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
