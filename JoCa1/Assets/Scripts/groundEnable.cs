using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundEnable : MonoBehaviour {
    private Rigidbody2D rig;
	// Use this for initialization
	void Start () {
		
	}
    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            rig.isKinematic = false;
        }
    }
}
