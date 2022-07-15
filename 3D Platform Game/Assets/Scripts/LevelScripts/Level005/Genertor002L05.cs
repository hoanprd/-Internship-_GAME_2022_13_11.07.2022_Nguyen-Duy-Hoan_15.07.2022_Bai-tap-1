using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Genertor002L05 : MonoBehaviour
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
                target2.SetActive(true);
                target4.SetActive(false);
                mate.material.color = Color.white;
            }
            else if (state % 2 != 0)
            {
                target2.SetActive(false);
                target4.SetActive(true);
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
