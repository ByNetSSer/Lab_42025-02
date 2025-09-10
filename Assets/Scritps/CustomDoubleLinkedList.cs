using UnityEngine;
using TMPro;
using System.Collections;
public class CustomDoubleLinkedList : DoubleLinkedList<Dialogo>
{

    public IEnumerator ReadText(Node<Dialogo> nodeRead, TextMeshProUGUI TextHudName, TextMeshProUGUI TextHUDDialogue)
    {
        GameManager.Instance.Changebool(true);
        string TextToRead = nodeRead.Value.Texto;
        TextHudName.text = nodeRead.Value.Name;
        TextHUDDialogue.text = "";
        for (int i = 0; i < TextToRead.Length; i++)
        {
            TextHUDDialogue.text += TextToRead[i];
            yield return new WaitForSeconds(0.05f);
        }
       GameManager.Instance. Changebool(false);
    }


}
