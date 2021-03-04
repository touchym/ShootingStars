using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    float speed = 10;

    Rigidbody2D rb;
    public GameObject world;
    

   // float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // rb.AddForce(transform.right * speed);
        rb.velocity = transform.right * speed;
        float posX = transform.position.x;
        float posY = transform.position.y;
        if ((posX <= -10) || (posX >= 10) || (posY <= -10) || (posY >= 10))
        {
            Destroy(gameObject);
        }


        Vector3 targ = world.transform.position;
        targ.z = 0;
        Vector3 objectPos = transform.position;
        targ.x = targ.x + objectPos.x;
        targ.y = targ.y + objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "e")
        {
            Destroy(gameObject);
        }
    }
}
