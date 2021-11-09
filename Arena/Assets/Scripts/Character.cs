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

    public abstract void Attack();

    public abstract void Defend();

    public abstract void Movement();
}
