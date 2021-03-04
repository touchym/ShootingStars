using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldCon : MonoBehaviour
{

    GameObject player;

    public GameObject spEnemy;

    public GameObject restartT;

    public GameObject worldPar;

  


    // public GameObject enemy;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spEnemy = GameObject.FindWithTag("sp");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "e")
        {
            DestroyAllEnemy();
           
            gameObject.GetComponent<WorldCon>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            //gameObject.active = false;
           // player.GetComponent<CharCon>().enabled = false;
             player.gameObject.active = false;
           // spEnemy.GetComponent<SpawnEnemy>().enabled = false;
            //spEnemy.active = false;
            spEnemy.SetActive(false);
            restartT.active = true;
   
           
            Instantiate(worldPar, transform.position, Quaternion.identity);

            EnemySound.Playsound("worldex");
          
        }
    }
    void DestroyAllEnemy()
    {
        GameObject[] enemy;
        enemy = GameObject.FindGameObjectsWithTag("e");
        for (int i = 0; i < enemy.Length; i++)
        {
            Destroy(enemy[i].gameObject);
        }
    }

}
