using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollectors : MonoBehaviour
{
    private int banana = 0;

    [SerializeField] private Text bananaText;
    [SerializeField] private AudioSource collectSound;
    private void OnTriggerEnter2D(Collider2D collission)
    {
        if(collission.gameObject.CompareTag("Banana"))
        {
            collectSound.Play();
             Destroy(collission.gameObject);
             banana = banana + 10;
             bananaText.text = "Scores: " + banana;
        }
    }
}
