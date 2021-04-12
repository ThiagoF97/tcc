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
    string metadata;
    MainProgram mainProgram = new MainProgram();
    
        public void setAllMetaData(int iBookId, XmlNode oBookNode)
        {
            CBook book = new CBook(iBookId, oBookNode);
            Page pages = book.Pages;
            foreach (Page pg in book.Pages)
                {
                    foreach (Line ln in pg.lines){
                        foreach(Effect efct in ln.m_htEffects){
                            //em desenvolvimento
                        }
                    }
                }
        }
        
        public void setMetaDataVision(string intensityValue, string intensityRange, string color, string activate){    
            metadata = "<sedl:Effect xsi:type=" + "sev:LightType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + activate + " color=" + color + "/>";
            
            mainProgram.metadata = metadata;
            mainProgram.start();
        }

        public void setMetaDataWind(string intensityValue, string intensityRange, string fade, string location, string activate){
            metadata = "<sedl:Effect xsi:type=" + "sev:WindType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + activate + "fade=" + fade + " location=:WCS:" + location + "/>";
            
            mainProgram.metadata = metadata;
            mainProgram.start();
        }

        public void setMetaDataSmell(string intensityValue, string intensityRange, string fade, string location, string activate){
            metadata = "<sedl:Effect xsi:type=" + "sev:ScentType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + activate + "fade=" + fade + " location=:WCS:" + location + "/>";
            
            mainProgram.metadata = metadata;
            mainProgram.start();
        }

        public void setMetaDataVibration(string intensityValue, string intensityRange, string fade, string activate){
            metadata = "<sedl:Effect xsi:type=" + "sev:VibrationType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + activate + "fade=" + fade + "/>";
            
            mainProgram.metadata = metadata;
            mainProgram.start();
        }
        
    }
}
