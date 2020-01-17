using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour {
    Transform player;
    Light light;
    [SerializeField] List<FlickingRule> flickingRules = new List<FlickingRule>();
    
    IEnumerator Start() {
        Init();
        while (true) {
            ChangeLightAmountToRandom();
            yield return new WaitForSeconds(Random.Range(0f,0.1f));
        }
    }

    void Init() {
        light = GetComponent<Light>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void ChangeLightAmountToRandom() {
        light.intensity = ChooseIntensityFromFlickingRules();
    }

    float ChooseIntensityFromFlickingRules() {
        var distance = Vector3.Distance(player.transform.position, transform.position);
        foreach (var rule in flickingRules) {
            if (distance < rule.minDistance)
                return rule.ChooseIntensity();
        }

        return 0;
    }
}

[System.Serializable]
public class FlickingRule {
    public float minDistance;
    public float minIntensity;
    public float maxIntensity;

    public float ChooseIntensity() {
        return Random.Range(minIntensity, maxIntensity);
    }
}