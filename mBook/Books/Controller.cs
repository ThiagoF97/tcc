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

        public void setMetaData(XmlNode oBookNode){
            XmlNode oEffectsNode = oBookNode["effects"];
            string sErrorMsg = "Não existem linhas cadastradas.";
           
            if (oEffectsNode == null)
            {
                MessageBox.Show(sErrorMsg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int iEffectId = 1;

                foreach (XmlNode oActionNode in oEffectsNode)
                {
                    if (oActionNode.Type == "smell")
                    {
                        foreach (XmlNode oSmellActionNode in oActionNode){
                            string intensityValue = "";
                            string intensityRange = "";
                            
                            string fade = "";
                            string location = "";
                            string activate = "true";
                            setMetaDataSmell(intensityValue, intensityRange, fade, location, activate);

                        }
                    }

                    if (oActionNode.Type == "vision")
                    {
                        foreach (XmlNode oVisionActionNode in oActionNode){
                            string intensityValue = "";
                            string intensityRange = "";
                            string color = oVisionActionNode.HEX;
                            string fade = "";
                            string location = "";
                            string activate = "true";
                            setMetaDataVision(intensityValue,intensityRange,color,fade,location,activate);

                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao carregar linhas.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        
        
        public void setMetaDataVision(string intensityValue, string intensityRange, string color, string fade, string location, string activate){    
            metadata = "<sedl:Effect xsi:type=" + "sev:LightType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + activate + "fade=" + fade + " location=:WCS:" + location + " color=" + color + "/>";
            
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
        private void ConnectSound(string path)
            {
                SoundPlayer player = new SoundPlayer();

                player.SoundLocation = path; //path do arquivo que contém o áudio
                player.Play();
                
            }

    }
}
