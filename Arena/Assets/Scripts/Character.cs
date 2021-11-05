using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private int hitPoints;
    public bool isDead;
    public int HitPoints
    {
        get { return hitPoints; }
        set { hitPoints = value; }
    }

    public virtual void Attack()
    {
        PlayerCharacter player = FindObjectOfType<PlayerCharacter>();
        player.playerWeapons[0].SetActive(true);
    }

    public virtual void Defend()
    {
        PlayerCharacter player = FindObjectOfType<PlayerCharacter>();
        player.playerWeapons[1].SetActive(true);
    }

    public abstract void CalculateHP();

    public abstract void Movement();
}
