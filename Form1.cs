using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_GIS_Panorama
{
    public partial class Form1 : Form
    {
        //Зададим флаг для обозначения открываем мы новую карту или добавляем к уже открытой
        public int mapIsOpenFl;
        ToolStripLabel infoLabel;
        
        public Form1()
        {
            InitializeComponent();
            // Связываем компоненты 
            OpenMapDialog1.cMapView = MapView1.C_CONTAINER;
            infoLabel = new ToolStripLabel();
            MapInfoStrip.Items.Add(infoLabel);
        }

              

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void OpenMap_Click(object sender, EventArgs e)
        {
            if (OpenMapDialog1.Execute);
            {
                // Проверяем значение флага mapIsOpenFl
                if (mapIsOpenFl != 1) //Если флаг не равен 1, то открываем новую карту
                {  // Открываем карту
                    MapView1.MapOpen(OpenMapDialog1.FileName, true);
                    mapIsOpenFl = 1; // Ставим значение флага равное 1, это означает что карта открыта

                }
                else
                { // Добавляем карту к уже открытой
                    MapView1.AppendData(OpenMapDialog1.FileName, 0);
                }

                //В данный момент кнопка считается нажатой
                //Отожмем кнопку
                OpenMap.CheckState = CheckState.Unchecked;
                //Поместим в 1 строку состояния имя карты и масштаб
                infoLabel.Text =  "Название:  " + MapView1.MapName + ";" + "       " + "Масштаб: 1: "+MapView1.MapScale.ToString();
                

            }
                
        }
    }
}
