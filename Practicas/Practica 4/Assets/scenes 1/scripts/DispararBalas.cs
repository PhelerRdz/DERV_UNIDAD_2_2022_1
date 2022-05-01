using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBalas : MonoBehaviour
{
    [SerializeField]
    GameObject []balas = new GameObject[10];

    [SerializeField]
    GameObject bala;

    [SerializeField]
    GameObject spawnBala;

    private void Awake()
    {
        //bala = GameObject.Find("Bullet_45m");
        /*
        for (int i = 0; i < 10; i++) { 
            balas[i] = Instantiate(bala, spawnBala.transform.position,
                      spawnBala.transform.rotation);
        }
        */
    }

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 10; i++)
        {
            balas[i] = Instantiate(bala, spawnBala.transform.position,
                      spawnBala.transform.rotation);
            balas[i].name = "bala_" + conBala++.ToString();
            balas[i].SetActive(false);
        }  
        
    }

    int conBala = 1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject temp = Instantiate(bala, 
                spawnBala.transform.position,
                spawnBala.transform.rotation);

            temp.name = "bala_player_"+ (conBala++);

            Destroy(temp,2);
        }
    }
}
