using UnityEngine;

public class TriggerItem3D : MonoBehaviour
{

    public string tagObjetivo = "Player";
    public Item3DPopup popup;
    public Camera camaraJugador;

    [Header("Activar animación manual")]
    public bool activarAnimacion = false;

    private bool yaEjecutado = false; // para que no se repita 100 veces

    private void Update()
    {
        if (activarAnimacion && !yaEjecutado)
        {
            yaEjecutado = true;
            ActivarAnimacion();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagObjetivo))
        {
            ActivarAnimacion();
        }
    }

    public void ActivarAnimacion()
    {
        if (popup != null && camaraJugador != null)
        {
            popup.MostrarItem(camaraJugador);
        }
        else
        {
            Debug.LogWarning("Faltan referencias en TriggerItem3D (popup o camaraJugador)");
        }
    }
}