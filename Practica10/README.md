# 📝 README — Práctica del habla en Unity

## 🎯 Descripción del Proyecto

Este proyecto integra **Whisper (whisper.cpp)** dentro de Unity para permitir **control por voz** de personajes.
El usuario puede:

- Seleccionar un guerrero haciendo **clic** sobre él.
- Pulsar una tecla (**R**) para activar la grabación de voz.
- Dar una orden hablada (por ejemplo: *“avanza”, “gira”, “ataca”, “defiéndete”*).
- Whisper transcribe la voz a texto.
- El guerrero seleccionado ejecuta la acción correspondiente.

El plugin funciona con **GPU Acceleration** en macOS mediante **Metal** (M1/M2/M3), mejorando notablemente el rendimiento.

---

## 🚀 Funcionalidades Implementadas

### ✔ Integración de Whisper en Unity
- Importación del paquete `whisper.unity`.
- Configuración del componente **WhisperManager**.
- Activación de GPU Acceleration mediante Metal.
- Manejo de modelos `.bin` ubicados en `StreamingAssets`.

### ✔ Captura de Audio y Transcripción
Sistema implementado:

- Mantener **R** → inicia grabación.
- Soltar **R** → detiene grabación.
- El audio se convierte a `float[]` y se envía al modelo Whisper.
- El texto transcrito se devuelve mediante `GetTextAsync()`.

### ✔ Selección de Personajes
- Raycast para seleccionar un guerrero con clic izquierdo.
- El guerrero seleccionado pasa a recibir las órdenes de voz.

### ✔ Ejecución de Órdenes por Voz
Cada guerrero interpreta texto y ejecuta acciones:

- **“avanza”, “adelante”** → movimiento hacia delante  
- **“gira”, “rota”** → rotación  
- **“ataca”** → ataque  
- **“defiéndete”, “escudo”** → defensa  

---

## 🏗️ Estructura de la Escena

├── WhisperManager        → Gestiona el modelo Whisper
├── VoiceController       → Graba audio y envía órdenes
├── GameController        → Maneja selección de guerreros
├── Guerrero1             → WarriorController
├── Guerrero2             → WarriorController
└── Main Camera


---

## 📜 Scripts Principales

### **1. WhisperManager (plugin)**
- Carga el modelo binario.
- Ejecuta inferencia de voz a texto.
- Usa GPU cuando es compatible.

### **2. VoiceController.cs**
Responsable de:
- Grabar audio con el micrófono.
- Transcribir mediante Whisper.
- Enviar texto al guerrero seleccionado.

### **3. SeleccionGuerrero.cs**
- Raycast para seleccionar guerreros.
- Guarda el guerrero seleccionado globalmente.

### **4. WarriorController.cs**
Define acciones como:
- Avanzar  
- Girar  
- Atacar  
- Defender  

---

## 🔧 Configuración Necesaria

### 📂 Modelos Whisper
Colocar los modelos `.bin` en
Ejemplos compatibles:

- `ggml-tiny.bin`
- `ggml-base.bin`

Configurar el WhisperManager para que use uno.

---

## 🎮 Controles

| Acción | Tecla |
|--------|--------|
| Seleccionar guerrero | Clic izquierdo |
| Iniciar grabación | Mantener **R** |
| Detener grabación | Soltar **R** |

---


## 🎥 Video Demostración

[![Ver video](https://img.youtube.com/vi/VIDEO_ID/0.jpg)](https://drive.google.com/file/d/1Y0geBb0qptPS-fTWlDFc6yWWGqbVQ2dz/view?usp=sharing)

Haz clic en la imagen para ver el video completo en Google Drive.
