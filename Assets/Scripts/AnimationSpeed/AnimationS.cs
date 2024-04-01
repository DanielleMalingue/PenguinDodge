using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationS : MonoBehaviour
{
    public float slowdownFactor = 0.5f; // Adjust this to control the slowdown factor

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Slow down the animation by adjusting the speed
        animator.speed = slowdownFactor;
    }
}
