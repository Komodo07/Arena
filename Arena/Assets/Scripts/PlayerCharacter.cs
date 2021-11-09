using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character // INHERITANCE
{
    public static PlayerCharacter Player { get; private set; }

    public GameObject[] playerWeapons;

    private bool isGameOver;
    public bool IsGameOver // ENCAPSULATION
    {
        get { return isGameOver; }
        set { isGameOver = value; }
    }

    private void Start()
    {
        Player = this;
        HitPoints = 3;
        isGameOver = false;
    }

    private void Update()
    {
        Movement();
        Attack();
        Defend();        
    }    

    public void CalculateHP(int extraHP)
    {
        HitPoints += extraHP;
    }

    public override void Movement() // POLYMORPHISM
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

    public override void Attack() // POLYMORPHISM
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerWeapons[0].SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            playerWeapons[0].SetActive(false);
        }
    }

    public override void Defend() // POLYMORPHISM
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            playerWeapons[1].SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            playerWeapons[1].SetActive(false);
        }
    }
}
