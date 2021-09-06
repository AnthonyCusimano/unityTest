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

        if (Input.GetKey(KeyCode.W))
            this.transform.Translate((Vector3.up * Time.deltaTime) * this.myMoveModifier);

        if (Input.GetKey(KeyCode.A))
            this.transform.Translate((Vector3.left * Time.deltaTime * this.myMoveModifier));

        if (Input.GetKey(KeyCode.S))
            this.transform.Translate((Vector3.down * Time.deltaTime) * this.myMoveModifier);

        if (Input.GetKey(KeyCode.D))
            this.transform.Translate((Vector3.right * Time.deltaTime) * this.myMoveModifier);

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
