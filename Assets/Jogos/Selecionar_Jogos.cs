using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecionar_Jogos : MonoBehaviour
{
    [SerializeField] GameObject contilhama;
    [SerializeField] GameObject asAventurasDeElisa;
    [SerializeField] GameObject dino;
    [SerializeField] GameObject nenhumJogo;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider)
        {
            if (Input.GetMouseButton(0))
            {
                if (hit.collider.gameObject.name == "Contilhama")
                {
                    contilhama.SetActive(true);
                    asAventurasDeElisa.SetActive(false);
                    dino.SetActive(false);
                    nenhumJogo.SetActive(false);
                    Invoke("Contilhama", 1.5f);
                }

                if (hit.collider.gameObject.name == "AsAventurasDeElisa")
                {
                    asAventurasDeElisa.SetActive(true);
                    contilhama.SetActive(false);
                    dino.SetActive(false);
                    nenhumJogo.SetActive(false);
                    Invoke("AsAventurasDeElisa", 1.5f);
                }

                if (hit.collider.gameObject.name == "Dino")
                {
                    dino.SetActive(true);
                    asAventurasDeElisa.SetActive(false);
                    contilhama.SetActive(false);
                    nenhumJogo.SetActive(false);
                    Invoke("Dino", 1.5f);
                }
            }
        }

        if (Input.GetMouseButton(0) && hit.collider == null)
        {
            nenhumJogo.SetActive(true);
            asAventurasDeElisa.SetActive(false);
            contilhama.SetActive(false);
            dino.SetActive(false);
            Invoke("NenhumJogo", 1.5f);
        }
    }

    void Contilhama()
    {
        contilhama.SetActive(false);
    }

    void AsAventurasDeElisa()
    {
        asAventurasDeElisa.SetActive(false);
    }

    void Dino()
    {
        dino.SetActive(false);
    }

    void NenhumJogo()
    {
        nenhumJogo.SetActive(false);
    }
}
