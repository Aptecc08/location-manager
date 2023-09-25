using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacterCommnad : ICommand
{
    private Location _location;
    public SpawnCharacterCommnad(Location location)
    {
        _location = location;
    }

    public void Execute()
    {
        Debug.Log(!_location.LocationIsCompletelyFilled());
        if(!_location.LocationIsCompletelyFilled())
        {
            CharactersSpawner.Instance.SpawnNewCharacter(_location);
        }
    }
}
