using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lever : MonoBehaviour
{
    [SerializeField] private HingeJoint _joint;
    private JointSpring temp;

    public void LeverMove(InputAction.CallbackContext context)
    {
        temp = _joint.spring;
        temp.targetPosition = 90;
        _joint.spring = temp;
       StartCoroutine(LeverStartTargetPositionWait());

    }

    private IEnumerator LeverStartTargetPositionWait()
    {
        yield return new WaitForSeconds(0.4f);
        temp.targetPosition = 0;
        _joint.spring = temp;
    }
}
