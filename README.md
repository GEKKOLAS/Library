# Library 📚

Library es una aplicación diseñada para gestionar y explorar colecciones de libros. Ideal para amantes de la literatura que desean organizar sus lecturas favoritas y descubrir nuevas obras.

## Características 🚀

- 📖 **Lista de libros**: Explora una lista completa de libros organizados por título, autor y año de publicación.
- 🔍 **Gestión de Libros**: Encuentra libros por título, autor o año de publicación.
- 🌟 **Gestión de autores**: Visualiza y administra libros relacionados con cada autor.
- 📷 **Portadas de libros**: Visualiza las portadas de los libros para una experiencia más atractiva. (no funcionan aun)

## Instalación ⚙️

1. Clona este repositorio:
    ```bash or terminal
    https://github.com/GEKKOLAS/Library.git
    ```
2. Navega al directorio del proyecto:
    ```bash or terminal
    cd Library
    ```
3. Instala las dependencias: Docker para establecer la imagen de mssql server y asegurarse de que este corriendo en docker desktop
    ```bash or terminal
    docker compose up -d    
    ```
4. Ejecuta la aplicación:
    ```bash or terminal
    dotnet run or dotnet watch
    ```

## Uso 🖥️

1. Accede a la aplicación en `http://localhost:5010`.
![pagina--1--](https://github.com/user-attachments/assets/094814e9-19d6-47b3-896f-efd543acc615)


2. Explora los libros disponibles.
   ![pagina--2--](https://github.com/user-attachments/assets/f307c1a8-e2de-4740-b203-fa23a99c4442)

3. Añade nuevos libros y autores utilizando el panel de administración.
![pagina--crear-autor---](https://github.com/user-attachments/assets/4afa0731-93b1-416a-9c6d-49fddd401af2)
![pagina---crear-libro-modal](https://github.com/user-attachments/assets/8c6bd5cb-e987-4fd9-a26c-ce61274a2e11)
![pagina--crear-autor-modal](https://github.com/user-attachments/assets/50ac0958-d1f0-425f-b5f1-de039f44421e)

## Tecnología 🔧

- **Frontend**: ASP.NET MVC y Bootstrap.
- **Backend**: .NET Core y Entity Framework.
- **Base de datos**: SQL Server.

## Contribución 🤝

¡Ayúdanos a mejorar Library! Si quieres contribuir, sigue estos pasos:

1. Haz un fork del proyecto.
2. Crea una nueva rama para tu mejora:
    ```bash
    git checkout -b mi-mejora
    ```
3. Haz tus cambios y realiza un commit:
    ```bash
    git commit -m "Descripción de la mejora"
    ```
4. Envía un pull request con tus cambios.

## Créditos 👏

- Desarrollado por Nicolás y su equipo.
- Inspirado en los grandes clásicos de la literatura.

## Licencia 📝

Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE` para más detalles.

---

