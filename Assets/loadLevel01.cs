using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel01 : MonoBehaviour {
    private string levelname="Test1";
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void loadLevel()
    {
        SceneManager.LoadScene(levelname);
    }
}
