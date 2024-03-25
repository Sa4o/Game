using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour

{ 
private void OnTriggerEnter(Collider other)

{

    if (other.gameObject.name.Equals("player"))
    {
        other.gameObject.GetComponent<player>().updateLife(50);
            Destroy(gameObject);
    }
}
}
