using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    #region Fields

    private int _scoreCounter = 0;
    private const string HIT = "Hit";

    #endregion Fields

    #region Methods

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != _HIT)
        {
            _scoreCounter++;
        }     
    }

    #endregion Methods
}
