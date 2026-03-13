using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class OneCallWeatherDisplay : MonoBehaviour
{
    [Header("UI")]
    public TMP_Text temperatureText;
    public TMP_Text timeText;

    [Header("OpenWeather")]
    public string apiKey = "API KEY REMOVED FOR SECURITY";

    [Header("Location")]
    public float latitude = 39.1031f;   // Cincinnati example
    public float longitude = -84.5120f;

    [Header("Refresh")]
    public float refreshIntervalSeconds = 600f; // 10 min

    void Start()
    {
        StartCoroutine(UpdateWeatherLoop());
    }

    void Update()
    {
        if (timeText != null)
        {
            timeText.text = DateTime.Now.ToString("h:mm \ntt");
        }
    }

    IEnumerator UpdateWeatherLoop()
    {
        while (true)
        {
            yield return StartCoroutine(GetWeather());
            yield return new WaitForSeconds(refreshIntervalSeconds);
        }
    }

    IEnumerator GetWeather()
    {
        string url =
            $"https://api.openweathermap.org/data/3.0/onecall?lat={latitude}&lon={longitude}&exclude=minutely,hourly,daily,alerts&appid={apiKey}&units=imperial";

        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Weather request failed: " + request.error);
                if (temperatureText != null)
                    temperatureText.text = "Temp unavailable";
                yield break;
            }

            string json = request.downloadHandler.text;
            WeatherRoot weather = JsonUtility.FromJson<WeatherRoot>(json);

            if (weather != null && weather.current != null)
            {
                int roundedTemp = Mathf.RoundToInt(weather.current.temp);
                temperatureText.text = $"{roundedTemp}°F";
            }
            else
            {
                temperatureText.text = "Temp unavailable";
            }
        }
    }
}

[System.Serializable]
public class WeatherRoot
{
    public CurrentWeather current;
}

[System.Serializable]
public class CurrentWeather
{
    public float temp;
}