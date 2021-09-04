using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int colourballs = 0;

    [SerializeField] private Text colourCounterText;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ColourBall"))
        {
            Destroy(collision.gameObject);
            colourballs++;
            colourCounterText.text = "Colours " + colourballs;
        }
    }
}
