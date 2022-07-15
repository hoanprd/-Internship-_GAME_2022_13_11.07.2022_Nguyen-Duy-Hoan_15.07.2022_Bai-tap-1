using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Genertor006L05 : MonoBehaviour
{
    [SerializeField] private Renderer mate;
    public GameObject Message;
    public AudioSource GS;
    int state = 0;
    bool IsActive = false;
    public bool ready3 = false;

    // Start is called before the first frame update
    void Start()
    {
        mate.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive && Input.GetKeyUp(KeyCode.F))
        {
            GS.Play();
            state++;
            if (state % 2 == 0)
            {
                ready3 = false;
                mate.material.color = Color.white;
            }
            else if (state % 2 != 0)
            {
                ready3 = true;
                mate.material.color = Color.blue;
            }
        }
    }
    private void OnCollisionEnter()
    {
        IsActive = true;
        Message.SetActive(true);
        Message.GetComponent<Text>().text = "Press F to start the elevator";
    }
    private void OnCollisionExit(Collision collision)
    {
        IsActive = false;
        Message.SetActive(false);
    }
}
