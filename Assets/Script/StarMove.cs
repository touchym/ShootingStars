using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarMove : MonoBehaviour
{
     GameObject world;
    WorldCon wd;
    public float speed;
    public GameObject enemyPar;

    private CameraCon shake;
    float n;

   

    // Start is called before the first frame update
    void Start()
    {
        world = GameObject.FindWithTag("a");
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CameraCon>();
       

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, world.transform.position, speed * Time.deltaTime);


        transform.Rotate(0, 0, 0.5f);
        n = 0.1f*Time.deltaTime;
        speed = speed + n;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "b")
        {

            EnemySound.Playsound("enemyex");

            shake.camShake();
            Instantiate(enemyPar, transform.position, Quaternion.identity);
            Destroy(gameObject);
            ScoreT.score++;

           


        }
        if (col.gameObject.tag == "a")
        {
            Destroy(gameObject);
        }
    }
}
