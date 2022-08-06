/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package asignacion.datos;

import java.sql.Connection;
import java.io.IOException;
import java.sql.*;
import javax.swing.JOptionPane;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author Diana
 */
public class conexionSQL {

    Connection conectar = null;

    public Connection Conexion() {

        try {
            Class.forName("com.mysql.jdbc.Driver");
            conectar = (Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/asignacioncursos",
                    "root", "");
            
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error de Conexion" + e.getMessage());
        }
        return conectar;
    }

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

    public static void close(Connection conn) throws IOException, SQLException {
        conn.close();
    }

}
