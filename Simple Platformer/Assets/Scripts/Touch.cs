using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private Player player;
    // Start is called before the first frame update
    public void Start()
    {
        player = FindObjectOfType<Player>();    
    }

    public void PressLeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;
    }

    public void PressRightArrow()
    {
        player.moveright = true;
        player.moveleft = false;
    }

    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
    }

    public void ReleaseRightArrow()
    {
        player.moveright = false;
    }

    public void Jump()
    {
        player.jump();
    }
}
