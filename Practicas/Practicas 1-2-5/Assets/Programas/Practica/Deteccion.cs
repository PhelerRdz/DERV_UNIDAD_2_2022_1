using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccion : MonoBehaviour
{
    [SerializeField]
    GameObject Enemigo;
    EnemyControl EnemyControl;
    // Start is called before the first frame update
    void Start()
    {
        EnemyControl = Enemigo.GetComponent<EnemyControl>();
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
            EnemyControl.EntidadJugador = objDetectado;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        string tag = other.tag;
        Debug.Log(tag);

        if (tag.Equals("Jugador"))
        {

            //GameObject objDetectado = other.gameObject;
            EnemyControl.EntidadJugador = null;

        }
    }
}
