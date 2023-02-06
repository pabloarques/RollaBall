using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class controladorEsfera : MonoBehaviour
{
    public float speed;
    private int count;
    public TextMeshPro text;

    void Start(){
        count = 0;
        updateCounter();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        GetComponent<Rigidbody>().AddForce(direction * speed);

    }

   
   void OnTriggerEnter(Collider other){
    if(other.tag == "Pickup"){
        Destroy(other.gameObject);
         count++;

        updateCounter();
    }
   }

    void updateCounter(){
        text.text = "Puntos: " + count;
    }
}
