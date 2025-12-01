using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using TMPro;

public class SensorReader : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sensorsText;

    private void OnEnable()
    {
        // Activar todos los sensores disponibles automáticamente
        foreach (var dev in InputSystem.devices)
        {
            if (dev is Sensor && !dev.enabled)
                InputSystem.EnableDevice(dev);
        }
    }

    private void OnDisable()
    {
        // Deshabilitar sensores cuando la escena se cierra
        foreach (var dev in InputSystem.devices)
        {
            if (dev is Sensor && dev.enabled)
                InputSystem.DisableDevice(dev);
        }
    }

    private void Update()
    {
        if (sensorsText == null) return;

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("<b>SENSORES DISPONIBLES</b>\n");



        foreach (var device in InputSystem.devices)
        {
            // Solo queremos sensores
            if (!(device is Sensor))
                continue;

            sb.AppendLine($"<b>{device.displayName}</b> ({device.GetType().Name})");

            // Mostramos todos los controles útiles del sensor
            foreach (var control in device.allControls)
            {
                string value = GetControlValue(control);
                if (value != null)
                    sb.AppendLine($"   {control.name}: {value}");
            }

            sb.AppendLine();
        }

        sensorsText.text = sb.ToString();
    }

    /// <summary>
    /// Devuelve el valor de un control como string,
    /// o null si no es un control relevante (botones, etc.).
    /// </summary>
    private string GetControlValue(InputControl control)
    {
        switch (control)
        {
            case Vector3Control v3:
                return v3.ReadValue().ToString();
            case QuaternionControl quat:
                return quat.ReadValue().ToString();
            case AxisControl axis:
                return axis.ReadValue().ToString("F3");
            case IntegerControl ic:
                return ic.ReadValue().ToString();
        }

        return null;
    }
}