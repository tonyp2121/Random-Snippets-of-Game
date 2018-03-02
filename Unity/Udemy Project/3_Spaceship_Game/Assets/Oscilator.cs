using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscilator : MonoBehaviour {

    [SerializeField] Vector3 movementVector = new Vector3 (20f, 0f, 0f);
    [SerializeField] float period = 2f;

    float movementPercent;// 0 for not moved 1 for fully moved

    Vector3 startingPosition;

	// Use this for initialization
	void Start () {
        startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        // set movementfactor
        if (period <= Mathf.Epsilon) { return; } 

        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2f;
        float rawSinWave = Mathf.Sin(cycles * tau);

        movementPercent = (rawSinWave + 1f) / 2f;

        Vector3 offset = movementVector * movementPercent;
        transform.position = startingPosition + offset;
	}
}
