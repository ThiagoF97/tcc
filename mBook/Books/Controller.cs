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
    String[] metaDataVec;
        public void setAllMetaData()
        {
            String metadata = "<sedl:Effect xsi:type=" + "sev:LightType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + "true" + " color=" + color + "/>";
            MainProgram.metadata = metadata;
            MainProgram.start();
        }
        
        public void setMetaData(String type, String intensityValue, String intensityRange, String color)
        {
            
            if(type == "Vision" || type == "V"){
            String metadata = "<sedl:Effect xsi:type=" + "sev:LightType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + "true" + " color=" + color + "/>";
            MainProgram.metadata = metadata;
            MainProgram.start();
            }

            if(type == "Smell" || type == "S"){
            metadata = "<sedl:Effect xsi:type=" + "sev:ScentType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + "true" + " color=" + color + "/>";
            MainProgram.metadata = metadata;
            MainProgram.start();
            }

            if(type == "Wind" || type == "W"){
            metadata = "<sedl:Effect xsi:type=" + "sev:WindType" + " intensity-value=" + intensityValue +
                            " intensity-range=" + intensityRange + " activate=" + "true" + " color=" + color + "/>";
            MainProgram.metadata = metadata;
            MainProgram.start();
            }
        }
        
    }
}
