using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum enemyState
{
    IDLE, ALERT, EXPLORE, PATROL, FOLLOW, FURY
}

public class GameManager : MonoBehaviour
{
    [Header("enemy AI")]
    public Transform[] enemyWayPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
