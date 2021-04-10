using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Collections;
using mBook.Books;
using EyeXFramework;
using Tobii.Interaction;
using System.Speech.Synthesis;

namespace mBook
{
    public static class Controller{
    
    //criar funçao para enviar mensagem para o MPEG-V parser
        public void setEvento(String tipoEfeito){
            
            if(tipoEfeito == vision){
                MainProgram.metadata = "";
                MainProgram.Start();
            }

            if(tipoEfeito == smell){
                MainProgram.metadata = "";
                MainProgram.Start();
            }

            if(tipoEfeito == hearing){
                MainProgram.metadata = "";
                MainProgram.Start();
            }

            if(tipoEfeito == toutch){
                MainProgram.metadata = "";
                MainProgram.Start();

            }

            
        }
    //chamar função que ouve eventos
        public void getEvento(Button button){
            String textoButao = button.Text;
            
            if(textoButao == "" || textoButao == null){
                return;
            }
            switch (textoButao){
                case "Halloween":
                setEvento("vision");                
                break;
                
                case "brincar":
                //visao
                setEvento("vision");
                break;
                
                case "pizza":
                //cheiro
                setEvento("smell");
                break;

                case "floresta":
                //visão
                setEvento("vision");
                break;

                case "porta":
                //som e cheiro
                setEvento("hearing");
                setEvento("smell");
                break;

                case "barulho":
                //som
                setEvento("hearing");
                break;

                case "monstro":
                //som
                setEvento("hearing");
                break;

                case "televisão":
                //som
                setEvento("hearing");                
                break;

                default:
                Console.WriteLine("Default case");
                break;
            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        } 
    }
}