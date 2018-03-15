using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour {

    [SerializeField] float timeToDie = 2f;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, timeToDie);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
