using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

[System.Serializable]
public class JsonData
{

    public string id;
    public string textURL ;
    public string buttonURL;
    public string imageURL;
    public string videoURL;
    public string audioURL;
    public string urlURL;


}
public class SaveDataJson : MonoBehaviour {

    public InputField m_idValue;
    public InputField m_textValue;
    public InputField m_buttonValue;
    public InputField m_imageValue;
    public InputField m_videoValue;
    public InputField m_audioValue;
    public InputField m_urlValue;

    private string m_id;
    private string m_text;
    private string m_button;
    private string m_image;
    private string m_video;
    private string m_audio;
    private string m_url;



    [SerializeField] private JsonData _jsonData = new JsonData();

    public void Update()
    {
        m_id = m_idValue.text;
        m_text = m_textValue.text;
        m_button = m_buttonValue.text;
        m_image = m_imageValue.text;
        m_video = m_videoValue.text;
        m_audio = m_audioValue.text;
        m_url = m_urlValue.text;


        _jsonData.id = m_id;
        _jsonData.textURL = m_text;
        _jsonData.buttonURL = m_button;
        _jsonData.imageURL = m_image;
        _jsonData.videoURL = m_video;
        _jsonData.audioURL = m_audio;
        _jsonData.urlURL = m_url;

    }


    public  void Save()
    {
        Debug.Log(" BRAVO ! vous avez sauvegarder votre client" + " " + m_id);
        string m_saveDataInJson = JsonUtility.ToJson(_jsonData);
        System.IO.File.WriteAllText(Application.streamingAssetsPath + ("/"+ m_id  + ".json"), m_saveDataInJson);
        Debug.Log(Application.streamingAssetsPath);

    }

}

