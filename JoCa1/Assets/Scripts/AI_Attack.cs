using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Attack : MonoBehaviour {
    public GameObject projectile;
    public Transform spawnPosition;

	// Use this for initialization
	void Start () {
        Debug.Log("AI_Attack Loaded");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("w")) 

        
        {
            Debug.Log("hallo");
            Instantiate(projectile, spawnPosition);
        }
	}
}
