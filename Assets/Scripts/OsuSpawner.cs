using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Logic;
using UnityEngine;

public class OsuSpawner : MonoBehaviour
{

    [SerializeField]
    private OsuEntityBehaviour _osuInstance;
    [SerializeField]
    private float _timeout = 1.5f;
    [SerializeField]
    private float _circleRadius = 5f;


    private Queue<OsuEntityBehaviour> _osuQueue;
    private OsuEntityBehaviour _liastAdded;
    private int _currentIndex;
    // Start is called before the first frame update

    public static OsuFactory Factory;
    void Start()
    {
        Factory = new OsuFactory();
        _osuQueue = new Queue<OsuEntityBehaviour>();

        var steps = 12;
        DrawCircle(steps);

    }

    private void DrawCircle(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            var angleStep = (Mathf.PI * 2) / steps;
            var randomOnCircle = PosFromAngle(angleStep * i);
            var osu = CreateOsu(randomOnCircle);
            _osuQueue.Enqueue(osu);
        }
    }

    private Vector3 RandomOnCircle()
    {
        float theta = Random.Range(0,Mathf.PI*2);

        return PosFromAngle(theta);
    }

    private Vector3 PosFromAngle(float theta)
    {
        var y = _circleRadius * Mathf.Cos(theta);
        var x = _circleRadius * Mathf.Sin(theta);
        return new Vector3(x, y);
    }

    private OsuEntityBehaviour CreateOsu(Vector3 pos)
    {
       var instance =  Instantiate(_osuInstance,pos,Quaternion.identity);
       _currentIndex++;
       instance.Init(_currentIndex,_currentIndex*_timeout,EntityClicked);
       return instance;

    }

    public void EntityClicked(IOsuEntity osu)
    {
        var peek = _osuQueue.Peek().Entity;
        if (osu.Index == peek.Index)
        {
            var toBeDestroed = _osuQueue.Dequeue();
            toBeDestroed.Destroy();

        }
    }

}
