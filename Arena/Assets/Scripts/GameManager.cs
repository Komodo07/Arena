using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject[] weapons;
    public GameObject enemy;
    

    private string playerName;
    public string PlayerName // ENCAPSULATION
    {
        get { return playerName; }
        set { playerName = value; }
    }
    
    private int maxWaves; //Feature can be added later asking player how many waves they want to fight.
    public int MaxWaves // ENCAPSULATION
    {
        get { return maxWaves; }
        set { maxWaves = value; }
    }

    private int waveCount; //Keeps track of current wave of enemies
    public int WaveCount // ENCAPSULATION
    {
        get { return waveCount; }
        set { waveCount = value; }
    }

    private int enemyCount; //Keeps track of enemies killed in the current wave
    public int EnemyCount // ENCAPSULATION
    {
        get { return enemyCount; }
        set { enemyCount = value; }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        MaxWaves = 3;
    }

    public void SpawnEnemies() // ABSTRACTION
    {        
        for (EnemyCount = 0; EnemyCount < 10; EnemyCount++)
        {
            Instantiate(enemy, new Vector3(Random.Range(-17, 17), 0, Random.Range(43, 77)), transform.rotation);
        }
    }

    public void SpawnWave() // ABSTRACTION
    {
        if (EnemyCount == 0 && WaveCount != MaxWaves)
        {
            SpawnEnemies();
            WaveCount++;
            PlayerCharacter.Player.CalculateHP(1);
        }
    }

    public void DropWeapon(float x, float z) // ABSTRACTION
    {
        int index = Random.Range(0, 3);
        float y = weapons[index].transform.position.y;
        Instantiate(weapons[index], new Vector3(x,y,z), weapons[index].transform.rotation);
    }

    public void GameOver() // ABSTRACTION
    {
        if (WaveCount == MaxWaves && EnemyCount == 0)
        {
            ArenaUIHandler.AUIHandler.gameOverPanel.SetActive(true);
            PlayerCharacter.Player.IsGameOver = true;
        }
    }
}
