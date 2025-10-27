# Práctica 5: Escena Google Cardboard

## 🧠 Descripción general
Esta práctica consiste en crear una **escena en realidad virtual (VR)** compatible con
**Google Cardboard**, donde el jugador puede desplazarse con la vista o con un mando, y
recolectar objetos al mirarlos durante un tiempo determinado.

El proyecto está desarrollado en **Unity** utilizando el **Google Cardboard XR Plugin**.

---

## 🏗️ Estructura del proyecto

### 🎯 Escena principal
La escena contiene:
- Un **terreno** generado con el sistema de `Terrain` de Unity.
- Varios **objetos recolectables** (por ejemplo gemas o cofres) importados desde la Asset Store.
- Un **jugador** (XR Origin) con cámara VR compatible con Cardboard.
- Un **sistema de gestión (GameManager)** para almacenar los objetos recolectados.

---

## 🕹️ Jugabilidad
- El jugador puede **moverse** de dos formas:
  1. **Con la vista**: el jugador avanza en la dirección a la que mira.
  2. **Con un mando Bluetooth** (usando las teclas de movimiento).
- Al **mirar un objeto** durante un tiempo determinado (`collectTime`), este se **recolecta** automáticamente y desaparece del entorno.
- Los objetos recolectados se almacenan en una lista gestionada por el `GameManager`.

---

## ⚙️ Scripts principales

| Script | Descripción |
|--------|--------------|
| **PlayerMove.cs** | Controla el movimiento del jugador (por vista o mando). |
| **Collectible.cs** | Detecta cuándo el jugador mira un objeto y lo recolecta tras cierto tiempo (`OnPointerEnter` / `OnPointerExit`). |
| **Collector.cs** | Objeto que atrae las gemas recolectadas cuando el jugador lo observa. |
| **GameManager.cs** | Gestiona la lista global de objetos recolectados. |

---

## 🧩 Requisitos de configuración

1. **Event System**
   - Asegúrate de tener un objeto `EventSystem` en la escena (`GameObject → UI → Event System`).

2. **Main Camera (Cardboard)**
   - La cámara dentro del `XR Origin` debe tener:
     - El tag `MainCamera`.
     - El componente `Physics Raycaster`.

3. **Gemas y objetos recolectables**
   - Deben tener un `Collider` y el script `Collectible.cs`.

4. **Terreno y objetos**
   - Creados con el sistema de `Terrain`.
   - Se pueden importar desde la **Asset Store** (por ejemplo, “Low Poly Nature Pack” o “Fantasy Treasure Set”).

---

## 🌐 Demostración

![Demostración](./Gif/Carboard.gif)

---

## 🚀 Instrucciones para ejecutar

1. Clonar o descargar el proyecto.
2. Abrirlo en **Unity**.
3. Asegurarse de que el XR Plugin Management tiene activado **Cardboard**.
4. Ejecutar la escena (`Play`) o compilar para Android:


---

## 🎨 Créditos
- **Autor:** Cristóbal Jesús Sarmiento Rodríguez 
- **Asignatura:** Interfaces Inteligentes 

