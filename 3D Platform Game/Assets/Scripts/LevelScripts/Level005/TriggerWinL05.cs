using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWinL05 : MonoBehaviour
{
    Genertor004L05 G45;
    Genertor005L05 G55;
    Genertor006L05 G65;
    public GameObject platform001;

    // Start is called before the first frame update
    void Start()
    {
        G45 = FindObjectOfType<Genertor004L05>();
        G55 = FindObjectOfType<Genertor005L05>();
        G65 = FindObjectOfType<Genertor006L05>();
    }

    // Update is called once per frame
    void Update()
    {
        if(G45.ready1 == true && G55.ready2 == true && G65.ready3 == true)
            platform001.SetActive(true);
    }
}
