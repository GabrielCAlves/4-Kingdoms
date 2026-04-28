using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Aqui");
        if(Input.GetKeyDown(KeyCode.Space)){
            animator.SetBool("pressed", true);
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            animator.SetBool("pressed", false);
        }

        if(Input.GetKeyDown(KeyCode.A)){
            animator.SetBool("primeiraAn", true);
        }
        if(Input.GetKeyUp(KeyCode.A)){
            animator.SetBool("primeiraAn", false);
        }

        if(Input.GetKeyDown(KeyCode.S)){
            animator.SetBool("segundaAn", true);
        }
        if(Input.GetKeyUp(KeyCode.S)){
            animator.SetBool("segundaAn", false);
        }
        
        if(Input.GetKeyDown(KeyCode.D)){
            animator.SetBool("terceiraAn", true);
        }
        if(Input.GetKeyUp(KeyCode.D)){
            animator.SetBool("terceiraAn", false);
        }
        
        if(Input.GetKeyDown(KeyCode.F)){
            animator.SetBool("quartaAn", true);
        }
        if(Input.GetKeyUp(KeyCode.F)){
            animator.SetBool("quartaAn", false);
        }
        
        if(Input.GetKeyDown(KeyCode.G)){
            animator.SetBool("quintaAn", true);
        }
        if(Input.GetKeyUp(KeyCode.G)){
            animator.SetBool("quintaAn", false);
        }
        
        if(Input.GetKeyDown(KeyCode.H)){
            animator.SetBool("sextaAn", true);
        }
        if(Input.GetKeyUp(KeyCode.H)){
            animator.SetBool("sextaAn", false);
        }
        
        if(Input.GetKeyDown(KeyCode.J)){
            animator.SetBool("setimaAn", true);
        }
        if(Input.GetKeyUp(KeyCode.J)){
            animator.SetBool("setimaAn", false);
        }
        
        if(Input.GetKeyDown(KeyCode.K)){
            animator.SetBool("oitavaAn", true);
        }
        if(Input.GetKeyUp(KeyCode.K)){
            animator.SetBool("oitavaAn", false);
        }
        
        if(Input.GetKeyDown(KeyCode.L)){
            animator.SetBool("nonaAn", true);
        }
        if(Input.GetKeyUp(KeyCode.L)){
            animator.SetBool("nonaAn", false);
        }
        
        if(Input.GetKeyDown(KeyCode.Q)){
            animator.SetBool("decimaAn", true);
        }
        if(Input.GetKeyUp(KeyCode.Q)){
            animator.SetBool("decimaAn", false);
        }
    }
}
