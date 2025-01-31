using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using UnityEngine;

public class SQLiteManager : MonoBehaviour
{
    private string dbPath;

    void Start()
    {
        // Definir la ruta de la base de datos
        dbPath = "URI=file:" + Application.persistentDataPath + "/GameDatabase.db";

        // Crear base de datos y tablas
        CreateDatabase();
    }

    void CreateDatabase()
    {
        using (var connection = new SqliteConnection(dbPath))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                // Crear tabla Jugadores
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Jugadores (
                        ID_Jugador INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nombre TEXT NOT NULL,
                        Edad INTEGER,
                        Email TEXT,
                        Fecha_Registro TEXT
                    );";
                command.ExecuteNonQuery();

                // Crear tabla Estadísticas
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Estadisticas (
                        ID_Estadistica INTEGER PRIMARY KEY AUTOINCREMENT,
                        ID_Jugador INTEGER,
                        Nivel INTEGER,
                        Puntos INTEGER,
                        Tiempo_Juego INTEGER,
                        FOREIGN KEY(ID_Jugador) REFERENCES Jugadores(ID_Jugador)
                    );";
                command.ExecuteNonQuery();

                // Crear tabla Partidas
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Partidas (
                        ID_Partida INTEGER PRIMARY KEY AUTOINCREMENT,
                        ID_Jugador INTEGER,
                        Fecha TEXT,
                        Duracion INTEGER,
                        Puntos_Obtenidos INTEGER,
                        FOREIGN KEY(ID_Jugador) REFERENCES Jugadores(ID_Jugador)
                    );";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
        Debug.Log("Base de datos creada correctamente.");
    }
}
