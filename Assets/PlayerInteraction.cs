using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private GameObject nearbyObject; // Yak�ndaki nesneyi tutacak de�i�ken

    void Update()
    {
        // E tu�una bas�ld���nda
        if (Input.GetKeyDown(KeyCode.E) && nearbyObject != null)
        {
            // Nesneyi alma i�lemi
            PickUpObject();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Al�nabilir nesneyle temas
        if (collision.CompareTag("Pickup"))
        {
            nearbyObject = collision.gameObject; // Yak�ndaki nesneyi kaydet
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // Nesne alandan ��kt���nda
        if (collision.CompareTag("Pickup"))
        {
            nearbyObject = null; // Yak�ndaki nesneyi s�f�rla
        }
    }

    void PickUpObject()
    {
        // Nesneyi yok et veya bir envantere ekle
        Debug.Log($"Nesne al�nd�: {nearbyObject.name}");
        Destroy(nearbyObject); // Nesneyi sahneden kald�r
    }
}
