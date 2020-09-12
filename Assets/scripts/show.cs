using UnityEngine;

public class show : MonoBehaviour
{

    // Update is called once per frame
    public int reset = 0;


    void Update()
    {


        if (destroy.flag == false)
        {
            reset = 200;
            destroy.flag = true;
        }

        if (reset == 0)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

        if (reset > 0)
        {
            reset--;
        }
    }
}
