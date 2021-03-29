using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PRINCIPAL : MonoBehaviour
{
    Vector3 ACELEROMETRO, VALORPREVIO, FILTRO;
    float AX, AY, AZ;
    public Text T1, T2, T3;
    public GameObject CUBO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VALORPREVIO = ACELEROMETRO;
        ACELEROMETRO = Input.acceleration;
        FILTRO = Vector3.Lerp(VALORPREVIO, ACELEROMETRO, 0.7f);

        AX = FILTRO.x;
        AY = FILTRO.y;
        AZ = FILTRO.z;

        T1.text = (AX * Mathf.Rad2Deg).ToString();
        T2.text = AX.ToString();
        T3.text = AX.ToString();

        CUBO.transform.localEulerAngles = new Vector3(AX* Mathf.Rad2Deg, AY * Mathf.Rad2Deg, AZ * Mathf.Rad2Deg);
        //CUBO.transform.localEulerAngles = new Vector3(0f, AY * Mathf.Rad2Deg, AX * Mathf.Rad2Deg);
    }
}


