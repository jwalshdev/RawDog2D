using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int pineappleCount = 0;
    private int pineapplesToWin = 7;

    [SerializeField] private Text pineapplesText;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            Destroy(collision.gameObject);
            pineappleCount++;
            pineapplesText.text = "Pineapples: " + pineappleCount;
        }

        if (pineappleCount == pineapplesToWin)
        {
            spriteRenderer.enabled = true;
        }
    }
}
