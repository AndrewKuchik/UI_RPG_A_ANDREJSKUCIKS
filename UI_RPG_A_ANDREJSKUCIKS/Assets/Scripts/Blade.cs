using UnityEngine;

public class Blade : Weapon
{
    public float minDamage, maxDamage;
    public override float GetDamage()
    {
        return Random.Range(minDamage, maxDamage);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
