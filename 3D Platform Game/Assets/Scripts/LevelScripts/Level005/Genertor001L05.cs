using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Genertor001L05 : MonoBehaviour
{
    [SerializeField] private Renderer mate;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject Message;
    public AudioSource GS;
    int state = 0;
    bool IsActive = false;

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
                target1.SetActive(true);
                target3.SetActive(false);
                mate.material.color = Color.white;
            }
            else if (state % 2 != 0)
            {
                target1.SetActive(false);
                target3.SetActive(true);
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
