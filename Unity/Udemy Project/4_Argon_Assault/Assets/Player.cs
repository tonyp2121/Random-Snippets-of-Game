using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
    
    [Tooltip("in m/s")] [SerializeField] float horizontalSpeed = 10f;
    [Tooltip("in m/s")] [SerializeField] float verticalSpeed = 10f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float verticalThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float xOffset = horizontalSpeed * horizontalThrow * Time.deltaTime;
        float rawNewXPos = transform.localPosition.x + xOffset;
        float newXPos = Mathf.Clamp(rawNewXPos, -4.5f, 4.5f);

        float yOffset = verticalSpeed * verticalThrow * Time.deltaTime;
        float rawNewYPos = transform.localPosition.y + yOffset;
        float newYPos = Mathf.Clamp(rawNewYPos, -3f, 3f);

        transform.localPosition = new Vector3(newXPos, newYPos, transform.localPosition.z);
	}
}
