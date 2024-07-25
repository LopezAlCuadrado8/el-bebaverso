using UnityEngine;
using TMPro;

public class NumeroPregunta : MonoBehaviour
{
    void Start(){
       TMP_Text texto = GetComponent<TMP_Text>();
       texto.text = transform.parent.name;
    }
}
