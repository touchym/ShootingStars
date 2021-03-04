using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCon : MonoBehaviour
{
    bool lr = true;
    float timeCounter = 0;
    public GameObject world;

    public Transform bp;
    public GameObject bullet;

    float speed;
    float hight;
    float width;

    float rad=30;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        width = 1.5f;
        hight = 1.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        CharConLR();
        Shooting();
    }

    private void CharConLR()
    {
        if (lr == true)
        {
            MoveCharL();
            if (Input.GetKeyDown(KeyCode.D))
            {
                lr = false;
            }

        }
        if (lr == false)
        {
            MoveCharR();
            if (Input.GetKeyDown(KeyCode.A))
            {
                lr = true;
            }
        }
    }

    private void MoveCharL()
    {
        timeCounter += Time.deltaTime * speed;
        

        float x = Mathf.Cos(timeCounter) * width;
        float y = Mathf.Sin(timeCounter) * hight;

        Vector3 targ = world.transform.position;
        targ.z = 0;
        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        transform.position = new Vector3(x, y, 0);
        

    }
    private void MoveCharR()
    {
        timeCounter += Time.deltaTime * speed*-1;

        float x = Mathf.Cos(timeCounter) * width;
        float y = Mathf.Sin(timeCounter) * hight;

        Vector3 targ = world.transform.position;
        targ.z = 0;
        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        transform.position = new Vector3(x, y, 0);

    }

    private void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnemySound.Playsound("shoot");
           
            Instantiate(bullet, bp.transform.position, Quaternion.identity);
        }
    }


}
