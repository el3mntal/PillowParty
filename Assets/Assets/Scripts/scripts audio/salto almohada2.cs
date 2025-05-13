using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio-salto : MonoBehaviour
{
AudioSource Audjump;
// Start is called before the first frame update
void Start()
{
    Audjump = GetComponent<AudioSource>();
}

void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        Audjump.Play();
    }
    vold OntriggerExit()
        }
Audjump.Stop();
    }
}