using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character: MonoBehaviour
{   
    public ClassesOfCharacters Class;
    public int Lvl;
    public Location LocationOsStay;

    private int _actualExpAmount;
    private Coroutine _dumpingCoroutine;

    private void Start()
    {
        _dumpingCoroutine = StartCoroutine(StartPumping());
    }

    public void SetClass(ClassesOfCharacters _class)
    {
        Class = _class;
    }

    public void AccureExp(int amountOfExp)
    {
        _actualExpAmount += amountOfExp;

        if (_actualExpAmount >= ChatartersConstants.LVLS_LIMITS[Lvl / 10])
            LvlUp();
    }

    public void LvlUp()
    {
        StopCoroutine(_dumpingCoroutine);
        Lvl++;

        if (Lvl / 10 > LocationOsStay.Lvl)
            CommandController.Instance.AddCommand(new RelocateCommand(this));
        else
            _dumpingCoroutine = StartCoroutine(StartPumping());
    }

    private IEnumerator StartPumping()
    {
        while (true)
        {
            yield return new WaitForSeconds(ChatartersConstants.SPEED_OF_PUMPING);
            CommandController.Instance.AddCommand(new KillCommand(this));
            yield return null;
        }
    }
}
