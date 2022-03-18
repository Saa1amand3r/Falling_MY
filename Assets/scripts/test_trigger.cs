using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_trigger : MonoBehaviour
{

	//public bool trigger = false;
	//public int hp = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D (Collider2D other) {
    	global_hp.Hp -= 0.5f;
        print (global_hp.Hp);
    }

    /*private void OnTriggerExit2D (Collider2D other) {
    	if(other.gameObject.tag == "platform") {
    		trigger = false;
    	}		
    }*/
}
