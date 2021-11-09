using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArenaUIHandler : MonoBehaviour
{
    public static ArenaUIHandler AUIHandler { get; private set; }

    public Text playerName;
    public Text enemiesKilled;
    public Text waveCount;
    public GameObject gameOverPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = GameManager.Instance.PlayerName;
        GameManager.Instance.SpawnEnemies();
        AUIHandler = this;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayRemainingEnemies();
        GameManager.Instance.SpawnWave();
        DisplayRemainingWaves();
        GameManager.Instance.GameOver();
    }

    void DisplayRemainingEnemies()
    {
        enemiesKilled.text = "Enemies Remaining: " + GameManager.Instance.EnemyCount.ToString();
    }

    void DisplayRemainingWaves()
    {
        waveCount.text = "Wave: " + GameManager.Instance.WaveCount.ToString() + "/" + GameManager.Instance.MaxWaves.ToString();
    }    
}
