using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message : MonoBehaviour
{
    public Sprite text;
    private CapsuleCollider2D capsuleCollider2D;
    private SpriteRenderer sr;

    private void Start() {
        sr = GetComponent<SpriteRenderer>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
    }   
    
    // Update is called once per frame
    void Update()
    {
        if(capsuleCollider2D.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            sr.sprite = text;
        }       
        else
        {
            sr.sprite = null;
        }
    }
}
