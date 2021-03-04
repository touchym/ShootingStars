using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
   public  GameObject player;
    public GameObject spg;
     SpawnEnemy spEnemy;
    public GameObject world;
   


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spEnemy = spg.GetComponent<SpawnEnemy>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ScoreT.ResetScore();
            Application.LoadLevel(0);

        }
    }
  

}
