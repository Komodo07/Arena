using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject[] weapons;
    public GameObject enemy;
    

    private string playerName;
    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    
    private int maxWaves; //Feature can be added later asking player how many waves they want to fight.
    public int MaxWaves
    {
        get { return maxWaves; }
        set { maxWaves = value; }
    }

    private int waveCount; //Keeps track of current wave of enemies
    public int WaveCount
    {
        get { return waveCount; }
        set { waveCount = value; }
    }

    private int enemyCount; //Keeps track of enemies killed in the current wave
    public int EnemyCount
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

    public void SpawnEnemies() //Spawns the designated number of enemies and increases the WaveCount
    {
        WaveCount++;
        for (EnemyCount = 0; EnemyCount < 10; EnemyCount++)
        {
            Instantiate(enemy, new Vector3(Random.Range(-17, 17), 0, Random.Range(43, 77)), transform.rotation);
        }
    }

    public void SpawnWave() //Determines if all enemies in this wave are dead and spawns the next wave
    {
        if (EnemyCount == 0 && WaveCount != MaxWaves)
        {
            SpawnEnemies();
        }
    }

    public void DropWeapon(float x, float z) //Drops a random weapon at enemy death location
    {
        int index = Random.Range(0, 3);
        float y = weapons[index].transform.position.y;
        Instantiate(weapons[index], new Vector3(x,y,z), weapons[index].transform.rotation);
    }

    public void GameOver()
    {
        if (WaveCount == MaxWaves && EnemyCount == 0)
        {
            ArenaUIHandler.AUIHandler.gameOverPanel.SetActive(true);
            //PlayerCharacter.FindObjectOfType<PlayerCharacter>().IsGameOver = true;
        }
    }
}
