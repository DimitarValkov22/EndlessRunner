using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
   // public AudioSource collectSound;

     void OnTriggerEnter(Collider other)
    {
       // collectSound.Play();
        this.gameObject.SetActive(false);
    }
}
