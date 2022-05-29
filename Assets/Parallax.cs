using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private void LateUpdate()
    {
        if (transform.position.x < -14)
        {
            transform.position += new Vector3(28, 0, 0);
        }
    }
}
