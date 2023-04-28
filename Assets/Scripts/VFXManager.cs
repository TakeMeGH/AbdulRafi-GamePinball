using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
	public GameObject vfxSource;
    public GameObject switchVFX;

	public void PlayVFX(Vector3 spawnPosition)
	{
		// spawn vfx pada posisi sesuai parameter
		GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
	}

    public void PlaySwitchVFX(Vector3 spawnPosition)
	{
		// spawn vfx pada posisi sesuai parameter
        Debug.Log("masuk");
		GameObject.Instantiate(switchVFX, spawnPosition, Quaternion.identity);
	}
}

