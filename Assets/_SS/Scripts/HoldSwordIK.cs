using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RootMotion.FinalIK
{
    public class HoldSwordIK : MonoBehaviour
    {
        public FullBodyBipedIK ik;
        public Transform leftHandTarget, rightHandTarget;


        // Update is called once per frame
        void LateUpdate()
        {
            ik.solver.rightHandEffector.position = rightHandTarget.position;
            ik.solver.rightHandEffector.rotation = rightHandTarget.rotation;
            ik.solver.rightHandEffector.positionWeight = 1f;
            ik.solver.rightHandEffector.rotationWeight = 1f;
            ik.solver.leftHandEffector.position = leftHandTarget.position;
            ik.solver.leftHandEffector.rotation = leftHandTarget.rotation;
            ik.solver.leftHandEffector.positionWeight = 1f;
            ik.solver.leftHandEffector.rotationWeight = 1f;

        }
    }
}
