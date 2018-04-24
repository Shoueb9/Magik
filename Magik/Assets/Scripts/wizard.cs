using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wizard : MonoBehaviour {

    public int counter;

	// Use this for initialization
	void Start () {

        counter = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        gameObject.SetActive(false);
    }
}
