using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class move_left : MonoBehaviour
{
    public float velocity;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            transform.position -= new Vector3(velocity * Time.deltaTime, 0, 0);
        }

        else if (GameManager.Instance.Isgameactive)
        {
            transform.position -= new Vector3(velocity * Time.deltaTime, 0, 0);
        }
    }
}
