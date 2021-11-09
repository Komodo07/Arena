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
        AUIHandler = this;
    }

    // Update is called once per frame
    void Update()
    {
        
        DisplayRemainingEnemies();        
        DisplayRemainingWaves();
        GameManager.Instance.GameOver();
    }

    private void FixedUpdate()
    {
        GameManager.Instance.SpawnWave();
    }

    void DisplayRemainingEnemies() // ABSTRACTION
    {
        enemiesKilled.text = "Enemies Remaining: " + GameManager.Instance.EnemyCount.ToString();
    }

    void DisplayRemainingWaves() // ABSTRACTION
    {
        waveCount.text = "Wave: " + GameManager.Instance.WaveCount.ToString() + "/" + GameManager.Instance.MaxWaves.ToString();
    }    
}
