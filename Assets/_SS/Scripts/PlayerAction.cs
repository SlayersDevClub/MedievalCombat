using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    Animator anim;
    public Animator shieldAnim;
    bool b = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            int randomNumber = Random.Range(1, 4);
            anim.SetTrigger("atk" + randomNumber);
        }

        if(Input.GetMouseButtonDown(1) && b)
        {
            shieldAnim.SetTrigger("block");
            b = !b;
        } else if (Input.GetMouseButtonDown(1) && !b)
        {
            shieldAnim.SetTrigger("unblock");
            b = !b;
        }


    }
}
