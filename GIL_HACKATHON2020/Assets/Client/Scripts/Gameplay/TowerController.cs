
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public GameObject TurretPrefab;


    public float MaxHealth;
    public float CurrentHealth;
    public float Damage;
    public float Range;
    public float NextUpgradeCost = 100f;
    public float TotalCost = 10f;

    public float sellCoef = 0.6f;
    public float repairCoef = 0.4f; 

    PlayerController player;

    RandomGenerator generator;   
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
        var UpdateStats = generator.RandomTurretStatsOnUpdate(player.badLuck);
        this.MaxHealth += UpdateStats[0];
        this.Damage += UpdateStats[1];
        this.Range += UpdateStats[2];
        var avatageUpgrade = (UpdateStats[0] + UpdateStats[1] + UpdateStats[2]) / 3;
        NextUpgradeCost += avatageUpgrade*10;
        var logUpgrade = $"{Damage} {Range } ";
        Debug.Log(logUpgrade);
    }

    private void Sell()
    {
        this.player.AddGold(sellCoef * TotalCost);
    }

    private void Repair()
    {
        this.player.SubtracGold(repairCoef * TotalCost - 10 * CurrentHealth);
    }
}
