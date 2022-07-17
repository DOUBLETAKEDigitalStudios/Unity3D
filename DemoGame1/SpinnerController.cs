using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerController : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private float xAngle = 0;
    [SerializeField]
    private float yAngle = 0;
    [SerializeField]
    private float zAngle = 0;

    #endregion Fields

    #region Methods

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }

    #endregion Methods
}
