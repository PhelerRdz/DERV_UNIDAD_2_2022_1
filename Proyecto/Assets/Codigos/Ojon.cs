using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ojon : MonoBehaviour
{
    [SerializeField]
    GameObject Enemigo;
    ControlEnemigo ControlEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        ControlEnemigo = Enemigo.GetComponent<ControlEnemigo>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;
        Debug.Log(tag);

        if (tag.Equals("Jugador"))
        {

            GameObject objDetectado = other.gameObject;
            ControlEnemigo.EntidadJugador = objDetectado;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        string tag = other.tag;
        Debug.Log(tag);

        if (tag.Equals("Jugador"))
        {

            //GameObject objDetectado = other.gameObject;
            ControlEnemigo.EntidadJugador = null;

        }
    }
}
