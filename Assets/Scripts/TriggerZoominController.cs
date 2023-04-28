using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoominController : MonoBehaviour
{
  public CameraController cameraController;
  public float length;

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "bola")
    {
        cameraController.FollowTarget(other.gameObject.transform, length);
    }
  }
}