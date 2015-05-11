﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lgis;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void oldMain()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static void Main(string[] args)
        {
            LUnitTest ut = new LUnitTest();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            LLayerGroup lg = ut.TestLayerView();
            //string s = LLayerComboBox.Encode(lg);
            string s = LGeoDatabase.LayerInfo(lg);
            Console.WriteLine(s);
            LLayerGroup recover = LGeoDatabase.RebuildLayerTree(s);
            Console.WriteLine(LGeoDatabase.LayerInfo(recover));
            Console.ReadLine();
        }
    }
}
