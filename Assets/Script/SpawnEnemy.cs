using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float respawnTime=4.5f;
    private Vector2 screenBounds;



    // Start is called before the first frame update
    void Start()
    {
        
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        SpawnEnemyz();
        StartCoroutine(TimeS());
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void SpawnEnemyz()
    {
        GameObject a = Instantiate(enemy) as GameObject;
        GameObject b = Instantiate(enemy) as GameObject;
        GameObject c = Instantiate(enemy) as GameObject;
        GameObject d = Instantiate(enemy) as GameObject;

      a.transform.position = new Vector3(screenBounds.x *1.5f, Random.Range(-screenBounds.y, screenBounds.y));
        b.transform.position = new Vector3(screenBounds.x * -1.5f, Random.Range(-screenBounds.y, screenBounds.y));
        c.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y*1.5f);
        d.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -1.5f);
    }
    IEnumerator TimeS()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemyz();
        }
       
    }
}
