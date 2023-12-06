using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class radioScript : MonoBehaviour
{
    public GameObject Player, Radio, RadioMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //open radio menu upon button press
       if (Vector3.Distance(Player.transform.position, Radio.transform.position) < 2.5f && Input.GetKeyDown(KeyCode.E))
        {
            RadioMenu.SetActive(true);
        }
    }
}
