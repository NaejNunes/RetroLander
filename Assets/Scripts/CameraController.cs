using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player;

    public float zoomMinimo = 15f;
    public float ZoomMximo = 4f;
    public float intervalo = 0.1f;
    private Camera minhaCamera;
    private float velocidadeZoom;
    private Vector3 velocidadeMovimento;

    // Start is called before the first frame update
    void Start()
    {
        minhaCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (player.position.y > 0)
            {
                minhaCamera.orthographicSize = Mathf.SmoothDamp(minhaCamera.orthographicSize, zoomMinimo, ref velocidadeZoom, intervalo);
            }
            else {
                Vector3 novaPosicao = new Vector3(player.position.x, player.position.y, -10);
                transform.position = Vector3.SmoothDamp(transform.position, novaPosicao, ref velocidadeMovimento, intervalo);
                minhaCamera.orthographicSize = Mathf.SmoothDamp(minhaCamera.orthographicSize, ZoomMximo, ref velocidadeZoom, intervalo);
            }
        }
    }
}
