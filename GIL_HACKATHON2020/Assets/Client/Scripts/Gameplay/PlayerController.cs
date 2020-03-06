using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float money { get; private set; }

    public float badLuck { get; private set; }

    public float kills { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Death()
    {
        throw new NotImplementedException();
    }
    public void AddGold(float amount)
    {
        this.money += amount;

    }
    public void SubtracGold(float amount)
    {
        if (money-amount<0)
        {
            this.money = 0;
            return;
        }
        this.money -= amount;
    }
}
