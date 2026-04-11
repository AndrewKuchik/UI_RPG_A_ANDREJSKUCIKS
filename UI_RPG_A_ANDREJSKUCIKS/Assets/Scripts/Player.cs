using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon activeWeapon;
    private bool isShieldActive;
    public override void Attack(Character toHit)
    {
        toHit.TakeDamage(activeWeapon);
        activeWeapon.ApplyEffect(toHit);
       // float damage = activeWeapon.GetDamage();
        //toHit.TakeDamage(damage);
    }

    public void ToggleShield()
    {
        Debug.Log("Man ir vairogs" + isShieldActive);
        isShieldActive = !isShieldActive;
        
    }

    public bool IsShieldActive()
    {
        return isShieldActive;
    }

    public override void TakeDamage(float damage)
    {
        if (this is Player player && player.isShieldActive)
        {
            damage *= 0.5f;
        }
Health -= damage;
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
