using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MainData
{
    public string m_base;
    public float visibility;
    public float dt;
    public int timezone;
    public int id;
    public string name;
    public int cod;

    public Coord coord;
    public Weather[] weather;
    public Main main;
    public Wind wind;
    public Clouds clouds;
    public Sys sys;
}


[System.Serializable]
public class Coord
{
    public float lat;
    public float lon;
}

[System.Serializable]
public class Weather
{
    public int id;
    public string main;
    public string description;
    public string icon;

}

[System.Serializable]
public class Main
{
    public float temp;
    public float feels_like;
    public float temp_min;
    public float temp_max;
    public float pressure;
    public float humidity;
}

[System.Serializable]
public class Wind
{
    public float speed;
    public float deg;
}

[System.Serializable]
public class Clouds
{
    public int all;
}

[System.Serializable]
public class Sys
{
    public int type;
    public int id;
    public string country;
    public int sunrise;
    public int sunset;
}