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
    String metadata;
    
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
        
        public void setMetaDataVision(String intensityValue, String intensityRange, String color){
                    String metadata = "<sedl:Effect xsi:type=" + "sev:LightType" + " intensity-value=" + intensityValue +
                                    " intensity-range=" + intensityRange + " activate=" + "true" + " color=" + color + "/>";
                    MainProgram.metadata = metadata;
                    MainProgram.start();
                }

        public void setMetaDataWind(String intensityValue, String intensityRange, String fade, String location){
            metadata = "<sedl:Effect xsi:type=" + "sev:WindType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + "true" + "fade=" + fade + " location=:WCS:" + location + "/>";
            MainProgram.metadata = metadata;
            MainProgram.start();
        }

        public void setMetaDataSmell(String intensityValue, String intensityRange, String fade, String location){
            metadata = "<sedl:Effect xsi:type=" + "sev:ScentType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + "true" + "fade=" + fade + " location=:WCS:" + location + "/>";
            MainProgram.metadata = metadata;
            MainProgram.start();
        }

        public void setMetaDataVibration(String intensityValue, String intensityRange, String fade){
            metadata = "<sedl:Effect xsi:type=" + "sev:VibrationType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + "true" + "fade=" + fade + "/>";
            MainProgram.metadata = metadata;
            MainProgram.start();
        }
        
    }
}
