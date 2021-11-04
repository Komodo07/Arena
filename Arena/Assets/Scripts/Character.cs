using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
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
