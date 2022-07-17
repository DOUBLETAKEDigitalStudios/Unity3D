using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    #region Fields

    private const string PLAYER = "Player";
    private const string HIT = "Hit";

    #endregion Fields

    #region Methods

    // Callback: Object's box-collider has been triggered by other collision object.
    private void OnCollisionEnter(Collision collision)
    {
        // Use "Player" tag
        if (collision.gameObject.tag == PLAYER)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = HIT;
        }  
    }

    #endregion Methods
}
