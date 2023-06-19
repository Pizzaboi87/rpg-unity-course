using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone_Skill_Controller : MonoBehaviour
{
    [SerializeField] private float cloneDuration;

    public void SetupClone(Transform _newTransform)
    {
        transform.position = _newTransform.position;
    }
}
