/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gestionarchivos;
import java.io.*;
/**
 *
 * @author alexander
 */
public class Gestion {
    FileInputStream entrada;
    FileOutputStream salida;
    File archivo;

public Gestion (){
}


public String AbrirATexto (File archivo){
String contenido = "";
    try {
         entrada = new FileInputStream(archivo);
         int ascci;
         while ((ascci = entrada.read()) != -1) {
            char caracter = (char)ascci;
            contenido += caracter;
            
        }
    } catch (Exception e) {
    }
    return  contenido;
 
    /**/



}


}