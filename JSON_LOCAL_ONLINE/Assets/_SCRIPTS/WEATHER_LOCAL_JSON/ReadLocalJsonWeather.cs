using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


// SCRIPT PERMETTANT LA LECTURE D'UN JSON DETAILLE AVEC LE JSONMAINCLASS.CS
public class ReadLocalJsonWeather : MonoBehaviour
{
    // MONTRE FICHIER JSON
    [TextArea(50, 20)]
    public string jsonString; 

    void Start()
    {
        jsonString = File.ReadAllText(Application.dataPath + "/Resources/WeatherAPI.json"); 
        MainData mainData = JsonUtility.FromJson<MainData>(jsonString);

        Debug.Log(mainData.m_base);
        Debug.Log(mainData.visibility);
        Debug.Log(mainData.dt);
        Debug.Log(mainData.timezone);
        Debug.Log(mainData.id);
        Debug.Log(mainData.cod);

        Debug.Log(mainData.coord.lat);
        Debug.Log(mainData.coord.lon);

        Debug.Log(mainData.weather[0].id);
        Debug.Log(mainData.weather[0].main);
        Debug.Log(mainData.weather[0].description);
        Debug.Log(mainData.weather[0].icon);

        Debug.Log(mainData.main.temp);
        Debug.Log(mainData.main.feels_like);
        Debug.Log(mainData.main.temp_min);
        Debug.Log(mainData.main.temp_max);
        Debug.Log(mainData.main.pressure);
        Debug.Log(mainData.main.humidity);

        Debug.Log(mainData.wind.speed);
        Debug.Log(mainData.wind.deg);

        Debug.Log(mainData.clouds.all);

        Debug.Log(mainData.sys.type);
        Debug.Log(mainData.sys.id);
        Debug.Log(mainData.sys.country);
        Debug.Log(mainData.sys.sunrise);
        Debug.Log(mainData.sys.sunset);

    }

}
