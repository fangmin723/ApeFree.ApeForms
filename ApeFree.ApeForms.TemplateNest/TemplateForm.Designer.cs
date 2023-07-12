﻿using ApeFree.ApeForms.Core.Controls;

namespace ApeFree.ApeForms.Demo
{
    partial class TemplateForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Core.Utils.StateColorSet stateColorSet1 = new Core.Utils.StateColorSet();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            panelHead = new System.Windows.Forms.Panel();
            clbTopBar = new ControlListBox();
            picLogo = new System.Windows.Forms.PictureBox();
            slideTabControl = new SlideTabControl();
            clbSideBar = new ControlListBox();
            clbBottomBar = new ControlListBox();
            panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            panelHead.Controls.Add(clbTopBar);
            panelHead.Controls.Add(picLogo);
            panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            panelHead.Location = new System.Drawing.Point(0, 0);
            panelHead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panelHead.Name = "panelHead";
            panelHead.Size = new System.Drawing.Size(915, 71);
            panelHead.TabIndex = 1;
            // 
            // clbTopBar
            // 
            clbTopBar.AutoScroll = true;
            clbTopBar.BackColor = System.Drawing.Color.Transparent;
            clbTopBar.Direction = System.Windows.Forms.FlowDirection.RightToLeft;
            clbTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            clbTopBar.Location = new System.Drawing.Point(175, 0);
            clbTopBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            clbTopBar.Name = "clbTopBar";
            clbTopBar.Size = new System.Drawing.Size(740, 71);
            clbTopBar.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            picLogo.Location = new System.Drawing.Point(0, 0);
            picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(175, 71);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // slideTabControl
            // 
            slideTabControl.CloseAllPagesOptionText = "Close all";
            slideTabControl.ClosePageOptionText = "Close";
            slideTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            slideTabControl.Location = new System.Drawing.Point(175, 71);
            slideTabControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            slideTabControl.Name = "slideTabControl";
            slideTabControl.Rate = 2;
            slideTabControl.Size = new System.Drawing.Size(740, 653);
            stateColorSet1.GotFocusBackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            stateColorSet1.GotFocusForeColor = System.Drawing.Color.White;
            stateColorSet1.LostFocusBackColor = System.Drawing.Color.FromArgb(251, 251, 251);
            stateColorSet1.LostFocusForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            stateColorSet1.MouseDownBackColor = System.Drawing.Color.FromArgb(14, 97, 152);
            stateColorSet1.MouseDownForeColor = System.Drawing.Color.White;
            stateColorSet1.MouseLeaveBackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            stateColorSet1.MouseLeaveForeColor = System.Drawing.Color.White;
            stateColorSet1.MouseMoveBackColor = System.Drawing.Color.FromArgb(82, 176, 239);
            stateColorSet1.MouseMoveForeColor = System.Drawing.Color.White;
            slideTabControl.StateColorSet = stateColorSet1;
            slideTabControl.TabIndex = 0;
            slideTabControl.TitleDock = System.Windows.Forms.DockStyle.Top;
            slideTabControl.TitleLayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            // 
            // clbSideBar
            // 
            clbSideBar.AutoScroll = true;
            clbSideBar.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            clbSideBar.Direction = System.Windows.Forms.FlowDirection.TopDown;
            clbSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            clbSideBar.Location = new System.Drawing.Point(0, 71);
            clbSideBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            clbSideBar.Name = "clbSideBar";
            clbSideBar.Size = new System.Drawing.Size(175, 724);
            clbSideBar.TabIndex = 3;
            // 
            // clbBottomBar
            // 
            clbBottomBar.AutoScroll = true;
            clbBottomBar.BackColor = System.Drawing.Color.WhiteSmoke;
            clbBottomBar.Direction = System.Windows.Forms.FlowDirection.BottomUp;
            clbBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            clbBottomBar.Location = new System.Drawing.Point(175, 724);
            clbBottomBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            clbBottomBar.Name = "clbBottomBar";
            clbBottomBar.Size = new System.Drawing.Size(740, 71);
            clbBottomBar.TabIndex = 4;
            // 
            // TemplateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(915, 795);
            Controls.Add(slideTabControl);
            Controls.Add(clbBottomBar);
            Controls.Add(clbSideBar);
            Controls.Add(panelHead);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "TemplateForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ApeForms Demo";
            panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Core.Controls.SlideTabControl slideTabControl;
        private System.Windows.Forms.Panel panelHead;
        private ControlListBox clbSideBar;
        private System.Windows.Forms.PictureBox picLogo;
        private ControlListBox clbTopBar;
        private ControlListBox clbBottomBar;
    }
}

