using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Animator anime;
    private bool flagMining;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        anime.SetBool("isMining", flagMining);
    }

    void FixedUpdate() {
        flagMining = Input.GetKey(KeyCode.Space);
    }
}
