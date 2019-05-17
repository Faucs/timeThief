    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpf = 10;
    public float travelTime = 4.0f;
    public float screenSize = 18.0f;
    private float currT = 0.0f;
    private float posX = 0.0f;
    private float posY = 0.0f;
	// Use this for initialization
	void Start () {
        posX = this.transform.position.x;
        posY = this.transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {                                //una vez cada frame
		/*/if(Input.GetKey(KeyCode.RightArrow))    //flecha derecha
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0), ForceMode2D.Impulse);
            //aplicamos el torque en el eje z, en modo impulso (considerando la masa del RB)
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-force, 0), ForceMode2D.Impulse);
        }*/
        posX = this.transform.position.x;
        posY = this.transform.position.y;
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
        // Update is called once per frame
        /*if (currT >maxT)
        {
            Destroy(gameObject);
        }*/
        currT += (float) Time.deltaTime;
        transform.position = new Vector2(Time.deltaTime*screenSize/travelTime + posX, posY); //debe demorar 1.6 seg entre el punto a y b v
    }
}