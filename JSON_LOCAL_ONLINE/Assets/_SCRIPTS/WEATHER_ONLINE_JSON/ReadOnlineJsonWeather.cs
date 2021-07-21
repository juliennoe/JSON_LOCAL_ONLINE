using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ReadOnlineJsonWeather : MonoBehaviour
{
    // VARIABLE CHEMIN ACCES URL
    [TextArea(5, 20)]
    public string pathJsonData;

    void Start()
    {
        // CHEMIN URL EN DUR
        pathJsonData = "api.openweathermap.org/data/2.5/weather?q=ouge&appid=d767cd7b02e730f0f63c306d82e50165";
        StartCoroutine("linkDataJson");
    }

    // COROUTINE DE LECTURE
    IEnumerator linkDataJson()
    {

        Debug.Log("je suis dans la coroutine LinkDataJson");

        UnityWebRequest wwwPathJson = UnityWebRequest.Get(pathJsonData); // Lecture du lien URL via pathJsonData contenu dans la metaData du marqueur
        yield return wwwPathJson.SendWebRequest();
        MainData JsonBridge = JsonUtility.FromJson<MainData>(wwwPathJson.downloadHandler.text); // Association du dictionnaire "JsonBridge" avec le Json afin de faire la passerelle entre le C# et le Json
    
        //  Debug.Log(JsonBridge.base);
        Debug.Log(JsonBridge.visibility);
        Debug.Log(JsonBridge.dt);
        Debug.Log(JsonBridge.timezone);
        Debug.Log(JsonBridge.id);
        Debug.Log(JsonBridge.name);
        Debug.Log(JsonBridge.cod);

        Debug.Log(JsonBridge.coord.lon);
        Debug.Log(JsonBridge.coord.lat);

        Debug.Log(JsonBridge.weather[0].id);
        Debug.Log(JsonBridge.weather[0].main);
        Debug.Log(JsonBridge.weather[0].description);
        Debug.Log(JsonBridge.weather[0].icon);

        Debug.Log(JsonBridge.main.temp);
        Debug.Log(JsonBridge.main.feels_like);
        Debug.Log(JsonBridge.main.temp_min);
        Debug.Log(JsonBridge.main.temp_max);
        Debug.Log(JsonBridge.main.pressure);
        Debug.Log(JsonBridge.main.humidity);

        Debug.Log(JsonBridge.wind.speed);
        Debug.Log(JsonBridge.wind.deg);

        Debug.Log(JsonBridge.clouds.all);

        Debug.Log(JsonBridge.sys.type);
        Debug.Log(JsonBridge.sys.id);
        Debug.Log(JsonBridge.sys.country);
        Debug.Log(JsonBridge.sys.sunrise);
        Debug.Log(JsonBridge.sys.sunset);



    }
}