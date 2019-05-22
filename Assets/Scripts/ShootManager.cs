using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{
    private ScoreManager scoreManager;
    public AudioSource bangSound;
    public GameObject bangEffect;

    private void Awake()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        bangSound = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Enemy"))
        {
            scoreManager.AddScore(10);
            GameObject effect = Instantiate(bangEffect);
            effect.transform.position = col.contacts[0].point;
            bangSound.Play();
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
