﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
  public GameObject[] ballPrefabs;

  private float spawnLimitXLeft = -22;
  private float spawnLimitXRight = 7;
  private float spawnPosY = 30;

  private float startDelay = 1.0f;

  // Start is called before the first frame update
  void Start()
  {
    var spawnInterval = Random.Range(3.0f, 5.0f);
    InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
  }

  // Spawn random ball at random x position at top of play area
  void SpawnRandomBall()
  {
    // Generate random ball index and random spawn position
    Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    var randomBall = Random.Range(0, 3);

    // instantiate ball at random spawn location
    Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
  }

}
