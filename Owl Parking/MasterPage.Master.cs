using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Ports;
using Owl_Parking.BLL;

namespace Owl_Parking
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        //SerialPort ardu = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
        protected void Page_Load(object sender, EventArgs e)
        {
            //ardu.Open();
            //ArduinoBLL arduinon = new ArduinoBLL();
            //int mensaje = Convert.ToInt32(ardu.ReadLine());
            //int id = 1;
            //arduinon.Editar(id, mensaje);
            //ardu.Close();
        }

        //[System.Web.Services.WebMethod]
        //public void EjecutarArduino(string name)
        //{
        //    ardu.Open();
        //    ArduinoBLL arduinon = new ArduinoBLL();
        //    int mensaje = Convert.ToInt32(ardu.ReadLine());
        //    int id = 1;
        //    arduinon.Editar(id, mensaje);
        //    ardu.Close();
        //}

    }
}