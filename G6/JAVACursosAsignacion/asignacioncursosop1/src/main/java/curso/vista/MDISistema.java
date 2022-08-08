/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package curso.vista;

/**
 *
 * @author Diana
 */
<<<<<<< HEAD:G6/JAVACursosAsignacion/AsignacionCursos/src/asignacion/vista/MDISistemas.java
import asignacion.datos.usuarios;
public class MDISistemas extends javax.swing.JFrame {
    
    usuarios mod;

    
    public MDISistemas() {
=======
public class MDISistema extends javax.swing.JFrame {

    /**
     * Creates new form MDISistema
     */
    public MDISistema() {
>>>>>>> actualizaciones:G6/JAVACursosAsignacion/asignacioncursosop1/src/main/java/curso/vista/MDISistema.java
        initComponents();
        
    }

    public MDISistemas (usuarios mod)
    {
        initComponents();
        setLocationRelativeTo(null);
        this.mod= mod;
        
        if(mod.getId_tipo() == 1)
        {
            
        }else if(mod.getId_tipo() == 2)
        {
            menuInforme.setVisible(false);
        }
            
    }
    
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
<<<<<<< HEAD:G6/JAVACursosAsignacion/AsignacionCursos/src/asignacion/vista/MDISistemas.java
        jMenuBar2 = new javax.swing.JMenuBar();
        menuLogin = new javax.swing.JMenu();
        menuMantenimientos = new javax.swing.JMenu();
        jMenu5 = new javax.swing.JMenu();
        jMenu6 = new javax.swing.JMenu();
        menuInforme = new javax.swing.JMenu();
        jMenu13 = new javax.swing.JMenu();
=======
        jButton1 = new javax.swing.JButton();
>>>>>>> actualizaciones:G6/JAVACursosAsignacion/asignacioncursosop1/src/main/java/curso/vista/MDISistema.java

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jButton1.setText("Menu");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jButton1)
                .addContainerGap(490, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(61, 61, 61)
                .addComponent(jButton1)
                .addContainerGap(221, Short.MAX_VALUE))
        );

<<<<<<< HEAD:G6/JAVACursosAsignacion/AsignacionCursos/src/asignacion/vista/MDISistemas.java
        menuLogin.setText("Login");
        jMenuBar2.add(menuLogin);

        menuMantenimientos.setText("Mantenimientos");

        jMenu5.setText("Boleta_Asignacion_Curso");
        menuMantenimientos.add(jMenu5);

        jMenu6.setText("Registro_Catedratico");
        menuMantenimientos.add(jMenu6);

        jMenuBar2.add(menuMantenimientos);

        menuInforme.setText("Informe");

        jMenu13.setText("Bitacora");
        menuInforme.add(jMenu13);

        jMenuBar2.add(menuInforme);

        setJMenuBar(jMenuBar2);

=======
>>>>>>> actualizaciones:G6/JAVACursosAsignacion/asignacioncursosop1/src/main/java/curso/vista/MDISistema.java
        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(45, 45, 45)
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(81, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(62, 62, 62)
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(106, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        Catalogos frm = new Catalogos();
        frm.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_jButton1ActionPerformed

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
            java.util.logging.Logger.getLogger(MDISistema.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(MDISistema.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(MDISistema.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(MDISistema.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
<<<<<<< HEAD:G6/JAVACursosAsignacion/AsignacionCursos/src/asignacion/vista/MDISistemas.java
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
=======
>>>>>>> actualizaciones:G6/JAVACursosAsignacion/asignacioncursosop1/src/main/java/curso/vista/MDISistema.java

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new MDISistema().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
<<<<<<< HEAD:G6/JAVACursosAsignacion/AsignacionCursos/src/asignacion/vista/MDISistemas.java
    private javax.swing.JMenu jMenu13;
    private javax.swing.JMenu jMenu5;
    private javax.swing.JMenu jMenu6;
    private javax.swing.JMenuBar jMenuBar2;
=======
    private javax.swing.JButton jButton1;
>>>>>>> actualizaciones:G6/JAVACursosAsignacion/asignacioncursosop1/src/main/java/curso/vista/MDISistema.java
    private javax.swing.JPanel jPanel1;
    private javax.swing.JMenu menuInforme;
    private javax.swing.JMenu menuLogin;
    private javax.swing.JMenu menuMantenimientos;
    // End of variables declaration//GEN-END:variables
}
