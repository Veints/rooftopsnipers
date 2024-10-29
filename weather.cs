using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public GameObject rainEffect; // Particle system for rain
    public GameObject snowEffect; // Particle system for snow

    void Start()
    {
        StartCoroutine(ChangeWeather());
    }

    private IEnumerator ChangeWeather()
    {
        while (true)
        {
            int weather = Random.Range(0, 3); // 0 = clear, 1 = rain, 2 = snow
            switch (weather)
            {
                case 0:
                    rainEffect.SetActive(false);
                    snowEffect.SetActive(false);
                    break;
                case 1:
                    rainEffect.SetActive(true);
                    snowEffect.SetActive(false);
                    break;
                case 2:
                    rainEffect.SetActive(false);
                    snowEffect.SetActive(true);
                    break;
            }
            yield return new WaitForSeconds(10f);
        }
    }
}
