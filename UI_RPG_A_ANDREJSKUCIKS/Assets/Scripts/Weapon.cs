using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string weaponName;
   public abstract float GetDamage();
    void Start()
    {
        
    }

    public abstract void ApplyEffect(Character target);
    // Update is called once per frame
    void Update()
    {
        
    }
}
