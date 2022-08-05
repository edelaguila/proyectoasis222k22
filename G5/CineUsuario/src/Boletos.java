
import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JToggleButton;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import java.sql.Statement;





/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author RMiranda
 */
public class Boletos extends javax.swing.JFrame {

    /**
     * Creates new form Boletos
     */
    public Boletos() {
        initComponents();
        setLocationRelativeTo(null);
        botones();
    }
    // armar asientos
    int filas=9;
    int columnas=10;
    int largoboton=50;
    int anchoboton=45;
    int ejex=35;
    int ejey=45;
    String letra;
    
    public JToggleButton [][] JTBotones = new JToggleButton[filas][columnas];
    
    public void botones (){
        Font fuente=new Font("Arial",Font.BOLD,10);
        int contadorasientos = 1;
        JTBotones = new JToggleButton[filas][columnas];
        
        for (int i = 0; i < filas; i++) {
            char letra= (char)(65+i);
            for (int j = 0; j < columnas; j++) {
                JTBotones[i][j] = new JToggleButton();
                JTBotones[i][j].setFont(fuente);
                JTBotones[i][j].setBounds(ejex, ejey, largoboton, anchoboton);
                JTBotones[i][j].setText(""+ letra + contadorasientos);
                JTBotones[i][j].setBackground(new Color(2, 103, 186));
                
                AccionBotones accion = new AccionBotones();
                JTBotones[i][j].addActionListener(accion);
                
                pnlBotones.add(JTBotones[i][j]);
                ejex += 50;
                contadorasientos++;
                
            }
            ejex = 35;
            ejey += 45;
            contadorasientos=1;
        }
    }
    
    //public void reservarasiento(String sala, String asiento){
    public void reservarasiento1(int numasiento){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        try { 
          //PreparedStatement consulta=cn.prepareStatement( "UPDATE asientosreservados SET diponibilidad= 'no' WHERE sala= '" + sala + "' AND asiento= '" + asiento + "';");
          PreparedStatement consulta=cn.prepareStatement( "UPDATE sala1 SET disponibilidad= 'no' WHERE id_asiento= " + numasiento + ";");
          int a=consulta.executeUpdate();
          
          if(a > 0){
              JOptionPane.showMessageDialog(null, "Asiento Reservado");
          }else{
              JOptionPane.showMessageDialog(null, "Asiento No Reservado");
          }
        } catch (Exception e) {
            System.err.println("Error: "+ e);
        }
    }
    
    public void reservarasiento2(int numasiento){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        try { 
          //PreparedStatement consulta=cn.prepareStatement( "UPDATE asientosreservados SET diponibilidad= 'no' WHERE sala= '" + sala + "' AND asiento= '" + asiento + "';");
          PreparedStatement consulta=cn.prepareStatement( "UPDATE sala2 SET disponibilidad= 'no' WHERE id_asiento2= " + numasiento + ";");
          int a=consulta.executeUpdate();
          
          if(a > 0){
              JOptionPane.showMessageDialog(null, "Asiento Reservado");
          }else{
              JOptionPane.showMessageDialog(null, "Asiento No Reservado");
          }
        } catch (Exception e) {
            System.err.println("Error: "+ e);
        }
    }
    
    public void reservarasiento3(int numasiento){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        try { 
          //PreparedStatement consulta=cn.prepareStatement( "UPDATE asientosreservados SET diponibilidad= 'no' WHERE sala= '" + sala + "' AND asiento= '" + asiento + "';");
          PreparedStatement consulta=cn.prepareStatement( "UPDATE sala3 SET disponibilidad= 'no' WHERE id_asiento3= " + numasiento + ";");
          int a=consulta.executeUpdate();
          
          if(a > 0){
              JOptionPane.showMessageDialog(null, "Asiento Reservado");
          }else{
              JOptionPane.showMessageDialog(null, "Asiento No Reservado");
          }
        } catch (Exception e) {
            System.err.println("Error: "+ e);
        }
    }
    
