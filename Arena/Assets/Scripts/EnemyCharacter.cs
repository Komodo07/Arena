using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : Character
{
    private void Awake()
    {
        HitPoints = 1;
        isDead = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.EnemyCount -= 1;
        isDead = true;
        Destroy(gameObject);
    }

    public override void CalculateHP()
    {
        throw new System.NotImplementedException();
    }

    public override void Movement()
    {
        throw new System.NotImplementedException();
    }
}
