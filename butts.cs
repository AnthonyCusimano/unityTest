using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 
*/
public class butts : MonoBehaviour
{

    //how far I move each frame lole
    float myMoveModifier;

    //
    public GameObject PlayerBullet;

    // Start is called before the first frame update
    void Start()
    {

        this.myMoveModifier = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        Rigidbody myRb = GetComponent<Rigidbody>();

        //right | left
        if (Input.GetKey(KeyCode.A))
            myRb.AddForce(Vector3.left * this.myMoveModifier);

        else if (Input.GetKey(KeyCode.D))
            myRb.AddForce(Vector3.right * this.myMoveModifier);

        //up | down
        if (Input.GetKey(KeyCode.W))
            myRb.AddForce(Vector3.up * this.myMoveModifier);

        else if (Input.GetKey(KeyCode.S))
            myRb.AddForce(Vector3.down * this.myMoveModifier);

        //space
        if (Input.GetKey(KeyCode.Space))
        {

            //Rigidbody T_BulletClone;

            Instantiate(PlayerBullet, new Vector3(0,0,0), Quaternion.identity);

            //T_BulletClone.velocity = transform.TransformDirection(Vector3.up * 23);

            Debug.Log("spawn a bullet pls");

        }

    }
}
