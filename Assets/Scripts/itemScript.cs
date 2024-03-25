using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject health_item;
    public int item_value = 10;
    private void OnCollisionEnter(Collision collision)
    {
        player playerScript = collision.gameObject.GetComponent<player>();
        playerScript.updateLife(item_value);
        Destroy(health_item);
    }
}
