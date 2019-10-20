using UnityEngine;
using System.Collections;

public class singouhantei : MonoBehaviour
{

    public GameObject cb1;
    public GameObject cr1;
    public GameObject cy1;
    public GameObject hb1;
    public GameObject hr1;
    public GameObject cb2;
    public GameObject cr2;
    public GameObject cy2;
    public GameObject hb2;
    public GameObject hr2;
    public int i = 0;
    public GameObject singoucube;


    // Use this for initialization
    void Start()
    {
        singoucube = GameObject.Find("singouCube");
        cb1 = GameObject.Find("cb1");
        cr1 = GameObject.Find("cr1");
        cy1 = GameObject.Find("cy1");
        hb1 = GameObject.Find("hb1");
        hr1 = GameObject.Find("hr1");
        cb2 = GameObject.Find("cb2");
        cr2 = GameObject.Find("cr2");
        cy2 = GameObject.Find("cy2");
        hb2 = GameObject.Find("hb2");
        hr2 = GameObject.Find("hr2");

        cb1.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
        cr1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
        cy1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
        hb1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
        hr1.GetComponent<Renderer>().sharedMaterial.color = new Color(1f, 0.044f, 0.044f, 1f);
        cb2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
        cr2.GetComponent<Renderer>().sharedMaterial.color = new Color(1f, 0.044f, 0.044f, 1f); 
        cy2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
        hb2.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
        hr2.GetComponent<Renderer>().sharedMaterial.color = Color.black;

        
    }

    void singou(int i)
    {
            if (i >= 30)
            {
                cb1.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
                cr1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                cr2.GetComponent<Renderer>().sharedMaterial.color = new Color(1f, 0.044f, 0.044f, 1f);
                cy2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                hb2.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
                hr2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
            }
            else if (i >= 25)
            {              
                hr1.GetComponent<Renderer>().sharedMaterial.color = new Color(1f, 0.044f, 0.044f, 1f);
                cb2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                cy2.GetComponent<Renderer>().sharedMaterial.color = new Color(0.988f, 1f, 0.167f, 1f);
        }
            else if (i >= 20)
            {
                switch (i)
                {
                    case 20:
                        hb1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                        break;
                    case 21:
                        hb1.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
                    break;
                    case 22:
                        hb1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                        break;
                    case 23:
                        hb1.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
                    break;
                    case 24:
                        hb1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                        break;
                }
            }
            else if (i >= 10)
            {
                cr1.GetComponent<Renderer>().sharedMaterial.color = new Color(1f, 0.044f, 0.044f, 1f);
                cy1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                hb1.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
                hr1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                cb2.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
                cr2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
            }
            else if (i >= 5)
            {
                cy1.GetComponent<Renderer>().sharedMaterial.color = new Color(0.988f, 1f, 0.167f, 1f);
                cb1.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                hr2.GetComponent<Renderer>().sharedMaterial.color = new Color(1f, 0.044f, 0.044f, 1f);
        }
            else
            {
                switch (i)
                {
                    case 0:
                        hb2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                        break;
                    case 1:
                        hb2.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
                    break;
                    case 2:
                        hb2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                        break;
                    case 3:
                        hb2.GetComponent<Renderer>().sharedMaterial.color = new Color(0.125f, 1f, 0.855f, 1f);
                    break;
                    case 4:
                        hb2.GetComponent<Renderer>().sharedMaterial.color = Color.black;
                        break;
                }
            }

        }

    void OnTriggerEnter(Collider singoucube)
    {
            i = 0;
            StartCoroutine(loop());
        
    }


    private IEnumerator loop()
{
    {
        // ループ
        while (true)
        {
            // 1秒毎にループします
            yield return new WaitForSeconds(2f);
            singou(i);
            i++;
            if (i > 40) { break; }
        }
    }
}

 
    
}
