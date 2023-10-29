using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Location")]
public class LocationInfo : ScriptableObject
{
    public LocationType LocationType;
    public List<Mob> AvaliableMobs = new List<Mob>(); 
    //public Resource[] AvalibleResources; массив с русурсами доступными в локации
    public int MaxAmountOfCharacters;
    public int MaxAmountOfMobs;
    public int MaxAmountOfResources;
    public int Lvl;
    public Sprite LocationSprite;
}
