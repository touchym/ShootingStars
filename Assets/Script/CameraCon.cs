using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    public Animator camAnim;
    public void camShake()
    {
        camAnim.SetTrigger("shake");
    }

}
