using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Camera))]
public class OsuRaycaster : MonoBehaviour
{
    [SerializeField]
    private LayerMask _layerMask;

    private Camera _ourCamera;

    private void Awake()
    {
        _ourCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    public void Update()
    {
        var mouseRay = _ourCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit raycastHit;
        if (Physics.Raycast(mouseRay,out raycastHit, 100f, _layerMask))
        {
            OsuEntityBehaviour entity = raycastHit.collider.gameObject.GetComponent<OsuEntityBehaviour>();
            if(entity!=null)
                entity.Entity.Click();

        }
        
    }
}
