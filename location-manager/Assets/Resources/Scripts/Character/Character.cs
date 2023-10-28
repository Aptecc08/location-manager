using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character: MonoBehaviour
{
    const float SPEED_OF_PUMPING = 5f;

    public ClassesOfCharacters Class;

    public Character(ClassesOfCharacters classForSpawn)
    {
        Class = classForSpawn;
    }


    private IEnumerator StartPumping()
    {
        yield return new WaitForSeconds(SPEED_OF_PUMPING);
        CommandController.Instance.AddCommand(new KillCommand());
    }
}
