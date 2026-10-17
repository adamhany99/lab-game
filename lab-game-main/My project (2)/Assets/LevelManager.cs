using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject CurrentCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        CurrentCheckpoint = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Respawnpl()
    {
        Debug.Log("mamam");
        FindObjectOfType<mm>().transform.position = CurrentCheckpoint.transform.position;
    }
}
