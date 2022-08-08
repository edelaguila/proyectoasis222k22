/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package curso.datos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

<<<<<<< HEAD:G6/JAVACursosAsignacion/AsignacionCursos/src/asignacion/datos/Conexion.java

import java.util.logging.Level;
import java.util.logging.Logger;
import java.sql.DriverManager;
import java.sql.Connection;
import java.sql.SQLException;
=======
>>>>>>> actualizaciones:G6/JAVACursosAsignacion/asignacioncursosop1/src/main/java/curso/datos/Conexion.java
/**
 *
 * @author jonat
 */
public class Conexion {
<<<<<<< HEAD:G6/JAVACursosAsignacion/AsignacionCursos/src/asignacion/datos/Conexion.java
=======
    // Estas constantes deben cambiarse temporalmente para probarlo localmente

    private static final String JDBC_URL = "jdbc:mysql://localhost:3306/asignacioncursos";
    private static final String JDBC_USER = "root";
    private static final String JDBC_PASS = "";



    public static Connection getConnection() throws SQLException {
        return DriverManager.getConnection(JDBC_URL, JDBC_USER, JDBC_PASS);
    }
>>>>>>> actualizaciones:G6/JAVACursosAsignacion/asignacioncursosop1/src/main/java/curso/datos/Conexion.java
    
    private final String base = "asignacioncurso2"; 
    private final String user = "root"; 
    private final String password = ""; 
    private final String url = "jdbc:mysql://localhost:3307/" + base;
    private Connection con = null;
    
    public Connection getConexion()
    {
        try {
            Class.forName("com.mysql.jdbc.Driver");
            con = DriverManager.getConnection(url, user, password);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Conexion.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(Conexion.class.getName()).log(Level.SEVERE, null, ex);
        }
        return con; 
    }

    
<<<<<<< HEAD:G6/JAVACursosAsignacion/AsignacionCursos/src/asignacion/datos/Conexion.java
           
=======
    public static void close(Connection conn){
        try {
            conn.close();
        } catch (SQLException ex) {
           ex.printStackTrace(System.out);
        }
    }
>>>>>>> actualizaciones:G6/JAVACursosAsignacion/asignacioncursosop1/src/main/java/curso/datos/Conexion.java
}
