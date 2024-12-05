using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject Key;

    void Start()
    {
        Key.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            Key.SetActive(true);
        }
    }
}
