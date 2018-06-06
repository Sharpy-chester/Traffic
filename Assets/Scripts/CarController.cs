using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float speed = 30f;
    private float laneRight = 600f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0f, 0f, -speed * Time.deltaTime);
        carAI();
    }

    void carAI()
    {
        RaycastHit hit;
        Vector3 forward = gameObject.transform.TransformDirection(Vector3.forward) * 100;
        Vector3 right = gameObject.transform.TransformDirection(Vector3.right) * 100;
        Debug.DrawRay(transform.position, forward, Color.green);
        Debug.DrawRay(transform.position, right, Color.green);

        if (Physics.Raycast(transform.position, forward, out hit, 100f))
        {

            if (Physics.Raycast(transform.position, right, out hit, 100f))
            {
                



            }
            else
            {
                Vector3 endpos = new Vector3(-laneRight * Time.deltaTime, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, endpos, 1f * Time.deltaTime);
            }



        }
    }
}
