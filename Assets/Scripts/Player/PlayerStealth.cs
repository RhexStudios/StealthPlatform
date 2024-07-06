using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStealh : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        player = GetComponentInParent<Transform>();            
    }

    public void HideInTheShadows()
    {

    }

    public void HideInTheObjects()
    {

    }
}
