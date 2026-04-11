using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private TMP_Text playerName,playerHP, enemyName, enemyHP;

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform enemySpawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Player: " + player.CharName);
        player.TakeDamage(3);
        enemy.TakeDamage(5);
    }
    public void ToggleButtonShield()
    {
        player.ToggleShield();
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP:" +player.Health.ToString("F1");
        enemyHP.text = "HP:" +enemy.Health.ToString("F1");


    }
    public void PlayerAttack()
    {
        player.Attack(enemy);
        if (enemy.IsDead())
        {
            SpawnNewEnemy();
            return;
        }
        enemy.Attack(player);
        if (player.IsDead())
        {
            GameOver();
            return;
        }
        UpdateUI();
    }

    private void SpawnNewEnemy()
    {
        Destroy(enemy.gameObject);
        GameObject newEnemyObj = Instantiate(enemyPrefab, enemySpawnPoint.position, Quaternion.identity);
        enemy = newEnemyObj.GetComponent<Enemy>();
        Debug.Log("NEW ENEMY ALERT");
        UpdateUI();
    }

    private void GameOver()
    {
        Debug.Log("GAME OVER HAHAHA");
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

   
}
