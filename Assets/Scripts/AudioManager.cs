using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] GameObject SFXAudioSource;
    [SerializeField] GameObject switchSFX;
	private void Start()
	{
		// jalankan BGM saat game dimulai
		PlayBGM();
	}
	
	// fungsi yang disiapkan untuk perintah menjalankan bgm dari script lain
	public void PlayBGM() { 
        audioSource.Play();
    }
	// fungsi yang disiapkan untuk perintah menjalankan sfx dari script lain
	public void PlaySFX(Vector3 spawnPosition) { 
        GameObject.Instantiate(SFXAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchSFX(Vector3 spawnPosition) { 
        GameObject.Instantiate(switchSFX, spawnPosition, Quaternion.identity);
    }
}