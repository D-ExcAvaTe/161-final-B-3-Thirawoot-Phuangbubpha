using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        
        Debug.Log("<color=FE9900/>Casting an Ice shard spell! got froze lmao xDxD</color>");
        
        Cast("Slime");
        Cast("Slime", 5);
    }
}
