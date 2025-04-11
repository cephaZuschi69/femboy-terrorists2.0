using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject ballPrefab; // Das Prefab der Kugel
    public float shootForce = 10f; // Kraft, mit der die Kugel abgeschossen wird

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Linksklick erkennen
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Eine Kugel an der Position des Spielers erzeugen
        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);

        // Der Kugel eine Geschwindigkeit basierend auf der Blickrichtung des Spielers geben
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * shootForce, ForceMode.Impulse);
    }
}