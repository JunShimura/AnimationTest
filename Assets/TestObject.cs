using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour {

    Animator testAnimator;
	// Use this for initialization
	void Start () {
        testAnimator = transform.GetChild(0).gameObject.GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            testAnimator.SetTrigger("TestStart");
        }
	}
}
