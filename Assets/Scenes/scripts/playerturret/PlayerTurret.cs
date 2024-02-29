using UnityEngine;

public class PlayerTurret : MonoBehaviour
{
    public Transform y_Axis;
    public Transform x_Axis;
    public float rotSpeed;
    private float angleX;

    public float bulletSpeed, bulletLifeSpan;
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public Transform impact;

    void Update()
    {
        HorizontalRotation();
        VerticalRotation();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        Vector3 P0 = shootPoint.position;
        Vector3 V0 = bulletSpeed * shootPoint.forward;
        float T = Parabolicshot.Flyingtime(P0, V0);
        impact.position = Parabolicshot.position(T, P0, V0);
    }

    void HorizontalRotation()
    {
        float dt = Time.fixedDeltaTime;
        float hInput = Input.GetAxis("Horizontal");
        float angle = rotSpeed * hInput * dt;
        Vector3 eulerAngles = new Vector3(0, angle, 0);
        y_Axis.Rotate(eulerAngles, Space.Self);
    }

    void VerticalRotation()
    {
        float dt = Time.fixedDeltaTime;
        float vInput = Input.GetAxis("Vertical");
        angleX -= rotSpeed * vInput * dt;
        angleX = Mathf.Clamp(angleX, -90f, 0f);
        x_Axis.localRotation = Quaternion.Euler(angleX, 0, 0);
    }

    void Fire()
    {
        Vector3 position = shootPoint.position;
        Quaternion rotation = shootPoint.rotation;
        GameObject bullet = Instantiate(bulletPrefab, position, rotation);
        bullet.GetComponent<KinematicBullet>().P0 = position;
        bullet.GetComponent<KinematicBullet>().V0 = bulletSpeed * shootPoint.forward;
        Destroy(bullet, bulletLifeSpan);
    }

}
