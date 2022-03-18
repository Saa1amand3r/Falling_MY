using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D exit) {
    	global_hp.Hp = 10f;
        print (global_hp.Hp);
        print (global_final_hp.resultHp);
    }
}
