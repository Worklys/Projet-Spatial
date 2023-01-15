using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueText : MonoBehaviour
{
  Text saveText;
  string  textScene;
  public float delai= 0.2f;

 void Awake(){

   saveText = GetComponent<Text>();
   textScene = saveText.text;
   saveText.text = null;
   StartCoroutine(DefilementText());
 }

 IEnumerator DefilementText(){

   for (int i=0; i <= textScene.Length; i++){

     saveText.text = textScene.Substring(0, i);
     yield return new WaitForSeconds(delai);
   }
 }
}
