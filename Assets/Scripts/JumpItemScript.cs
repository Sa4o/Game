using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpItemScript : MonoBehaviour

{
    private GameObject bJump;

    void Start()
    {
        bJump = GameObject.Find("bJump");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("player"))
        {
            bJump.SetActive(true);
            Destroy(gameObject);
        }
    }
}
