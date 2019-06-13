using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float velocidade = 50f;

    public float combustivel = 1000f;

    public float consumoCombustivel = 1f;

    public float velocidadeLimitePouso = 50f;

    public LayerMask raycastLayersMask;

    public SpriteRenderer propulsorFX;

    public GameObject explosao;

    public Text hudAltitude;

    public Text hudCombustivel;

    public Text hudVelocidadeVertical;

    public Text hudVelocidadeHorizontal;

    private Rigidbody2D rb;

    private float velocidadeVertical;

    private float velocidadeHorizontal;

    private float altitude;

    private string setaEsquerda = "\u2190";

    private string setaDireita = "\u2192";

    private string setaCima = "\u2191";

    private string setaBaixo = "\u2193";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
