using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour
{
    [SerializeField]
    public GameObject EntidadJugador;

    Vector3 posInicio;
    // Start is called before the first frame update
    void Start()
    {
        posInicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (EntidadJugador != null)
        { //sigue al personaje
            transform.LookAt(EntidadJugador.transform);

            transform.position = Vector3.MoveTowards(
                transform.position,
                EntidadJugador.transform.position,
                6f * Time.deltaTime);
        }
        else
        {  //regresa a posicion de inicio
            transform.LookAt(posInicio);

            transform.position = Vector3.MoveTowards(
                transform.position,
                posInicio,
                6f * Time.deltaTime);
        }
    }
}
