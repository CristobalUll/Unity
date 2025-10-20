# Práctica 4 — Delegados y Eventos (Unity)

## Descripción general
En esta práctica se ha trabajado con **Unity** para implementar una serie de ejercicios orientados a comprender el funcionamiento de **colisiones, detección de eventos,
comunicación entre objetos, interacción con la UI y lógica de juego**.  
El objetivo final es crear un **prototipo interactivo** que combine movimiento, detección de colisiones, recolección de objetos y un sistema de puntuación con recompensas visuales.

---

## Ejercicio 1 — Detección de colisiones básicas
En este ejercicio se implementa la **colisión entre un cilindro y un cubo**, mostrando cómo detectar eventos `OnCollisionEnter` sin usar *Triggers*.  
Se utiliza un script de control que reacciona ante el impacto y envía mensajes a otros objetos.

**Demostración:**  
![Ejercicio 1](Ejercicio1/Ejercicio1.gif)

---

## 💬 Ejercicio 2 — Comunicación mediante mensajes
Aquí se crean **scripts de mensajería** que permiten a distintos objetos (como cubo y cilindro) comunicarse entre sí sin necesidad de estar directamente conectados.  
El sistema detecta colisiones y envía un mensaje global a través de un "mensajero" central.

**Demostración:**  
![Ejercicio 2](media/ejercicio2.gif)

---

## 🔴 Ejercicio 3 — Escudos con cambio de color
Se incorporan **escudos en la escena** que cambian de color al ser tocados por los humanoides.  
Se utilizan colisiones `OnTriggerEnter` y componentes `Renderer` para modificar dinámicamente el color de los escudos.

**Demostración:**  
![Ejercicio 3](media/ejercicio3.gif)

---

## 🚶 Ejercicio 4 — Movimiento y orientación
Se desarrolla el movimiento de los humanoides mediante `transform.Translate()` y su orientación hacia un objetivo determinado en la escena.  
El script ajusta la rotación y el desplazamiento continuo para simular comportamiento autónomo.

**Demostración:**  
![Ejercicio 4](media/ejercicio4.gif)

---

## 🧮 Ejercicio 5 — Sistema de puntuación
Se implementa la lógica de **recolección de escudos** con distintas puntuaciones:  
- Escudo tipo 1 → +5 puntos  
- Escudo tipo 2 → +10 puntos  

Los puntos se muestran en consola al recolectar cada objeto.

**Demostración:**  
![Ejercicio 5](media/ejercicio5.gif)

---

## 🖥️ Ejercicio 6 — Interfaz de puntuación (UI)
Se añade una **interfaz gráfica (Canvas)** con texto que muestra la puntuación actual del jugador.  
Cada vez que se recoge un escudo, la UI se actualiza dinámicamente con el nuevo valor.

**Demostración:**  
![Ejercicio 6](media/ejercicio6.gif)

---

## 🎁 Ejercicio 7 — Sistema de recompensas
Se amplía la mecánica de puntuación para que **cada 100 puntos** el jugador obtenga una **recompensa visual**, mostrada en la UI durante unos segundos.  
Esto simula logros o bonificaciones dentro del juego.

**Demostración:**  
![Ejercicio 7](media/ejercicio7.gif)

---

## 🕹️ Ejercicio 8 — Escena final del prototipo
Se genera una **escena completa y funcional**, combinando todas las mecánicas anteriores:
- Movimiento del jugador  
- Recolección de escudos  
- Sistema de puntuación  
- Recompensas visuales  
- Interfaz integrada  

El resultado es un **prototipo jugable**, con entorno 3D, interfaz limpia y mecánicas interactivas básicas.

**Demostración:**  
![Ejercicio 8](media/ejercicio8.gif)

---

## 🧑‍💻 Autor
**[Tu nombre aquí]**  
Grado en Ingeniería Informática  
Asignatura: *Computabilidad y Algoritmia*  
Curso 2024/2025  
