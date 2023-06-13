using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var jah = Random.Range(0, 4);
            GetComponent<Animator>().SetTrigger(new string("Attack" + jah) );
        }   
    }
}
