using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    public GameObject[] playerWeapons;

    private bool isGameOver;
    public bool IsGameOver
    {
        get { return isGameOver; }
        set { isGameOver = value; }
    }

    private void Start()
    {
        HitPoints = 3;
        isGameOver = false;
    }

    private void Update()
    {
        Movement();

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }

        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Defend();
        }

        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            playerWeapons[0].SetActive(false);
        }

        if(Input.GetKeyUp(KeyCode.Mouse1))
        {
            playerWeapons[1].SetActive(false);
        }
    }    

    public override void CalculateHP()
    {
        if (HitPoints != 0)
        {
            HitPoints -= 1;
            return;
        }

        GameObject.Destroy(this);
    }

    public override void Movement()
    {
        if(!isGameOver)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * 10);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * 10);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * 10);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * Time.deltaTime * 10);
            }
        }
    }
}
