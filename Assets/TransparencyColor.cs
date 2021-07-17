using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransparencyColor : MonoBehaviour
{
    private Image images;
    private int v = 0;
    public Color color = Color.white;

    void Start()
    {
        color.a = 0.0f;
        GetComponent<Image>().color = color;
        // Start is called before the first frame update
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            for (float i = 0.0f; i <= 1.0f; i = i + 0.1f)
            {
                color.a = i;
                GetComponent<Image>().color = color;

            }
            //color.a = 1.0f;
            //GetComponent<Image>().color = color;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            changleAlpha();
        }
    }
    public void changleAlpha()
    {
        for (float i = 0.0f; i <= 1.0f; i = i + 0.1f)
        {
            StartCoroutine(ChangeAlpha(i));

        }
    }
    IEnumerator ChangeAlpha(float i)
    {
        color.a = i;
        GetComponent<Image>().color = color;
        yield return new WaitForSeconds(1.0f);
        

    }
}
