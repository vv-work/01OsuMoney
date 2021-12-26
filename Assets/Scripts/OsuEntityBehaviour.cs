using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Logic;
using TMPro;
using UnityEngine;

public class OsuEntityBehaviour : MonoBehaviour
{
    [SerializeField]
    public TextMeshPro _localText;
    public IOsuEntity Entity;

    public void Destroy()
    { 
        Destroy(gameObject);
    }
 
    public void Init(int index, float perfectTime, Action<IOsuEntity> entityClicked)
    {
        _localText.text = index.ToString("D2");
        Entity = OsuSpawner.Factory.CreateEntity(index, perfectTime);
        Entity.OnHit += (t)=> { entityClicked(Entity); };
    }
}
