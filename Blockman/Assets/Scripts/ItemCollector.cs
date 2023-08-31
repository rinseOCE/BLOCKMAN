using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int rings = 0;

    [SerializeField] Text ringsText;

    [SerializeField] AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ring"))
        {
            Destroy(other.gameObject);
            rings++;
            ringsText.text = "Rings: " + rings;
            collectSound.Play();
        }
    }
}
