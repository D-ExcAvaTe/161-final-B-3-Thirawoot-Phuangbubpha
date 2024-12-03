using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpell : Spell
{
    public override void Cast()
    {
        base.Cast();

        Debug.Log("<color=FE9900/>Casting an Lightning shock spell! got shocked muhahaha!></color>");

        Cast("Orc");
        Cast("Orc", 5);

        ParalyzedSpellEffect("Orc");
    }

    private void ParalyzedSpellEffect(string target)
    {

        Debug.Log($"<color=FE9900/>*Additional Effect* {target} is now paralyzed due to Lightning shock spell!!</color>");
    }
}