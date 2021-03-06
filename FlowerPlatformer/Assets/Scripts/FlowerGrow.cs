﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerGrow : MonoBehaviour
{
    public Animator anim;
    public bool grow = false;
    public float growSpeed = 10f;

    private void Awake()
    {
        anim.SetFloat("Grow", 0f);
    }

    public void ToggleFlower()
    {
        grow = !grow;
    }
    void Update()
    {
        if (grow)
        {
            if (anim.GetFloat("Grow") < 1)
            {
                anim.SetFloat("Grow", anim.GetFloat("Grow") + growSpeed * Time.deltaTime);
            }
            else
            {
                anim.SetFloat("Grow", 1f);
            }
        }
        else
        {
            if (anim.GetFloat("Grow") > 0)
            {
                anim.SetFloat("Grow", anim.GetFloat("Grow") - (growSpeed * Time.deltaTime));
            }
            else
            {
                anim.SetFloat("Grow", 0f);
            }
        }
    }
}

