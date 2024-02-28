using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WeightSpawner : MonoBehaviour
{
    
    
    

    public GameObject leftTrigger;
    public GameObject rightTrigger;

    public GameObject LeftPlate;
    public GameObject RightPlate;
    public GameObject Scale;

    public Image indicator;
    public TextMeshProUGUI currentState;

    public Vector3 position;
    public GameObject squarePrefab;

    private void Update()
    {
        if(leftTrigger.GetComponent<WeightCalculator>().Weight == rightTrigger.GetComponent<WeightCalculator>().Weight)
        {
            indicator.color = Color.green;
            currentState.text = "=";

            Scale.transform.localPosition = new Vector3(0, 0, -1f);
            Scale.transform.localRotation = Quaternion.Euler(new Vector3(-90, 0, 0));

            LeftPlate.transform.localPosition = new Vector3(-2.023f, 2.88f, 0);
            LeftPlate.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));

            RightPlate.transform.localPosition = new Vector3(2.041f, 2.88f, 0);
            RightPlate.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));

        }
        else if(leftTrigger.GetComponent<WeightCalculator>().Weight > rightTrigger.GetComponent<WeightCalculator>().Weight)
        {
            indicator.color = Color.red;
            currentState.text = ">";
        }
        else if(leftTrigger.GetComponent<WeightCalculator>().Weight < rightTrigger.GetComponent<WeightCalculator>().Weight)
        {
            indicator.color = Color.red;
            currentState.text = "<";
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Square"))
        {
            Spawner();
        }
    }
    public void Spawner()
    {
        Instantiate(squarePrefab, position, Quaternion.identity);
    }
    public void HandleReset()
    {
        SceneManager.LoadScene(0);
    }

}
