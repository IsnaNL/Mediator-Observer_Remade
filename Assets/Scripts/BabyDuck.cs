using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyDuck : MonoBehaviour
{
    public Duckling duckling;
    public Vector3 velocity;
    public float speed;
    public int ducklinglayer;


    public void Start()
    {
        duckling.Attach(this);
        speed = 1;
    }
    // Start is called before the first frame update
    public void Move(Vector3 des)
    {
        Vector3 moveto = new Vector3(des.x - transform.position.x,0, des.z - transform.position.z).normalized;
        velocity = new Vector3(moveto.x * speed, 0, moveto.z * speed);
        Debug.Log("BabyDuckMoving" + " /" + this.gameObject.name + " - Observer");


    }
    public void FixedUpdate()
    {
      //  (Vector3.Distance(transform.position, des) >= 1)
        transform.Translate(velocity * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == ducklinglayer)
        {
            velocity = Vector3.zero;
            Debug.Log("Baby Duck Reached Subject - Observer" );

        }
    }
    public int CoinFlip()
    {
        int r = Random.Range(0, 2);
       // Debug.Log(r);
        Debug.Log("Baby Duck Deciding If it wants to change colors" );
        return r;
    }
}
