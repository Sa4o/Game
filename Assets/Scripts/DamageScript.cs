using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage = 5;
    private void OnCollisionEnter(Collision collision)
    {
        player playerScript = collision.gameObject.GetComponent<player>();
        playerScript.updateLife(-damage);
    }
}
