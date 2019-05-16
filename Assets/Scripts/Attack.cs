using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public Button attackBtn;

    // Start is called before the first frame update
    void Start()
    {
        attackBtn.onClick.AddListener(OnAttack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttack()
    {        
        Debug.Log("Atack");
    }
}
