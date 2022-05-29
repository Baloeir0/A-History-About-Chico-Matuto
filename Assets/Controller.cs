using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float jumpforce;
    public float gravityMult;

    private Rigidbody rigbody;
    private bool bo = true;

    // Start is called before the first frame update
    void Start()
    {
        rigbody = GetComponent<Rigidbody>();

        Physics.gravity *= gravityMult;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && bo && GameManager.Instance.Isgameactive)
        {
            rigbody.AddForce(new Vector3(0, jumpforce, 0));
            bo = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mountain"))
        {
            Debug.Log("Entrou");
            GameManager.Instance.Isgameactive = false;
        }

        else if (collision.gameObject.CompareTag("Ground"))
        {
            bo = true;
        }     
    }
}
