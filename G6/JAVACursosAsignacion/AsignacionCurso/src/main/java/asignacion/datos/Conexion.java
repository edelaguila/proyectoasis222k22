/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package asignacion.datos;

import com.sun.jdi.connect.spi.Connection;
import java.io.IOException;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.sql.DriverManager;

import java.sql.SQLException;
/**
 *
 * @author Diana
 */
public class Conexion {

    private Connection con = null;
    
    private static final String JDBC_URL = "jdbc:mysql://localhost:3306/asignacioncursos";
    private static final String JDBC_USER = "root";
    private static final String JDBC_PASS = "";
    private static final String JDBC_BASE = "asignacioncursos";

    public static java.sql.Connection getConnection() throws SQLException {
        return DriverManager.getConnection( JDBC_URL, JDBC_USER, JDBC_PASS);
     //    return DriverManager.getConnection(JDBC_BASE);
//         return DriverManager.getConnection( base, user, password, url);
    }
//
    public static void close(ResultSet rs) {
        try {
            rs.close();
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        }
    }

    public static void close(PreparedStatement stmt) {
        try {
            stmt.close();
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        }
    }

    public static void close(java.sql.Connection conn) {
        try {
            conn.close();
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        }
    }
    
  
    
//    private static final String base = "asignacioncursos"; 
//    private static final String user = "root"; 
//    private static final String password = ""; 
//    private static final String url = "jdbc:mysql://localhost:3306/" + base;
//    private Connection con = null;
    
//    public Connection getConexion()
//    {
//        try {
//            Class.forName("com.mysql.jdbc.Driver");
//            con = (Connection) DriverManager.getConnection(url, user, password);
//        } catch (ClassNotFoundException ex) {
//            Logger.getLogger(Conexion.class.getName()).log(Level.SEVERE, null, ex);
//        } catch (SQLException ex) {
//            Logger.getLogger(Conexion.class.getName()).log(Level.SEVERE, null, ex);
//        }
//        return con; 
//       
//           
//         }
     }


