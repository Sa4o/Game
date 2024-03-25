using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("player"))
        {
            GameObject.Find("Door").GetComponent<Animator>().SetBool("open", true);
            Destroy(gameObject);
        }
    }
}
