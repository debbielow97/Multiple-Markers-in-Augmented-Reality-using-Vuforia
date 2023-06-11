using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hutao_animation : MonoBehaviour
{

    private Animator anim;
    public GameObject yelan;
    private bool animated = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (this.transform.position, yelan.transform.position);
        if(distance < 1.5f && animated){
            anim.Play("defeated",-1,0f);
            animated = false;
        }
    }
}
