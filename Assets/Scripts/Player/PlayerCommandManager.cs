using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommandManager : MonoBehaviour
{
    private PlayerMovement _pm;
    private PlayerStealh _ps;
    private PlayerCommandManager _manager;

    public PlayerCommandManager(PlayerMovement pm, PlayerStealh ps)
    {
        _pm = pm;
        _ps = ps;
    }

    void Start()
    {
        if(_manager != null)
            Destroy(_manager);
        else
            _manager = this;

        _pm = GetComponent<PlayerMovement>();
        _ps = GetComponent<PlayerStealh>();
    }

    
    void Update()
    {
           
    }
}
