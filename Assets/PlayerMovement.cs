using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerrb;
    public float jumpforce;
    public float playerspeed;
    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Moveforward();
        }
    }
    private void jump()
    {
        playerrb.velocity = new Vector3(0,jumpforce,0);
    }
    private void Moveforward()
    {
        playerrb.velocity = new Vector3(0,0,playerspeed);
    }
}
