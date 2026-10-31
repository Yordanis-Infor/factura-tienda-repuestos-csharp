# Proyecto 1: Automatización de factura de una tienda de repuestos

## Datos de los integrantes

| N.º | Nombre completo | Número |
|---|---|---|
| 1 | Grebel Maikors Jose Gaton | 11 |
| 2 | Yordanis Josue Morla Feliz | 13 |

---

## Descripción de la tarea

Una tienda de repuestos desea automatizar el proceso de facturación mediante un programa que permita calcular el total de una compra. Cada venta incluye un 18 % de ITBIS y, cuando el cliente es frecuente, recibe un descuento del 10 % aplicado antes de calcular el impuesto.

## Análisis del problema

### 1. Entrada

- Nombre del cliente.
- Monto de la compra.
- Indicar si el cliente es frecuente o no.

### 2. Proceso

1. Solicitar los datos del cliente y el monto de la compra.
2. Verificar si el cliente es frecuente.
3. Si es frecuente, aplicar un descuento del 10 % sobre el monto original.
4. Calcular el 18 % de ITBIS sobre el monto después del descuento.
5. Sumar el ITBIS al monto descontado.
6. Obtener el total final de la factura.

### 3. Salida

- Nombre del cliente.
- Monto original de la compra.
- Descuento aplicado.
- ITBIS correspondiente (18 %).
- Total final a pagar.

---

## Capturas de ejecución

### Cliente normal (opción 1)

![Cliente normal](./imagenes/Opcion1.png)

### Cliente frecuente (opción 2)

![Cliente frecuente](./imagenes/Opcion2.png)

---

## Tecnologías utilizadas

| Tecnología | Descripción |
|---|---|
| **C# (C Sharp)** | Lenguaje de programación utilizado para desarrollar la lógica del proyecto. |
| **Visual Studio Community** | Entorno de desarrollo integrado (IDE) utilizado para escribir, ejecutar y depurar el código. |
| **GitHub** | Plataforma utilizada para almacenar, gestionar y compartir el código fuente del proyecto. |
