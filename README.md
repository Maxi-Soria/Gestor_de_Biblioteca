# Descripción del Proyecto: Sistema de Gestión de Biblioteca

Este proyecto consiste en el desarrollo de un Sistema de Gestión de Biblioteca para escritorio, diseñado para facilitar la administración de libros y el control de préstamos realizados por los usuarios. El sistema permitirá gestionar de manera eficiente las operaciones básicas de una biblioteca, como el registro de libros y usuarios, así como la gestión y seguimiento de los préstamos.

## Objetivos principales:

- **Gestión de usuarios**: El sistema permitirá registrar usuarios, almacenar sus datos personales (nombre, apellido, DNI, correo electrónico) y una imagen de perfil. Los usuarios tendrán la capacidad de solicitar préstamos de libros.

- **Gestión de libros**: Se podrán registrar libros en la base de datos con su título, autor, fecha de publicación y una imagen de portada.

- **Gestión de préstamos**: Los usuarios podrán solicitar préstamos de libros disponibles. Se controlarán las fechas de préstamo y devolución, y el sistema detectará retrasos en las devoluciones.

- **Penalizaciones por devoluciones tardías**: Si un usuario no devuelve un libro en la fecha estipulada, el sistema impondrá una penalización automática, suspendiendo al usuario de realizar nuevos préstamos por una semana.

## Funcionalidades clave:

- **Registro de usuarios y libros**: El administrador de la biblioteca podrá agregar y gestionar información de usuarios y libros.

- **Préstamos de libros**: Los usuarios podrán solicitar préstamos de libros disponibles en el sistema, con un seguimiento de las fechas de préstamo y devolución.

- **Suspensiones automáticas**: Los usuarios que no devuelvan un libro a tiempo serán suspendidos de realizar nuevos préstamos durante un período de siete días.

- **Imágenes asociadas**: Tanto los libros como los usuarios podrán tener imágenes asociadas (guardadas como rutas), que se mostrarán en la aplicación.

## Tecnologías utilizadas:

- **.NET Framework (WinForms)**: Para desarrollar la interfaz de usuario de la aplicación de escritorio.

- **SQL Server**: Para el almacenamiento de datos, incluyendo la información de usuarios, libros y préstamos.

- **C#**: Como lenguaje de programación principal para la lógica del sistema.

Este proyecto es una excelente oportunidad para practicar conceptos de programación como la gestión de bases de datos relacionales, el desarrollo de aplicaciones de escritorio y la implementación de reglas de negocio específicas, como la penalización por retraso en devoluciones.



