﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFadeStateBehaviour : StateMachineBehaviour
{
    [HideInInspector]
    public TutorialTransitionIn tutorialTransition;

    // This will be called when the animator first transitions to this state.
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    // This will be called once the animator has transitioned out of the state.
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);

        if (tutorialTransition != null)
        {
            tutorialTransition.OnFadeInComplete();
        }
    }

    // This will be called every frame whilst in the state.
    override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateIK(animator, stateInfo, layerIndex);
    }
}
