using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStart : MonoBehaviour
{

    bool a=true;
    SpawnEnemy sp;
    GameObject gsp;


    // Start is called before the first frame update
    void Start()
    {

        sp = GameObject.FindGameObjectWithTag("sp").GetComponent<SpawnEnemy>();
        sp.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a == true)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                sp.enabled = true;
                a =false;
            }

        }
        if (a == false)
        {
            MoveCamera();
        }
       
    }
    void MoveCamera()
    {
        transform.position += new Vector3(0.5f, 0, 0);
        float posx = transform.position.x;

       // MoveCamera();
        if (posx >= 0)
        {
            transform.position = new Vector3(0, 0, -10);
        }
    }
  
  
}
