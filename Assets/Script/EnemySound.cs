using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{
    public static AudioClip ess,wxp,sh;
   static AudioSource es;
    // Start is called before the first frame update
    void Start()
    {
        ess = Resources.Load<AudioClip>("enemyex");
        wxp = Resources.Load<AudioClip>("worldex");
        sh = Resources.Load<AudioClip>("shoot");

        es = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public static void Playsound(string clip)
    {
        switch (clip)
        {
            case "enemyex":
                es.PlayOneShot(ess);
                break;
            case "worldex":
                es.PlayOneShot(wxp);
                break;
            case "shoot":
                es.PlayOneShot(sh);
                break;
        }
    }
}
