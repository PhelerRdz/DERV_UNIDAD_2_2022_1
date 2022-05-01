using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganada : MonoBehaviour
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

        if (gameObject.tag.Equals("Meta"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Win");
        }
        else
        {

        }
    }
}
