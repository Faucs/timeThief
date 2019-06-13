using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*El casatesoros corresponde actualmente a un sprite de 500*700 con pixeles 100 por unidad
https://www.youtube.com/watch?v=dfe6LT9VCBc
https://www.all8.com/tools/bpm.htm*/
public class PlayerController : MonoBehaviour
{
    public float jumpf = 10;
    public float bpm = 0;
    public float screenSize = 12.0f;
    private float currT = 0.0f;
    private float posX = 0.0f;
    private float posY = 0.0f;
    private float jumpStart;
    float speed;
    void Start (){
    }

	void Update () {
		/*/if(Input.GetKey(KeyCode.RightArrow))    //flecha derecha
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0), ForceMode2D.Impulse);
            //aplicamos el torque en el eje z, en modo impulso (considerando la masa del RB)
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-force, 0), ForceMode2D.Impulse);
        }*/
        speed = bpm/60;
        posX = this.transform.position.x;
        posY = this.transform.position.y;
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            jumpStart = 0.0f;
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
        /*if (currT >maxT)
        {
            Destroy(gameObject);
        }*/
        transform.position = new Vector2((Time.deltaTime*screenSize*speed) + posX, posY); //debe demorar 1.6 seg entre el punto a y b v
    }
}