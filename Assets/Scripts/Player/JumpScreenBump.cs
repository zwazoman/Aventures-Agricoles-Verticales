using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScreenBump : MonoBehaviour
{
    [SerializeField] private PlayerMovement _movement;
    [SerializeField] private CinemachineImpulseSource impulseSource;

    private void Start()
    {
        //_movement.OnJump += StartImpulse;
    }

    private void StartImpulse()
    {
        impulseSource.GenerateImpulse(1);
    }
}
