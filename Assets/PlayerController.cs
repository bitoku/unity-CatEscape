using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void LeftButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RightButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
