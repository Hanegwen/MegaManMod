using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFix : MonoBehaviour {

    [SerializeField]
    GameObject Trigger;

    [SerializeField]
    GameObject NewPoint;

    [SerializeField]
    bool hit;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Trigger")
        {
            hit = true;
            this.gameObject.transform.position = NewPoint.transform.position;
        }
    }
}
