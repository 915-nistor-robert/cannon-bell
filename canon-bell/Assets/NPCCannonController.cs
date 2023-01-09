using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCannonController : MonoBehaviour
{
    public float rotationSpeed = 1;

    public float blastPower = 5;

    public GameObject Cannonball;

    public Transform ShotPoint;

    // public GameObject Explosion;

    // Update is called once per frame
    void Update()
    {
        float verticalRotation = Input.GetAxis("Vertical");
        
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + 
                                              new Vector3(-verticalRotation * rotationSpeed, 0, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject createCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
            createCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.forward * blastPower;
        }
    }
}
