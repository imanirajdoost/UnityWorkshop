using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public int score;
    public GameObject playerToShoot;
    public GameObject startLine;
    public float minX;
    public float maxX;
    // Start is called before the first frame update


    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0)){
            //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit2D raycast;

            //if(Physics2D.Raycast(ray,out raycast, Mathf.Infinity)){
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject ball = (GameObject)Instantiate(playerToShoot);
            //Debug.Log(mousePos);
            if(mousePos.x < minX){



                ball.transform.position = new Vector2(minX, startLine.transform.position.y);

            }else if(mousePos.x > maxX){

                ball.transform.position = new Vector2(maxX, startLine.transform.position.y);


            }else{
                ball.transform.position = new Vector2(mousePos.x, startLine.transform.position.y);




            }
                
            var body = ball.GetComponent<Rigidbody2D>();
            body.velocity = new Vector2(0,speed);
           // body.AddForce(Vector2.up * speed * Time.deltaTime);



            //}




        }


        
    }
}
