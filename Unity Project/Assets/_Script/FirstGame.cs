using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstGame : MonoBehaviour {

    // Use this for initialization
    public Vector3 pos;
    void Start()
    {

        pos.x = -137f;
        pos.y = 180f;
        pos.z = -17f;


    }

    // Update is called once per frame
    void Update()
    {

        float playerInpX = Input.GetAxis("Horizontal");
        float playerInpY = Input.GetAxis("Vertical");

        pos.x += playerInpX;
        pos.y += playerInpY;

        transform.position = pos;

        //print(pos.x + " " + pos.y + " " + pos.z);
        print("X " + playerInpX + " Y " + playerInpY);



    }
}
