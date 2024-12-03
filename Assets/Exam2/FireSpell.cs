using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        base.Cast();

        Debug.Log("<color=FE9900/>Casting a Fireball spell! xDxD</color>");

        Cast("Shark");
        Cast("Shark", 5);
    }
}
