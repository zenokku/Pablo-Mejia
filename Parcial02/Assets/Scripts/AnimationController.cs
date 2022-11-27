using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    public float acumulador = 0.0f;
    float loopEndTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        acumulador = acumulador + Time.deltaTime;
        animator.SetFloat("Blend", acumulador);
        loopEndTime = 10.0f;
        if (acumulador > loopEndTime)
        {
            acumulador = 0.0f;
        }
    }

}
