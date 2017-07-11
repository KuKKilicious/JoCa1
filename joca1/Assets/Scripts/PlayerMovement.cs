using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.anyKey)
        {
            Vector3 vec = this.transform.position;
            vec.x = vec.x + 1;

            this.transform.position = vec;
        }
	}
}
