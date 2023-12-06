using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roastMarshmallowsScript : MonoBehaviour
{
    public GameObject wM, rM, bM, fire;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(wM.transform.position, fire.transform.position) < 1f)
        {
            timer += Time.deltaTime;
        }

        //roast marshmallow
        roasted();

        //burn marshmallow
        burnt();

        //eat marshmallows
        eat();
    }

    private void roasted()
    {
        if(timer >= 5f)
        {
            rM.SetActive(true);
            wM.SetActive(false);
        }
    }

    private void burnt()
    {

        if (timer >= 10f)
        {
            rM.SetActive(false);
            bM.SetActive(true);
        }
    }

    private void eat()
    {

    }
}
