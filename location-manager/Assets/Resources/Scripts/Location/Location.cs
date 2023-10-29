using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public LocationInfo locationInfo;
    public int Lvl;
    public int CurrentAmountOfCharacters;
    public int CurrnetAmountOfMobs;
    public int CurrentAmountOfResources;

    public List<Character> CharactersOnLocation = new List<Character>();

    [SerializeField] private float characterPerSecond;

    private int _maxAmountOfCharacters;
    private int _maxAmountOfMobs;
    private int _maxAmountOfResources;

    public void Start()
    {
        _maxAmountOfMobs = locationInfo.MaxAmountOfMobs;
        _maxAmountOfCharacters = locationInfo.MaxAmountOfCharacters;
        _maxAmountOfResources = locationInfo.MaxAmountOfResources;
        Lvl = locationInfo.Lvl;
        _maxAmountOfCharacters = 10;
        StartCoroutine(StartSpawnCharacters());
    }

    public bool LocationIsCompletelyFilled()
    {
        return _maxAmountOfCharacters == CharactersOnLocation.Count;
    }

    public void AddCharacter(Character character)
    {
        if (CurrentAmountOfCharacters < 10f)
        {
            CurrentAmountOfCharacters++;
            CharactersOnLocation.Add(character);
            UpdateInfo();
        }
    }

    private void UpdateInfo()
    {
        CurrentAmountOfCharacters = CharactersOnLocation.Count;
    }

    public void RemoveMob()
    {
        CurrnetAmountOfMobs--;
    }

    private IEnumerator StartSpawnCharacters()
    {
        while (true)
        {
            Debug.Log("Spawn");
            CommandController.Instance.AddCommand(new SpawnCharacterCommnad(this));
            yield return new WaitForSeconds(1);
        }
    }
}
