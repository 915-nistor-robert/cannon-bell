using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingBell : MonoBehaviour
{

    public AudioSource bellRing;
    // Start is called before the first frame update
    void Start()
    {
        bellRing = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        bellRing.Play();
    }
}
