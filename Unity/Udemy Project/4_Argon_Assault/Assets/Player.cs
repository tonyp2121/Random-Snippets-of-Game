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
        float xOffset = horizontalSpeed * horizontalThrow * Time.deltaTime;
        float newXPos = Mathf.Clamp(transform.localPosition.x + xOffset, -4.5f, 4.5f);

        float verticalThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = verticalSpeed * verticalThrow * Time.deltaTime;
        float newYPos = Mathf.Clamp(transform.localPosition.y + yOffset, -3f, 3f);

        transform.localPosition = new Vector3(newXPos, newYPos, transform.localPosition.z);
	}
}
