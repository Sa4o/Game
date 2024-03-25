using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("player"))
        {
            other.gameObject.GetComponent<player>().velocity = 7;
            Destroy(gameObject);
        }
    }
}