    public void quitreserasiento1(int numasiento){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        try { 
          //PreparedStatement consulta=cn.prepareStatement( "UPDATE asientosreservados SET diponibilidad= 'no' WHERE sala= '" + sala + "' AND asiento= '" + asiento + "';");
          PreparedStatement consulta=cn.prepareStatement( "UPDATE sala1 SET disponibilidad= 'si' WHERE id_asiento= " + numasiento + ";");
          int a=consulta.executeUpdate();
          
          if(a > 0){
              JOptionPane.showMessageDialog(null, "Se quito reservacion de asiento");
          }else{
              JOptionPane.showMessageDialog(null, "Asiento No Reservado");
          }
        } catch (Exception e) {
            System.err.println("Error: "+ e);
        }
    }
    
    public void quitreserasiento2(int numasiento){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        try { 
          //PreparedStatement consulta=cn.prepareStatement( "UPDATE asientosreservados SET diponibilidad= 'no' WHERE sala= '" + sala + "' AND asiento= '" + asiento + "';");
          PreparedStatement consulta=cn.prepareStatement( "UPDATE sala2 SET disponibilidad= 'si' WHERE id_asiento2= " + numasiento + ";");
          int a=consulta.executeUpdate();
          
          if(a > 0){
              JOptionPane.showMessageDialog(null, "Se quito reservacion de asiento");
          }else{
              JOptionPane.showMessageDialog(null, "Asiento No Reservado");
          }
        } catch (Exception e) {
            System.err.println("Error: "+ e);
        }
    }
    
    public void quitreserasiento3(int numasiento){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        try { 
          //PreparedStatement consulta=cn.prepareStatement( "UPDATE asientosreservados SET diponibilidad= 'no' WHERE sala= '" + sala + "' AND asiento= '" + asiento + "';");
          PreparedStatement consulta=cn.prepareStatement( "UPDATE sala3 SET disponibilidad= 'si' WHERE id_asiento3= " + numasiento + ";");
          int a=consulta.executeUpdate();
          
          if(a > 0){
              JOptionPane.showMessageDialog(null, "Se quito reservacion de asiento");
          }else{
              JOptionPane.showMessageDialog(null, "Asiento No Reservado");
          }
        } catch (Exception e) {
            System.err.println("Error: "+ e);
        }
    }
    
    public void buscarasientrese1(){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        String sql="";
        sql="SELECT id_asiento,disponibilidad FROM sala1";
        
        int idasiento;
        String estado;
        
        try {
            
            Statement st=cn.createStatement();
            ResultSet rs=st.executeQuery(sql);
            
            while(rs.next()){
                idasiento=rs.getInt("id_asiento");
                estado=rs.getString("disponibilidad");
                int numasiento= 1001;
                for (int i = 0; i < filas; i++) {
                    for (int j = 0; j < columnas; j++) {
                        if ((idasiento==numasiento)&&(estado.equals("no"))) {
                            JTBotones[i][j].setEnabled(false);
                        }else if ((idasiento==numasiento)&&(estado.equals("si"))){
                            JTBotones[i][j].setEnabled(true);
                            JTBotones[i][j].setBackground(new Color(2, 103, 186));
                        }
                        numasiento++;
                    }
                    
                }
                
            }
            
            
        } catch (Exception e) {
        }
    }
    
    public void buscarasientrese2(){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        String sql="";
        sql="SELECT id_asiento2,disponibilidad FROM sala2";
        
        int idasiento2;
        String estado;
        
        try {
            
            Statement st=cn.createStatement();
            ResultSet rs=st.executeQuery(sql);
            
            while(rs.next()){
                idasiento2=rs.getInt("id_asiento2");
                estado=rs.getString("disponibilidad");
                int numasiento= 1101;
                for (int i = 0; i < filas; i++) {
                    for (int j = 0; j < columnas; j++) {
                        if ((idasiento2==numasiento)&&(estado.equals("no"))) {
                            JTBotones[i][j].setEnabled(false);
                        }else if ((idasiento2==numasiento)&&(estado.equals("si"))){
                            JTBotones[i][j].setEnabled(true);
                            JTBotones[i][j].setBackground(new Color(2, 103, 186));
                        }
                        numasiento++;
                    }
                    
                }
                
            }
            
            
        } catch (Exception e) {
        }
    }
    
