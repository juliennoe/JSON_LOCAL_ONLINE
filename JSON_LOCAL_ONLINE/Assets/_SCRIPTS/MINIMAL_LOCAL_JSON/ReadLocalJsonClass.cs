using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// EXEMPLE DEFINITION DE LA CLASSE POUR LIEN AVEC LE JSON EN LOCAL
[System.Serializable]
public class SoloDataJson 
{
    public string t_string;
    public int t_int;
    public float t_float;
    public byte t_byte;
    public bool t_bool;

}

[System.Serializable]
public class T_array
{
    public string t_string;
    public int t_int;
    public float t_float;
    public byte t_byte;
    public bool t_bool;
    public string[] t_sousArray;
}

[System.Serializable]
public class ArrayArray
{
    public T_array[] t_array;
}

