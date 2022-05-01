using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    public NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //izquierdo 0, derecho 1 (cuando
        {
            RaycastHit hit; 
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) //100 es distancia maxima
            {
                Agent.SetDestination(hit.point); //cuando se de click en una parte del escenario, se creara un ray, cuando choque con algo con colision, este ray se creara en la posicion de la camara
                // y su posicion final sera en la posicion del mouse
            }
        } 
    }
}
