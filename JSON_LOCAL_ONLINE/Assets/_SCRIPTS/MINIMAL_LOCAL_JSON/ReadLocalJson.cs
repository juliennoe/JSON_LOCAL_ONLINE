using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class ReadLocalJson : MonoBehaviour
{
    // MONTRE FICHIER JSON
    [TextArea(55, 20)]
    public string jsonString; 

    void Start()
    {
        jsonString = File.ReadAllText(Application.dataPath + "/Resources/data.json"); // LECTURE DU FICHIER JSON

        SoloDataJson m_soloDataJson = JsonUtility.FromJson<SoloDataJson>(jsonString); // CONVERSION DU FICHIER JSON
        ArrayArray m_arrayArray = JsonUtility.FromJson<ArrayArray>(jsonString);

        Debug.Log(m_soloDataJson.t_string);
        Debug.Log(m_arrayArray.t_array[1].t_float);
        Debug.Log(m_arrayArray.t_array[2].t_sousArray[1]);
     
    }


}
