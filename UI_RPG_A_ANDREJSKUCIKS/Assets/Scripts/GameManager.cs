using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Player: " + player.CharName);
        player.TakeDamage(3);
        enemy.TakeDamage(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
