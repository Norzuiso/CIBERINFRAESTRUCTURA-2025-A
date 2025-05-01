# Warm up - Hola mundo


![Captura de pantalla 2025-04-30 233521](https://github.com/user-attachments/assets/576112dc-e3f9-457c-9b6c-152af711178e)

![Captura de pantalla 2025-04-30 233449](https://github.com/user-attachments/assets/6647f5de-01c9-4e3d-b105-c1d1ebfb3480)


## Casos de prueba para `HolaMundo` (validador de contraseñas WinForms)

| Caso                                        | Entrada (Pass1 / Pass2)     | Esperado                                          | Resultado   |
| ------------------------------------------- | --------------------------- | ------------------------------------------------- | ----------- |
| 1. Ambas vacías                             | `""` / `""`                 | Error por formato inválido                        | ❌ Rechazado |
| 2. Solo minúsculas                          | `contraseña` / `contraseña` | Error por falta de mayúscula, número y símbolo    | ❌ Rechazado |
| 3. Solo números                             | `12345678` / `12345678`     | Error por falta de letras y símbolo               | ❌ Rechazado |
| 4. Formato válido pero diferentes           | `Abc123$%` / `Abc123$$`     | Error: no coinciden                               | ❌ Rechazado |
| 5. Formato válido y coinciden               | `Apass123!` / `Apass123!`   | MessageBox: “La contraseña ha sido validada”      | ✅ Aceptado  |
| 6. Falta símbolo                            | `Apass1234` / `Apass1234`   | Error por símbolo faltante                        | ❌ Rechazado |
| 7. Falta mayúscula                          | `apass123!` / `apass123!`   | Error por mayúscula faltante                      | ❌ Rechazado |
| 8. Contraseñas válidas pero con espacios    | `A1b2c3!@` / `A1b2c3!@`     | Error si no permites espacios (depende del Regex) | ⚠️ Ambiguo  |
| 9. Contraseña correcta, confirmación vacía  | `A1b2c3!@` / `""`           | Error por no coincidir                            | ❌ Rechazado |

---


#### Capturas de pantalla
 1. Ambas vacías    
	 1. `""` / `""`
     ![image](https://github.com/user-attachments/assets/3123bed7-1d28-43d0-b2fb-405c76b165b7)

 2. Solo minúsculas                          
	 1. `contraseña` / `contraseña`
	![image](https://github.com/user-attachments/assets/352a4823-16d3-4319-9184-d29c97dd48e3)

 3. Solo números                             
		`12345678` / `12345678` 
		![image](https://github.com/user-attachments/assets/389e0952-4498-4773-b09e-70df694a9c26)

 4. Formato válido pero diferentes       
	 1. `Abc123$%` / `Abc123$$` 
	![image](https://github.com/user-attachments/assets/4bd8c5f9-3cd4-4fb8-9892-038d450d5f4e)

 5. Formato válido y coinciden   
	 1. `Apass123!` / `Apass123!`
![image](https://github.com/user-attachments/assets/95042a86-d70c-497d-a561-e3af28e546b5)

 6. Falta símbolo          
	 1. `Apass1234` / `Apass1234`
    ![image](https://github.com/user-attachments/assets/f181907f-eb27-4e9c-927d-e194ced94aca)

 7. Falta mayúscula
	 1. `apass123!` / `apass123!`
    ![image](https://github.com/user-attachments/assets/f2c9634c-033d-48ad-ae1d-026394279a0c)

 8. Contraseñas válidas pero con espacios
	 1. `A1b2c3!@` / `A1b2c3!@`
     ![image](https://github.com/user-attachments/assets/42ee080c-851c-4fec-aa65-75fbde2045f4)

 9. Contraseña correcta, confirmación vacía
   1. `A1b2c3!@` / `""`
      ![image](https://github.com/user-attachments/assets/4852616d-6f3d-431a-95ee-9e5f5f8d7ff7)
