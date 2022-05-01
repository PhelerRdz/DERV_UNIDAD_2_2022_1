using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionBala : MonoBehaviour
{
    [SerializeField]
    public float velocidad;

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //new Vector3(x, 0.5, 0.25)
        rb.AddForce(transform.forward * velocidad, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("Objeto_Pared"))
        {

            Destroy(collision.gameObject);
            //Destroy(this.gameObject);
        }

    }
}
