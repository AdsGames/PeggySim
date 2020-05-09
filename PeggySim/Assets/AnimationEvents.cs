﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    public bool Complete = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AnimationFinished()
    {
        Complete = true;
    }

    public void StartAnimation()
    {
        Complete = false;
    }
}
