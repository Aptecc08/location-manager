using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersSpawner : MonoBehaviour
{
    public static CharactersSpawner Instance { get; set; }

    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;
    }
    public void SpawnNewCharacter(Location location)
    {
        Character newCharacter = new Character(ChooseClassForCharacter());
        location.AddCharacter(newCharacter);
    }

    private ClassesOfCharacters ChooseClassForCharacter()
    {
        ClassesOfCharacters characterClass;
        var temp = Random.value;
        if (temp < 0.33)
            characterClass = ClassesOfCharacters.Mage;
        else if (temp > 0.66)
            characterClass = ClassesOfCharacters.Archer;
        else
            characterClass = ClassesOfCharacters.Warrior;
        return characterClass;
    }
}
