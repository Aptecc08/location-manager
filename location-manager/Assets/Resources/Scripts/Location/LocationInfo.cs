using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Location")]
public class LocationInfo : ScriptableObject
{
    public LocationType LocationType;
    //public Mobs[] AvaliableMobs; ������ � ������ ���������� � ���� �������
    //public Resource[] AvalibleResources; ������ � ��������� ���������� � �������
    public int MaxAmountOfCharacters;
    public int MaxAmountOfMobs;
    public int MaxAmountOfResources;
    public int Lvl;
    public Sprite LocationSprite;
}
