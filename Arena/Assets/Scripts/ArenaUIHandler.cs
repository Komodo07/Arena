using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArenaUIHandler : MonoBehaviour
{
    public Text playerName;
    
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = GameManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