    public void buscarasientrese3(){
        conectar cc=new conectar();
        Connection cn=cc.conexion();
        String sql="";
        sql="SELECT id_asiento3,disponibilidad FROM sala3";
        
        int idasiento3;
        String estado;
        
        try {
            
            Statement st=cn.createStatement();
            ResultSet rs=st.executeQuery(sql);
            
            while(rs.next()){
                idasiento3=rs.getInt("id_asiento3");
                estado=rs.getString("disponibilidad");
                int numasiento= 1201;
                for (int i = 0; i < filas; i++) {
                    for (int j = 0; j < columnas; j++) {
                        if ((idasiento3==numasiento)&&(estado.equals("no"))) {
                            JTBotones[i][j].setBackground(new Color(230, 32, 32));
                            JTBotones[i][j].setEnabled(false);
                        }else if ((idasiento3==numasiento)&&(estado.equals("si"))){
                            JTBotones[i][j].setEnabled(true);
                            JTBotones[i][j].setBackground(new Color(2, 103, 186));
                        }
                        numasiento++;
                    }
                    
                }
                
            }
            
            
        } catch (Exception e) {
        }
    }
  
    
    public class AccionBotones implements ActionListener{
        
        @Override
        public void actionPerformed(ActionEvent ae) {
            String sala = jComboBox1.getSelectedItem().toString();
            if(sala.equals("S1")){
                int numasiento= 1001;
                for (int i = 0; i < filas; i++) {
                    for (int j = 0; j < columnas; j++) {
                        if (ae.getSource().equals(JTBotones[i][j])) {
                            if (JTBotones[i][j].isSelected()) {
                                JTBotones[i][j].setBackground(new Color(55, 219, 88));
                                    reservarasiento1(numasiento);      
                            }else{
                                JTBotones[i][j].setBackground(new Color(2, 103, 186));
                                quitreserasiento1(numasiento);
                            }
                        }
                        numasiento++;
                    }
                }
            }
            if(sala.equals("S2")){
                int numasiento= 1101;
                for (int i = 0; i < filas; i++) {
                    for (int j = 0; j < columnas; j++) {
                        if (ae.getSource().equals(JTBotones[i][j])) {
                            if (JTBotones[i][j].isSelected()) {
                                JTBotones[i][j].setBackground(new Color(55, 219, 88));
                                    reservarasiento2(numasiento);      
                            }else{
                                JTBotones[i][j].setBackground(new Color(2, 103, 186));
                                quitreserasiento2(numasiento);
                            }
                        }
                        numasiento++;
                    }
                }
            }
            if(sala.equals("S3")){
                int numasiento= 1201;
                for (int i = 0; i < filas; i++) {
                    for (int j = 0; j < columnas; j++) {
                        if (ae.getSource().equals(JTBotones[i][j])) {
                            if (JTBotones[i][j].isSelected()) {
                                JTBotones[i][j].setBackground(new Color(55, 219, 88));
                                    reservarasiento3(numasiento);      
                            }else{
                                JTBotones[i][j].setBackground(new Color(2, 103, 186));
                                quitreserasiento3(numasiento);
                            }
                        }
                        numasiento++;
                    }
                }
            }
        }  
    }
    
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        pnlBotones = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jPanel3 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jPanel4 = new javax.swing.JPanel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        jLabel9 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        jLabel12 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        jLabel14 = new javax.swing.JLabel();
        jComboBox1 = new javax.swing.JComboBox<>();
        jLabel15 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setBackground(new java.awt.Color(102, 153, 255));

        jButton1.setText("Close");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jLabel1.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel1.setText("Asientos");

        pnlBotones.setBackground(new java.awt.Color(255, 255, 255));

