# 🕹️ Práctica 3 — Física y Colisiones en Unity

## 👨‍💻 Autor
**Nombre: Cristóbal Jesús Sarmiento Rodríguez**  
**Asignatura: Interfaces Inteligentes** 
**Fecha: 14/10/2025**  

---

## 📘 Descripción general
En esta práctica se trabajan distintos conceptos de física en Unity:  
- Uso de colliders y triggers.  
- Interacciones mediante la Layer Collision Matrix.  
- Aplicación de materiales físicos.  
- Detección de colisiones y reacciones con `OnCollisionEnter` y `OnTriggerEnter`.  
- Movimiento y lanzamiento de objetos con `Rigidbody` y `AddForce()`.


---

## Parte 1 — Escena Básica

**Explicación: Primera situación**  
En este apartado, podemos observar como el cubo que tiene el RigidBody cae al vacío, ya que se ha puesto un plano
por defecto (sin modificar nada). Si hubiesemos querido que tuviese colisión con el cubo, tendríamos que haber
activado la opción "Convex" en el inspector (pero como no se especificaba nada, se ha dejado por defecto).
 

**GIF de demostración:**  
![Situación 1](./Primera%20Parte/Primer%20Ejercicio.gif)

---

**Explicación: Segunda situación**  
En este apartado, pasa lo mismo que en el anterior pero también con la esfera, es decir, los dos objetos
se caen al vacío por la misma razón explicada en la situación anterior.
 

**GIF de demostración:**  
![Situación 2](./Primera%20Parte/Segundo%20Ejercicio.gif)


---

**Explicación: Tercera situación**  
En este apartado, pasa lo mismo que en la primera situación, solamente se cae el cubo. La esfera no precipita
debido a que la hemos puesto como un objeto físico cinemático que controlamos nosotros.
 

**GIF de demostración:**  
![Situación 2](./Primera%20Parte/Tercer%20Ejercicio.gif)

---

**Explicación: Cuarta situación**  
En este apartado, todos los objetos se caen al vacío, debido a que el plano no tiene la propiedad
activada que mencionábamos anteriormente.
 

**GIF de demostración:**  
![Situación 2](./Primera%20Parte/Cuarto%20Ejercicio.gif)

---

**Explicación: Quinta situación**  
En este apartado, pasa exactamente lo mismo que en la tercera situación, los objetos caen a la misma
velocidad independientemente de la masa que tengan.
 

**GIF de demostración:**  
![Situación 2](./Primera%20Parte/Quinto%20Ejercicio.gif)

---

**Explicación: Sexta situación**  
En este apartado, pasa exactamente lo mismo que en la situación anterior, ya que únicamente aumentamos
la masa de la esfera de nuevo.
 

**GIF de demostración:**  
![Situación 2](./Primera%20Parte/Sexto%20Ejercicio.gif)

---

**Explicación: Séptima situación**  
En este apartado, sino activamos la opción del plano cae todo de nuevo, sino, rebotaría un poco y 
acabaría frenándose por la fricción puesta.
 

**GIF de demostración:**  
![Situación 2](./Primera%20Parte/Séptimo%20Ejercicio.gif)

---

**Explicación: Octava situación**  
En este apartado, sino activamos la opción del plano cae todo de nuevo, sino, rebotaría un poco y 
acabaría frenándose por la fricción puesta.
 

**GIF de demostración:**  
![Situación 2](./Primera%20Parte/Octavo%20Ejercicio.gif)

---

## Parte 2 — Colisiones y triggers

**Explicación: Ejercicio 1**  


**GIF de demostración:**  
![Ejercicio 2](./Seguna%20Parte/1.1%20Ejercicio.gif)

---

## 🧩 Conclusión
En esta práctica se comprendió cómo Unity maneja la física realista a través de **Rigidbody**, **Colliders**, **Triggers** y **Physic Materials**.  
Cada ejercicio muestra un aspecto clave del motor de física y su relación con las capas, fuerzas y colisiones.

---
