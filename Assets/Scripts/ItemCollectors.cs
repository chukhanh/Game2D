using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollectors : MonoBehaviour
{
    private int banana = 0;

    [SerializeField] private Text bananaText;
    private void OnTriggerEnter2D(Collider2D collission)
    {
        if(collission.gameObject.CompareTag("Banana"))
        {
             Destroy(collission.gameObject);
             banana = banana + 10;
             bananaText.text = "Scores: " + banana;
        }
    }
}
