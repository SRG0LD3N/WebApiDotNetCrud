<h1 align="center">
    <img src="https://readme-typing-svg.herokuapp.com/?font=Righteous&size=35&center=true&vCenter=true&width=700&height=70&duration=4000&color=1877F2&lines=Sistema+de+Control+de+Parqueo+🚗;Proyecto+Programacion+I+💻;Universidad+Mariano+Galvez+🎓" />
</h1>

Api desarrollada usando **.NET 8** utilizando **Entity Framework Core 8** para la gestión básica de productos (CRUD). El proyecto implementa los datos en **SQL Server** y tiene documentación interactiva de endpoints a través de **Swagger UI**.

---

## Tecnologías Utilizadas

* **Lenguaje:** C# / .NET 8
* **ORM:** Entity Framework Core v8.0.31
* **Base de Datos:** SQL Server (LocalDB)
* **Documentación:** Swagger / OpenAPI
* **Control de Versiones:** Git & GitHub

---

## 📊 Modelo de Datos (`Producto`)

| Campo    | Tipo de Dato | Descripción                     |
| :------- | :----------- | :------------------------------ |
| `Id`     | `int`        | Clave primaria (Auto-incremental)|
| `Nombre` | `string`     | Nombre descriptivo del producto |
| `Precio` | `decimal`    | Precio unitario                 |
| `Stock`  | `int`        | Cantidad en inventario          |

---

## 🛠️ Endpoints de la API

La API expone el controlador `ProductosController` bajo la ruta base `/api/Productos`:

| Método | Endpoint             | Descripción                        | Respuesta Exitosa |
| :----- | :------------------- | :--------------------------------- | :---------------- |
| `GET`  | `/api/Productos`     | Obtiene la lista total de productos| `200 OK`          |
| `GET`  | `/api/Productos/{id}`| Obtiene un producto por su ID     | `200 OK`          |
| `POST` | `/api/Productos`     | Registra un nuevo producto         | `201 Created`     |
| `PUT`  | `/api/Productos/{id}`| Actualiza los datos de un producto | `204 No Content`  |
| `DELETE`| `/api/Productos/{id}`| Elimina un producto por su ID      | `204 No Content`  |

---

## ⚙️ Configuración y Ejecución Local

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/SRG0LD3N/WebApiDotNetCrud.git](https://github.com/SRG0LD3N/WebApiDotNetCrud.git)
