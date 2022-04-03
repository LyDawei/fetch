using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
  public GameObject dogPrefab;
  public float time = 2.0f;
  public float timer;

  // Update is called once per frame
  void Update()
  {
    timer += Time.deltaTime;

    if (timer >= time)
    {
      // On spacebar press, send dog
      if (Input.GetKeyDown(KeyCode.Space))
      {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        timer = 0;
      }
    }

  }
}
