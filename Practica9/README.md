# 📱🎮 Práctica – Uso de Componentes del Móvil en Unity3D
### Interfaces Inteligentes – Grado en Ingeniería Informática  
**Curso 2025/2026**

---

## 🧭 1. Objetivo de la práctica

El objetivo de esta práctica es **integrar sensores móviles en Unity3D** usando el **nuevo Input System**.  
Se trabaja con **GPS**, **brújula** y **acelerómetro**, desarrollando dos escenas principales:

1. **Visualización de sensores del dispositivo**  
2. **Control de un personaje** mediante:
   - Orientación al norte  
   - Inclinación del móvil  
   - Validación de una **geovalla** mediante GPS  

---

## 📊 2. Escena 1 – Visualización de Sensores

En esta escena:

- Se listan todos los sensores disponibles mediante `InputSystem.devices`.
- Se muestran sus controles y valores en tiempo real.
- Se utiliza una **UI con ScrollView** y **Content Size Fitter** para acomodar el listado dinámico.

**Resultado:** una interfaz que permite observar en tiempo real cómo afectan los movimientos y la orientación del dispositivo a los sensores.

[![Ver vídeo](https://img.shields.io/badge/Ver%20Video-Drive-blue?style=for-the-badge)](https://drive.google.com/file/d/14_GW8O88bT502XJS0lkFKRERDLGHeHt-/view?usp=sharing)

---

## ⚔️ 3. Escena 2 – Control del Guerrero con Sensores

### 🧭 A) Orientación hacia el Norte  
El guerrero apunta siempre hacia el norte utilizando:  
- `Input.compass.trueHeading`  
- Rotación suave mediante `Quaternion.Slerp`  

### 📐 B) Movimiento por inclinación  
El movimiento del personaje se controla con:  
- `Input.acceleration`  
- Detección automática del **eje dominante** según la orientación del móvil  

### 📍 C) Geovalla (Geofencing)  
El personaje **solo se mueve** si el jugador se encuentra dentro de una zona GPS válida:  
- Se usa `Input.location` para obtener latitud/longitud  
- Se comprueba si la posición está dentro del rango configurado  

[![Ver vídeo](https://img.shields.io/badge/Ver%20Video-Drive-blue?style=for-the-badge)](https://drive.google.com/file/d/10P4tSQwhTQwhuBFb2HAMvmx2_JDVHVE_/view?usp=sharing)


---

## 📁 4. Scripts Principales

| Script | Función |
|--------|---------|
| **SensorReader.cs** | Detecta los sensores disponibles dinámicamente y actualiza la UI en tiempo real. |
| **SensorController.cs** | Controla orientación, movimiento por acelerómetro y validación de geovalla. |

---

## 📱 5. Pruebas en dispositivos reales

###  iPhone  
- Construcción a Xcode  
- Añadir permisos de **localización** y **motion usage** en `Info.plist`  
- Ejecutar en dispositivo físico  

---

## 📝 6. Conclusiones

La práctica demuestra la **integración multimodal** de sensores móviles en Unity3D y el desarrollo de mecánicas que
combinan **posición**, **orientación** y **movimiento físico** para controlar elementos del juego.
