using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCommand : ICommand
{
    private const int AMOUNT_OF_EXP_PER_MOB = 10;

    private Character _character;

    public KillCommand(Character character)
    {
        _character = character;
    }
    public void Execute()
    {
        Location location = _character.LocationOsStay; 
        if (location.CurrnetAmountOfMobs == 0)
            return;
        else
        {
            location.RemoveMob();
            _character.AccureExp(AMOUNT_OF_EXP_PER_MOB);
        }
    }
}
