using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeightCalculator : MonoBehaviour
{
    private float weight = 0;

    
    public TextMeshProUGUI squareWeightText;
    public TextMeshProUGUI sphereWeightText;

    int squareWeight;
    int sphereWeight;

    public float Weight
    {
        get
        {
            return weight;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        weight += other.GetComponent<Rigidbody>().mass;

        if (other.CompareTag("Square"))
        {
            
            squareWeight += 1;
            squareWeightText.text = squareWeight.ToString();
        }
        else if (other.CompareTag("Sphere"))
        {
            
            sphereWeight += 1;
            sphereWeightText.text = sphereWeight.ToString();
        }
    }

    
}
