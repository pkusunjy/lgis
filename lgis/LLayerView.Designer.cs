﻿namespace Lgis
{
    partial class LLayerView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.trvLayers = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvLayers
            // 
            this.trvLayers.Location = new System.Drawing.Point(0, 12);
            this.trvLayers.Name = "trvLayers";
            this.trvLayers.Size = new System.Drawing.Size(175, 267);
            this.trvLayers.TabIndex = 0;
            // 
            // LLayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvLayers);
            this.Name = "LLayerView";
            this.Size = new System.Drawing.Size(189, 295);
            this.Load += new System.EventHandler(this.LLayerView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvLayers;
    }
}
