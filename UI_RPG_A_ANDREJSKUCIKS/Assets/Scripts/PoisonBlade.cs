using UnityEngine;

public class PoisonBlade : Blade
{
    [SerializeField] float poisonDamage;

    [SerializeField] private int poisonCount;

    public override float GetDamage()
    {
        float baseGamage = base.GetDamage();
        if (poisonCount > 0)
        {
            poisonCount --;
            return baseGamage + poisonDamage;
        }
        return baseGamage;
    }

    public override void ApplyEffect(Character target)
    {Debug.Log("Poisoned");
        target.TakeDamage(2);
        
    }
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
