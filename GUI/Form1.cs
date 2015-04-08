﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lgis;
namespace GUI
{
    public partial class Form1 : Form
    {
        Point mouseLocation = new Point(0,0);
        LVectorLayer vl = new LVectorLayer();
        //bool mouseDragging;
        public Form1()
        {
            InitializeComponent();
            btnStopEditing.Enabled = false;
            lWindow1.Layers.Add(vl) ;
            lWindow1.editingLayer = vl;
            lWindow1.Invalidate();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            lWindow1.ZoomIn();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            lWindow1.ZoomOut();
        }

        private void btnZoomToLayer_Click(object sender, EventArgs e)
        {
            lWindow1.ZoomToLayer();
            lblScale.Refresh();
            lWindow1.Refresh();
        }

        private void lblScale_Click(object sender, EventArgs e)
        {

        }

        private void lblScale_Paint(object sender, PaintEventArgs e)
        {
            lblScale.Text = "Scale:" + lWindow1.Scale.ToString();
        }

        private void lblCoordinate_Paint(object sender, PaintEventArgs e)
        {
            lblCoordinate.Text = "(X,Y)=" + lWindow1.ToGeographicCoordinate(mouseLocation).ToString();
        }

        private void btnStartEditting_Click(object sender, EventArgs e)
        {
            btnStopEditing.Enabled = true;
            btnStartEditing.Enabled = false;
            lWindow1.StartEditing();
        }

        private void btnStopEditing_Click(object sender, EventArgs e)
        {
            btnStopEditing.Enabled = false;
            btnStartEditing.Enabled = true;
            lWindow1.StopEditing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lWindow1_Load(object sender, EventArgs e)
        {

        }

        private void lblCoordinate_Click(object sender, EventArgs e)
        {

        }

    }
}
