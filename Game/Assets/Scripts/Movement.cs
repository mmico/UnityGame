using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = this.transform.position + this.transform.forward * 0.1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = this.transform.position - this.transform.forward * 0.1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0.0f, -1.5f, 0.0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0.0f, 1.5f, 0.0f));
        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.position = this.transform.position - this.transform.right * 0.1f;
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.position = this.transform.position + this.transform.right * 0.1f;
        }
    }
}
