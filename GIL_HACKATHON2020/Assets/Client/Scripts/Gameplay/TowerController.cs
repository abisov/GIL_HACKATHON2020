
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public GameObject TurretPrefab { get; private set; }


    public float Health ;
    public float Damage;
    public float Range;
    public float NextUpgradeCost = 100f;
    public float TotalCost = 10f;

    public float sellCoef = 0.6f;
    public float repairCoef = 0.4f; 

    PlayerController player;
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            Upgrade();
        }
    }

    private void Build()
    {
        throw new NotImplementedException();
    }

    private void Upgrade()
    {
        
        this.Damage +=this.Damage*;
        this.Range += 10;
        NextUpgradeCost += 100;
        var logUpgrade = $"{Damage} {Range } ";
        Debug.Log(logUpgrade);
    }

    private void Sell()
    {
        this.player.AddGold(sellCoef * TotalCost);
    }

    private void Repair()
    {
        this.player.SubtracGold(repairCoef * TotalCost - 10 * Health);
    }
}
