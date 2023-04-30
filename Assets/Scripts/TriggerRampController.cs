using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
  public float score = 10;

  public ScoreManager scoreManager;

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "bola")
    {
      //tambah skor kalau terkena bola
      scoreManager.AddScore(score);
    }
  }
}

