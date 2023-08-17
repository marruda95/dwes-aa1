# Dessarollo De Aplicaciones Web Entorno Cliente 1EV

## Console App: Books

Esta aplicación simula la reserva de una biblioteca, donde un usuario sin registrar puede encontrar un catálogo de libros, o buscar un autor en concreto. Si el usuario tiene usuario, puede acceder a reservar un libro del catálogo si hay ejemplares o si existe. 

###### Docker
- docker build -t marruda95/appconsole_dwes:es .
- docker build -t marruda95/appconsole_dwes:en .
- docker push marruda95/appconsole_dwes:es
- docker push marruda95/appconsole_dwes:en 
- docker run -it  -v /logs -p 5416 marruda95/appconsole_dwes:es
- docker exec -it CONTAINER /bin/bash
- docker pull marruda95/appconsole_dwes:es
- docker run -it --rm -v /logs marruda95/appconsole_dwes:es

###### Especificaciones
- Menú principal y secundarios para navegar entre las funcionalidades interactuando a través de la consola de la aplicación.
- Gestión de alta y selección de usuarios y/o productos y/o servicios.
- Zona privada de información.
- Zona pública de información.
- Modelo de datos: Members, Books, Genres
- Funcionalidad de búsqueda: buscar por autor.
- App contenerizada + Subida
- Utilizavión de Git y metodología Gitflow.
- Gestión de logs con Nlog.
- Variables de entorno que modifican la app por idioma.
- Interfaz mejorada con Spectre.Console