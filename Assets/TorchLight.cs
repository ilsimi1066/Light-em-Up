using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLight : MonoBehaviour
{
    Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        light.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log(light.enabled);
            light.enabled = !light.enabled;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (light.enabled && other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().decrease_hp();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (light.enabled && other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().decrease_hp();
        }
    }
}
