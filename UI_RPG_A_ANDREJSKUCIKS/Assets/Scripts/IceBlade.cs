using UnityEngine;

public class IceBlade : Weapon
{
    public override float GetDamage()
    {
        return 5f;
    }

    public override void ApplyEffect(Character target)
    {
        target.Freeze();
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
