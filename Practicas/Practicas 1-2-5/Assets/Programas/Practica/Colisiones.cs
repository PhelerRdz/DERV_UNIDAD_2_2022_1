using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisiones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entrando a colision con: " + collision.gameObject.name);
        GameObject gameObject = collision.gameObject;

        if (gameObject.tag.Equals("Jugador"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
        else
        {

        }
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Manteniendo la colision con: " + collision.gameObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Saliendo de la colision con: " + collision.gameObject.name);
    }
}
