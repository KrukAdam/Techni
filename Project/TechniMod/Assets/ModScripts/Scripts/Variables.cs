using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int Int = 3; //Liczba ca³kowita
    public float Float = 2.1f; //Po przecinku
    public bool Bool = false;
    public string String = "";
    public EnumTemp EnumT = EnumTemp.None;
}
public enum EnumTemp
{
    None,
    First,
    Second
}