        javax.swing.GroupLayout pnlBotonesLayout = new javax.swing.GroupLayout(pnlBotones);
        pnlBotones.setLayout(pnlBotonesLayout);
        pnlBotonesLayout.setHorizontalGroup(
            pnlBotonesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 584, Short.MAX_VALUE)
        );
        pnlBotonesLayout.setVerticalGroup(
            pnlBotonesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 457, Short.MAX_VALUE)
        );

        jPanel2.setBackground(new java.awt.Color(0, 255, 51));

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 40, Short.MAX_VALUE)
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 35, Short.MAX_VALUE)
        );

        jPanel3.setBackground(new java.awt.Color(153, 153, 153));

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 40, Short.MAX_VALUE)
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 35, Short.MAX_VALUE)
        );

        jLabel2.setText("Asientos Seleccionados");

        jLabel3.setText("Asientos Ocupados");

        jPanel4.setBackground(new java.awt.Color(153, 153, 153));

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 554, Short.MAX_VALUE)
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 15, Short.MAX_VALUE)
        );

        jLabel4.setText("Pantalla");

        jLabel5.setText("A");

        jLabel6.setText("B");

        jLabel7.setText("C");

        jLabel8.setText("D");

        jLabel9.setText("E");

        jLabel10.setText("F");

        jLabel11.setText("G");

        jLabel12.setText("H");

        jLabel13.setText("I");

        jPanel1.setBackground(new java.awt.Color(0, 153, 204));

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 35, Short.MAX_VALUE)
        );

        jLabel14.setText("Asientos Diponibles");

        jComboBox1.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Salas", "S1", "S2", "S3" }));
        jComboBox1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jComboBox1ActionPerformed(evt);
            }
        });

        jLabel15.setText("Seleccion de Sala");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel1)
                .addGap(307, 307, 307)
                .addComponent(jButton1)
                .addContainerGap())
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(37, 37, 37)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel5, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel7, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel8, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel12, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel13, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 7, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel11, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel10, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel9, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel6, javax.swing.GroupLayout.Alignment.TRAILING))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(pnlBotones, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(66, 66, 66)
                        .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jComboBox1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                .addComponent(jPanel3, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                        .addGap(70, 70, 70))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(28, 28, 28)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel2)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addComponent(jLabel3)
                                .addComponent(jLabel15)
                                .addComponent(jLabel14)))
                        .addGap(0, 31, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(59, 59, 59)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
            .addGroup(layout.createSequentialGroup()
                .addGap(322, 322, 322)
                .addComponent(jLabel4)
                .addGap(21, 448, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jButton1)
                    .addComponent(jLabel1, javax.swing.GroupLayout.Alignment.TRAILING))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(jLabel4)
                                .addGap(11, 11, 11)
                                .addComponent(pnlBotones, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(95, 95, 95)
                                .addComponent(jLabel5)
                                .addGap(31, 31, 31)
                                .addComponent(jLabel6)
                                .addGap(27, 27, 27)
                                .addComponent(jLabel7)
                                .addGap(27, 27, 27)
                                .addComponent(jLabel8)
                                .addGap(26, 26, 26)
                                .addComponent(jLabel9)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel10)
                                .addGap(28, 28, 28)
                                .addComponent(jLabel11)
                                .addGap(31, 31, 31)
                                .addComponent(jLabel12)
                                .addGap(26, 26, 26)
                                .addComponent(jLabel13)
                                .addGap(23, 23, 23)))
                        .addContainerGap())
                    .addGroup(layout.createSequentialGroup()
                        .addGap(62, 62, 62)
                        .addComponent(jLabel2)
                        .addGap(18, 18, 18)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(52, 52, 52)
                        .addComponent(jLabel3)
                        .addGap(18, 18, 18)
                        .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(51, 51, 51)
                        .addComponent(jLabel14)
                        .addGap(18, 18, 18)
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jLabel15)
                        .addGap(18, 18, 18)
                        .addComponent(jComboBox1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(62, 62, 62))))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        Pago carte = new Pago();
        carte.setVisible(true);
        this.dispose();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jComboBox1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jComboBox1ActionPerformed
        String opcion = jComboBox1.getSelectedItem().toString();
        if (opcion.equals("S1")) {
            buscarasientrese1();
        }else if (opcion.equals("S2")) {
            buscarasientrese2();
        }else if (opcion.equals("S3")) {
            buscarasientrese3();
        }
    }//GEN-LAST:event_jComboBox1ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Boletos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Boletos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Boletos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Boletos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Boletos().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JComboBox<String> jComboBox1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel pnlBotones;
    // End of variables declaration//GEN-END:variables
}
