# Práctica 6: Meta XR Simulator + XR Interaction Toolkit

## Objetivo
Configurar un entorno de **realidad virtual (VR)** en Unity utilizando el **Meta XR Simulator** y el
**XR Interaction Toolkit**, permitiendo simular interacciones básicas (agarre directo y selección con rayo)
sin necesidad de un visor físico Meta Quest.

---

## Instalación y Configuración del Entorno

### 1. Instalación de paquetes necesarios
Desde **Window → Package Manager**, se instalaron los siguientes paquetes:

- **XR Plugin Management** → para gestionar los plugins XR del proyecto.  
- **OpenXR Plugin** → estándar de compatibilidad XR (necesario para Meta Quest).  
- **XR Interaction Toolkit** → para habilitar interacciones (agarrar, soltar, rayos, etc.).  

En el **XR Interaction Toolkit**, se importó el *Sample* **Starter Assets** (añade prefabs configurados de movimiento e interacción).

---

### 2. Instalación del SDK de Meta
Desde la **Asset Store / Package Manager**, se importaron:

- **Meta XR Core SDK**  
- **Meta XR Simulator**

En el *Package Manager → Meta XR Simulator*, se importaron los *Samples*, los cuales añadieron el prefab **Meta XR Simulator Rig** al proyecto.

---

### 3. Configuración de OpenXR
En **Edit → Project Settings → XR Plug-in Management → OpenXR**, se activaron:

- ✅ **OpenXR** en las plataformas *Standalone (Windows)* y *Android*  
- ✅ **Meta XR Simulator**  
- ✅ **Meta Quest Touch Controller Profile**  
- ✅ (Opcional) **Hand Tracking**

Si Unity mostró advertencias, se aplicó **Fix All**.

---

### 4. Configuración de la escena

1. Se eliminó la `Main Camera`.  
2. Se añadieron los siguientes objetos desde el menú:
   - `XR Origin (VR)` → para el modo Quest real (build Android).
   - `Meta XR Simulator Rig` → para modo simulador (Play en PC).
3. **Solo uno de ellos se mantiene activo según el modo**:
   - *Simulación en PC:* activo `Meta XR Simulator Rig`
   - *Build para Quest:* activo `XR Origin (VR)`

---

## Escena creada

### 1. Objetos
- **Plano** (Ground)
- **Cubo cercano** (Direct Interactable)
- **Cubo lejano** (Ray Interactable)

### 2. Scripts creados

#### `LogOnGrab.cs`
Muestra un mensaje en consola cuando el jugador agarra el cubo cercano:


#### `ChangeColorOnSelect.cs`
Cambia el color del cubo lejano cuando el jugador lo agarra.



![Demostración del simulador](/Gif/Meta.gif)



Autor

Cristóbal Jesús Sarmiento Rodríguez
Asignatura: Interfaces Inteligentes – Práctica XR
Universidad de La Laguna
Curso 2025

