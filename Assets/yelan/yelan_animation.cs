using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yelan_animation : MonoBehaviour
{

    private Animator anim;
    public GameObject hutao;
    private bool animated = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (this.transform.position, hutao.transform.position);
        if(distance < 1.5f && animated){
            anim.Play("kick",-1,0f);
            animated = false;
        }
    }
}
