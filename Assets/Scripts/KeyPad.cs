using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    public TMPro.TMP_Text ANS;
    private string Answer = "12345";
    [SerializeField] private Animator Door;
   public void number(int Number)
    {
        ANS.text += Number.ToString();
    } 

    public void Ejecutar()
    {

        if (ANS.text == Answer)
        {
            ANS.text = "OPEN";
            StartCoroutine("BorrarTexto");

            Door.SetBool("open",true);
            StartCoroutine("StopDoor");
        }
        else
        {
            ANS.text = "Incorrecto";
            StartCoroutine("BorrarTexto");
        }
    }
    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Door.SetBool("open",false);
        Door.enabled = false;
    }
    IEnumerator BorrarTexto()
    {
        yield return new WaitForSeconds(0.5f);
        ANS.text = "";
    }

}
