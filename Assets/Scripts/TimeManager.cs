using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public Text txtTime;
    public Text txtTimeFloored;
    public Text txtsegs;
    public Text txtmin;
    public GameObject txtPerdiste;

    public float TimeToDoSomething;
    public float TimeToWait;

    public bool isCounting;
    public float elapsedTime;

    // Use this for initialization
    void Start () {
        elapsedTime = 0;
        isCounting = false;
	}

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;

        txtTime.text = currentTime.ToString();

        txtTimeFloored.text = Mathf.Floor(currentTime).ToString();

        int minutos = Mathf.FloorToInt((currentTime + 100 / 60));
        txtmin.text = minutos.ToString();

        txtsegs.text = (currentTime % 60).ToString();

        if(currentTime > 3)
        {
            txtPerdiste.SetActive(true);
        }

        if (isCounting)
        {
            elapsedTime += Time.deltaTime;
        }

        if(currentTime > TimeToDoSomething)
        {
            TimeToDoSomething += TimeToWait;
            txtPerdiste.GetComponent<Text>().text = "Cambio en " + TimeToDoSomething.ToString();
        }
    }
}
