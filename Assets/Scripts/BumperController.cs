using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    [SerializeField] float multiplier;
    [SerializeField] AudioManager audioManager;
    [SerializeField] VFXManager vFXManager;
    [SerializeField] ScoreManager scoreManager;
    const int SCORE = 10;
    Color red = Color.red;
    Color green = Color.green;
    Color blue = Color.blue;
    Animator animator;
    Renderer rendererMaterial;
    // Start is called before the first frame update
    void Start()
    {
        rendererMaterial = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "bola"){
            scoreManager.AddScore(SCORE);
            other.gameObject.GetComponent<Rigidbody>().velocity *= multiplier;
            animator.SetTrigger("isHit");
            audioManager.PlaySFX(transform.position);
            vFXManager.PlayVFX(other.transform.position);
            Color curColor = rendererMaterial.material.color;
            if(curColor == green){
                curColor = red;
            }
            else if(curColor == red){
                curColor = blue;
            }
            else if(curColor == blue){
                curColor = green;
            }
            rendererMaterial.material.color = curColor;
        }
    }
}
