using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testPromptScript : MonoBehaviour
{
    public TMP_Text textBox;
    public string None, Start, Careful, Roast, Roasted, Burnt, Interact;
    public GameObject Player, Fire, Radio, WMarshmallows, RMarshmallows, BMarshmallows;
    public Transform radioRespawn, playerRespawn;

    // Update is called once per frame
    void Update()
    {
        //respawn if too close to fire
        respawn();

        //text prompts
        if (Vector3.Distance(Player.transform.position, Fire.transform.position) < 2f)
        {
            textBox.text = Careful;
        }
        else if (Vector3.Distance(Radio.transform.position, Fire.transform.position) < 2f)
        {
            textBox.text = Careful;
        }
        else if (Vector3.Distance(WMarshmallows.transform.position, Fire.transform.position) < 1f)
        {
            textBox.text = Roast;
        }
        else if (Vector3.Distance(RMarshmallows.transform.position, Fire.transform.position) < 1f)
        {
            textBox.text = Roasted;
        }
        else if (Vector3.Distance(BMarshmallows.transform.position, Fire.transform.position) < 1f)
        {
            textBox.text = Burnt;
        }
        else if (Vector3.Distance(Player.transform.position, Radio.transform.position) < 2.5f)
        {
            textBox.text = Interact;
        }
        else
        {
            textBox.text = None;
        }
    }

    //respawn player or items if thrown into fire
    private void respawn()
    {
        if (Vector3.Distance(Player.transform.position, Fire.transform.position) < 1f)
        {
            Player.transform.position = playerRespawn.transform.position;
        }
        else if (Vector3.Distance(Radio.transform.position, Fire.transform.position) < 1f)
        {
            Radio.transform.position = radioRespawn.transform.position;
        }
    }
}
