using UnityEngine;

public class Character : MonoBehaviour
{
    public float health;
    public float speed;
    [SerializeField]
    private string charName;

    public string CharName
    {
        get { return charName; }
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
